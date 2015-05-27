import BlogService = require('blog/domain/service');
import Header = require('layout/factories/header');
import MarkupGenerator = require('infrastructure/markup-generator/markup-generator');

class BlogEditController {
    public Id: number;
    public Title: string;
    public Subtitle: string;
    public Content: string;

    static $inject = ['$routeParams', 'header', 'blogService'];
    constructor(private $routeParams: any, private header: Header, private blogService: BlogService) {
        var vm = this;

        this.Id = (!!$routeParams.postId) ? $routeParams.postId : 0;
        if (this.Id != 0) {
            this.LoadPostById(this.Id);
        }

        this.SetHeaderInfo();
    }

    public Markup: () => string = () => {
        return MarkupGenerator.GenerateMarkup(this.Content);
    }

    public LoadPostById = (postId: number) => {
        this.blogService.GetPostDetailById({ Id: postId }).then((post: PersonalDomain.Application.Blogging.Models.PostDTO) => {
            this.Title = post.Title;
            this.Subtitle = post.Subtitle;
            this.Content = post.Content;
        });
    }

    public Save = () => {
        var postDto: PersonalDomain.Application.Blogging.Models.PostDTO = {
            Id: this.Id,
            Title: this.Title,
            Subtitle: this.Subtitle,
            Content: this.Content,
            Comments: []
        };

        this.blogService.SavePost(postDto).then((commandResult: PersonalDomain.Application.Operations.Response.OperationResponse) => {
            toastr.info("Saved");
        });
    }

    private SetHeaderInfo = () => {
        this.header.Title = "James Chadwick";
        this.header.SubTitle = "Full-Stack Developer";
        this.header.ImageUrl = "../../../Content/images/home-bg.jpg";
    }
}

export = BlogEditController;