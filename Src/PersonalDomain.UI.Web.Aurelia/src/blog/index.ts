import {BlogService} from 'blog/domain/data-service';

export class Index {
	public Posts: PersonalDomain.Application.Blogging.Models.PostSummaryDTO[];
	public TotalPostCount: number;	
    private _pageNumber: number = 1;
    private _pageSize: number = 20;
        
    static inject = [BlogService];
    constructor(private _blogService: BlogService) {

    }
    
	public activate = (params, routeConfig) => {
		return this.LoadIndexByPageNumber(params.index, this._pageSize).then((response: PersonalDomain.Application.Blogging.Models.PostIndexDTO) => {
			routeConfig.navModel.router.UpdateHeader("James Chadwick", "Full-Stack Developer");					
			this.Posts = response.PostSummaries;
			this.TotalPostCount = response.PostSummaryCount;
		});
	}    
    
	private LoadIndexByPageNumber(pageNumber: number, pageSize: number): Promise<PersonalDomain.Application.Blogging.Models.PostIndexDTO> {
		return this._blogService.GetPostIndexByPage({ PageId: pageNumber, PageSize: pageSize });
	}    
}