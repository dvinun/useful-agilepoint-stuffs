using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {
        public static DomainUser[] GetDomainUsers(string source, string filter)
        {
            IWFAdminService svc = Common.GetAdminAPI();
            DomainUser[] users = null;
            try
            {
                users = svc.GetDomainUsers(source, filter);
            }

            catch (Exception ex)
            {
            }
            return users;

        }



    }
}
