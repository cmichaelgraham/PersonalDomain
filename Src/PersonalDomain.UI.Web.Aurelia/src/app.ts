import {Router} from "aurelia-router";

export class App {
    static inject = [Router];

    constructor(private router: Router) {
        router.configure((config) => {
            config.title = "jamespchadwick.com";
            config.map([
                { route: ["", "blog"],  moduleId: "./blog/index",     nav: true,  title: "Blog" },
                { route: "blog/:slug",  moduleId: "./blog/detail" },
                { route: "about",       moduleId: "./blog/about",     nav: true,  title: "About" },
                { route: "contact",     moduleId: "./blog/contact",   nav: true,  title: "Contact" }
            ]);
        });
    }
}