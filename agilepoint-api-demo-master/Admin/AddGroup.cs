using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {
        public static WFGroup AddGroup(string groupName, string description, string responsibleUser, bool enabled)
        {
            IWFAdminService svc = Common.GetAdminAPI();
            WFGroup group = null;
            try
            {
                group = svc.AddGroup(groupName, description,responsibleUser, enabled);
            }

            catch (Exception ex)
            {
            }
            return group;

        }




    }
}
