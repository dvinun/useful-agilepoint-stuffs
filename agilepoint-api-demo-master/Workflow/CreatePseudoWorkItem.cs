using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

             public static WFEvent CreatePseudoWorkItem(string sourceWorkItemID, string workToPerform, string userID,
            WFTimeDuration duration, string clientData, bool reserved)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            WFEvent evt = null;
            try
            {
                evt = svc.CreatePseudoWorkItem(sourceWorkItemID, workToPerform, userID, duration, clientData, false);
            }
            catch (Exception ex)
            {

            }
            return evt;
        }




    }
}
