using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {

    public static void RemoveRoleMember(string roleName, string assignee, string assigneeType, string objectID)
{
IWFAdminService svc = Common.GetAdminAPI();
try
	{
    svc.RemoveRoleMember(roleName, assignee,assigneeType,null);
	}

catch (Exception ex)
	{}


}



    }
}
