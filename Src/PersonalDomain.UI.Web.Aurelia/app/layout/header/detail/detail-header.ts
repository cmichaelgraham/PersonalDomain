import LayoutHeaderViewModel = require('../layout-header');
import BlogService = require('app/blog/domain/service');

class DetailHeader extends LayoutHeaderViewModel {
    static inject = [BlogService];

    constructor(private _blogService: BlogService) {
        super();
    }

    public activate = (params: any) => {
        return this._blogService.GetPostDetailById({ Id: params["id"] }).then((response: PersonalDomain.Application.Blogging.Models.PostDTO) => {
            this.Title = response.Title;
            this.SubTitle = response.Subtitle;
        });
    }
}

export = DetailHeader;
