import {Redirect} from "aurelia-router";
import {AuthenticationContext} from 'infrastructure/authentication-context';

export class AuthorizationPipelineStep {
	public run(routingContext, next) {
		if (routingContext.nextInstructions.some(i => i.config.authorize)) {
			return AuthenticationContext.IsAuthenticated() ? next() : next.cancel(new Redirect('about'));	
		}
		
		return next();
	}
}