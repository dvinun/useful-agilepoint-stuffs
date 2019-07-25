using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {

    public static KeyValue[] GetOrganizationProperties(string name)
{
IWFAdminService svc = Common.GetAdminAPI();
KeyValue[] organizationProperties=null;
try{
organizationProperties =
    svc.GetOrganizationProperties(name);
}
catch (Exception ex)
	{}
return organizationProperties;


}



    }
}
