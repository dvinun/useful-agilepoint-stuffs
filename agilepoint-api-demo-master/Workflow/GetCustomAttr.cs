using System;
using System.Collections.Generic;
using System.Text;
using Ascentn.Workflow.Base;



namespace AgilePointAPICodeSampleProject
{
    public partial class Workflow
    {

             public static object GetCustomAttr(string customID, string name)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            Object obj = null;
            try
            {
                obj = svc.GetCustomAttr(customID, name);
            }

            catch (Exception ex)
            { }
            return obj;
        }

        public static string GetCustomAttrs(string WorkObjID)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            string xml = null;
            try
            {
                xml = svc.GetCustomAttrs(WorkObjID);
                //WFCustomAttributes attrs = new WFCustomAttributes();
                //attrs.AttrXml = xml; // de-serialize xml
                //string[] attributeNames = attrs.GetNames();// get attribute names
                //Object value = attrs["MyAttributeName"]; // retrieve attribute value
            }
            catch (Exception ex)
            { }
            return xml;
        }

        public static KeyValue[] GetCustomAttrsEx(string[] customIDs)
        {
            IWFWorkflowService svc = Common.GetWorkFlowAPI();
            KeyValue[] keyValues = null;
            try
            {
                keyValues = svc.GetCustomAttrsEx(customIDs);
            }
            catch (Exception ex)
            { }

            return keyValues;
        }




    }
}
