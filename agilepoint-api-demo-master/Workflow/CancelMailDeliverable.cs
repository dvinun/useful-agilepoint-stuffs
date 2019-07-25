using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

            public static void CancelMailDeliverable(string mID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string emailNotificationID = mID;

            try
            {
                svc.CancelMailDeliverable(emailNotificationID);
            }

            catch (Exception ex)
            {
            }

        }




    }
}
