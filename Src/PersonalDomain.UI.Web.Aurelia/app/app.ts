import aureliaRouter = require("aurelia-router");

class App {
    static inject = [aureliaRouter.Router];

    constructor(private router: aureliaRouter.Router) {
        this.router.configure((config) => {
            config.title = "jamespchadwick.com";
            config.map([
                { route: ["", "blog"],      viewPorts: { header: { moduleId: 'app/layout/header/default/default-header' },  content: { moduleId: "app/blog/index" } },      nav: true,  title: "Blog" },
                { route: "detail/:id",      viewPorts: { header: { moduleId: 'app/layout/header/detail/detail-header' },    content: { moduleId: "app/blog/detail" } } },
                { route: "about",           viewPorts: { header: { moduleId: 'app/layout/header/about/about-header' },      content: { moduleId: "app/blog/about" } },      nav: true,  title: "About" },
                { route: "contact",         viewPorts: { header: { moduleId: 'app/layout/header/contact/contact-header' },  content: { moduleId: "app/blog/contact" } },    nav: true,  title: "Contact" }
            ]);
        });
    }
}

export = App;