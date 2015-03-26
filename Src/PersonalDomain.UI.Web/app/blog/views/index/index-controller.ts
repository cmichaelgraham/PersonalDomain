module PersonalDomain.Blog.Index {
    export class BlogIndexController extends PersonalDomain.Blog.BlogController {
        private pageNumber: number = 0;

        static $inject = ["$scope", "$routeParams", "blogService"];
        constructor(public $scope: IBlogIndexScope, private $routeParams: any, public blogService: IBlogService) {
            super($scope, blogService);

            if (!!$routeParams.pageNumber) {
                this.pageNumber = $routeParams.pageNumber;                
            }

            this.LoadPostSummariesByPage(this.pageNumber);
        }

        private LoadPostSummariesByPage = (pageIndex: number) => {
            this.blogService.GetPostSummariesByPage(pageIndex).then((response: ng.IHttpPromiseCallbackArg<any[]>) => {
                this.$scope.postSummaries = response.data;
            });
        }

        public OnNextButtonClick: () => {
            
        }
    }
} 