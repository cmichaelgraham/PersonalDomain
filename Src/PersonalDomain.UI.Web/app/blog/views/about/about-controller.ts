import BlogService = require('../../domain/service');
import Header = require('../../../layout/factories/header');

class BlogAboutController {
    public Bio: string;

    static $inject = ['$routeParams', 'header', 'blogService'];
    constructor(private $routeParams: any, private header: Header, private blogService: BlogService) {
        var vm = this;

        this.LoadAuthorById(1);
    }

    public LoadAuthorById = (id: number) => {
        this.blogService.GetAuthorById({ Id: id }).then((author: PersonalDomain.Application.Blogging.Models.AuthorDTO) => {
            this.header.Title = "About " + author.FullName;
            this.header.SubTitle = author.Tagline;
            this.header.ImageUrl = "../../../../Content/images/about-bg.jpg";
            this.Bio = author.Bio;
        });
    }
}

export = BlogAboutController;