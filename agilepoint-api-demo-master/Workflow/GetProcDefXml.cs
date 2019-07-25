using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;


//Process Definition Methods 

namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

             public static string GetProcDefXml(string pID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            //process definition ID for a process.
            string processDefinitionID = pID;// for example "42544811EC2D4FC18E6BA15CC9FE28DF";
            string procDefXML = string.Empty;
            try
            {
                //Returns process definition in XML format.
                procDefXML = svc.GetProcDefXml(processDefinitionID);
            }

            catch (Exception ex)
            {
                //Console.WriteLine(ShUtil.GetSoapMessage(ex));
            }
            return procDefXML;
        }




    }
}