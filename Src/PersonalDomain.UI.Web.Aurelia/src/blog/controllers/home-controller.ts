import {BlogService} from 'blog/services/blog-service'
import {Home} from 'blog/views/home'

export class IndexController {
    private _pageNumber: number = 1;
    private _pageSize: number = 20;

	public HomeViewModel: Home = undefined;

	static inject = [BlogService];
    constructor(private _blogService: BlogService) {

    }
	
	public activate = (params, routeConfig, navigationInstruction) => {
		routeConfig.navModel.router.UpdateHeader("James Chadwick", "Full-Stack Developer");
					
		return this.LoadIndexByPageNumber(params.index, this._pageSize).then((response: PersonalDomain.Application.Blogging.Models.PostIndexDTO) => {		
			this.HomeViewModel = new Home(response.PostSummaries, response.PostSummaryCount);
		});
	}
	
	private LoadIndexByPageNumber: (pageNumber: number, pageSize: number) => Promise<PersonalDomain.Application.Blogging.Models.PostIndexDTO> = (pageNumber, pageSize) =>  {
		return this._blogService.GetPostIndexByPage({ PageId: pageNumber, PageSize: pageSize });
	} 
}