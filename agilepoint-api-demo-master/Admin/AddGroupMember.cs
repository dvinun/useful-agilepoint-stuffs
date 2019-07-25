using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {
        public static WFGroupMember AddGroupMember(string groupName, string userName, 
            string description, string clientData, bool enable)
        {
            IWFAdminService svc = Common.GetAdminAPI();
            WFGroupMember group = null;
            try
            {
                group = svc.AddGroupMember(groupName, userName, description,clientData, enable);
            }

            catch (Exception ex)
            {
            }
            return group;
        }



    }
}
