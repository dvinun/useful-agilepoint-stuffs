using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;

namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {
        public static string GetProcDefGraphics(string pID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            //process definition ID or process instance ID
            string procesID = pID;// for example,
            string procDefGraphicsXML = string.Empty;

            try
            {
                //returns an image of a process definition as string.
                procDefGraphicsXML = svc.GetProcDefGraphics(procesID);
                GraphicImage g = new GraphicImage();
                g.FromXml(procDefGraphicsXML);
                byte[] images = g.Image; // process image
                NamedRectangle[] shapes = g.Shapes;

            }

            catch (Exception ex)
            {
                Console.WriteLine(ShUtil.GetSoapMessage(ex));
            }

            return procDefGraphicsXML;
        }

    }
}
