using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

        public static void RestoreProcInst(string procInstID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string processInstanceID = procInstID;// the ID of process instance to berestored.

            try
            {
                svc.RestoreProcInst(processInstanceID);
            }

            catch (Exception ex)
            {
            }
        }



    }
}
