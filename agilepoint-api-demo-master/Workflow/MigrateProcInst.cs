using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;

namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {
        public static void MigrateProcInst(WFProcessMigrationInstruction instruction,
    string processInstanceID, string reserved)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            try
            {
                svc.MigrateProcInst(instruction, processInstanceID, reserved);
            }
            catch (Exception ex)
            {

            }
        }

    }
}
