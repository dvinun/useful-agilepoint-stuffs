// Function to get the query string from the url.
function GetQueryParameters()
{
var Parameters = GetQueryString(); // built in AgilePoint Helper method
	
SetFieldValue('RequestedBy', Parameters.RequestedBy);
SetFieldValue('CreatedDate', Parameters.CreatedDate);
SetFieldValue('RequestDescription', Parameters.RequestDescription);
SetFieldValue('ReportViewURL', Parameters.ReportViewURL);
SetFieldValue('EffectiveDate', Parameters.EffectiveDate);
SetFieldValue('ThroughDate', Parameters.ThroughDate);
SetFieldValue('ApplicationShortName', Parameters.ApplicationShortName);
SetFieldValue('ArtifactsFolderLocation', Parameters.ArtifactsFolderLocation);
SetFieldValue('ChargeCodeRequestCount', Parameters.ChargeCodeRequestCount);
SetFieldValue('ApplicationName', Parameters.ApplicationName);
SetFieldValue('SourceProcessID', Parameters.SourceProcessID);
SetFieldValue('DisplaySubProductType', Parameters.DisplaySubProductType);
SetFieldValue('TrainingRequired', Parameters.TrainingRequired);
SetFieldValue('DisplayInitiativeType', Parameters.DisplayInitiativeType);
SetFieldValue('DisplayProductType', Parameters.DisplayProductType);
SetFieldValue('ArtifactsFolderName', Parameters.ArtifactsFolderName); 
SetFieldValue('ArtifactsFolderNameSystemComposed', Parameters.ArtifactsFolderNameSystemComposed); 
}

function SetFieldValue(fieldId, fieldValue)
{
eFormHelper.setFieldValue({fieldId: fieldId, value: fieldValue}, function(){});
}
