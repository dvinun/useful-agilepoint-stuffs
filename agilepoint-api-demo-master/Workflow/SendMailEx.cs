using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {
        public static void SendMailEx(String from, String to, String cc, String subject, String body, String attachments)
        {

            IWFWorkflowService svc = Common.GetWorkFlowAPI();

            try
            {

                //Send Mail
                svc.SendMailEx(from, to, cc, subject, body, attachments);
            }

            catch (Exception ex)
            {
            }

        }

        public static void SendMailEx(String from, String to, String cc, String subject, String body, String attachments, Enum priority)
        {

            IWFWorkflowService svc = Common.GetWorkFlowAPI();

            try
            {

                svc.SendMailEx(from, to, cc, subject, body, attachments);
            }

            catch (Exception ex)
            {
            }

        }







    }
}
