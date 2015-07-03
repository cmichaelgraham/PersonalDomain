import LayoutHeaderViewModel = require('../layout-header');

class DefaultHeader extends LayoutHeaderViewModel {
    constructor() {
        super();

        this.Title = "About James";
        this.SubTitle = "Tagline Goes Here";
    }
}

export = DefaultHeader;
