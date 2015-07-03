import aureliaRouter = require("aurelia-router");
import BlogService = require('./domain/service');

class Index {
    public IsNextButtonVisible: boolean = false;
    private _pageIndex: number = 1;
    private _pageSize: number = 20;
    public Posts: PersonalDomain.Application.Blogging.Models.PostSummaryDTO[] = [];
    public PostCount: number;

    static inject = [BlogService];
    constructor(private _blogService: BlogService) {

    }

    public activate = (routeParams: any) => {
        return this.LoadPage(this._pageIndex).then((response: PersonalDomain.Application.Blogging.Models.PostIndexDTO) => {
            this.Posts = response.PostSummaries;
            this.PostCount = response.PostSummaryCount;
            this.IsNextButtonVisible = this.GetIsNextButtonVisible();
        }); 
    }

    public determineActivationStrategy = () => {
        return "replace";
    }

    public GetPostUrl: (post: PersonalDomain.Application.Blogging.Models.PostSummaryDTO) => string = (post) => {
        return '#/detail/' + post.Id;
    }

    public GetIsNextButtonVisible: () => boolean = () => {
        return this.Posts.length < this.PostCount;
    }

    public OnNextButtonClick = () => {
        this._pageIndex = this._pageIndex + 1;
        this.LoadPage(this._pageIndex).then((response: PersonalDomain.Application.Blogging.Models.PostIndexDTO) => {
            this.Posts = this.Posts.concat(response.PostSummaries);
            this.PostCount = response.PostSummaryCount;
            this.IsNextButtonVisible = this.GetIsNextButtonVisible();
        });
    }

    private LoadPage: (index: number) => IPromise<PersonalDomain.Application.Blogging.Models.PostIndexDTO> = (index) => {
        return this._blogService.GetPostIndexByPage({ PageId: index, PageSize: this._pageSize });       
    }
}

export = Index;