import {inject} from 'aurelia-framework';
import {Router} from "aurelia-router";
import {AuthenticationDataService} from 'account/domain/data-service';
import {AuthenticationService} from 'account/services/authentication-service';

@inject(AuthenticationDataService, Router)
export class LogIn {
	public UserName: string;
	public Password: string;
	
	constructor(private _authenticationDataService: AuthenticationDataService, private _router: Router) {
	}
	
	public Login(): void {
		this._authenticationDataService.GetToken({ UserName: this.UserName, Password: this.Password }).then((token) => {
			AuthenticationService.Login(token);
			this._router.navigate("/admin/posts");
		});	
	}		
}