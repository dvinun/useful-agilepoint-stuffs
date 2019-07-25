using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;

namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {
        public static WFEvent SuspendProcInst(string piID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            WFEvent evt = null;
            try
            {
                string processInstanceID = piID;// process instance to be suspended.
                evt = svc.SuspendProcInst(processInstanceID);
            }

            catch (Exception ex)
            {
            }
            return evt;
        }

    }

}
