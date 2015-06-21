using Framework.DataAccess.EntityFramework.DataMapper;
using PersonalDomain.Data.Blogging.DataMappers;
using PersonalDomain.Domain.Blogging.Post;

namespace PersonalDomain.Data.DataMapper
{
    public class CommentDataMapper : EntityConfiguration<Comment>, IPostMapper
    {
        public override void Map()
        {
            HasRequired(c => c.Author).WithMany(c => c.Comments).HasForeignKey(c => c.AuthorId);
        }
    }
}