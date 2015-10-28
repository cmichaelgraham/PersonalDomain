import {inject} from 'aurelia-framework';
import {BlogDataService} from 'blog/domain/data-service';

import {LeafletMap} from 'maps/leaflet-map';


@inject(BlogDataService, LeafletMap)
export class Index {
	public Posts: PersonalDomain.Application.Blogging.Models.PostSummaryDTO[];
	public TotalPostCount: number;	
    private _pageNumber: number = 1;
    private _pageSize: number = 20;
        
    constructor(private _blogDataService: BlogDataService, public Map: LeafletMap) {

    }
    
	public activate = (params, routeConfig) => {
		return this.LoadIndexByPageNumber(params.index, this._pageSize).then((response: PersonalDomain.Application.Blogging.Models.PostIndexDTO) => {
			routeConfig.navModel.router.UpdateHeader("James Chadwick", "Full-Stack Developer");					
			this.Posts = response.PostSummaries;
			this.TotalPostCount = response.PostSummaryCount;
						
			this.Map = new LeafletMap();
		});
	}    
    
	private LoadIndexByPageNumber(pageNumber: number, pageSize: number): Promise<PersonalDomain.Application.Blogging.Models.PostIndexDTO> {
		return this._blogDataService.GetPostSummariesByPage({ PageId: pageNumber, PageSize: pageSize });
	}    
}