import {Redirect} from "aurelia-router";
import {AuthenticationService} from "account/services/authentication-service";

export class AuthorizationPipelineStep {
	public run(routingContext, next) {
		if (routingContext.nextInstructions.some(i => i.config.authorize)) {
			return AuthenticationService.IsAuthenticated() ? next() : next.cancel(new Redirect('admin'));	
		}
		
		return next();
	}
}