using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {

      public static string GetSystemUser()
      {
       IWFAdminService svc = Common.GetAdminAPI();
        string systemUser = string.Empty;
       try
	{
    systemUser = svc.GetSystemUser();
      }
      catch (Exception ex)
	{
                }
       return systemUser;
      }



    }
}