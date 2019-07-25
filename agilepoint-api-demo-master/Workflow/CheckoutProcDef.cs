using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;

namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {
        public static string CheckoutProcDef(string pID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string processDefinitionXML = string.Empty;
            try
            {
                string processDefinitionID = pID; // process definition to be checked out
                processDefinitionXML = svc.CheckoutProcDef(processDefinitionID);

            }

            catch (Exception ex)
            {
                Console.WriteLine("Failed! " + ShUtil.GetSoapMessage(ex));
            }

            return processDefinitionXML;
        }

        public static void UnCheckOutProcDef(string pID)
        {
            try
            {
                IWFWorkflowService svc = Common.GetWorkFlowAPI();
                string processTemplateID = pID;
                svc.UncheckoutProcDef(processTemplateID);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Message:\n" + ShUtil.GetSoapMessage(ex));
            }
        }

        public static string CheckinProcDef(string xml, string ReleaseValue)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string procDefID = string.Empty;
            string xmlval = xml;// Process definition XML as string
            WFProcessDefinition pd = new WFProcessDefinition();
            GraphicImage g = new GraphicImage();
            ProcDefXmlParser parser = new ProcDefXmlParser(new
            WFDefaultActivityInstantiator(), pd, g);
            parser.Parse(xml);

            if (ReleaseValue == "Release Now")
            {
                pd.ReleaseDate = DateTime.Now;
                pd.Version = "1.0"; // new version
                procDefID = svc.CheckinProcDef(xml);
                svc.ReleaseProcDef(procDefID);
            }

            else if (ReleaseValue == "Release On")
            {
                DateTime d = DateTime.Now;
                d.AddMonths(1);
                pd.ReleaseDate = d;// a specific date in the future
                pd.Version = "1.0"; // new version
                procDefID = svc.CheckinProcDef(xml);
                svc.ReleaseProcDef(procDefID);
            }

            else // not release process definition
            {
                pd.ReleaseDate = Constants.NullDate;
                procDefID = svc.CheckinProcDef(xml);
            }
            return procDefID;
        }

    }
}
