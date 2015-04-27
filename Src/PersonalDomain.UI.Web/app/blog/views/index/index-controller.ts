module PersonalDomain.Blog.Index {
    export class BlogIndexController implements IBlogIndexScope {
        public PostSummaries: PersonalDomain.Application.Blogging.Models.PostSummaryDTO[];
        private _pageNumber: number;

        static $inject = ['$routeParams', 'blogService'];
        constructor(private $routeParams: any, private blogService: PersonalDomain.Application.Operations.BlogService) {
            var vm = this;

            this._pageNumber = (!!$routeParams.pageNumber) ? $routeParams.pageNumber : 0;
            this.LoadPostSummariesByPage(this._pageNumber);
        }

        public LoadPostSummariesByPage = (pageIndex: number) => {
            this.blogService.GetPostSummariesByPage({ Id: pageIndex }).then((response: ng.IHttpPromiseCallbackArg<PersonalDomain.Application.Blogging.Models.PostSummaryDTO[]>) => {
                this.PostSummaries = response.data;
            });
        }

        public Next = () => {
        }
    }
} 