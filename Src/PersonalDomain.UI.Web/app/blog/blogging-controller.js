var PersonalDomain;
(function (PersonalDomain) {
    (function (Blogging) {
        var BloggingController = (function () {
            function BloggingController($scope, bloggingService) {
                this.$scope = $scope;
                this.bloggingService = bloggingService;
                $scope.Posts = bloggingService.GetPostsByPage(0);
            }
            BloggingController.$inject = ["$scope", "bloggingService"];
            return BloggingController;
        })();
        Blogging.BloggingController = BloggingController;
    })(PersonalDomain.Blogging || (PersonalDomain.Blogging = {}));
    var Blogging = PersonalDomain.Blogging;
})(PersonalDomain || (PersonalDomain = {}));
//# sourceMappingURL=blogging-controller.js.map
