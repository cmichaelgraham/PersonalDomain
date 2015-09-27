import {AuthenticationDataService} from 'account/domain/data-service';

export class LoginViewModel {
	public UserName: string;
	public Password: string;
	public UseRefreshTokens: boolean;
	
    constructor(private _authenticationService: AuthenticationDataService) {

    }	
	
	public Login(): void {
		this._authenticationService.GetToken({ UserName: this.UserName, Password: this.Password }).then((token) => {
			localStorage.setItem("token", token);
		});	
	}	
}