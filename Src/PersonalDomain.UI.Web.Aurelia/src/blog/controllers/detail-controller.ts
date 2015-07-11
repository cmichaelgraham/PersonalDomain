import {BlogService} from 'blog/services/blog-service'
import {Detail} from 'blog/views/detail'

export class DetailController {
	public DetailViewModel: Detail = undefined;
	
	static inject = [BlogService];
    constructor(private _blogService: BlogService) {

    }	
	
	public activate = (params, routeConfig, navigationInstruction) => {
		return this.GetPostDetailBySlug(params.slug).then((postDetail: PersonalDomain.Application.Blogging.Models.PostDTO) => {
			this.DetailViewModel = new Detail(postDetail);
		});
	}
	
	private GetPostDetailBySlug: (slug: string) => Promise<PersonalDomain.Application.Blogging.Models.PostDTO> = (slug) => {
		return this._blogService.GetPostDetailBySlug({ Slug: slug });
	}
}