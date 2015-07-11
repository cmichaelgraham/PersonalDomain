import {BlogService} from 'blog/services/blog-service'
import {Contact} from 'blog/views/contact'

export class ContactController {
	public ContactViewModel: Contact = new Contact();
		
    constructor() {

    }	
	
	public activate = (params, routeConfig, navigationInstruction) => {
	}	
}	