import BlogService = require('../../domain/service');

class BlogAboutController implements IBlogAboutScope {
    public Bio: string;

    static $inject = ['$routeParams', 'header', 'blogService'];
    constructor(private $routeParams: any, private header: IHeader, private blogService: BlogService) {
        var vm = this;

        this.LoadAuthorById(1);
    }

        public LoadAuthorById = (id: number) => {
        this.blogService.GetAuthorById({ Id: id }).then((response: ng.IHttpPromiseCallbackArg<PersonalDomain.Application.Blogging.Models.AuthorDTO>) => {
            this.header.Title = "About " + response.data.FullName;
            this.header.SubTitle = response.data.Tagline;
            this.header.ImageUrl = "../../../../Content/images/about-bg.jpg";
            this.Bio = response.data.Bio;
        });
    }
}

export = BlogAboutController;