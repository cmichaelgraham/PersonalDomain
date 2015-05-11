module PersonalDomain.Blog {
    export class BlogModule {
        constructor() {
            angular.module('blog', ['ngAnimate', 'ngRoute', 'ngSanitize', 'ngResource'])
                   .controller("LayoutController",PersonalDomain.Application.Layout.LayoutController)
                   .controller('AboutController', PersonalDomain.Blog.About.BlogAboutController)
                   .controller('ContactController', PersonalDomain.Blog.About.BlogContactController)
                   .controller('IndexController', PersonalDomain.Blog.Index.BlogIndexController)
                   .controller('DetailController', PersonalDomain.Blog.Detail.BlogDetailController)
                   .directive('postDetail', () => { return new PersonalDomain.Blog.PostDetailDirective(); })
                   .directive('postSummary', () => { return new PersonalDomain.Blog.PostSummaryDirective(); })
                   .service('blogService', PersonalDomain.Application.Operations.BlogService)
                   .factory('header', () => { return new PersonalDomain.Application.Layout.Factories.Header(); })
                   .config([ '$routeProvider', ($routeProvider: ng.route.IRouteProvider) => {
                       $routeProvider
                           .when('/about',
                           {
                               controller: 'AboutController',
                               controllerAs: 'vm',
                               templateUrl: '/app/blog/views/about/about.html'                                   
                           })
                           .when('/contact',
                           {
                               controller: 'ContactController',
                               controllerAs: 'vm',
                               templateUrl: '/app/blog/views/contact/contact.html'
                           })
                           .when('/detail/:postId',
                           {
                               controller: 'DetailController',
                               controllerAs: 'vm',
                               templateUrl: '/app/blog/views/detail/detail.html'
                           })
                           .when('/index/:pageNumber?',
                           {
                               controller: 'IndexController',
                               controllerAs: 'vm',
                               templateUrl: '/app/blog/views/index/index.html'
                           })
                           .otherwise({
                               redirectTo: '/index'
                           });
                        }])
                    .run([ '$route' , $route => { } ]);
        }

        public start() {
            $(document).ready(() => {
                console.log('booting ' + 'blog');
                angular.bootstrap(document, ['blog']);
            });
        }
    }
}   