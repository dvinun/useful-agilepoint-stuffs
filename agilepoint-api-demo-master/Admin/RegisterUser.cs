using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {

     public static void RegisterUser(RegisteredUser user)
     {
      IWFAdminService svc = Common.GetAdminAPI();
      try
	{
      svc.RegisterUser(user);
             }
      catch (Exception ex)
	{
       }

     }


    }
}
