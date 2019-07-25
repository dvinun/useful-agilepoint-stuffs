using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;
using System.ServiceModel;
using Ascentn.AgilePoint.WCFClient;
using System.Threading;
using System.Configuration;

namespace AgilePointAPICodeSampleProject
{
    class Common
    {
        static IWFAdminService m_adm;
        static IWFWorkflowService m_api;

        public static IWFAdminService GetAdminAPI()
        {
            if (m_adm != null) return m_adm;
            string logusername = ConfigurationSettings.AppSettings["UserName"];
            string logpassword = ConfigurationSettings.AppSettings["Password"];
            string logdomain = ConfigurationSettings.AppSettings["Domain"];

            System.Net.ICredentials credentials = credentials = new System.Net.NetworkCredential(logusername, logpassword, logdomain);
            if (credentials == null) return m_adm;

                string locale = GetLocale();

                string user = "";
                string url = ConfigurationSettings.AppSettings["ServerURL"];

                WSHttpBinding wsHttpBinding = new WSHttpBinding(SecurityMode.Message);
                wsHttpBinding.Security.Mode = SecurityMode.Message;
                wsHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Windows;
                wsHttpBinding.Security.Transport.ProxyCredentialType = HttpProxyCredentialType.Windows;
                wsHttpBinding.Security.Message.ClientCredentialType = MessageCredentialType.Windows;
                wsHttpBinding.MaxBufferPoolSize = Int32.MaxValue;
                wsHttpBinding.MaxReceivedMessageSize = Int32.MaxValue;

                System.Xml.XmlDictionaryReaderQuotas rdQuota = new System.Xml.XmlDictionaryReaderQuotas();
                rdQuota.MaxArrayLength = Int32.MaxValue;
                rdQuota.MaxStringContentLength = Int32.MaxValue;
                wsHttpBinding.ReaderQuotas = rdQuota;

                user = logdomain + @"\" + logusername;
                //string adminBinding = "WSHttpBinding_IWCFAdminService";
                m_adm = new WCFAdminProxy("TestApp", "", locale, user, credentials, wsHttpBinding, url);
            

            return m_adm;
        }

        public static string GetLocale()
        {
            return Thread.CurrentThread.CurrentUICulture.Name;
        }

        public static IWFWorkflowService GetWorkFlowAPI()
        {


            if (m_api != null) return m_api;
            string logusername = ConfigurationSettings.AppSettings["UserName"];
            string logpassword = ConfigurationSettings.AppSettings["Password"];
            string logdomain = ConfigurationSettings.AppSettings["Domain"];


            System.Net.ICredentials credentials = credentials = new System.Net.NetworkCredential(logusername, logpassword, logdomain);
            if (credentials == null) return m_api;

            string locale = GetLocale();          

                string url = ConfigurationSettings.AppSettings["ServerURL"];

                WSHttpBinding wsHttpBinding = new WSHttpBinding(SecurityMode.Message);
                wsHttpBinding.Security.Mode = SecurityMode.Message;
                wsHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Windows;
                wsHttpBinding.Security.Transport.ProxyCredentialType = HttpProxyCredentialType.Windows;

                wsHttpBinding.Security.Message.ClientCredentialType = MessageCredentialType.Windows;
                wsHttpBinding.MaxBufferPoolSize = Int32.MaxValue;
                wsHttpBinding.MaxReceivedMessageSize = Int32.MaxValue;

                System.Xml.XmlDictionaryReaderQuotas rdQuota = new System.Xml.XmlDictionaryReaderQuotas();
                rdQuota.MaxArrayLength = Int32.MaxValue;
                rdQuota.MaxStringContentLength = Int32.MaxValue;
                wsHttpBinding.ReaderQuotas = rdQuota;

                string user = String.Empty;
                user = logdomain + @"\" + logusername;
                //string workflowBinding = "WSHttpBinding_IWCFWorkflowService";
                m_api = new WCFWorkflowProxy("TestApp", "", locale, user, credentials, wsHttpBinding, url);
                //m_api = new AgilePointAPICodeSampleProject.WCFWorkflowProxy("ENVOY Mortgage", "", "nl", user, credentials, wsHttpBinding, url);
            
            return m_api;
        }

    }
}
