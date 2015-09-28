import {BlogDataService} from 'blog/domain/data-service';

export class AuthorDetailViewModel {
    public Bio: string;
    
    static inject = [BlogDataService];
    constructor(private _blogDataService: BlogDataService) {
    } 
    
	public activate = (params, routeConfig) => {			
		return this.GetAuthorById(params.id).then((author) => {
			routeConfig.navModel.router.UpdateHeader("About James", "The Man with the Methodology");					
			this.Bio = author.Bio;
		});
	}
    
	private GetAuthorById(id: number): Promise<PersonalDomain.Application.Blogging.Models.AuthorDTO> {
        return this._blogDataService.GetAuthorById({ Id: 1 });			
	}         
}