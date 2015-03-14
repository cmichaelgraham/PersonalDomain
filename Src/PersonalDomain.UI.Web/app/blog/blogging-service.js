var PersonalDomain;
(function (PersonalDomain) {
    (function (Blogging) {
        var BloggingService = (function () {
            function BloggingService($http) {
                var _this = this;
                this.$http = $http;
                this.GetPost = function (id) {
                    return _this.$http({
                        method: "post",
                        url: "/api/GetPost",
                        data: { Id: id }
                    }).then(function (data) {
                        return data;
                    });
                };
                this.GetPostsByPage = function (pageNumber) {
                    return _this.$http({
                        method: "post",
                        url: "/api/GetPostSummariesByPage",
                        data: { Id: pageNumber }
                    }).then(function (data) {
                        return data;
                    });
                };
                this.SavePost = function (data) {
                    return _this.$http({
                        method: "post",
                        url: "/api/SavePost",
                        data: undefined
                    }).then(function (response) {
                        return response;
                    });
                };
            }
            return BloggingService;
        })();
        Blogging.BloggingService = BloggingService;
    })(PersonalDomain.Blogging || (PersonalDomain.Blogging = {}));
    var Blogging = PersonalDomain.Blogging;
})(PersonalDomain || (PersonalDomain = {}));
//# sourceMappingURL=blogging-service.js.map
