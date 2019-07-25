using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {
     public static void UpdateRegisterUser(RegisteredUser user)
     {
      IWFAdminService svc = Common.GetAdminAPI();
      try
	{
    svc.UpdateRegisterUser( user );
	}

catch( Exception ex )
	{
}
     }



    }
}
