/// <reference path="~/GeneratedArtifacts/viewModel.js" />

myapp.ViewplActivity.Details_postRender = function (element, contentItem) {
    // Write code here.
    var name = contentItem.screen.plActivity.details.getModel()[':@SummaryProperty'].property.name;
    contentItem.dataBind("screen.plActivity." + name, function (value) {
        contentItem.screen.details.displayName = value;
    });
}

