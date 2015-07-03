import LayoutHeaderViewModel = require('../layout-header');

class ContactHeader extends LayoutHeaderViewModel {
    constructor() {
        super();

        this.Title = "Contact James";
        this.SubTitle = "Have questions? I have answers (maybe).";
    }
}

export = ContactHeader;
