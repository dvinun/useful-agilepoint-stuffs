using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;

namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {
        public static string[] SplitProcInst(WFProcessSplittingInstruction instruction)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();

            string[] IDs = null;
            try
            {
                IDs = svc.SplitProcInst(instruction);
            }
            catch (Exception ex)
            {
            }
            return IDs;
        }

    }
}
