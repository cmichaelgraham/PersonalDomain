﻿module PersonalDomain.Blog.Index {
    export class BlogIndexController implements IBlogIndexScope {
        private _pageNumber: number;
        private _pageSize: number = 10;

        public PostSummaries: PersonalDomain.Application.Blogging.Models.PostSummaryDTO[];
        public PostSummaryCount: number;

        static $inject = ['$routeParams', 'blogService'];
        constructor(private $routeParams: any, private blogService: PersonalDomain.Application.Operations.BlogService) {
            var vm = this;

            this._pageNumber = (!!$routeParams.pageNumber) ? $routeParams.pageNumber : 1;
            this.LoadPostIndexByPage();
        }

        public IsNextButtonVisible: () => boolean = () => {
            return (this._pageNumber * this._pageSize) < this.PostSummaryCount;
        }

        public LoadPostIndexByPage = () => {
            var request: PersonalDomain.Application.Operations.Request.GetPostIndexByPageRequest = {
                PageId: this._pageNumber,
                PageSize: this._pageSize
            }

            this.blogService.GetPostIndexByPage(request).then((response: ng.IHttpPromiseCallbackArg<PersonalDomain.Application.Blogging.Models.PostIndexDTO>) => {
                this.PostSummaries = response.data.PostSummaries;
                this.PostSummaryCount = response.data.PostSummaryCount;
            });
        }

        public Next = () => {
            this._pageNumber++;
            this.LoadPostIndexByPage();
        }
    }
} 