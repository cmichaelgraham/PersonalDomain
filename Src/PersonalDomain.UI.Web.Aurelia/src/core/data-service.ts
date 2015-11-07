import {HttpClient, RequestBuilder} from 'aurelia-http-client';
import {AuthorizationInterceptor} from 'infrastructure/authorization-interceptor';
import {AuthenticationService} from 'account/services/authentication-service';

export class CoreDataService {
	constructor(public BaseUrl: string, public HttpClient: HttpClient, public AuthorizationInterceptor: AuthorizationInterceptor) {
	}
	
	public Post<TRequest, TResponse>(url: string, jsonRequest: TRequest): Promise<TResponse> {
		var post = (<any>this.HttpClient).createRequest(this.BaseUrl + url)
										 .asPost()
										 .withHeader("Content-Type", "application/json;charset=UTF-8")
										 .withInterceptor(this.AuthorizationInterceptor)
										 .withContent(jsonRequest);
		
		if (AuthenticationService.IsAuthenticated()) {
			post = post.withHeader("Authorization", AuthenticationService.AuthorizationHeader());
		}	

		return post.send().then((httpResponse) => { return JSON.parse(httpResponse.response); });									
	}
}