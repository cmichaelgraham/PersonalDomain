import BlogService = require('./domain/service');

class Detail {
    public PostDetail: PersonalDomain.Application.Blogging.Models.PostDTO;

    static inject = [BlogService];
    constructor(private _blogService: BlogService) {

    }

    public activate = (routeParams: any) => {
        return this._blogService.GetPostDetailById({ Id: routeParams["id"] }).then((response) => {
            this.PostDetail = response;
        });
    }
}

export = Detail; 