using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;


//Process Definition Methods 

namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

             public static string UpdateProcDef(string xml)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string processDefinitionID = string.Empty;
            string processDefinitionXML = xml;// see previous description of how to get process definition XML          

            try
            {
                //Update Process definition using updated process xml string
                processDefinitionID = svc.UpdateProcDef(xml);
            }
            catch (Exception ex)
            {
            }
            return processDefinitionID;
        }




    }
}
