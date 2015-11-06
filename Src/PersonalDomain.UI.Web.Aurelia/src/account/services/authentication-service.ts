export class AuthenticationService {
	public static AuthorizationHeader(): string {
		var tokenJson = JSON.parse(localStorage["token"]);
		return tokenJson["token_type"] + " " + tokenJson["access_token"];
	};
	
	public static IsAuthenticated(): boolean {
		return localStorage["token"] !== undefined;
	};
	
	public static UseRefreshTokens: boolean;

	public static Login(token: string) {
		localStorage.setItem("token", token);
	}
	
	public static Logout() {
		localStorage.removeItem("token");
	}	
}