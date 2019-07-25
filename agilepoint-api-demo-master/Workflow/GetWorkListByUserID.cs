using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

              public static WFManualWorkItem[] GetWorkListByUserID(string username, string status)
        {
            //Get all WFManualWorkItem assigned to user
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string userID = username;// for example, @"Demo3\Administrator";
            string filterByStatus = status;
            WFManualWorkItem[] workItems = null;
            try
            {
                workItems = svc.GetWorkListByUserID(userID,
                filterByStatus);
            }
            catch (Exception ex)
            {
            }
            return workItems;
        }




    }
}
