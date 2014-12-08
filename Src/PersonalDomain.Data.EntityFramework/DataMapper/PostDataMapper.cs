using Data.EntityFramework.DataMapper;
using PersonalDomain.Data.Blogging.DataMappers;
using PersonalDomain.Domain.Blogging.Post;

namespace PersonalDomain.Data.EntityFramework.DataMapper
{
    public class PostDataMapper : EntityConfiguration<Post>, IPostMapper
    {
        public override void Map()
        {
        }
    }
}
