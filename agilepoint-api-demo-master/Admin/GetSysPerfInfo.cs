using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {

        public static WFSysPerfInfo GetSysPerfInfo()
        {
            IWFAdminService svc = Common.GetAdminAPI();
            WFSysPerfInfo sysPerfInfo = null;
            try
            {
                sysPerfInfo = svc.GetSysPerfInfo();
            }

            catch (Exception ex)
            {

            }
            return sysPerfInfo;
        }

    }

}





