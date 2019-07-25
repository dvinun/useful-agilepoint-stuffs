using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

        public static void ArchiveProcInst(string procInstID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string processInstanceID = procInstID;// the ID of process instance to bearchived

            try
            {
                svc.ArchiveProcInst(processInstanceID);
            }

            catch (Exception ex)
            {

            }

        }



    }
}
