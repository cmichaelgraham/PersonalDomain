import {inject} from 'aurelia-framework';
import {AuthenticationDataService} from 'account/domain/data-service';
import {AuthenticationService} from 'account/services/authentication-service';

@inject(AuthenticationDataService)
export class LogIn {
	public UserName: string;
	public Password: string;
	
	constructor(private _authenticationDataService: AuthenticationDataService) {
	}
	
	public Login(): void {
		this._authenticationDataService.GetToken({ UserName: this.UserName, Password: this.Password }).then((token) => {
			AuthenticationService.Login(token);
		});	
	}		
}