using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

        public static WFEvent CancelProcedure(string wID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            WFEvent evt = null;
            string workItemID = wID;//
            try
            {
                evt = svc.CancelProcedure(workItemID);
            }

            catch (Exception ex)
            {
            }

            return evt;
        }




    }
}
