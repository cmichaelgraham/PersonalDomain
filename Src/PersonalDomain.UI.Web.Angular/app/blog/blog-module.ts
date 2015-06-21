//Controllers
import LayoutController = require('layout/views/layout-controller');
import BlogAboutController = require('blog/views/about/about-controller');
import BlogContactController = require('blog/views/contact/contact-controller');
import BlogDetailController = require('blog/views/detail/detail-controller');
import BlogEditController = require('blog/views/edit/edit-controller');
import BlogIndexController = require('blog/views/index/index-controller');

//Directives
import PostDetailDirective = require('blog/directives/ng-post-detail/post-detail');
import PostSummaryDirective = require('blog/directives/ng-post-summary/post-summary');

//Services
import BlogService = require('blog/domain/service');

//Factories
import Header = require('layout/factories/header')

class BlogModule {
    constructor() {
        angular.module('blog', ['ngAnimate', 'ngRoute', 'ngSanitize', 'ngResource'])
            .controller("LayoutController", LayoutController)
            .controller('AboutController', BlogAboutController)
            .controller('ContactController', BlogContactController)
            .controller('DetailController', BlogDetailController)
            .controller('EditController', BlogEditController)
            .controller('IndexController', BlogIndexController)
            .directive('postDetail', () => { return new PostDetailDirective(); })
            .directive('postSummary', () => { return new PostSummaryDirective(); })
            .service('blogService', BlogService)
            .factory('header', () => { return new Header(); })
            .config(['$routeProvider', ($routeProvider: ng.route.IRouteProvider) => {
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
                    .when('/edit/:postId?', {
                        controller: 'EditController',
                        controllerAs: 'vm',
                        templateUrl: '/app/blog/views/edit/edit.html'
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
            .run(['$route', $route => { }]);
    }
}

export = BlogModule;