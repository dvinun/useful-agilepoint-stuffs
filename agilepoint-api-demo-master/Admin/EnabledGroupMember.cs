using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {

        public static WFGroupMember EnabledGroupMember(string groupName, string userName, bool enabled)
        {
            IWFAdminService svc = Common.GetAdminAPI();
            WFGroupMember GroupMember = null;
            try
            {
                GroupMember = svc.EnabledGroupMember(groupName, userName, enabled);
            }

            catch (Exception ex)
            {

            }
            return GroupMember;

        }



    }
}
