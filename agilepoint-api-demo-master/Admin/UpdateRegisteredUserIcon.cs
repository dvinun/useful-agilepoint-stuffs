using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {
     public static void UpdateRegisteredUserIcon(string userName, byte[] userIcon)
     {
      IWFAdminService svc = Common.GetAdminAPI();
                  try
            {
                svc.UpdateRegisteredUserIcon(userName, userIcon);
             }
            catch (Exception ex)
            {
            }
     }



    }
}
