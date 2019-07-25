using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

             public static void UpdateWorkItem(string workItemID, NameValue[] attributes)
        {

            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string wID = workItemID;// work item ID of manual work item or automatic work item.

            try
            {
                //NameValue[] attrs = NameValue.Array("NAME", "[New Name]", "DUE_DATE", DateTime.Now.Add(new TimeSpan(1, 1, 1))); // for example, DateTime.Now.AddDays(3.0)
                svc.UpdateWorkItem(workItemID, attributes);
            }

            catch (Exception ex)
            { }
        }




    }
}
