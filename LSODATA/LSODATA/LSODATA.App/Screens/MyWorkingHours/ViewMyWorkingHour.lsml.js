/// <reference path="~/GeneratedArtifacts/viewModel.js" />

myapp.ViewMyWorkingHour.Details_postRender = function (element, contentItem) {
    // Write code here.
    var name = contentItem.screen.WorkingHours.details.getModel()[':@SummaryProperty'].property.name;
    contentItem.dataBind("screen.WorkingHours." + name, function (value) {
        contentItem.screen.details.displayName = value;
    });
}

