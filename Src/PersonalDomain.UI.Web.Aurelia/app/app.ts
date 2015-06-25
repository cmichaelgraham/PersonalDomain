import aur = require("aurelia-router");

class App {
    static inject = [aur.Router];

    constructor(private router: aur.Router) {
        this.router.configure((config) => {
            config.title = "James P Chadwick";
            config.map([
                { route: ["", "welcome"], moduleId: "app/welcome", nav: true, title: "Welcome to VS/TS" },
                { route: "flickr", moduleId: "app/flickr", nav: true },
                { route: "child-router", moduleId: "app/child-router", nav: true, title: "Child Router" }
            ]);
        });
    }
}

export = App;