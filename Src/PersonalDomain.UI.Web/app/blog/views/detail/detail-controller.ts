module PersonalDomain.Blog.Detail {
    export class BlogDetailController implements IBlogDetailScope {
        public Post: PersonalDomain.Application.Blogging.Models.PostDTO;

        static $inject = ['$routeParams', 'blogService'];
        constructor(private $routeParams: any, private blogService: PersonalDomain.Application.Operations.BlogService) {
            var vm = this;

            this.LoadPostById($routeParams.postId);
        }

        public LoadPostById = (postId: number) => {
            this.blogService.GetPostDetailById({ Id: postId }).then((response: ng.IHttpPromiseCallbackArg<PersonalDomain.Application.Blogging.Models.PostDTO>) => {
                this.Post = response.data;
            });
        }
    }
} 