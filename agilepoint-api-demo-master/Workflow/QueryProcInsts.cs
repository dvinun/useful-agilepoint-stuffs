using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;

namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {
        public static WFBaseProcessInstance[] QueryProcInsts(WFQueryExpr expr)
        {

            // query all running process instance
            //string status = WFProcessInstance.RUNNING;
            //WFAny any = WFAny.Create(status);
            //WFQueryExpr exprr = new WFQueryExpr("STATUS", SQLExpr.EQ, any, true);

            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            WFBaseProcessInstance[] result = null;
            try
            {

                result = svc.QueryProcInsts(expr);
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public static WFBaseProcessInstance[] QueryProcInstsEx(string Where)
        {
            // SQL Expression
            //string where = "STATUS in ('Running','Canceled')";
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            WFBaseProcessInstance[] result = null;
            try
            {

                result = svc.QueryProcInstsEx(Where);
            }
            catch (Exception ex)
            {

            }
            return result;
        }

    }
}
