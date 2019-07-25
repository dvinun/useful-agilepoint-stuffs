using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;

namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {
        public static void DeleteProcDef(string pID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();

            string processTemplateID = pID;// The unique identifier of the process definition to be deleted
            svc.DeleteProcDef(processTemplateID);
        }

    }
}
