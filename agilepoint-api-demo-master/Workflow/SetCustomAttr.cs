using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

             public static void SetCustomAttr(String customID, String name, object val)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();

            try
            {
                svc.SetCustomAttr(customID, name, val);
            }

            catch (Exception ex)
            { }
        }

        public static void SetCustomAttrs(string customID, NameValue[] nameValues)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();

            try
            {
                svc.SetCustomAttrs(customID, nameValues);
            }

            catch (Exception ex)
            { }
        }




    }
}
