import BlogService = require('blog/domain/service');
import Header = require('layout/factories/header');

class BlogContactController {
    public Name: string;
    public Email: string;
    public Phone: string;
    public Message: string;

    static $inject = ['$routeParams', 'header', 'blogService'];
    constructor(private $routeParams: any, private header: Header, private blogService: BlogService) {
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