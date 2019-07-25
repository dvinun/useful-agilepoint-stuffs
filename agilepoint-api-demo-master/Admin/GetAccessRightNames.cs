using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {
        public static string[] GetAccessRightNames()
        {
            IWFAdminService svc = Common.GetAdminAPI();
            string[] permissionNames = null;
            try
            {
                permissionNames = svc.GetAccessRightNames();
            }

            catch (Exception ex)
            {
            }
            return permissionNames;

        }



    }
}
