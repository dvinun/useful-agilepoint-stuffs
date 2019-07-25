using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

             public static WFEvent CompleteWorkItem(string wID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string workItemID = wID;// work item ID
            WFEvent evt = null;
            try
            {
                evt = svc.CompleteWorkItem(workItemID);
            }
            catch (Exception ex)
            {
            }
            return evt;
        }

        public static WFEvent CompleteWorkItemEx(string wID, string clientData)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string workItemID = wID;// work item ID
            string clientDataValue = clientData;
            WFEvent evt = null;
            try
            {
                evt = svc.CompleteWorkItemEx(workItemID, clientData);
            }
            catch (Exception ex)
            {
            }
            return evt;
        }



    }
}
