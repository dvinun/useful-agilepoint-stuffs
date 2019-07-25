using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {

public static RegisteredUser GetRegisterUser(string userName)
{
IWFAdminService svc = Common.GetAdminAPI();
RegisteredUser registerUser = null;
try
	{
    registerUser =
    svc.GetRegisterUser(userName);
}
catch (Exception ex)
	{
}
return registerUser;

}



    }
}