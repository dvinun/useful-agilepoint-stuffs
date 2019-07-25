using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {

        public static string GetSmtpServer()
        {
            IWFAdminService svc = Common.GetAdminAPI();
            string smtpServer = string.Empty;
            try
            {
                smtpServer = svc.GetSmtpServer();
            }
            catch (Exception ex)
            {
            }
            return smtpServer;
        }



    }
}
