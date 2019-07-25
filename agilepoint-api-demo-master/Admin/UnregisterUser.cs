using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {

     public void UnregisterUser(string userName)
     {
     IWFAdminService svc = Common.GetAdminAPI();
     try
	{
      svc.UnregisterUser(userName);
	}
     catch( Exception ex)
	{
                }
     }



    }
}
