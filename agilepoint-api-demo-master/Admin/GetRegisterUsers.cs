using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {
     public static RegisteredUser[] GetRegisterUsers()
{
IWFAdminService svc = Common.GetAdminAPI();
RegisteredUser[] registerUsers = null;
try
	{
     registerUsers = svc.GetRegisterUsers();
               }
catch (Exception ex)
	{

}
return registerUsers;

}




    }
}
