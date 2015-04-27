﻿module PersonalDomain.Blog {
    export class BlogModule {
        constructor() {
            angular.module('Blog', [ 'ngAnimate', 'ngRoute', 'ngSanitize', 'ngResource' ])
                   .controller('indexController', PersonalDomain.Blog.Index.BlogIndexController)
                   .controller('detailController', PersonalDomain.Blog.Detail.BlogDetailController)
                   .directive('postDetail', () => { return new PersonalDomain.Blog.PostDetailDirective(); })
                   .directive('postSummary', () => { return new PersonalDomain.Blog.PostSummaryDirective(); })
                   .service('blogService', PersonalDomain.Application.Operations.BlogService)
                   .config([ '$routeProvider', ($routeProvider: ng.route.IRouteProvider) => {
                        $routeProvider
                            .when('/index/:pageNumber?',
                            {
                                controller: 'indexController',
                                controllerAs: 'vm',
                                templateUrl: '/app/blog/views/index/index.html'
                            })
                            .when('/detail/:postId',
                            {
                                controller: 'detailController',
                                controllerAs: 'vm',
                                templateUrl: '/app/blog/views/detail/detail.html'
                            })
                            .otherwise({
                                redirectTo: '/index'
                            });
                        } ])
                    .run([ '$route', $route => { } ]);
        }

        public start() {
            $(document).ready(() => {
                console.log('booting ' + 'Blog');
                angular.bootstrap(document, ['Blog']);
            });
        }
    }
}   