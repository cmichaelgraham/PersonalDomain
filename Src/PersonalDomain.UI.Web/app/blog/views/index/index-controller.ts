import BlogService = require('blog/domain/service');
import Header = require('layout/factories/header');

class BlogIndexController {
    private _pageNumber: number;
    private _pageSize: number = 10;

    public PostSummaries: PersonalDomain.Application.Blogging.Models.PostSummaryDTO[];
    public PostSummaryCount: number;

    static $inject = ['$routeParams', 'header', 'blogService'];
    constructor(private $routeParams: any, private header: Header, private blogService: BlogService) {
        var vm = this;

        this._pageNumber = (!!$routeParams.pageNumber) ? $routeParams.pageNumber : 1;
        this.SetHeaderInfo();
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

        this.blogService.GetPostIndexByPage(request).then((postIndex: PersonalDomain.Application.Blogging.Models.PostIndexDTO) => {
            this.PostSummaries = postIndex.PostSummaries;
            this.PostSummaryCount = postIndex.PostSummaryCount;
        });
    }

    public Next = () => {
        this._pageNumber++;
        this.LoadPostIndexByPage();
    }

    private SetHeaderInfo = () => {
        this.header.Title = "James Chadwick";
        this.header.SubTitle = "Full-Stack Developer";
        this.header.ImageUrl = "../../../Content/images/home-bg.jpg";
    }
}

export = BlogIndexController;