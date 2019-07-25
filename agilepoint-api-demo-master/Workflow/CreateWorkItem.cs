using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

             public static WFEvent CreateWorkItem(string activityInstanceID, string workToPerform, string userID,
            WFTimeDuration duration, string clientData)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string ActivityInstanceID = activityInstanceID; // for example, "0172460E0AF943C6A6520044452BCAB3";
            string WorkToPerform = workToPerform; // for example, "SubmitRequest";
            //different workToPerform can be used if desired
            WFEvent evt = null;

            //WFTimeDuration duration = new WFTimeDuration("15", WFTimeUnit.DAY, true );// business time
            string user = userID; //the participant of the linked work item

            try
            {
                evt = svc.CreateWorkItem(activityInstanceID,
                workToPerform, user, duration, null);
            }
            catch (Exception ex)
            {
            }
            return evt;
        }




    }
}
