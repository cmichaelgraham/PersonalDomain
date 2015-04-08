module PersonalDomain.Blog {
    export class BlogService implements IBlogService {

        static inject = ['$http']
        constructor(private $http: ng.IHttpService) {
        }

        public GetPost: (id: number) => ng.IHttpPromise<any> = (id) => {
            return this.$http({
                method: 'post',
                url: '/api/GetPost',
                data: { Id: id }
            });
        }

        public GetPostSummariesByPage: (pageNumber: number) => ng.IHttpPromise<any> = (pageNumber) => {
            return this.$http({
                method: 'post',
                url: '/api/GetPostSummariesByPage',
                data: { Id: pageNumber }
            });
        }

        public GetPostSummaryCount: () => ng.IHttpPromise<number> = () => {
            return this.$http({
                method: 'post',
                url: '/api/GetPostSummaryCount'
            });
        }

        public SavePost: (data: any) => ng.IHttpPromise<any> = (data) => {
            return this.$http({
                method: 'post',
                url: '/api/SavePost',
                data: undefined
            });
        }
    }
}  