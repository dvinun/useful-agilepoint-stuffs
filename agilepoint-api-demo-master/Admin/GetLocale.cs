using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;


namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {

     public static string GetLocale()
{
      IWFAdminService svc = Common.GetAdminAPI();
      string locale = string.Empty;
      try
	{
    locale = svc.GetLocale();
             }
      catch (Exception ex)
	{
                }
return locale;

}


    }
}
