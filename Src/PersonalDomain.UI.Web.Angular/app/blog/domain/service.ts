//Generated by Flashman\James Chadwick at 6/21/2015 1:15 PM
class BlogService {

    private _baseUrl: string = "http://blog.jamespchadwick.com";

    static inject = ['$http'];
    constructor(private $http: ng.IHttpService) {
    }

    public SaveComment: (request: PersonalDomain.Application.Blogging.Models.CommentDTO) => ng.IPromise<PersonalDomain.Application.Operations.Response.OperationResponse> = (request) => {
	    return this.$http({ method: 'post', url: this._baseUrl + '/api/SaveComment', data: request})
                   .then((response: ng.IHttpPromiseCallbackArg<PersonalDomain.Application.Operations.Response.OperationResponse>): PersonalDomain.Application.Operations.Response.OperationResponse => {
                        return <PersonalDomain.Application.Operations.Response.OperationResponse>response.data;
                    });
    }

    public SavePost: (request: PersonalDomain.Application.Blogging.Models.PostDTO) => ng.IPromise<PersonalDomain.Application.Operations.Response.OperationResponse> = (request) => {
	    return this.$http({ method: 'post', url: this._baseUrl + '/api/SavePost', data: request})
                   .then((response: ng.IHttpPromiseCallbackArg<PersonalDomain.Application.Operations.Response.OperationResponse>): PersonalDomain.Application.Operations.Response.OperationResponse => {
                        return <PersonalDomain.Application.Operations.Response.OperationResponse>response.data;
                    });
    }

    public GetAuthorById: (request: PersonalDomain.Application.Operations.Request.ByIdRequest) => ng.IPromise<PersonalDomain.Application.Blogging.Models.AuthorDTO> = (request) => {
	    return this.$http({ method: 'post', url: this._baseUrl + '/api/GetAuthorById', data: request})
                   .then((response: ng.IHttpPromiseCallbackArg<PersonalDomain.Application.Blogging.Models.AuthorDTO>): PersonalDomain.Application.Blogging.Models.AuthorDTO => {
                        return <PersonalDomain.Application.Blogging.Models.AuthorDTO>response.data;
                    });
    }

    public GetPostDetailById: (request: PersonalDomain.Application.Operations.Request.ByIdRequest) => ng.IPromise<PersonalDomain.Application.Blogging.Models.PostDTO> = (request) => {
	    return this.$http({ method: 'post', url: this._baseUrl + '/api/GetPostDetailById', data: request})
                   .then((response: ng.IHttpPromiseCallbackArg<PersonalDomain.Application.Blogging.Models.PostDTO>): PersonalDomain.Application.Blogging.Models.PostDTO => {
                        return <PersonalDomain.Application.Blogging.Models.PostDTO>response.data;
                    });
    }

    public GetPostIndexByPage: (request: PersonalDomain.Application.Operations.Request.GetPostIndexByPageRequest) => ng.IPromise<PersonalDomain.Application.Blogging.Models.PostIndexDTO> = (request) => {
	    return this.$http({ method: 'post', url: this._baseUrl + '/api/GetPostIndexByPage', data: request})
                   .then((response: ng.IHttpPromiseCallbackArg<PersonalDomain.Application.Blogging.Models.PostIndexDTO>): PersonalDomain.Application.Blogging.Models.PostIndexDTO => {
                        return <PersonalDomain.Application.Blogging.Models.PostIndexDTO>response.data;
                    });
    }
		
}
export = BlogService;
