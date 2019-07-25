using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {

      public static void RemoveRole(string roleName)
      {
      IWFAdminService svc = Common.GetAdminAPI();
      try
	{
    svc.RemoveRole (roleName);
	}

catch (Exception ex)
	{}
      
      }



    }
}
