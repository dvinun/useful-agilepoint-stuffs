using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {
     public static WFRoleMember[] QueryRoleMembers(string roleName, string sql)
     {
     IWFAdminService svc = Common.GetAdminAPI();
       WFRoleMember[] roleMembers = null;
try
	{
        roleMembers = svc.QueryRoleMembers(roleName, sql);
}
catch (Exception ex)
	{ }
return roleMembers;


     }


    }
}
