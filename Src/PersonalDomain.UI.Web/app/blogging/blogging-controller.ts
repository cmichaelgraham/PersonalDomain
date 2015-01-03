module PersonalDomain.Blogging {
    export class BloggingController {

        static $inject = ["$scope", "bloggingService"];

        constructor(private $scope: IBloggingScope, private bloggingService: BloggingService) {
            $scope.Posts = bloggingService.GetPostsByPage(0);
        }
    }
} 