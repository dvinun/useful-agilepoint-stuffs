using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {

        public static void CancelDelegation(string delegationID)
        {
            IWFAdminService svc = Common.GetAdminAPI();
            try
            {
                svc.CancelDelegation(delegationID);
            }

            catch (Exception ex)
            {

            }

        }


    }
}
