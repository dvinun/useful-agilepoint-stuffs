using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {
        public static string QueryDatabase(string sql)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string xml = string.Empty;
            try
            {
                // calling the QueryDatabase webmethod and passing the sql query as the argument.
                xml = svc.QueryDatabase(sql);

            }


            catch (Exception ex)
            {

            }
            return xml;
        }



        public static string[] QueryDatabaseEx(string sql)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string[] xmls = null;
            try
            {
                // calling the QueryDatabase webmethod and passing the sql query as the argument.
                xmls = svc.QueryDatabaseEx(sql);
            }

            catch (Exception ex)
            {
            }
            return xmls;
        }



    }
}
