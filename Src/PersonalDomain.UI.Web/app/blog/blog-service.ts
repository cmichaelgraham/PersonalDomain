module PersonalDomain.Blog {
    export class BlogService implements IBlogService {

        constructor(private $http: ng.IHttpService) {
        }

        public GetPostSummariesByPage: (pageNumber: number) => ng.IHttpPromise<any> = (pageNumber) => {
            return this.$http({
                method: "post",
                url: "/api/GetPostSummariesByPage",
                data: { Id: pageNumber }
            });
        }

        //public GetPost: (id: number) => any = (id) => { 
        //    return this.$http({
        //        method: "post",
        //        url: "/api/GetPost",
        //        data: { Id: id }
        //    }).then((data: any) => {
        //        return data;
        //    });
        //}

        //public GetPostSummariesByPage: (pageNumber: number) => any = (pageNumber) => {
        //    return this.$http({
        //        method: "post",
        //        url: "/api/GetPostSummariesByPage",
        //        data: { Id: pageNumber }
        //    }).then((data: any) => {
        //        return data;
        //    });
        //}

        //public SavePost: (data: any) => any = (data) => {
        //    return this.$http({
        //        method: "post",
        //        url: "/api/SavePost",
        //        data: undefined
        //    }).then((response: any) => {
        //        return response;
        //    });
        //}
    }
}  