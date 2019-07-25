using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {
        public static WFRoleMember AddRoleMember(string roleName, string assignee, string assigneeType, string clientData, string objectID, string objectType)
        {
            IWFAdminService svc = Common.GetAdminAPI();
            WFRoleMember member = null;
            try
            {
                member = svc.AddRoleMember(roleName, assignee, assigneeType, clientData, objectID, objectType);
            }

            catch (Exception ex)
            {
            }
            return member;

        }

    }





}
