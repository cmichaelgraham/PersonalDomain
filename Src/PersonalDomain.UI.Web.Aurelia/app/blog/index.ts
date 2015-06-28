import BlogService = require('./domain/service');

class Index {
    public Posts: PersonalDomain.Application.Blogging.Models.PostSummaryDTO[] = [];

    static inject = [BlogService];
    constructor(private _blogService: BlogService) {

    }

    public activate = (routeParams: any) =>  {
        return this._blogService.GetPostIndexByPage({ PageId: routeParams["id"], PageSize: 20 }).then((response) => {
            this.Posts = response.PostSummaries;
        });
    }

    public GetPostUrl: (post: PersonalDomain.Application.Blogging.Models.PostSummaryDTO) => string = (post) => {
        return '#/detail/' + post.Id;
    }
}

export = Index;