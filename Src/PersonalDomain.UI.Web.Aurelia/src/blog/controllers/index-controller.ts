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
		});
	}
	
	private LoadIndexByPageNumber: (pageNumber: number, pageSize: number) => Promise<PersonalDomain.Application.Blogging.Models.PostIndexDTO> = (pageNumber, pageSize) =>  {
		return this._blogService.GetPostIndexByPage({ PageId: pageNumber, PageSize: pageSize });
	} 
}

// 
//     public OnNextButtonClick = () => {
//         this._pageIndex = this._pageIndex + 1;
//         this.LoadPage(this._pageIndex).then((response: PersonalDomain.Application.Blogging.Models.PostIndexDTO) => {
//             this.Posts = this.Posts.concat(response.PostSummaries);
//             this.PostCount = response.PostSummaryCount;
//             this.IsNextButtonVisible = this.GetIsNextButtonVisible();
//         });
//     }
// 
//     private LoadPage: (index: number) => Promise<PersonalDomain.Application.Blogging.Models.PostIndexDTO> = (index) => {
//         return this._blogService.GetPostIndexByPage({ PageId: index, PageSize: this._pageSize });       
//     }