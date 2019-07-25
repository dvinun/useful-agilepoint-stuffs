using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {

    public static void RemoveGroupMember(string groupName, string userName)
    {
     IWFAdminService svc = Common.GetAdminAPI();
     try
	{
    svc.RemoveGroupMember(groupName, userName);
	}

catch (Exception ex)
	{}

    }


    }
}
