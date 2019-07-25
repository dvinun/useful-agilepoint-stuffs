using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {

        public static WFRole GetRole(string roleName)
        {
            IWFAdminService svc = Common.GetAdminAPI();
            WFRole role = null;
            try
            {
                role = svc.GetRole(roleName);
            }
            catch (Exception ex)
            { }
            return role;



        }



    }
}
