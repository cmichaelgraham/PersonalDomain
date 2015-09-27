import {BlogService} from 'blog/domain/data-service';

export class Detail {
    public Content: string;
    
    static inject = [BlogService];
    constructor(private _blogService: BlogService) {

    }  
    
	public activate = (params, routeConfig) => {
		return this.GetPostDetailBySlug(params.slug).then((postDetail: PersonalDomain.Application.Blogging.Models.PostDTO) => {
			routeConfig.navModel.setTitle(postDetail.Title);
			routeConfig.navModel.router.UpdateHeader(postDetail.Title, postDetail.Subtitle);
						
			this.Content = postDetail.Content;
		});
	}    
    
	private GetPostDetailBySlug(slug: string): Promise<PersonalDomain.Application.Blogging.Models.PostDTO> {
		return this._blogService.GetPostDetailBySlug({ Slug: slug });
	}    
} 