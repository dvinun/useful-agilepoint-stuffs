using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;

namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {
        public static WFEvent[] GetEventsByProcInstID(string piID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string processInstanceID = piID; // process instance ID
            WFEvent[] events = null;
            try
            {
                events = svc.GetEventsByProcInstID(processInstanceID);

            }

            catch (Exception ex)
            {
            }
            return events;
        }

    }
}
