/// <reference path="~/GeneratedArtifacts/viewModel.js" />

myapp.ViewsylCourse.Details_postRender = function (element, contentItem) {
    // Write code here.
    var name = contentItem.screen.sylCourse.details.getModel()[':@SummaryProperty'].property.name;
    contentItem.dataBind("screen.sylCourse." + name, function (value) {
        contentItem.screen.details.displayName = value;
    });
}

