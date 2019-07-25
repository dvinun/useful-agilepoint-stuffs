using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;

namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

        public static WFBaseProcessInstance GetProcInst(string PIID)
        {
            // This is sample code for console application
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string processInstanceID = PIID;// process instance ID
            WFBaseProcessInstance processInstance = null;
            try
            {
                //Returns an instance of WFBaseProcessInstance type.
                processInstance =
                svc.GetProcInst(processInstanceID);
            }

            catch (Exception ex)
            {
            }
            return processInstance;
        }

        public static NameValue[] GetProcInstAttrs(String piID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();

            string processInstanceID = piID;// process instance ID
            NameValue[] attributes = svc.GetProcInstAttrs(processInstanceID);
            return attributes;
        }


    }
}
