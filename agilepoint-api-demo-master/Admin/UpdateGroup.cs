using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {

     public static WFGroup UpdateGroup(string groupName, string description, string responsibleUser, bool enabled)

{
IWFAdminService svc = Common.GetAdminAPI();
WFGroup updatedGroup=null;
try
	{
updatedGroup = svc.UpdateGroup(groupName, description,
responsibleUser, true);
	}

catch (Exception ex)
	{}
return updatedGroup;

}



    }
}
