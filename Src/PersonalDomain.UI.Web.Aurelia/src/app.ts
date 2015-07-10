import {Router} from "aurelia-router";

export class App {
    configureRouter(config, router: Router) {
        router.configure((config) => {
            config.title = "jamespchadwick.com";
            config.map([
                { route: ["", "blog"],   moduleId: "./blog/index",     nav: true,  title: "Blog" },
                { name: "posts",         route: "posts/:slug",  moduleId: "./blog/detail" },
                { name: "about",         route: "about",        moduleId: "./blog/about",     nav: true,  title: "About" },
                { route: "contact",      moduleId: "./blog/contact",   nav: true,  title: "Contact" }
            ]);
        });
    }
}