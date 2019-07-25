using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;

namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {
        public static string MergeProcInsts(WFProcessMergingInstruction instruction)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string MergProcInst = string.Empty;
            try
            {
                MergProcInst = svc.MergeProcInsts(instruction);
            }
            catch (Exception ex)
            {
            }
            return MergProcInst;

        }

    }
}
