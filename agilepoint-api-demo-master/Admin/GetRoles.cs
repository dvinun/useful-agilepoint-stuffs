using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {

        public static WFRole[] GetRoles()
        {
            IWFAdminService svc = Common.GetAdminAPI();
            WFRole[] roles = null;
            try
            {
                roles = svc.GetRoles();
            }

            catch (Exception ex)
            { }
            return roles;


        }


    }
}
