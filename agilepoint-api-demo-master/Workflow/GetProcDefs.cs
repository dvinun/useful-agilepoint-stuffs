using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;

namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {
        public static WFBaseProcessDefinition[] GetProcDefs()
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            WFBaseProcessDefinition[] processDefinitions = null;
            try
            {
                //Returns Array of WFBaseProcessDefinition type.
                processDefinitions = svc.GetProcDefs();
                for (int i = 0; i < processDefinitions.Length; i++)
                {
                    Console.WriteLine("Definition ID: '" +
                    processDefinitions[i].DefID + "' ");
                    Console.WriteLine("Definition Name: '" +
                    processDefinitions[i].DefName + "' ");
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine(ShUtil.GetSoapMessage(ex));
            }
            return processDefinitions;

        }

    }
}
