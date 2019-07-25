using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {
        public static WFAuditTrailItem[] QueryAuditTrail(string where)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            WFAuditTrailItem[] result = null;
            try
            {
                // calling the QueryAuditTrail web method it return a array of Dataset.
                result = svc.QueryAuditTrail(where);

            }

            catch (Exception ex)
            {

            }
            return result;
        }



    }
}
