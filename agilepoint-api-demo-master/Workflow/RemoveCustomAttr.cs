using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

             public static void RemoveCustomAttr(string customID, string attributeName)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            try
            {
                svc.RemoveCustomAttr(customID, attributeName);
            }

            catch (Exception ex)
            { }
        }




    }
}
