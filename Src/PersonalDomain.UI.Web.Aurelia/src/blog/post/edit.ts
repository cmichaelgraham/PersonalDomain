import {BlogDataService} from 'blog/domain/data-service';

export class PostEditViwModel {
	public Id: number;
	public Title: string;
	public SubTitle: string;
	public Content: string;
	public Slug: string;
	
	static inject = [BlogDataService];
	constructor(private _blogDataService: BlogDataService) {
	}
	
	public activate = (params) => {
		this.Id = params.id == undefined ? 0 : params.id;
		
		if (this.Id != 0) {
			return this.LoadPost(this.Id).then((post) => {
				this.Title = post.Title;
				this.SubTitle = post.Subtitle;
				this.Content = post.Content;
				this.Slug = post.Slug;
			});
		}	
	}
	
	private LoadPost(id: number): Promise<PersonalDomain.Application.Blogging.Models.PostDTO> {
		return this._blogDataService.GetPostById({ Id: id });
	}
	
	private SavePost() {
		var request: PersonalDomain.Application.Blogging.Models.PostDTO = {
			Id: this.Id,
			Title: this.Title,
			Subtitle: this.SubTitle,
			Slug: this.Slug,
			Content: this.Content,
			Comments: []
		};
		
		this._blogDataService.SavePost(request).then((response) => {
			if (response.IsSuccess) {
				alert("Saved!!");
			}
		});
	}
}