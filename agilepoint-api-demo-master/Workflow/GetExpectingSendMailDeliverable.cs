using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {
             public static WFMailDeliverable[] GetExpectingSendMailDeliverable()
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            WFMailDeliverable[] mailDeliverables = null;
            try
            {
                //Returns Array of WFMailDeliverable type
                mailDeliverables = svc.GetExpectingSendMailDeliverable();
            }
            catch (Exception ex)
            {
            }
            return mailDeliverables;
        }





    }
}