using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;


//Process Definition Methods 

namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

        public static WFBaseProcessDefinition[] GetProcDefByBasePID(string basePID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            WFBaseProcessDefinition[] processDefinitions = null;
            //Base process definition ID.
            string baseprocessInstanceID = basePID; // for example "1e3d514d43d3465cae6ec3bbbd409168";

            try
            {
                //Returns Array of WFBaseProcessDefinition for all versions of process definition 
                processDefinitions = svc.GetProcDefByBasePID(baseprocessInstanceID);
            }

            catch (Exception ex)
            {

            }
            return processDefinitions;
        }




    }
}
