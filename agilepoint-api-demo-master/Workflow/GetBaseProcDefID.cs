using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;

namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {
        public static string GetBaseProcDefID(string pName)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string processDefinitionName = pName;
            string baseProcessDefinitionID = svc.GetBaseProcDefID(processDefinitionName);
            return baseProcessDefinitionID;

        }

    }
}
