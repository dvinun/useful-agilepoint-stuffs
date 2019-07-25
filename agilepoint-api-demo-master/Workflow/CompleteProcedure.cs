using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

             public static WFEvent CompleteProcedure(string wID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            WFEvent evt = null;
            string autoWorkItemID = wID;//
            try
            {
                evt = svc.CompleteProcedure(autoWorkItemID);
            }

            catch (Exception ex)
            {
            }

            return evt;
        }




    }
}
