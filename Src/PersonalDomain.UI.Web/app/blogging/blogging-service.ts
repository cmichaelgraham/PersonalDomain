module PersonalDomain.Blogging {
    export class BloggingService {

        constructor(private $http: ng.IHttpService) {
        }

        public GetPostById: (id: number) => any = (id) => { 
            return this.$http({
                method: "post",
                url: "/api/GetPost",
                data: { Id: id }
            }).then((data) => {
                return data;
            });
        }

        public SavePost: (data: any) => any = (data) => {
            return this.$http({
                method: "post",
                url: "/api/SavePost",
                data: undefined
            }).then((response) => {
                return response;
            });
        }
    }
}  