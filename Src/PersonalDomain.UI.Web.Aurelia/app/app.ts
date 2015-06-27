import aur = require("aurelia-router");

class App {
    static inject = [aur.Router];

    constructor(private router: aur.Router) {
        this.router.configure((config) => {
            config.title = "jamespchadwick.com";
            config.map([
                { route: ["", "blog"],  moduleId: "app/blog/index", nav: true, title: "Blog" },
                { route: "about",       moduleId: "app/under-construction", nav: true, title: "About" },
                { route: "contact",     moduleId: "app/under-construction", nav: true, title: "Contact" }
            ]);
        });
    }
}

export = App;