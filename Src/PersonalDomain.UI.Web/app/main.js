require.config({
    paths: {
        angular: '../Scripts/angular/angular',
        jquery: '../Scripts/jquery/jquery-2.1.1',
        domReady: '../Scripts/domReady/domReady'
    },
    shim: {
        angular: { deps: ['jquery'], exports: 'angular' }
    }
});

require(['angular', 'blog/blog-module', 'domReady'], function(angular, blogModule, domReady) {
    domReady(function () {
        var bloggingModule = new blogModule();
        angular.bootstrap(document, ['blog']);
    });
});