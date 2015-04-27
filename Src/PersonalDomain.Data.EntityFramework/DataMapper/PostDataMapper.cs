using Data.EntityFramework.DataMapper;
using PersonalDomain.Data.Blogging.DataMappers;
using PersonalDomain.Domain.Blogging.Post;

namespace PersonalDomain.Data.DataMapper
{
    public class PostDataMapper : EntityConfiguration<Post>, IPostMapper
    {
        public override void Map()
        {
            HasRequired(c => c.Author).WithMany(c => c.Posts).HasForeignKey(c => c.AuthorId);
        }
    }
}
