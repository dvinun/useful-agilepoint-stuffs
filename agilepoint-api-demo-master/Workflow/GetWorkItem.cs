using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

             public static WFManualWorkItem GetWorkItem(string wID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string workItemID = wID;// for example, "54A648A0A3004A02981E7F0848820FE7";
            WFManualWorkItem workItem = null;
            try
            {
                workItem = svc.GetWorkItem(workItemID);
            }
            catch (Exception ex)
            {
            }
            return workItem;
        }




    }
}
