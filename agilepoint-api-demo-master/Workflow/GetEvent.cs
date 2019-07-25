using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

             public static WFEvent GetEvent(string evtID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string eventID = evtID;// for example, "049C3974240F47D3BA8EB6D4A3CDCD3F";
            WFEvent evt = null;
            try
            {
                evt = svc.GetEvent(eventID);
            }
            catch (Exception ex)
            { }
            return evt;
        }




    }
}
