import LayoutHeaderViewModel = require('../layout-header');

class DefaultHeader extends LayoutHeaderViewModel {
    constructor() {
        super();

        this.Title = "James Chadwick";
        this.SubTitle = "Full-Stack Developer";
    }
}

export = DefaultHeader;
