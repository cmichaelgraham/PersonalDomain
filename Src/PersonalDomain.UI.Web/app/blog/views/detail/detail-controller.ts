module PersonalDomain.Blog.Detail {
    export class BlogDetailController extends PersonalDomain.Blog.BlogController {

        static $inject = ["$scope", "$routeParams", "blogService"];
        constructor(public $scope: IBlogDetailScope, private $routeParams: any, public blogService: IBlogService) {
            super($scope, blogService);

            this.LoadPostById($routeParams.postId);
        }

        private LoadPostById = (postId: number) => {
            this.blogService.GetPost(postId).then((response: ng.IHttpPromiseCallbackArg<any>) => {
                this.$scope.post = response.data;
            });
        }
    }
} 