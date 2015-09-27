export class AuthenticationContext {
	private static _token: any;

	public static IsAuthenticated(): boolean {
		return localStorage["token"] !== undefined;
	}
	public static Authorization(): string {
		if (this.IsAuthenticated()) {
			var token = JSON.parse(localStorage["token"]);
			return token["token_type"] + " " + token["access_token"];
		}
		
		return undefined;							
	}
}