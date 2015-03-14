interface IBlogScope {
    
}

interface IBlogIndexScope extends IBlogScope {
    postSummaries: any[];
}

interface IBlogDetailScope extends IBlogScope {
    
}

interface IPostDetailScope {
    post: string;
}

interface IPostSummaryScope {
    post: string;
}

interface IBlogService {
    //GetPost: (id: number) => any;
    //GetPostSummariesByPage: (pageNumber: number) => any[];
    //SavePost: (data: any) => any;

    GetPostSummariesByPage: (pageNumber: number) => ng.IHttpPromise<any>;
}