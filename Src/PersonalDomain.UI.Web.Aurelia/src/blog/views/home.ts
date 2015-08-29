export class Home {
    constructor(public Posts: PersonalDomain.Application.Blogging.Models.PostSummaryDTO[], public TotalPostCount: number) {
    }
}