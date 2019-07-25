using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {
             public static WFBaseActivityInstance[] QueryActivityInsts(WFQueryExpr expr)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            //string processInstanceID = "";
            //WFAny any = WFAny.Create(processInstanceID);
            //WFQueryExpr expr = new WFQueryExpr("PROC_INST_ID", SQLExpr.IN, any, true);
            WFBaseActivityInstance[] ais = null;
            try
            {
                ais = svc.QueryActivityInsts(expr);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Failed! " + ShUtil.GetSoapMessage(ex));
            }
            return ais;
        }





    }
}
