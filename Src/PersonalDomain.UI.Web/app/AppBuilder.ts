///// <reference path="controllers/democontroller.ts" />
///// <reference path="scope/idemoscope.ts" />
//module App {
//    "use strict";
//    export class AppBuilder {

//        app: ng.IModule;

//        constructor(name: string) {
//            this.app = angular.module(name, [
//            // Angular modules 
//                "ngAnimate",
//                "ngRoute",
//                "ngSanitize",
//                "ngResource"
//            ]);

//            this.app.controller("personController", [
//                "$scope", ($scope : Scope.IDemoScope)
//                    => new App.Controllers.DemoController($scope)
//            ]);
            
//            this.app.config([
//                "$routeProvider",
//                ($routeProvider: ng.route.IRouteProvider) => { 
//                    $routeProvider
//                        .when("/person",
//                        {
//                            controller: "personController",
//                            controllerAs: "myController",
//                            templateUrl: "app/views/personView.html"
//                        })
//                        .otherwise({
//                            redirectTo: "/person"
//                        });
//                }
//            ]);

//            this.app.run([
//                "$route", $route => {
//                    // Include $route to kick start the router.
//                }
//            ]);

//        }


//        public start() {
//            $(document).ready(() =>
//            {
//                console.log("booting " + this.app.name);
//                angular.bootstrap(document, [this.app.name]);
//            });
//        }
//    }
//}
