interface IBlogScope {
    
}

interface IBlogIndexScope extends IBlogScope {
    postSummaries: any[];
}

interface IBlogDetailScope extends IBlogScope {
    post: any;
}

interface IPostDetailScope {

}

interface IPostSummaryScope {
    post: any;
}

interface IBlogService {
    GetPost: (id: number) => ng.IHttpPromise<any>;
    GetPostSummariesByPage: (pageNumber: number) => ng.IHttpPromise<any>;
    GetPostSummaryCount: () => ng.IHttpPromise<any>;
    SavePost: (data: any) => ng.IHttpPromise<any>;
}