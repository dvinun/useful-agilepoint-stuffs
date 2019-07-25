using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

             public static WFEvent UndoAssignWorkItem(string wID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string workItemID = wID;// for example, "03ABD59A0EB74D7A8741709478E83877";
            WFEvent evt = null;
            try
            {
                evt = svc.UndoAssignWorkItem(workItemID);
            }
            catch (Exception ex)
            { }
            return evt;
        }

        public static WFEvent UndoAssignWorkItemEx(string wID, string clientData)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string workItemID = wID;// for example, "03ABD59A0EB74D7A8741709478E83877";
            WFEvent evt = null;
            try
            {
                evt = svc.UndoAssignWorkItemEx(workItemID, clientData);
            }

            catch (Exception ex)
            { }
            return evt;
        }




    }
}
