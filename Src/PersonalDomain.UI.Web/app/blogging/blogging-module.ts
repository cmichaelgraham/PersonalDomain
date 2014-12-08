/// <reference path="blogging-controller.ts" />
/// <reference path="blogging-service.ts" />

module PersonalDomain.Blogging {
    export class BloggingModule {
        constructor() {
            angular.module("Blogging", [ "ngAnimate", "ngRoute", "ngSanitize", "ngResource" ])
                   .controller("bloggingController", BloggingController)
                   .service("bloggingService", BloggingService)


                .filter("filtered", () => {
                    var filteredFilter = (input: string) => { return "Filtered"; };
                    return filteredFilter;
                })
                   .config([ "$routeProvider", ($routeProvider: ng.route.IRouteProvider) => {
                        $routeProvider
                            .when("/blog",
                            {
                                controller: "bloggingController",
                                controllerAs: "myController",
                                templateUrl: "app/blogging/blog.html"
                            })
                            .otherwise({
                                redirectTo: "/blog"
                            });
                        } ])
                    .run([
                        "$route", $route => {
                            // Include $route to kick start the router.
                        }
                    ]);
        }

        public start() {
            $(document).ready(() => {
                console.log("booting " + "Blogging");
                angular.bootstrap(document, ["Blogging"]);
            });
        }
    }
}   