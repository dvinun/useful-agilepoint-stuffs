Generating HTML with AgilePoint Process Data

using System;
using System.Collections;
using System.Data;
using System.Xml;
using System.Net;
using System.IO;
using System.Text;
using System.Linq;
using Ascentn.Workflow.Base;
namespace ManagedCode
{
    public class CSharpCodeSnippet
    {
        // Invoke method is this class's entry point
        public void Invoke(
            WFProcessInstance pi,
            WFAutomaticWorkItem w,
            IWFAPI api,
            NameValue[] parameters)
        {
            //
            // write code here
            // 
            try
            {
                //Get sql query xml from process schema
                string SQLxml = api.GetCustomAttr(pi.WorkObjectID, "/pd:myFields/pd:ResultXML", false).ToString();
                //Load XML string as xml document
                XmlDocument doc = new XmlDocument();
                if (!string.IsNullOrEmpty(SQLxml))
                    doc.LoadXml(SQLxml);
                else
                {
                    api.SetCustomAttr(pi.WorkObjectID, "DoNotOfferTable", "<b>No 'Do Not Offer' Items for the week.</b>");
                    Logger.WriteLine("No SQL Xml in custom attribute");
                    return;
                }

                //Get Process Definition name from process schema attribute
                string procdef = api.GetCustomAttr(pi.WorkObjectID, "/pd:myFields/pd:ProcessDefinitionName", false).ToString();
                //Charge code process initiator
                string processInitiator = api.GetCustomAttr(pi.WorkObjectID, "/pd:myFields/pd:ChargeCodeProcessInitiator", false).ToString();
                //string processInitiator = api.GetCustomAttr(pi.WorkObjectID,"ProcessInitiator",true).ToString();
                //process definnition ID
                string PID = api.GetReleasedPID(procdef);
                //Process Instance ID
                string PIID = UUID.GetID();
                //Create new process instance name
                string PIName = procdef + "_" + PIID;
                //Create new work object id
                string WID = UUID.GetID();
                //Create process instance
                WFEvent processinstance = api.CreateProcInst(PID, PIID, PIName, WID, null, processInitiator, string.Empty, WID, null, true);
                //Check for null value
                Logger.WriteLine("PID - " + PIID);
DateTime EffectiveDate= DateTime.Now;
DateTime ThroughDate = DateTime.Now;
bool bInitDates = false;
                if (processinstance != null)
                {
                    //Loop and check for process instance is created by checking process intance status
                    while (string.Compare(processinstance.Status, "Processed", true) != 0)
                    {
                        //Set a delay of 2 second
                        System.Threading.Thread.Sleep(2000);
                        //Query event for event status
                        processinstance = api.GetEvent(processinstance.EventID);
                        //Logger.WriteLine("trying to get event in while ");
                    }
                    //Get Process XML
                    string processXml = (api.GetCustomAttr(WID, "//", false).ToString());
                    //Load process xml as xml document
                    XmlDocument pdoc = new XmlDocument();
                    pdoc.LoadXml(processXml);
                    //Get namespace for xpath search
                    XmlNamespaceManager nsmgr = new XmlNamespaceManager(pdoc.NameTable);
                    nsmgr.AddNamespace("pd", "http://www.ascentn.com/bpm/XMLSchema");
                    //Get Empty Subform node
                    XmlNode sformNode = pdoc.DocumentElement.SelectSingleNode("pd:BatchRequestTable_SubForm", nsmgr);
                    if (sformNode != null)
                    {
                        //Delete empty subform node
                        pdoc.DocumentElement.RemoveChild(sformNode);
                    }
                    //Get list of subform node from sql xml
                    XmlNodeList subforms = doc.DocumentElement.SelectNodes("pd:BatchRequestTable_SubForm", nsmgr);
                    int Serial = 1;//serial number
                    if (subforms.Count > 0)
                    {
                        string htmlTable = BEGINTABLE();
                        DateTime currentThroughDate = DateTime.Now;
                        DateTime tempThroughDate = DateTime.Now;
                        DateTime tempEffectiveDate = DateTime.Now;
                        //import each node to process xml
                        foreach (XmlNode item in subforms)
                        {
                            XmlNode inode = pdoc.ImportNode(item, true);
                            if (inode != null)
                            {
                                inode.SelectSingleNode("pd:BatchRequestTable/pd:SerialNumber", nsmgr).InnerXml = Serial.ToString();
                                pdoc.DocumentElement.AppendChild(inode);
                                Serial++;
                                // Display the day of the week in table 
                                tempThroughDate = Convert.ToDateTime(inode.SelectSingleNode("pd:BatchRequestTable/pd:ThroughDate", nsmgr).InnerXml);
                                tempEffectiveDate = Convert.ToDateTime(inode.SelectSingleNode("pd:BatchRequestTable/pd:EffectiveDate", nsmgr).InnerXml);
                                if (tempThroughDate != currentThroughDate)
                                {
                                    currentThroughDate = tempThroughDate;
                                    htmlTable = BEGINROW(htmlTable);
                                    htmlTable = ADDCELL(htmlTable, "<b>" + currentThroughDate.ToString("dddd") + "</b>");
                                    htmlTable = ENDROW(htmlTable);
                                }
                                // Construct html table row for email template
                                htmlTable = BEGINROW(htmlTable);
                                htmlTable = ADDCELL(htmlTable, inode.SelectSingleNode("pd:BatchRequestTable/pd:SerialNumber", nsmgr).InnerXml);
                                htmlTable = ADDCELL(htmlTable, inode.SelectSingleNode("pd:BatchRequestTable/pd:ChargeCode", nsmgr).InnerXml);
                                htmlTable = ADDCELL(htmlTable, inode.SelectSingleNode("pd:BatchRequestTable/pd:ChargeCodeDescription", nsmgr).InnerXml);
                                htmlTable = ADDCELL(htmlTable, GetFormattedDate(inode.SelectSingleNode("pd:BatchRequestTable/pd:EffectiveDate", nsmgr).InnerXml));
                                htmlTable = ADDCELL(htmlTable, GetFormattedDate(inode.SelectSingleNode("pd:BatchRequestTable/pd:ThroughDate", nsmgr).InnerXml));
                                htmlTable = ENDROW(htmlTable);
// init dates for adding them in main schema 
// We need to init root level dates with 
// least early date for EffectiveDate & most recent date for ThroughDate
if( bInitDates == false) 
{
ThroughDate = tempThroughDate;
EffectiveDate = tempEffectiveDate;
bInitDates = true;
}
if( tempThroughDate > ThroughDate )
{
ThroughDate = tempThroughDate;
}
if( tempEffectiveDate < EffectiveDate )
{
EffectiveDate = tempEffectiveDate;
}
                            }
                        }
                        htmlTable = ENDTABLE(htmlTable);
                        api.SetCustomAttr(pi.WorkObjectID, "DoNotOfferTable", htmlTable);
                    }
                    else
                    {
                        //No items - Empty
                    }
                    //Save updated schema back to process instnace
                    api.SetCustomAttr(WID, "//", pdoc.CreateXmlDeclaration("1.0", "utf-8", null).OuterXml + pdoc.DocumentElement.OuterXml);
                    // Set User Composed Description
                    string WeekBeginDate = api.GetCustomAttr(pi.WorkObjectID, "WeekBeginDate", false).ToString();
                    string WeekEndDate = api.GetCustomAttr(pi.WorkObjectID, "WeekEndDate", false).ToString();
                    string CommonRequestDescription = "New 'Do Not Offer' Items for the week - " + WeekBeginDate + " to " + WeekEndDate;
string UserComposedName = "DoNotOffer_Ending_"+ThroughDate.ToString("yyyy_MM_dd"); 
                    api.SetCustomAttr(WID, "/pd:Data/pd:UserComposedName", UserComposedName);
                    api.SetCustomAttr(WID, "/pd:Data/pd:CommonRequestDescription", CommonRequestDescription);
                    api.SetCustomAttr(WID, "/pd:Data/pd:EffectiveDate", EffectiveDate.ToString("dd MMM yyyy"));
                    api.SetCustomAttr(WID, "/pd:Data/pd:ThroughDate", ThroughDate.ToString("dd MMM yyyy"));
                }
                else
                {
                    Logger.WriteLine("Process Instance was not created.");
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLine(ex.Message);
            }
        }
string GetFormattedDate(string date)
{
return (string.IsNullOrEmpty(date) == true) ? string.Empty : 
DateTime.Parse(date).ToString("yyyy-MM-dd");
}
        string BEGINTABLE()
        {
            string htmlTable = "<TABLE> <TBODY> <TR>" +
                "<TD class=style8 style=\"BORDER-RIGHT: medium none; FONT-WEIGHT: bold\">Serial No.</TD>" +
                "<TD class=style8 style=\"BORDER-RIGHT: medium none; FONT-WEIGHT: bold\">Charge Code</TD>" +
                "<TD class=style7 style=\"BORDER-RIGHT: medium none; FONT-WEIGHT: bold\">Charge Code Description</TD>" +
                "<TD class=style7 style=\"BORDER-RIGHT: medium none; FONT-WEIGHT: bold\">Effective Date</TD>" +
                "<TD class=style7 style=\"BORDER-RIGHT: medium none; FONT-WEIGHT: bold\">Through Date</TD>" +
                "</TR>";
            return htmlTable;
        }
        string ENDTABLE(string htmlTable)
        {
            htmlTable += "</TBODY></TABLE>";
            return htmlTable;
        }
        string BEGINROW(string htmlTable)
        {
            htmlTable += "<TR>";
            return htmlTable;
        }
        string ADDCELL(string htmlTable, string cellVal)
        {
            htmlTable += "<TD class=style8 style=\"BORDER-RIGHT: medium none; FONT-WEIGHT: normal\">" + cellVal + "</TD>";
            return htmlTable;
        }
        string ENDROW(string htmlTable)
        {
            htmlTable += "</TR>";
            return htmlTable;
        }
    }
}
