using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {
           public static void ResendMailDeliverable(string mID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string emailNotificationID = mID;// for example, "1e3d514d43d3465cae6ec3bbbd409168";
            try
            {
                svc.ResendMailDeliverable(emailNotificationID);
            }
            catch (Exception ex)
            { }
        }



    }
}
