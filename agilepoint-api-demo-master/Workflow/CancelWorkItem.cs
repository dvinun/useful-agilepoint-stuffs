using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

        public static WFEvent CancelWorkItem(string wID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string workItemID = wID; //
            WFEvent evt = null;
            try
            {
                evt = svc.CancelWorkItem(wID);
            }
            catch (Exception ex)
            {
            }
            return evt;
        }

        public static WFEvent CancelWorkItemEx(string wID, string clientData)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string workItemID = wID;// work item ID
            string clientDataValue = clientData;
            WFEvent evt = null;
            try
            {
                evt = svc.CancelWorkItemEx(workItemID, clientData);
            }
            catch (Exception ex)
            {
            }
            return evt;
        }




    }
}
