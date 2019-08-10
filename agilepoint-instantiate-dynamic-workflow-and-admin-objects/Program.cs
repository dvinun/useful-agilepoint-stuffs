using Ascentn.AgilePoint.WCFClient;
using Ascentn.Workflow.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.ServiceModel;


namespace HttpClientDemo
{
    class Program
    {
        static string userNameWithDomain;
        static string passWord;
        static string AuthHeader;
        static void Main(string[] args)
        {
             userNameWithDomain = "ap-fvzlpv2\\agpsvc";
             passWord = "Pass@word88";
             AuthHeader = string.Format("Basic " + Base64Encode(string.Format("{0}:{1}", userNameWithDomain, passWord)));

            try
            {
                SetCustomAttribute();
                WFManualWorkItem workItemResponse =GetWorkItem("804738002502C7551199AE51BDBC1BEF");
                IWFWorkflowService wfService = GetWorkflowService();
                WFManualWorkItem wFProcessDefinitions = wfService.GetWorkItem("804738002502C7551199AE51BDBC1BEF");               
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("\nException Caught!");
               
            }
        }

    

        public static IWFWorkflowService GetWorkflowService()
        {
            Uri uri = new Uri("net.tcp://AP-FVZLPV2:13488/AgilePointServer/Workflow");
            IWFWorkflowService m_api;
            const string APPLICATION_NAME = "SPSIntegration";
            string SVCuserName = "agpsvc";
            string SVCPassWord = "Pass@word88";
            string SVCUserDomain = "AP-FVZLPV2";
            string svcAdminUserNameWithDomain = string.Format("{0}\\{1}", SVCUserDomain, SVCuserName);
            string imporsantorUser = "AP-FVZLPV2\\agpuser1";
            System.Net.ICredentials credentials = new NetworkCredential(SVCuserName, SVCPassWord, SVCUserDomain);
            var myBinding = new NetTcpBinding();
            string nettcpurl = "net.tcp://AP-FVZLPV2:13488/AgilePointServer/Workflow";
            string locale = "en-Us";
            m_api = new WCFWorkflowProxy(APPLICATION_NAME, "AP-FVZLPV2", locale, imporsantorUser, credentials, myBinding, nettcpurl, svcAdminUserNameWithDomain);
            string authenticatedUserName = m_api.CheckAuthenticated();
            return m_api;
        }

        public static WFManualWorkItem  GetWorkItem(string workItemId)
        {
            string url = string.Format("http://ap-fvzlpv2:13490/agilepointserver/workflow/GetWorkItem/{0}", workItemId);
            WebHeaderCollection headerCollection = new WebHeaderCollection();
            headerCollection.Add("Authorization", AuthHeader);
            string Response = RestUtility.MakeRESTHTTPRequest(url, System.Net.Http.HttpMethod.Get, headerCollection, string.Empty, "application/json");
            ManualWorkItemResponse manualWorkItemResponse= JsonConvert.DeserializeObject<ManualWorkItemResponse>(Response);
            return  manualWorkItemResponse.GetWorkItemResult;
        }

        public static void SetCustomAttribute()
        {
            string url = string.Format("http://ap-fvzlpv2:13490/agilepointserver/workflow/SetCustomAttrs/{0}", "4C04E35AD1914CD69A1A68D5AB52DB4C");
            WebHeaderCollection headerCollection = new WebHeaderCollection();
            headerCollection.Add("Authorization", AuthHeader);
            List<NameValue> list = new List<NameValue>();
            list.Add(new NameValue("/pd:AP/pd:processFields/pd:text1", "Value1"));
            CustAttributeRequest custAttributeRequest = new CustAttributeRequest();
            custAttributeRequest.attributes = list;
            string payload = JsonConvert.SerializeObject(custAttributeRequest);
            string Response = RestUtility.MakeRESTHTTPRequest(url, System.Net.Http.HttpMethod.Post, headerCollection, payload, "application/json");
           // ManualWorkItemResponse manualWorkItemResponse = JsonConvert.DeserializeObject<ManualWorkItemResponse>(Response);


        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }

    public class ManualWorkItemResponse
    {

        public WFManualWorkItem GetWorkItemResult { get; set; }
    }
    

    public class CustAttributeRequest
    {
        public List<NameValue> attributes { get; set; }
    }
}
