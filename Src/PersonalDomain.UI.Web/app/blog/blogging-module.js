/// <reference path="blogging-controller.ts" />
/// <reference path="blogging-service.ts" />
var PersonalDomain;
(function (PersonalDomain) {
    (function (Blogging) {
        var BloggingModule = (function () {
            function BloggingModule() {
                angular.module("Blogging", ["ngAnimate", "ngRoute", "ngSanitize", "ngResource"]).controller("bloggingController", Blogging.BloggingController).service("bloggingService", Blogging.BloggingService).config([
                    "$routeProvider", function ($routeProvider) {
                        $routeProvider.when("/", {
                            controller: "bloggingController",
                            controllerAs: "myController",
                            templateUrl: "app/blogging/blog.html"
                        }).otherwise({
                            redirectTo: "/"
                        });
                    }]).run(["$route", function ($route) {
                    }]);
            }
            BloggingModule.prototype.start = function () {
                $(document).ready(function () {
                    console.log("booting " + "Blogging");
                    angular.bootstrap(document, ["Blogging"]);
                });
            };
            return BloggingModule;
        })();
        Blogging.BloggingModule = BloggingModule;
    })(PersonalDomain.Blogging || (PersonalDomain.Blogging = {}));
    var Blogging = PersonalDomain.Blogging;
})(PersonalDomain || (PersonalDomain = {}));
//# sourceMappingURL=blogging-module.js.map
