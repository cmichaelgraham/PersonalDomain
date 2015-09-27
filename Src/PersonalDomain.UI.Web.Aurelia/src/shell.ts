import {Router} from "aurelia-router";
import {AuthenticationContext} from "infrastructure/authentication-context";
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
                { name: "posts",    route: "posts/:slug",   moduleId: "blog/detail/detail",   authorize: true },
                { name: "about",    route: "about",         moduleId: "blog/about/about",     nav: true,        title: "About" },
                { name: "Login",    route: "login",         moduleId: "account/index",        nav: true,        title: "Login" }
            ]);
            
            return config;
        });
        
        (<any>router).UpdateHeader = (title, subtitle) => { this.Title = title; this.SubTitle = subtitle; };        

        this.router = router;
    }
}