var App;
(function (App) {
    /// <reference path="../scope/idemoscope.ts" />
    /// <reference path="../scope/person.ts" />
    (function (Controllers) {
        "use strict";
        var DemoController = (function () {
            function DemoController($scope) {
                this.$scope = $scope;
                if (this.$scope.person === null || this.$scope.person === undefined) {
                    this.$scope.person = new App.Scope.Person();
                }
            }
            DemoController.prototype.clear = function () {
                this.$scope.person.firstName = "";
                this.$scope.person.lastName = "";
            };
            DemoController.$inject = ["$scope"];
            return DemoController;
        })();
        Controllers.DemoController = DemoController;
    })(App.Controllers || (App.Controllers = {}));
    var Controllers = App.Controllers;
})(App || (App = {}));
//# sourceMappingURL=DemoController.js.map
