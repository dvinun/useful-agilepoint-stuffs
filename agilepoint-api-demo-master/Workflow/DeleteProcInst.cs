using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;

namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {
        public void DeleteProcInst(string piID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string processInstanceID = piID;// the ID of the process instance to becanceled.

            try
            {
                svc.DeleteProcInst(processInstanceID);
            }

            catch (Exception ex)
            {
            }
        }

    }
}
