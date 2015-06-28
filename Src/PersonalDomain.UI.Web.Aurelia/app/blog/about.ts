import BlogService = require('./domain/service');

class About {
    public Bio: string;

    static inject = [BlogService];
    constructor(private _blogService: BlogService) {

    }

    public activate() {
        return this._blogService.GetAuthorById({ Id: 1 }).then((response: PersonalDomain.Application.Blogging.Models.AuthorDTO) => {
            this.Bio = response.Bio;
        });
    }
}

export = About;

//import BlogService = require('blog/domain/service');
//import Header = require('layout/factories/header');

//class BlogAboutController {
//    public Bio: string;

//    static $inject = ['header', 'blogService'];
//    constructor(private header: Header, private blogService: BlogService) {
//        var vm = this;

//        this.LoadAuthorById(1);
//    }

//    public LoadAuthorById = (id: number) => {
//        this.blogService.GetAuthorById({ Id: id }).then((author: PersonalDomain.Application.Blogging.Models.AuthorDTO) => {
//            this.header.Title = "About " + author.FullName;
//            this.header.SubTitle = author.Tagline;
//            this.header.ImageUrl = "../../../../Content/images/about-bg.jpg";
//            this.Bio = author.Bio;
//        });
//    }
//}

//export = BlogAboutController; 