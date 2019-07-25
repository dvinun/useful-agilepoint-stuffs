using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {

public static void RemoveDelegation(string delegationID)
{
IWFAdminService svc = Common.GetAdminAPI();
try
	{
    svc.RemoveDelegation(delegationID);
	}

catch (Exception ex)
	{}


}



    }
}
