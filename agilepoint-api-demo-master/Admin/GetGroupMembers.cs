using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {
        public static WFGroupMember[] GetGroupMembers(string groupName)
        {
            IWFAdminService svc = Common.GetAdminAPI();
            WFGroupMember[] grpMembers = null;
            try
            {
                grpMembers = svc.GetGroupMembers(groupName);
            }

            catch (Exception ex)
            { }
            return grpMembers;
        }




    }
}
