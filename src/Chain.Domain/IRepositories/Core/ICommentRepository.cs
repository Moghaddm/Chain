using Chain.Domain.Entities.Core;

namespace Chain.Domain.IRepositories.Core;
public interface ICommentRepository : IRepository<Comment>
{
    ValueTask<long> AddComment(int productId, Comment comment);
    ValueTask<long> RemoveComment(int commentId);
    ValueTask<List<Comment>> GetProductComments(int productId);
}