using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {
 public static WFDelegation[] GetDelegations(string fromUser, string toUser, string status)

{
IWFAdminService svc = Common.GetAdminAPI();
WFDelegation[] delegations=null;
try
	{
    delegations = svc.GetDelegations( fromUser, toUser,status);
     }
catch (Exception ex)
	{}

return delegations;

}


    }
}
