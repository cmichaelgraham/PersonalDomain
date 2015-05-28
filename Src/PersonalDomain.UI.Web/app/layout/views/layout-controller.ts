//$jchadwick- TODO: https://stackoverflow.com/questions/12506329/how-to-dynamically-change-header-based-on-angularjs-partial-view/17898250#17898250
//            Possible way to go about refactoring?
class LayoutController {
    constructor($scope: ng.IScope, header) {
        (<any>$scope).Header = header;
    }
}

export = LayoutController;
 