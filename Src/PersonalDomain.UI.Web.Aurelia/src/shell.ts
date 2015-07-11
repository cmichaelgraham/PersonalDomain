import {Router} from "aurelia-router";

export class Shell {
    public router: Router;
    
    configureRouter(config, router: Router) {
        router.configure((config) => {
            config.title = "jamespchadwick.com";
            config.map([
                { name: "index",    route: ["", "blog/:index"],   moduleId: "./blog/controllers/index-controller",         nav: true,  title: "Blog" },
                { name: "posts",    route: "posts/:slug",         moduleId: "./blog/controllers/detail-controller" },
                { name: "about",    route: "about",               moduleId: "./blog/controllers/about-controller",         nav: true,  title: "About" },
                { name: "contact",  route: "contact",             moduleId: "./blog/controllers/contact-controller",       nav: true,  title: "Contact" }
            ]);
        });
        
        this.router = router;
    }
}