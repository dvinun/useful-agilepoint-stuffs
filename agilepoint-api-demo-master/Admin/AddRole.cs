using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {

        public static WFRole AddRole(String roleName, String description, int[] rights, bool enabled)
        {
            IWFAdminService svc = Common.GetAdminAPI();
            WFRole role = null;
            try
            {
                role = svc.AddRole(roleName, description, rights, true);
            }

            catch (Exception ex)
            {
            }
            return role;
        }



    }
}
