import {HttpClient} from 'aurelia-http-client';
import {AuthenticationContext} from 'infrastructure/authentication-context';

export class CoreDataService {
	constructor(public BaseUrl: string, public HttpClient: HttpClient) {
	}
	
	public Post<TRequest, TResponse>(url: string, jsonRequest: TRequest): Promise<TResponse> {
		var post = (<any>this.HttpClient).createRequest(this.BaseUrl + url)
										 .asPost()
										 .withHeader("Content-Type", "application/json;charset=UTF-8")
										 .withContent(jsonRequest);
		
		if (AuthenticationContext.IsAuthenticated()) {
			post = post.withHeader("Authorization", AuthenticationContext.Token());
		}	
											
		return post.send().then((httpResponse) => { return JSON.parse(httpResponse.response); });
	}
}