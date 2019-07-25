using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

             public static WFEvent ReassignUpdateWorkItem(string workItemID, string originalUserID,
            string newAssigneeUserID, string clientData)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            WFEvent evt = null;
            try
            {
                evt = ReassignUpdateWorkItem(workItemID, originalUserID, newAssigneeUserID, null);
            }
            catch (Exception ex)
            {
            }
            return evt;
        }




    }
}
