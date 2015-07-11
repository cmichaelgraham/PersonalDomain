import {BlogService} from 'blog/services/blog-service'
import {Index} from 'blog/views/index'

export class IndexController {
    private _pageNumber: number = 1;
    private _pageSize: number = 20;

	public IndexViewModel: Index = undefined;

	static inject = [BlogService];
    constructor(private _blogService: BlogService) {

    }
	
	public activate = (params, routeConfig, navigationInstruction) => {
		return this.LoadIndexByPageNumber(params.index, this._pageSize).then((response: PersonalDomain.Application.Blogging.Models.PostIndexDTO) => {
			this.IndexViewModel = new Index(response.PostSummaries, response.PostSummaryCount);
			this.IndexViewModel.OnNextButtonClick = () => {
				this._pageNumber = this._pageNumber + 1;
				this.LoadIndexByPageNumber(this._pageNumber, this._pageSize).then((response: PersonalDomain.Application.Blogging.Models.PostIndexDTO) => {
					this.IndexViewModel.Posts = this.IndexViewModel.Posts.concat(response.PostSummaries);
					this.IndexViewModel.TotalPostCount = response.PostSummaryCount;
				});
			};
		});
	}
	
	private LoadIndexByPageNumber: (pageNumber: number, pageSize: number) => Promise<PersonalDomain.Application.Blogging.Models.PostIndexDTO> = (pageNumber, pageSize) =>  {
		return this._blogService.GetPostIndexByPage({ PageId: pageNumber, PageSize: pageSize });
	} 
}