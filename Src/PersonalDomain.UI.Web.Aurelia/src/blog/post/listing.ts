import {inject} from 'aurelia-framework';
import {BlogDataService} from 'blog/domain/data-service';

@inject(BlogDataService)
export class PostListingViewModel {
	public PostSummaries: PersonalDomain.Application.Blogging.Models.PostSummaryDTO[];
	
	constructor(private _blogDataService: BlogDataService) {
		
	}
	
	public activate = () => {
		return this.LoadPostSummaries().then((postSummaries) => {
			this.PostSummaries = postSummaries;
		});	
	}
	
	private LoadPostSummaries(): Promise<PersonalDomain.Application.Blogging.Models.PostSummaryDTO[]> {
		return this._blogDataService.GetPostSummaries({});
	}
}