module PersonalDomain.Blogging {
    export class BloggingController {

        static $inject = ["$scope", "bloggingService"];

        constructor(private $scope: IBloggingScope, private bloggingService: BloggingService) {
            bloggingService.SavePost(undefined);
        }
    }
} 