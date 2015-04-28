interface IBlogDetailScope {
    Post: PersonalDomain.Application.Blogging.Models.PostDTO;
}

interface IBlogIndexScope {
    IsNextButtonVisible: () => boolean;
    Next: () => void;
    PostSummaries: PersonalDomain.Application.Blogging.Models.PostSummaryDTO[];
}

interface IPostDetailScope {

}

interface IPostSummaryScope {
    post: any;
}
