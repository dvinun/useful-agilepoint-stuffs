using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {


             public static WFManualWorkItem[] QueryWorkList(WFQueryExpr expr)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            //WFAny any = WFAny.Create(WFManualWorkItem.ASSIGNED);
            //WFQueryExpr expr = new WFQueryExpr("WF_MANUAL_WORKITEM.STATUS",
            //SQLExpr.EQ, any, true);
            WFManualWorkItem[] workItems = null;
            try
            {
                workItems = svc.QueryWorkList(expr);
            }
            catch (Exception ex)
            {
            }
            return workItems;
        }

        public static WFManualWorkItem[] QueryWorkListEx(string sql)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            WFManualWorkItem[] workItems = null;
            try
            {
                workItems = svc.QueryWorkListEx(sql);
            }
            catch (Exception ex)
            {
            }
            return workItems;
        }


    }
}
