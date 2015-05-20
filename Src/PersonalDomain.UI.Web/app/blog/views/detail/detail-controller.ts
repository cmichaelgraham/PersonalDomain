import BlogService = require('../../domain/service');

class BlogDetailController implements IBlogDetailScope {
    public Post: PersonalDomain.Application.Blogging.Models.PostDTO;

    static $inject = ['$routeParams', 'header', 'blogService'];
    constructor(private $routeParams: any, private header: IHeader, private blogService: BlogService) {
        var vm = this;

        this.LoadPostById($routeParams.postId);
    }

        public LoadPostById = (postId: number) => {
        this.blogService.GetPostDetailById({ Id: postId }).then((response: ng.IHttpPromiseCallbackArg<PersonalDomain.Application.Blogging.Models.PostDTO>) => {
            this.Post = response.data;
            this.header.Title = response.data.Title;
            this.header.SubTitle = response.data.Subtitle;
            this.header.ImageUrl = "../../../../Content/images/post-bg.jpg";
        });
    }
}

export = BlogDetailController;