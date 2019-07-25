using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {
        public static WFGroup GetGroup(string groupName)
        {
            IWFAdminService svc = Common.GetAdminAPI();
            WFGroup grpInfo = null;
            try
            {
                grpInfo = svc.GetGroup(groupName);
            }
            catch (Exception ex)
            {

            }
            return grpInfo;

        }



    }
}
