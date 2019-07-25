using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Admin
    {

        public virtual string GetSenderEMailAddress()
        {

            IWFAdminService svc = Common.GetAdminAPI();
            string senderEMailAddress = string.Empty;

            try
            {
                senderEMailAddress = svc.GetSenderEMailAddress();
            }

            catch (Exception ex)
            {

            }
            return senderEMailAddress;

        }



    }
}
