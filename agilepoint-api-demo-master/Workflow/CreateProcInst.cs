using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;

namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {
        public static WFEvent CreateProcInst(string PID, string PIID, string PIName, string workObjectID,
     string superPIID, bool startImmediately)
        {

            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string processDefinitionName = "EmployeeOnboardProcess";

            // get UUID of released process definition
            string processDefinitionID = svc.GetReleasedPID(processDefinitionName);

            // assign UUID of process instance
            string processInstanceID = UUID.GetID();

            // process instance name that has to be unique within process definition ID
            string processInstanceName = string.Format("{0}-{1}", processDefinitionName, DateTime.Now.Ticks);

            // work object ID
            workObjectID = UUID.GetID();

            // create process instance
            WFEvent E = svc.CreateProcInst(PID, PIID, PIName, workObjectID, null, true);

            return E;

        }

        public static WFEvent CreateProcInstEx(string PID, string PIID, string PIName, string workObjectID,
            string workObjectInfo, string superPIID, string initiator, string customID,
            NameValue[] attributes, bool startImmediately)
        {

            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            WFEvent evt = svc.CreateProcInstEx(
                  PID,
                  PIID,
                  PIName,
                  workObjectID,
                  workObjectInfo,
                  superPIID,
                  initiator,
                  workObjectID,
                  attributes,
                  true);

            return evt;

        }

        public static WFEvent CreateProcInstEx(string PID, string PIID, string PIName, string workObjectID,
            string superPIID, string initiator, string customID, NameValue[] attributes, bool startImmediately)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            WFEvent evt = svc.CreateProcInstEx(
                  PID,
                  PIID,
                  PIName,
                  workObjectID,
                  superPIID,
                  initiator,
                  customID,
                  attributes,
                  true);

            return evt;
        }

        public static WFEvent CreateProcInstEx(string PID, string PIID, string PIName,
            string workObjectID, string superPIID, string customID, NameValue[] attributes, bool startImmediately)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();

            WFEvent evt = svc.CreateProcInstEx(
                  PID,
                  PIID,
                  PIName,
                  workObjectID,
                  superPIID,
                  customID,
                  attributes,
                  true);

            return evt;

        }
    }
}
