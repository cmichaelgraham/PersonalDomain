import BlogService = require('../../domain/service');

class BlogContactController implements IBlogContactScope {
    public Name: string;
    public Email: string;
    public Phone: string;
    public Message: string;

    static $inject = ['$routeParams', 'header', 'blogService'];
    constructor(private $routeParams: any, private header: IHeader, private blogService: BlogService) {
        var vm = this;

        this.SetHeaderInfo();
    }

        public SendContactRequest = () => {
        //$jchadwick TODO: Figure out how I'm going to actually send emails from an Azure website / private domain
    }

        public SetHeaderInfo = () => {
        this.header.Title = "Contact Me";
        this.header.SubTitle = "Have questions? I have answers (maybe).";
        this.header.ImageUrl = "../../../../Content/images/contact-bg.jpg";
    }
}

export = BlogContactController;