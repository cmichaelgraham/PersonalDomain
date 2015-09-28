import {BlogDataService} from 'blog/domain/data-service';

export class PostDetailViewModel {
    public Content: string;
    
    static inject = [BlogDataService];
    constructor(private _blogDataService: BlogDataService) {

    }  
    
	public activate = (params, routeConfig) => {
		return this.LoadPost(params.slug).then((post) => {
			routeConfig.navModel.setTitle(post.Title);
			routeConfig.navModel.router.UpdateHeader(post.Title, post.Subtitle);
						
			this.Content = post.Content;
		});
	}    
    
	private LoadPost(slug: string): Promise<PersonalDomain.Application.Blogging.Models.PostDTO> {
		return this._blogDataService.GetPostBySlug({ Slug: slug });
	}  
} 