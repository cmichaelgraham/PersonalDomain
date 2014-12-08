///// <reference path="../scope/idemoscope.ts" />
///// <reference path="../scope/person.ts" />
//module App.Controllers {
//    "use strict";
//    export class DemoController {

//        static $inject = ["$scope"];

//        constructor(private $scope: Scope.IDemoScope) {
//            if (this.$scope.person === null || this.$scope.person === undefined) {
//                this.$scope.person = new Scope.Person();
//            }
//        }
//        public clear(): void {
//            this.$scope.person.firstName = "";
//            this.$scope.person.lastName = "";
//        }
//    }
//} 