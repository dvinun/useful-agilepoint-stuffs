using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;

namespace AgilePointAPICodeSampleProject
{
   public partial class Workflow
    {

        public static WFEvent CancelProcInst(string piID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string processInstanceID = piID;// the ID of the process instance to becanceled.
            WFEvent evt = null;
            try
            {
                evt = svc.CancelProcInst(processInstanceID);
            }

            catch (Exception ex)
            {

            }
            return evt;
        }

    }
}
