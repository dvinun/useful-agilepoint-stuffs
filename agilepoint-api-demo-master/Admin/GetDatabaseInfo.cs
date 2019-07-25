using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;

namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {
        public static DatabaseInfo GetDatabaseInfo()
        {
            IWFAdminService svc = Common.GetAdminAPI();
            DatabaseInfo dbInfo = null;
            try
            {
                dbInfo = svc.GetDatabaseInfo();
                
                
            }
            catch (Exception ex)
            {
            }
            return dbInfo;

        }
    }
}
