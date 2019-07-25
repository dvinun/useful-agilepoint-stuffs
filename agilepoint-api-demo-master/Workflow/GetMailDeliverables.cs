using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {
             public static WFMailDeliverable[] GetMailDeliverables(string piID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string processInstanceID = piID;// for example, "1e3d514d43d3465cae6ec3bbbd409168";
            WFMailDeliverable[] emailNotifications = null;
            try
            {
                emailNotifications = svc.GetMailDeliverables(processInstanceID);
            }

            catch (Exception ex)
            { }
            return emailNotifications;
        }





    }
}
