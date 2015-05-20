class PostSummaryDirective implements ng.IDirective {
    public restrict = "E";
    public scope: IPostSummaryScope = {
        post: "="
    };
    public templateUrl = "/app/blog/directives/ng-post-summary/post-summary.html";
}

export = PostSummaryDirective;