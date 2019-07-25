using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

             public static WFBaseActivityInstance GetActivityInst(string aiID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string activityInstanceID = aiID;// activity instance
            WFBaseActivityInstance activityInstance = null;
            try
            {
                activityInstance = svc.GetActivityInst(activityInstanceID);

            }

            catch (Exception ex)
            {
            }
            return activityInstance;
        }

        public static KeyValue[] GetActivityInstStatus(string piID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string processInstanceID = piID;// for example, "02C3FA88ADE04750A34B5B3168C25793";
            KeyValue[] resultList = null;
            try
            {
                resultList = svc.GetActivityInstStatus(processInstanceID);
            }
            catch (Exception ex)
            {
            }
            return resultList;
        }

        public static WFBaseActivityInstance[] GetActivityInstsByPIID(string piID)
        {
            // This is console application sample
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string processInstanceID = piID;//"02C3FA88ADE04750A34B5B3168C25793";
            WFBaseActivityInstance[] activityInstance = null;
            try
            {
                activityInstance = svc.GetActivityInstsByPIID(processInstanceID);
            }
            catch (Exception ex)
            {
            }
            return activityInstance;
        }



    }
}
