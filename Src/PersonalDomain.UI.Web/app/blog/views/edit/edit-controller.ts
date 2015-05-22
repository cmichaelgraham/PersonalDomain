import BlogService = require('blog/domain/service');
import Header = require('layout/factories/header');
import MarkupGenerator = require('infrastructure/markup-generator/markup-generator');

class BlogEditController {
    public Id: number;
    public Title: string;
    public Subtitle: string;
    public ContentMarkdown: string;

    static $inject = ['$routeParams', 'header', 'blogService'];
    constructor(private $routeParams: any, private header: Header, private blogService: BlogService) {
        var vm = this;

        this.SetHeaderInfo();
    }

    public ContentMarkup: () => string = () => {
        return MarkupGenerator.GenerateMarkup(this.ContentMarkdown);
    }

    public LoadPostById = (postId: number) => {
        this.blogService.GetPostDetailById({ Id: postId }).then((post: PersonalDomain.Application.Blogging.Models.PostDTO) => {
            this.Title = post.Title;
            this.Subtitle = post.Subtitle;
            this.ContentMarkdown = post.Content;
        });
    }

    public Save = () => {
        var postDto: PersonalDomain.Application.Blogging.Models.PostDTO = {
            Id: 999, //this.Id,
            Title: "New Title", //this.Title,
            Subtitle: "New Subtitle", //this.Subtitle,
            Content: this.ContentMarkdown,
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