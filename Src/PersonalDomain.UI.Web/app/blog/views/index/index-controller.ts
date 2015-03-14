module PersonalDomain.Blog.Index {
    export class BlogIndexController extends PersonalDomain.Blog.BlogController {

        static $inject = ["$scope", "blogService"];

        constructor(public $scope: IBlogIndexScope, public bloggingService: IBlogService) {
            super($scope, bloggingService);

            bloggingService.GetPostSummariesByPage(0).then((response: any[]) => {
                $scope.postSummaries = response.data;
                debugger;
            });
        }
    }
} 