/// <reference path="blogging-controller.ts" />
/// <reference path="blogging-service.ts" />

module PersonalDomain.Blogging {
    export class BloggingModule {
        constructor() {
            angular.module("Blogging", [ "ngAnimate", "ngRoute", "ngSanitize", "ngResource" ])
                   .controller("bloggingController", BloggingController)
                   .service("bloggingService", BloggingService)
                   .config([ "$routeProvider", ($routeProvider: ng.route.IRouteProvider) => {
                        $routeProvider
                            .when("/",
                            {
                                controller: "bloggingController",
                                controllerAs: "myController",
                                templateUrl: "app/blogging/blog.html"
                            })
                            .otherwise({
                                redirectTo: "/"
                            });
                        } ])
                    .run([ "$route", $route => { } ]);
        }

        public start() {
            $(document).ready(() => {
                console.log("booting " + "Blogging");
                angular.bootstrap(document, ["Blogging"]);
            });
        }
    }
}   