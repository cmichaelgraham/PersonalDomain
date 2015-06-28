import aur = require("aurelia-router");

class App {
    static inject = [aur.Router];

    constructor(private router: aur.Router) {
        this.router.configure((config) => {
            config.title = "jamespchadwick.com";
            config.map([
                { route: ["", "blog/:id"],  moduleId: "app/blog/index",     nav: true, title: "Blog" },
                { route: "detail/:id",      moduleId: "app/blog/detail" },
                { route: "about",           moduleId: "app/blog/about",     nav: true, title: "About" },
                { route: "contact",         moduleId: "app/blog/contact",   nav: true, title: "Contact" }
            ]);
        });
    }
}

export = App;