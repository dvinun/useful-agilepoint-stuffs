using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {

        public static WFDelegation GetDelegation(string delegationID)
        {

            IWFAdminService svc = Common.GetAdminAPI();
            WFDelegation delegation = null;
            try
            {
                delegation = svc.GetDelegation(delegationID);
            }
            catch (Exception ex)
            { }
            return delegation;
        }


    }
}
