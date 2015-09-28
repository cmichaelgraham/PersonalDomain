import {AuthenticationDataService} from 'account/domain/data-service';

export class Index {
	public UserName: string;
	public Password: string;
	
	static inject = [AuthenticationDataService];
	constructor(private _authenticationDataService: AuthenticationDataService) {
	}
	
	public Login(): void {
		this._authenticationDataService.GetToken({ UserName: this.UserName, Password: this.Password }).then((token) => {
			localStorage.setItem("token", token);
		});	
	}		
}