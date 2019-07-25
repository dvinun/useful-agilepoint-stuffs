using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {
    public static void RemoveGroup(string groupName)
    {
     IWFAdminService svc = Common.GetAdminAPI();
     try
	{
    svc.RemoveGroup(groupName);
	}

catch (Exception ex)
	{
                }


    }



    }
}
