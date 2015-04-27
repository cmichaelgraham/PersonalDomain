using Data.EntityFramework.DataMapper;
using PersonalDomain.Data.Blogging.DataMappers;
using PersonalDomain.Domain.Blogging.Post;

namespace PersonalDomain.Data.DataMapper
{
    public class AuthorDataMapper : EntityConfiguration<Author>, IAuthorMapper
    {
        public override void Map()
        {
        }
    }
}
