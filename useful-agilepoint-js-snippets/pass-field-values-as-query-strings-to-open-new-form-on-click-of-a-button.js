function onClickAlert(){
$('div.containerAlertProcessIcon').click(function(){
debugger;

var RequestedBy = $('#RequestedBy').val();
var CreatedDate = $('#CreatedDate').val();
var RequestDescription = $('#RequestDescription').val();
var ReportViewURL = $('#ReportViewURL').val();
var EffectiveDate = $('#EffectiveDate').val();
var ThroughDate = $('#ThroughDate').val();
var ApplicationShortName = $('#ApplicationShortName').val();
var ArtifactsFolderLocation = $('#ArtifactsFolderLocation').val();
var ChargeCodeRequestCount = $('#ChargeCodeRequestCount').val();
var ApplicationName = $('#ApplicationName').val();
var SourceProcessID = $('#ChargeCodeRequestProcessId').val();
var DisplaySubProductType = $('#DisplaySubProductType').val();
var TrainingRequired = $('#DsiplayTrainingRequired').val();
var DisplayInitiativeType = $('#DisplayInitiativeType').val();
var DisplayProductType = $('#DisplayProductType').val();
var ArtifactsFolderName = $('#ArtifactsFolderName').val();
var ArtifactsFolderNameSystemComposed = $('#ArtifactsFolderNameSystemComposed').val();
var AlertProcessUrl = $('#AlertProcessUrl').val();

AlertProcessUrl = AlertProcessUrl + '&' + 
'RequestedBy=' + RequestedBy + '&' +
'CreatedDate=' + CreatedDate + '&' + 
'RequestDescription=' + RequestDescription + '&' +
'ReportViewURL=' + ReportViewURL + '&' +
'EffectiveDate=' + EffectiveDate + '&' +
'ThroughDate=' + ThroughDate + '&' +
'ApplicationShortName=' + ApplicationShortName + '&' +
'ArtifactsFolderLocation=' + ArtifactsFolderLocation + '&' +
'ChargeCodeRequestCount=' + ChargeCodeRequestCount + '&' +
'ApplicationName=' + ApplicationName + '&' +
'SourceProcessID=' + SourceProcessID + '&' +
'DisplaySubProductType=' + DisplaySubProductType + '&' +
'TrainingRequired=' + TrainingRequired + '&' +
'DisplayInitiativeType=' + DisplayInitiativeType + '&' +
'DisplayProductType=' + DisplayProductType + '&' +
'ArtifactsFolderName=' + ArtifactsFolderName + '&' +
'ArtifactsFolderNameSystemComposed=' + ArtifactsFolderNameSystemComposed;


window.open(AlertProcessUrl);

});
}
