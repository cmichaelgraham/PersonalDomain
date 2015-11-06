import {Router} from "aurelia-router";
import {AuthorizationPipelineStep} from "infrastructure/authorization-pipeline-step";

export class Shell {
    public router: Router;
    public Title: string;
    public SubTitle: string;
    
    public configureRouter = (config, router: Router) => {
        router.configure((config) => {
            config.title = "jamespchadwick.com";
            config.addPipelineStep("authorize", AuthorizationPipelineStep);
            config.map([
                { name: "home",     route: ["", "home"],    moduleId: "blog/index",           nav: true,        title: "Home" },
                { name: "posts",    route: "posts/:slug",   moduleId: "blog/post/detail" },
                { name: "about",    route: "about",         moduleId: "blog/author/detail",   nav: true,        title: "About" },
                { name: "admin",    route: "admin",         moduleId: "account/index",                          title: "Administration" },
            ]);
            
            return config;
        });
        
        (<any>router).UpdateHeader = (title, subtitle) => { this.Title = title; this.SubTitle = subtitle; };        

        this.router = router;
    }
}