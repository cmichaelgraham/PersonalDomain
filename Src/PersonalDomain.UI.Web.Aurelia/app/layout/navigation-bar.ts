import aureliaFramework = require("aurelia-framework");

class NavigationBar {
    static metadata = aureliaFramework.Behavior.withProperty("router");
}

export = NavigationBar;