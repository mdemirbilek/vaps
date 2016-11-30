/// <reference path="~/GeneratedArtifacts/viewModel.js" />

myapp.ViewerpFaculty.Details_postRender = function (element, contentItem) {
    // Write code here.
    var name = contentItem.screen.erpFaculty.details.getModel()[':@SummaryProperty'].property.name;
    contentItem.dataBind("screen.erpFaculty." + name, function (value) {
        contentItem.screen.details.displayName = value;
    });
}

