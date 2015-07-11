export class Index {
	public OnNextButtonClick: () => void;

    constructor(public Posts: PersonalDomain.Application.Blogging.Models.PostSummaryDTO[], public TotalPostCount: number) {
    }
    
    get IsNextButtonVisible(): boolean {
        return this.Posts.length < this.TotalPostCount;
    }
}