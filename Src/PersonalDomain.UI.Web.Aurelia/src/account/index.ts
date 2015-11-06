import {Router} from "aurelia-router";

export class Index {
    public router: Router;
        
    public configureRouter = (config, router: Router) => {
        router.configure((config) => {
            config.title = "Admin | jamespchadwick.com";
            config.map([
                { name: "log-in",        route: ["","log-in"],     moduleId: "account/log-in/log-in",      nav: true,      title: "Log In" },
                { name: "posts",         route: "posts",           moduleId: "blog/post/listing",          nav: true,      title: "Posts",     authorize: true },
                { name: "post",          route: "post/:id",        moduleId: "blog/post/edit",                             title: "Edit Post", authorize: true }          
            ]);
            
            return config;
        });
        
        this.router = router;
    }     
}