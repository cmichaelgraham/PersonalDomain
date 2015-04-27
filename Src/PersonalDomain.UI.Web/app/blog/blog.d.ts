interface IBlogDetailScope {
    Post: any;
}

interface IBlogIndexScope {
    PostSummaries: any[];
    Next: () => void;
}

interface IPostDetailScope {

}

interface IPostSummaryScope {
    post: any;
}
