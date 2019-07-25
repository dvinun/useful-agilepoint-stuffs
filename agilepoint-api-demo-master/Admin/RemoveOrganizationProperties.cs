using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {

    public static void RemoveOrganizationProperties(string name)
{
IWFAdminService svc = Common.GetAdminAPI();
try
	{
    svc. RemoveOrganizationProperties (name);
	}

catch (Exception ex)
	{}



}


    }
}
