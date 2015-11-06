import {inject} from 'aurelia-framework';
import {BlogDataService} from 'blog/domain/data-service';
import {MarkupGenerator} from 'infrastructure/markup-generator';

@inject(BlogDataService)
export class PostDetailViewModel {
    public Content: string;
    
	get Markup() : string {
		return MarkupGenerator.GenerateMarkup(this.Content);
	}
		    
    constructor(private _blogDataService: BlogDataService) {
    }  
    
	public activate = (params, routeConfig) => {
		return this.LoadPost(params.slug).then((post) => {
			routeConfig.navModel.setTitle(post.Title);
			routeConfig.navModel.router.UpdateHeader(post.Title, post.Subtitle);
						
			this.Content = post.Content;
		});
	}
	
	private LoadPost(slug: string): Promise<PersonalDomain.Application.Blogging.Models.PostDetailDTO> {
		return this._blogDataService.GetPostBySlug({ Slug: slug });
	}  
} 