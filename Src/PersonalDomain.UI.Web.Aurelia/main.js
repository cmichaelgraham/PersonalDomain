require.config({
    paths: {
        aurelia: "../scripts/aurelia",
        views: "../app",
    }
});

require(["aurelia/aurelia-bundle-latest"], function (aurelia) { });
