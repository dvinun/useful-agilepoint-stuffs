using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {

        public static WFDelegation AddDelegation(WFDelegation delegation)
        {
            IWFAdminService svc = Common.GetAdminAPI();
            WFDelegation delegations = null;
            try
            {
                delegations = svc.AddDelegation(delegation);

            }

            catch (Exception ex)
            {

            }
            return delegations;


        }


    }
}
