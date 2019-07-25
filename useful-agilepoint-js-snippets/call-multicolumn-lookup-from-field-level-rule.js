function refresh_ticket_data(ctrl){
    console.log('refresh_ticket_data. Ticket Id is empty. ' + $(ctrl).attr('id') )
    trigger_mc_lookup($(ctrl).parents(".subFormContentRowChildWrapper").find("[id^='ZenDeskTicketInfoLookup']").attr('id'))
    trigger_mc_lookup($(ctrl).parents(".subFormContentRowChildWrapper").find("[id^='ZenDeskTicketCommentRefresh']").attr('id'))
}

function trigger_mc_lookup(fieldId) {
    console.log('trigger_mc_lookup: ' + fieldId)
    var options = {"fieldId": fieldId, lookupType: eFormHelper.constants.lookuptype.multicolumn};
    eFormHelper.triggerAutoLookup(options, function(myResult) {
        if (myResult.isSuccess) {
            console.log('Successfully refreshed ' + fieldId)
        } else {
            console.log('trigger_mc_lookup error:')
            console.log(myResult)
        }
    });
}
