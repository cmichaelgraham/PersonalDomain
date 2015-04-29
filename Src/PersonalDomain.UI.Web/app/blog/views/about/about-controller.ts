module PersonalDomain.Blog.About {
    export class BlogAboutController implements IBlogAboutScope {
        public Name: string;
        public Tagline: string;
        public Bio: string;

        static $inject = ['$routeParams', 'blogService'];
        constructor(private $routeParams: any, private blogService: PersonalDomain.Application.Operations.BlogService) {
            var vm = this;

            this.LoadAuthorById(1);
        }

        public LoadAuthorById = (id: number) => {
            this.blogService.GetAuthorById({ Id: id }).then((response: ng.IHttpPromiseCallbackArg<PersonalDomain.Application.Blogging.Models.AuthorDTO>) => {
                this.Name = response.data.FullName;
                this.Tagline = response.data.Tagline;
                this.Bio = response.data.Bio;
            });
        }
    }
} 