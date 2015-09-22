import {Router} from "aurelia-router";

export class Shell {
    public router: Router;
    public HeaderTitle: string;
    public HeaderSubTitle: string;
    
    public configureRouter = (config, router: Router) => {
        router.configure((config) => {
            config.title = "jamespchadwick.com";
            config.map([
                { name: "home",     route: ["", "home"],          moduleId: "./blog/controllers/home-controller",       nav: true,  title: "Home" },
                { name: "posts",    route: "posts/:slug",         moduleId: "./blog/controllers/detail-controller" },
                { name: "about",    route: "about",               moduleId: "./blog/controllers/about-controller",      nav: true,  title: "About" }
            ]);
            
            return config;
        });
        
        (<any>router).UpdateHeader = (title, subtitle) => {
            this.HeaderTitle = title;
            this.HeaderSubTitle = subtitle;
        };
        
        this.router = router;
    }
}