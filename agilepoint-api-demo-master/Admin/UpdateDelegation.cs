using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {

public static WFDelegation UpdateDelegation(WFDelegation delegation)
{
IWFAdminService svc = Common.GetAdminAPI();
WFDelegation updatedDelegation=null;
try
	{
updatedDelegation = svc.UpdateDelegation( delegation );
	}

catch (Exception ex)
	{}
return updatedDelegation;


}



    }
}
