using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;

namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {
        public static WFEvent PromoteProcInst(String piID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            WFEvent evt = svc.PromoteProcInst(piID);
            return evt;
        }

    }
}
