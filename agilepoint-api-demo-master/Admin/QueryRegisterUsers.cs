using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {
    public static RegisteredUser[] QueryRegisterUsers(string sqlWhereClause)
    {
     IWFAdminService svc = Common.GetAdminAPI();
     RegisteredUser[] registeredUsers = null;
     try
	{
     registeredUsers = svc.QueryRegisterUsers(sqlWhereClause);
     }
     catch (Exception ex)
	{

}
return registeredUsers;


    }




    }
}
