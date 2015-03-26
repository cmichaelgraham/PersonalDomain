module PersonalDomain.Blog {
    export class BlogController {
        constructor(public $scope: IBlogScope, public blogService: IBlogService) {
        }
    }
} 