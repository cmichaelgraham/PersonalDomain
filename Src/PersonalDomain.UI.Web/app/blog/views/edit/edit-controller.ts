import BlogService = require('../../domain/service');
import Header = require('../../../layout/factories/header');

class BlogEditController {
    public Id: number;
    public Title: string;
    public Subtitle: string;
    public ContentMarkdown: string;

    private _markedOptions: MarkedOptions = { gfm: true, tables: true, breaks: false, pedantic: false, sanitize: false, smartLists: true, smartypants: false };

    static $inject = ['$routeParams', 'header', 'blogService'];
    constructor(private $routeParams: any, private header: Header, private blogService: BlogService) {
        var vm = this;

        this.SetHeaderInfo();
    }

    public GetContentMarkup: () => string = () => {
        return marked(this.ContentMarkdown, this._markedOptions);
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