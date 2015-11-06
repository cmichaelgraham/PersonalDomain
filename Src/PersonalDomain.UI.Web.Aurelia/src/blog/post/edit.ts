import {inject} from 'aurelia-framework';
import {ensure, Validation, ValidationGroup} from 'aurelia-validation';
import {BlogDataService} from 'blog/domain/data-service';
import * as toastr from 'toastr';
import * as marked from 'marked';
import {MarkupGenerator} from 'infrastructure/markup-generator';

@inject(BlogDataService, Validation)
export class PostEditViwModel {
	public Id: number;
	@ensure((title) => { title.isNotEmpty(); })
	public Title: string;
	@ensure((subtitle) => { subtitle.isNotEmpty(); })
	public SubTitle: string;
	@ensure((content) => { content.isNotEmpty(); })
	public Content: string;
	@ensure((slug) => { slug.isNotEmpty(); })
	public Slug: string;

	public Validator: ValidationGroup;
	
	constructor(private _blogDataService: BlogDataService, private _validation: Validation) {
		this.Validator = _validation.on(this);
	}
	
	public activate = (params) => {
		this.Id = params.id == undefined ? 0 : params.id;
		
		if (this.Id != 0) {
			return this.LoadPost(this.Id).then((post) => {
				this.Title = post.Title;
				this.SubTitle = post.Subtitle;
				this.Content = post.Content;
				this.Slug = post.Slug == null ? '' : post.Slug;
			});
		}	
	}
	
	private LoadPost(id: number): Promise<PersonalDomain.Application.Blogging.Models.PostDetailDTO> {
		return this._blogDataService.GetPostById({ Id: id });
	}
	
	get Markup() : string {
		return MarkupGenerator.GenerateMarkup(this.Content);
	}
	
	private SavePost() {
		this.Validator.validate().then(() => {
			var request: PersonalDomain.Application.Blogging.Models.PostDetailDTO = {
				Id: this.Id,
				Title: this.Title,
				Subtitle: this.SubTitle,
				Slug: this.Slug,
				Content: this.Content,
				Comments: []
			};
			
			this._blogDataService.SavePost(request).then((response) => {
				if (response.IsSuccess) {
					toastr.info("hey");
				}
			});				
		});
	}
}