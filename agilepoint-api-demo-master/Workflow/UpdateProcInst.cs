using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;

namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {
        public static void UpdateProcInst(string processInstanceID, NameValue[] attributes)
        {
            //IWFWorkflowService svc = Common.GetWorkFlowAPI();
            //string processInstanceID = PIID; // process instance ID
            //string newProccessInstanceName = "[new process instance name]";
            //DateTime newDueDate = DateTime.Now.AddDays(7.0);

            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            svc.UpdateProcInst(processInstanceID, attributes);
        }

    }
}
