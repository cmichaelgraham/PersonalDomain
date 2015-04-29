interface IBlogAboutScope {
    Name: string;
    Tagline: string;
    Bio: string;
}

interface IBlogContactScope {
    Name: string;
    Email: string;
    Phone: string;
    Message: string;
    sendContactRequest: () => void;
}

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
