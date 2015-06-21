import BlogService = require('blog/domain/service');
import Header = require('layout/factories/header');

class BlogDetailController {
    public Post: PersonalDomain.Application.Blogging.Models.PostDTO;

    static $inject = ['$routeParams', 'header', 'blogService'];
    constructor(private $routeParams: any, private header: Header, private blogService: BlogService) {
        var vm = this;

        this.LoadPostById($routeParams.postId);
    }

    public LoadPostById = (postId: number) => {
        this.blogService.GetPostDetailById({ Id: postId }).then((post: PersonalDomain.Application.Blogging.Models.PostDTO) => {
            this.Post = post;
            this.header.Title = post.Title;
            this.header.SubTitle = post.Subtitle;
            this.header.ImageUrl = "../../../../Content/images/post-bg.jpg";            
        });
    }
}

export = BlogDetailController;