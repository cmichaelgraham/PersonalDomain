import {inject} from 'aurelia-framework';
import {Router} from "aurelia-router";

@inject(Router)
export class AuthorizationInterceptor {
	public constructor(private _router: Router) {
		
	}
	
	public responseError (message) {
		switch (message.statusCode) {
			case 401:
			this._router.navigate("/admin");
			return message;
		}
		return message;
	}
}