using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

            public static WFEvent ReassignWorkItem(string wID, string userID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            WFEvent evt = null;
            try
            {
                evt = svc.ReassignWorkItem(wID, userID);
            }
            catch (Exception ex)
            { }
            return evt;
        }

        public static WFEvent ReassignWorkItemEx(string wID, string userID, string clientData)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            WFEvent evt = null;
            try
            {
                evt = svc.ReassignWorkItemEx(wID,
               userID, clientData);
            }

            catch (Exception ex)
            { }
            return evt;
        }




    }
}
