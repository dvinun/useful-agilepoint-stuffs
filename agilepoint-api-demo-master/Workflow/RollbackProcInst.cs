using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;

namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

        public static WFEvent RollbackProcInst(String AIID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string activityInstanceID = AIID;// target activity instance to roll back
            WFEvent evt = null;
            try
            {
                evt = svc.RollbackProcInst(activityInstanceID);
            }

            catch (Exception ex)
            {
            }
            return evt;
        }

    }
}
