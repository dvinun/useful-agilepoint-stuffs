using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {

public static WFRole UpdateRole(string roleName, string description, int[] rights, bool enabled)
{
IWFAdminService svc = Common.GetAdminAPI();
WFRole updatedRole=null;
try
	{
    updatedRole = svc.UpdateRole(roleName, description,rights, true);
	}

catch( Exception ex)
	{}
return updatedRole;


}



    }
}
