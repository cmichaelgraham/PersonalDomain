module PersonalDomain.Blog {
    export class BlogModule {
        constructor() {
            angular.module("Blog", [ "ngAnimate", "ngRoute", "ngSanitize", "ngResource" ])
                   .controller("indexController", PersonalDomain.Blog.Index.BlogIndexController)
                   .directive("postSummary", () => { return new PersonalDomain.Blog.PostSummaryDirective(); })
                   .service("blogService", BlogService)
                   .config([ "$routeProvider", ($routeProvider: ng.route.IRouteProvider) => {
                        $routeProvider
                            .when("/",
                            {
                                controller: "indexController",
                                controllerAs: "myController",
                                templateUrl: "/app/blog/views/index/index.html"
                            })
                            .otherwise({
                                redirectTo: "/"
                            });
                        } ])
                    .run([ "$route", $route => { } ]);
        }

        public start() {
            $(document).ready(() => {
                console.log("booting " + "Blog");
                angular.bootstrap(document, ["Blog"]);
            });
        }
    }
}   