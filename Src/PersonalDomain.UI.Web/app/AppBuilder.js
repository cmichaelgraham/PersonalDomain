/// <reference path="controllers/democontroller.ts" />
/// <reference path="scope/idemoscope.ts" />
var App;
(function (App) {
    "use strict";
    var AppBuilder = (function () {
        function AppBuilder(name) {
            this.app = angular.module(name, [
                "ngAnimate",
                "ngRoute",
                "ngSanitize",
                "ngResource"
            ]);

            this.app.controller("personController", [
                "$scope", function ($scope) {
                    return new App.Controllers.DemoController($scope);
                }
            ]);

            this.app.config([
                "$routeProvider",
                function ($routeProvider) {
                    $routeProvider.when("/person", {
                        controller: "personController",
                        controllerAs: "myController",
                        templateUrl: "app/views/personView.html"
                    }).otherwise({
                        redirectTo: "/person"
                    });
                }
            ]);

            this.app.run([
                "$route", function ($route) {
                    // Include $route to kick start the router.
                }
            ]);
        }
        AppBuilder.prototype.start = function () {
            var _this = this;
            $(document).ready(function () {
                console.log("booting " + _this.app.name);
                angular.bootstrap(document, [_this.app.name]);
            });
        };
        return AppBuilder;
    })();
    App.AppBuilder = AppBuilder;
})(App || (App = {}));
//# sourceMappingURL=AppBuilder.js.map
