using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

             public static WFEvent RollbackActivityInst(string activityInstanceID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            WFEvent evt = null;
            try
            {
                evt = svc.RollbackActivityInst(activityInstanceID);
            }
            catch (Exception ex)
            {
            }
            return evt;

        }

        public static WFEvent RollbackActivityInsts(WFPartialRollbackInstruction instruction)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            WFEvent evt = null;
            //ROLL BACK UNIT
            WFPartialRollbackInstruction.PartialRollbackUnit unit1 = new WFPartialRollbackInstruction.PartialRollbackUnit();
            unit1.DestinationActivityInstanceID = ""; // destination activity instance ID
            unit1.SourceActivityInstanceIDs = new string[] { "", "", "" }; // array of source activity instance ID


            WFPartialRollbackInstruction.PartialRollbackUnit unit2 = new WFPartialRollbackInstruction.PartialRollbackUnit();
            unit2.DestinationActivityInstanceID = ""; // destination activityinstance ID
            unit2.SourceActivityInstanceIDs = new string[] { "", "" }; // array of source activity instance ID
            WFPartialRollbackInstruction instructions = new WFPartialRollbackInstruction();


            evt = svc.RollbackActivityInsts(instruction);
            return evt;
        }
    }
}
