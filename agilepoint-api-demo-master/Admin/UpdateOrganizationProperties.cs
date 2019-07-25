using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {

public static void UpdateOrganizationProperties(string name, KeyValue[] list)
{
IWFAdminService svc = Common.GetAdminAPI();
try
	{
 svc.UpdateOrganizationProperties(name,list);
	}

catch (Exception ex)
	{}




}



    }
}
