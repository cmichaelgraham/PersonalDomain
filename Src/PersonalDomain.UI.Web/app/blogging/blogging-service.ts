module PersonalDomain.Blogging {
    export class BloggingService {

        constructor(private $http: ng.IHttpService) {
        }

        public GetPost: (id: number) => any = (id) => { 
            return this.$http({
                method: "post",
                url: "/api/GetPost",
                data: { Id: id }
            }).then((data: any) => {
                return data;
            });
        }

        public GetPostsByPage: (pageNumber: number) => any = (pageNumber) => {
            return this.$http({
                method: "post",
                url: "/api/GetPostSummariesByPage",
                data: { Id: pageNumber }
            }).then((data: any) => {
                return data;
            });
        }

        public SavePost: (data: any) => any = (data) => {
            return this.$http({
                method: "post",
                url: "/api/SavePost",
                data: undefined
            }).then((response: any) => {
                return response;
            });
        }
    }
}  