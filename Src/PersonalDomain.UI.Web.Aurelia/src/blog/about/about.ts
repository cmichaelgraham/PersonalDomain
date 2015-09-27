import {BlogService} from 'blog/domain/data-service';

export class About {
    public Bio: string;
    
    static inject = [BlogService];
    constructor(private _blogService: BlogService) {
    } 
    
	public activate = (params, routeConfig) => {			
		return this.GetAuthorById(params.id).then((author: PersonalDomain.Application.Blogging.Models.AuthorDTO) => {
			routeConfig.navModel.router.UpdateHeader("About James", "The Man with the Methodology");					
			this.Bio = author.Bio;
		});
	}
    
	private GetAuthorById(id: number): Promise<PersonalDomain.Application.Blogging.Models.AuthorDTO> {
        return this._blogService.GetAuthorById({ Id: 1 });			
	}         
}