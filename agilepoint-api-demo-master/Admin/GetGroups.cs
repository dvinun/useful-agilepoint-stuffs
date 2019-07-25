using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {
        public static WFGroup[] GetGroups()
        {
            IWFAdminService svc = Common.GetAdminAPI();
            WFGroup[] apGroups = null;
            try
            {
                apGroups = svc.GetGroups();
            }
            catch (Exception ex)
            {
            }
            return apGroups;
        }



    }
}
