//Generated by Flashman\James Chadwick at 5/26/2015 8:06 PM

declare module PersonalDomain.Application.Blogging.Models {
	interface CommentDTO {
		Id: number;
		PostId: number;
		UserId: number;
		UserName: number;
		Content: string;
	}
	interface PostDTO {
		Id: number;
		Title: string;
		Subtitle: string;
		Content: string;
		Comments: PersonalDomain.Application.Blogging.Models.CommentDTO[];
	}
	interface AuthorDTO {
		FullName: string;
		Tagline: string;
		Bio: string;
	}
	interface PostIndexDTO {
		PostSummaries: PersonalDomain.Application.Blogging.Models.PostSummaryDTO[];
		PostSummaryCount: number;
	}
	interface PostSummaryDTO {
		Id: number;
		Title: string;
		Subtitle: string;
		Author: string;
		PostedDate: string;
	}
}
declare module PersonalDomain.Application.Operations.Response {
	interface OperationResponse {
		IsSuccess: boolean;
	}
}
declare module PersonalDomain.Application.Operations.Request {
	interface ByIdRequest {
		Id: number;
	}
	interface GetPostIndexByPageRequest {
		PageId: number;
		PageSize: number;
	}
}