using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;


//Process Definition Methods 

namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

             public static KeyValue[] GetReleasedProcDefs()
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            KeyValue[] defs = svc.GetReleasedProcDefs();
            return defs;
        }




    }
}