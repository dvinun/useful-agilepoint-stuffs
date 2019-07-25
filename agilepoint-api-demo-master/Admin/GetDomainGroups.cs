using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {
        public static KeyValue[] GetDomainGroups(string source, string filter)
        {
            IWFAdminService svc = Common.GetAdminAPI();
            KeyValue[] grps = null;
            try
            {
                grps = svc.GetDomainGroups(source, filter);
            }

            catch (Exception ex)
            {
            }
            return grps;
        }

        public static DomainUser[] GetDomainGroupMembers(string groupDistinguishedName)
        {
            IWFAdminService svc = Common.GetAdminAPI();
            DomainUser[] grpUsers = null;
            try
            {
                grpUsers = svc.GetDomainGroupMembers(groupDistinguishedName);
            }


            catch (Exception ex)
            {

            }
            return grpUsers;
        }

    }
}