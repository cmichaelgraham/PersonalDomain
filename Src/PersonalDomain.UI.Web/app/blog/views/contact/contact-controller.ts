module PersonalDomain.Blog.About {
    export class BlogContactController implements IBlogContactScope {
        public Name: string;
        public Email: string;
        public Phone: string;
        public Message: string;

        static $inject = ['$routeParams', 'blogService'];
        constructor(private $routeParams: any, private blogService: PersonalDomain.Application.Operations.BlogService) {
            var vm = this;
        }

        public sendContactRequest = () => {
            //$jchadwick TODO: Figure out how I'm going to actually send emails from an Azure website / private domain
        }
    }
} 