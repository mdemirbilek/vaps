/// <reference path="~/GeneratedArtifacts/viewModel.js" />

myapp.BrowseMyWorkingHours.created = function (screen) {
    // Write code here.


    msls.promiseOperation(CallGetUserName).then(function PromiseSuccess(PromiseResult) {

        screen.WorkingHoursUserName = PromiseResult;
        //alert(PromiseResult);
    });



};



//// This function will be wrapped in a Promise object
function CallGetUserName(operation) {
    $.ajax({
        type: 'post',
        data: {},
        url: '../GetUserName.ashx',
        success: operation.code(function AjaxSuccess(AjaxResult) {
            operation.complete(AjaxResult);
        })
    });
}