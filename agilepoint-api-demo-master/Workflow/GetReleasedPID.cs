using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;


//Process Definition Methods 

namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

        public static string GetReleasedPID(string pName)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string processDefinitionName = pName;
            string processDefinitionID = svc.GetReleasedPID(processDefinitionName);
            return processDefinitionID;
        }



    }
}