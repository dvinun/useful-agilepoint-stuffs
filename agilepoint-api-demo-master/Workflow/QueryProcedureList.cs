using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

        public static WFAutomaticWorkItem[] QueryProcedureList(WFQueryExpr expr)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            WFAutomaticWorkItem[] result = null;
            try
            {
                ////WebMethod with sql query expression as argument.
                //WFAny any = WFAny.Create(WFAutomaticWorkItem.WAITING);
                //WFQueryExpr expr = new WFQueryExpr("STATUS", SQLExpr.EQ, any, true);   construct the parameter in this manner
                result = svc.QueryProcedureList(expr);
            }
            catch (Exception ex)
            {
            }
            return result;
        }




    }
}
