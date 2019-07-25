using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;

namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {
        public static void ReleaseProcDef(string processTemplateID)
        {
            try
            {
                IWFWorkflowService svc = Common.GetWorkFlowAPI();
                //string processDefinitionID = "";
                svc.ReleaseProcDef(processTemplateID);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Failed! " + ShUtil.GetSoapMessage(ex));
            }
        }

    }

}
