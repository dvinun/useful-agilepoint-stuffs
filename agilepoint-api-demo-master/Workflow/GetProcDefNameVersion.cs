using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;

namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {
        public static KeyValue GetProcDefNameVersion(string pID)
        {

            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            KeyValue keyValue = new KeyValue();
            //process definition ID for a process.
            string processTemplatedID = pID;// for example "1e3d514d43d3465cae6ec3bbbd409168";

            try
            {
                //Returns KeyValuepair, for example "process definition Name-process definition Version"
                keyValue = svc.GetProcDefNameVersion(processTemplatedID);
                //return keyValue;
            }

            catch (Exception ex)
            {

            }
            return keyValue;
        }

    }
}
