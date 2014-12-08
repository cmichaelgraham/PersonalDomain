var App;
(function (App) {
    (function (Scope) {
        "use strict";
        var Person = (function () {
            function Person() {
            }
            return Person;
        })();
        Scope.Person = Person;
    })(App.Scope || (App.Scope = {}));
    var Scope = App.Scope;
})(App || (App = {}));
//# sourceMappingURL=Person.js.map
