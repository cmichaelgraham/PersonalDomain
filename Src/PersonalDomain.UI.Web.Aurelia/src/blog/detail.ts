import {BlogService} from './domain/service';

export class Detail {
    public PostDetail: PersonalDomain.Application.Blogging.Models.PostDTO;

    static inject = [BlogService];
    constructor(private _blogService: BlogService) {

    }

    public activate = (params: any) => {
        return this._blogService.GetPostDetailBySlug({ Slug: params["slug"] }).then((response) => {
            this.PostDetail = response;
        });
    }
} 