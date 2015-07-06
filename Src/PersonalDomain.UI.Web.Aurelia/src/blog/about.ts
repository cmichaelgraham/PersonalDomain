import {BlogService} from './domain/service';

export class About {
    public Bio: string;

    static inject = [BlogService];
    constructor(private _blogService: BlogService) {

    }

    public activate() {
        return this._blogService.GetAuthorById({ Id: 1 }).then((response: PersonalDomain.Application.Blogging.Models.AuthorDTO) => {
            this.Bio = response.Bio;
        });
    }
}