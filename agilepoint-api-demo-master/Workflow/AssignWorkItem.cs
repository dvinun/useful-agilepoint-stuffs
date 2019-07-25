using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

             public static WFEvent AssignWorkItem(string wID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string WorkItemID = wID;
            WFEvent evt = null;
            try
            {

                evt = svc.AssignWorkItem(WorkItemID);
            }
            catch (Exception ex)
            {
            }
            return evt;
        }

        public static WFEvent AssignWorkItemEx(string WorkItemID, string clientData)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string wID = WorkItemID;// work item ID
            WFEvent evt = null;
            string clientDataValue = clientData;
            try
            {
                evt = svc.AssignWorkItemEx(wID, clientDataValue);
            }
            catch (Exception ex)
            {
            }
            return evt;
        }




    }
}
