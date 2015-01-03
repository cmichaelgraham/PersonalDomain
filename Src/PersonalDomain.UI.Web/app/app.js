var PersonalDomain;
(function (PersonalDomain) {
    (function (Blogging) {
        var BloggingController = (function () {
            function BloggingController($scope, bloggingService) {
                this.$scope = $scope;
                this.bloggingService = bloggingService;
            }
            BloggingController.$inject = ["$scope", "bloggingService"];
            return BloggingController;
        })();
        Blogging.BloggingController = BloggingController;
    })(PersonalDomain.Blogging || (PersonalDomain.Blogging = {}));
    var Blogging = PersonalDomain.Blogging;
})(PersonalDomain || (PersonalDomain = {}));
var PersonalDomain;
(function (PersonalDomain) {
    (function (Blogging) {
        var BloggingService = (function () {
            function BloggingService($http) {
                var _this = this;
                this.$http = $http;
                this.GetPostById = function (id) {
                    return _this.$http({
                        method: "post",
                        url: "/api/GetPost",
                        data: { Id: id }
                    }).then(function (data) {
                        return data;
                    });
                };
                this.SavePost = function (data) {
                    return _this.$http({
                        method: "post",
                        url: "/api/SavePost",
                        data: undefined
                    }).then(function (response) {
                        return response;
                    });
                };
            }
            return BloggingService;
        })();
        Blogging.BloggingService = BloggingService;
    })(PersonalDomain.Blogging || (PersonalDomain.Blogging = {}));
    var Blogging = PersonalDomain.Blogging;
})(PersonalDomain || (PersonalDomain = {}));
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
/// <reference path="blogging/blogging-module.ts" />
new PersonalDomain.Blogging.BloggingModule().start();
//# sourceMappingURL=app.js.map
