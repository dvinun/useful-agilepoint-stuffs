using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {
        public static void SendMail(String to, String cc, String subject, String body)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();

            try
            {

                svc.SendMail(to, cc, subject, body);
            }

            catch (Exception ex)
            {
            }



        }
    }
}