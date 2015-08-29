import {BlogService} from 'blog/services/blog-service'
import {About} from 'blog/views/about'

export class AboutController {
	public AboutViewModel: About = undefined;
	
	static inject = [BlogService];
    constructor(private _blogService: BlogService) {

    }	
	
	public activate = (params, routeConfig, navigationInstruction) => {
		routeConfig.navModel.router.UpdateHeader("About James", "TAGLINE GOES HERE");
					
		return this.GetAuthorById(params.id).then((author: PersonalDomain.Application.Blogging.Models.AuthorDTO) => {		
			this.AboutViewModel = new About(author.Bio); 
		});
	}	

	private GetAuthorById: (id: number) => Promise<PersonalDomain.Application.Blogging.Models.AuthorDTO> = (id) => {
        return this._blogService.GetAuthorById({ Id: 1 });			
	} 	
}