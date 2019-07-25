using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {

        public static int[] GetAccessRights(string userName)
        {
            IWFAdminService svc = Common.GetAdminAPI();
            int[] userRights = null;
            try
            {

                userRights = svc.GetAccessRights(userName);

            }

            catch (Exception ex)
            {

            }

            return userRights;


        }



    }
}
