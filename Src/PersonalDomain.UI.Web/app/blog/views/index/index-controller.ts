module PersonalDomain.Blog.Index {
    export class BlogIndexController implements IBlogIndexScope {
        public PostSummaries: any[];
        private _pageNumber: number;

        static $inject = ['$routeParams', 'blogService'];
        constructor(private $routeParams: any, private blogService: PersonalDomain.Application.Operations.BlogService) {
            var vm = this;

            this._pageNumber = (!!$routeParams.pageNumber) ? $routeParams.pageNumber : 0;
            this.LoadPostSummariesByPage(this._pageNumber);
        }

        public LoadPostSummariesByPage = (pageIndex: number) => {
            //this.blogService.GetPostSummariesByPage(pageIndex).then((response: ng.IHttpPromiseCallbackArg<any[]>) => {
            //    this.PostSummaries = response.data;
            //});
        }

        public Next = () => {
        }
    }
} 