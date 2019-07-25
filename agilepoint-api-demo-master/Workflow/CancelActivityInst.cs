using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {


            public static WFEvent CancelActivityInst(string activityInstanceID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string ActInstanceID = activityInstanceID;// activity instance needs to be canceled.
            WFEvent evt = null;
            try
            {
                evt = svc.CancelActivityInst(ActInstanceID);
            }
            catch (Exception ex)
            {
            }

            return evt;
        }



    }
}
