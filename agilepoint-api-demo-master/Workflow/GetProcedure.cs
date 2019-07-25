using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

            public static WFAutomaticWorkItem GetProcedure(string wID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string workItemID = wID;
            WFAutomaticWorkItem wItem = null;
            try
            {
                wItem = svc.GetProcedure(workItemID);
            }
            catch (Exception ex)
            {
            }
            return wItem;

        }




    }
}
