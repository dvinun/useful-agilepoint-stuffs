using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {
     
             public static WFEvent CreateLinkedWorkItem(string sourceWorkItemID, string workToPerform,
            string userID, WFTimeDuration duration, string clientData)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            // get existing work item
            string workItemID = sourceWorkItemID;// for example,"90CF843AC57644058A391FBFA030F607"
            WFEvent evt = null;
            try
            {
                // Get the source WFManualWorkItem object
                //WFManualWorkItem sourceWorkItem = svc.GetWorkItem(workItemID);
                //string workToPerform = sourceWorkItem.Name; //different workToPerform can be used if desired
                //WFTimeDuration duration = new WFTimeDuration();
                //duration.Length = "15"; //for example, 15 days
                //duration.Unit = WFTimeUnit.DAY;
                //string user = @"[DOMAIN NAME]\username"; //the participant of the linked work item
                evt = svc.CreateLinkedWorkItem(workItemID, workToPerform, userID, duration, clientData);
            }

            catch (Exception ex)
            {
            }
            return evt;
        }


        public static WFEvent CreateLinkedWorkItemEx(string sourceWorkItemID, string workToPerform,
            string userID, WFTimeDuration duration, string clientData, bool bDependent)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            WFEvent evt = null;
            try
            {
                evt = svc.CreateLinkedWorkItemEx(sourceWorkItemID, workToPerform, userID, duration, null, true);
            }
            catch (Exception ex)
            {

            }
            return evt;
        }





    }
}
