using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {

        public static string GetDomainName()
        {
            IWFAdminService svc = Common.GetAdminAPI();
            string domainName = null;
            try
            {
                domainName = svc.GetDomainName();
            }
            catch (Exception ex)
            {

            }
            return domainName;

        }



    }
}
