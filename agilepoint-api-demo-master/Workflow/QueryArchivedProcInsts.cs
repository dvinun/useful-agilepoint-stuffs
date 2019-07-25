using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

        public static WFBaseProcessInstance[] QueryArchivedProcInsts(string sql)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            WFBaseProcessInstance[] archivedProcessInstances = null;
            try
            {
                archivedProcessInstances = svc.QueryArchivedProcInsts(sql);
            }

            catch (Exception ex)
            {
            }
            return archivedProcessInstances;
        }


    }
}
