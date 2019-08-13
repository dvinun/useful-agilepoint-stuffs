using Hitachi.PhaseGate.Base;
using Hitachi.PhaseGate.Contract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Hitachi.PhaseGate.Workflow
{
    internal abstract class NXOperation : INXOperation, IDisposable
    {
        public NXOperationType OperationType { get; private set; }
        public string NXOperationUrl { get; private set; }

        private HttpClient client;

        private string AuthorizationHeader
        {
            get
            {
                string UnParseString = $"{PGMConfig.AgilePointDomain}\\{PGMConfig.AgilePointUsername}:{PGMConfig.AgilePointPassword}";
                string ParsedString = Convert.ToBase64String(Encoding.ASCII.GetBytes(UnParseString));
                return ParsedString;
            }
        }

        private static Dictionary<NXOperationType, string> NXOperationURLCollection = new Dictionary<NXOperationType, string>()
        {
            { NXOperationType.AssignWorkItem, "/Workflow/AssignWorkItem/{0}" },
            { NXOperationType.CancelWorkItem, "/Workflow/CancelWorkItem/{0}" },
            { NXOperationType.CompleteWorkItem, "/Workflow/CompleteWorkItem/{0}" },
            { NXOperationType.UpdateCustomAttributes, "/Workflow/SetCustomAttrs/{0}" },
            { NXOperationType.GetCustomAttribute, "/Workflow/GetCustomAttr/{0}" },
            { NXOperationType.GetWorkItem, "/Workflow/GetWorkItem/{0}" },
            { NXOperationType.CreateProcessInstance, "/Workflow/CreateProcInst" },
            { NXOperationType.GetReleasedDefId, "/Workflow/GetReleasedPID/{0}" },
            { NXOperationType.QueryProcessInstances,"/Workflow/QueryProcInsts" },
            { NXOperationType.GetProcessInstance,"/Workflow/GetProcInst/{0}" }
        };

        public NXOperation(NXOperationType operationType)
        {
            OperationType = operationType;
            CreateNXOperationUrl();
            client = new HttpClient
            {
                Timeout = new TimeSpan(0, 0, 30)
            };

            Logger.Debug($"NXOperation Mode '{operationType}' initialized with type {this.GetType()}.");
        }

        public abstract object ExecuteOperation(Hashtable parameters = null);

        private void CreateNXOperationUrl()
        {
            if (!NXOperationURLCollection.TryGetValue(OperationType, out string relativeUrl))
            {
                throw new InvalidOperationException($"Relative NX operation Url is not defined for '{OperationType}'!");
            }

            NXOperationUrl = $"{PGMConfig.AgilePointServiceBaseUrl}{relativeUrl}";
        }

        protected T ValidateAndGet<T>(object obj) where T : NXContract
        {
            if (obj == null)
            {
                throw new ArgumentNullException($"NX Contract cannot be null for requested type '{typeof(T)}'");
            }

            if (!(obj is T))
            {
                throw new ArgumentNullException($"NX Contract is not in requested Type '{typeof(T)}'");
            }

            return (T)obj;
        }

        protected async Task<string> HttpGet(string url, string authUserName)
        {
            try
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Basic {AuthorizationHeader}");
                client.DefaultRequestHeaders.Add("authUserName", authUserName);
                client.DefaultRequestHeaders.Add("appID", PGMConfig.AppName);
                HttpResponseMessage result = await client.GetAsync(url).ConfigureAwait(false);
                string response = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
                if (!result.IsSuccessStatusCode)
                {
                    Logger.Error($"Exception occurred while performing NX Operation '{url}' , Error response : {response} !");
                }
                return response;
            }
            catch (Exception ex)
            {
                Logger.Error($"Exception occurred while performing NX Operation '{url}' , Exception : {ex.Message} !");
                return null;
            }
        }

        protected async Task<string> HttpPost(string url, string authUserName, string data = null)
        {
            try
            {
                // if no data for payload replace using new object or {}
                using (StringContent content = new StringContent(data ?? "{}", Encoding.UTF8))
                {
                    content.Headers.Remove("Content-Type");
                    content.Headers.Add("Content-Type", "application/json");
                    client.DefaultRequestHeaders.Add("Authorization", $"Basic {AuthorizationHeader}");
                    client.DefaultRequestHeaders.Add("authUserName", authUserName);
                    client.DefaultRequestHeaders.Add("appID", PGMConfig.AppName);
                    HttpResponseMessage result = await client.PostAsync(url, content).ConfigureAwait(false);
                    string response = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
                    if (!result.IsSuccessStatusCode)
                    {
                        Logger.Error($"Exception occurred while performing NX Operation '{url}' , Error response : {response} !");
                    }
                    return response;
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"Exception occurred while performing NX Operation '{url}' , Exception : {ex.Message}!");
                return null;
            }
        }

        public virtual void Dispose()
        {
            if (client != null)
            {
                client.Dispose();
                client = null;
            }
        }
    }
}