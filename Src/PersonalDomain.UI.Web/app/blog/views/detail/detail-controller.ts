module PersonalDomain.Blog.Detail {
    export class BlogDetailController implements IBlogDetailScope {
        public Post: any;

        static $inject = ['$routeParams', 'blogService'];
        constructor(private $routeParams: any, private blogService: IBlogService) {
            var vm = this;

            this.LoadPostById($routeParams.postId);
        }

        public LoadPostById = (postId: number) => {
            this.blogService.GetPost(postId).then((response: ng.IHttpPromiseCallbackArg<any>) => {
                this.Post = response.data;
            });
        }
    }
} 