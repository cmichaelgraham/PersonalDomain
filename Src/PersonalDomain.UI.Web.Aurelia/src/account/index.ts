import {AuthenticationDataService} from 'account/domain/data-service';
import {LoginViewModel} from 'account/login/account-login';
import {SocialLoginViewModel} from 'account/login/social-login';

export class Index {
	public LoginViewModel: LoginViewModel;
	public SocialLoginViewModel: SocialLoginViewModel;
	
	static inject = [AuthenticationDataService];
	constructor(private _authenticationDataService: AuthenticationDataService) {
		this.LoginViewModel = new LoginViewModel(_authenticationDataService);
		this.SocialLoginViewModel = new SocialLoginViewModel(_authenticationDataService);
	}
}