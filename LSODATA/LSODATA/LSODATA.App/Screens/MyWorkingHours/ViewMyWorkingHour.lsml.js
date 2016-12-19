/// <reference path="~/GeneratedArtifacts/viewModel.js" />

myapp.ViewMyWorkingHour.Details_postRender = function (element, contentItem) {
    // Write code here.
    var name = contentItem.screen.WorkingHours.details.getModel()[':@SummaryProperty'].property.name;
    contentItem.dataBind("screen.WorkingHours." + name, function (value) {
        contentItem.screen.details.displayName = value;
    });
}


myapp.ViewMyWorkingHour.TotalHours_render = function (element, contentItem) {
    var tt = $("<span>" + contentItem.data.TotalHours + ":" + contentItem.data.TotalMinutes + "</span>");
    tt.appendTo($(element));
};
myapp.ViewMyWorkingHour.HourDiff_render = function (element, contentItem) {
    var td = $("<span>" + contentItem.data.HourDiff + ":" + contentItem.data.MinuteDiff + "</span>");
    td.appendTo($(element));
};
myapp.ViewMyWorkingHour.AcceptedOTeHrs_render = function (element, contentItem) {
    var ot = $("<span>" + contentItem.data.AcceptedOTeHrs + ":" + contentItem.data.AcceptedOTMin + "</span>");
    ot.appendTo($(element));
};
myapp.ViewMyWorkingHour.RecYear_render = function (element, contentItem) {
    var wp = $("<span>" + contentItem.data.RecYear + ", " + contentItem.data.RecMonth + "</span>");
    wp.appendTo($(element));
};