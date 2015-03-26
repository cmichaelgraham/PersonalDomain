module PersonalDomain.Blog {
    export class PostDetailDirective implements ng.IDirective {
        public restrict = "E";
        public scope: IPostDetailScope = {
            post: "="
        };
        public templateUrl = "/app/blog/directives/ng-post-detail/post-detail.html";
    }
} 