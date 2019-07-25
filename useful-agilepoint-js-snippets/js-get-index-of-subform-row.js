// The requirement is to have some unique id field on each row. I had a textbox containing the randomstring populated by a formula field whenever the text box is empty. This code has some bugs so, this is to just give an idea only of how to get the index of the subform.

function SetDefaultDeliveryWarningDate(dueDateControl)
{
debugger;
 var dueDateStr = $("#"+dueDateControl.id).val();
 
 if( dueDateStr === null || dueDateStr == "" ) return;
 
 var dueDate = new Date(dueDateStr);
 var deliveryWarningDate = new Date(dueDate);
 deliveryWarningDate.setDate(dueDate.getDate() - 5);
 
 //var deliveryWarningDateId = $(dueDateControl).parents(".subFormContentRowChildWrapper").find("[id^='MODeliveryWarningDate']").attr('id');
 var popupRowIdControl = $(dueDateControl).parents(".subFormContentRowChildWrapper").find("[id^='RowID']");
 var popupRandomIdControl = $(dueDateControl).parents(".subFormContentRowChildWrapper").find("[id^='RandomID']");
 var popupRowIdControlVal = $(popupRowIdControl).val();
 var popupRandomIdControlVal = $(popupRandomIdControl).val();
 
 var MM = ('0' + (deliveryWarningDate.getMonth() + 1)).slice(-2);
 var DD =  ('0' + (deliveryWarningDate.getDate())).slice(-2);
 var YYYY = deliveryWarningDate.getFullYear();
 
 var deliveryWarningDateStr_YYYYMMDD = YYYY + '-' + MM + '-' + DD;
 
 // Set the date value to control through jquery  
 //$("#" + deliveryWarningDateId).val(MM + '/' + DD + '/' + YYYY);
 
 // Set the date value to control through eForm Helper Function
 var subformIndex = GetSubformRowIndex(dueDateControl, popupRowIdControlVal, popupRandomIdControlVal);
 
eFormHelper.setFieldValue({fieldId: 'ManufacturingOrders/MODeliveryWarningDate:[' + subformIndex + ']', value: deliveryWarningDateStr_YYYYMMDD}, function(result){});
}

function GetSubformRowIndex(dueDateControl, popupRowIdControlVal, popupRandomIdControlVal)
{
	var subformContentRows = $(dueDateControl).parents(".subFormContentRowChildWrapper").parent().parent().children('.subFormContentRow');
	
	if( subformContentRows == null || subformContentRows.length == 0) return -1;
	for(var index=0; index < subformContentRows.length; index++)
	{
		var rowIdControlVal = $(subformContentRows[index]).find("[id^='RowID']").val();
		var randomIdControlVal = $(subformContentRows[index]).find("[id^='RandomID']").val();
		
		if( rowIdControlVal == popupRowIdControlVal) return index + 1;
	}		
	return -1;
}
