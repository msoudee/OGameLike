using System.ComponentModel.DataAnnotations;

namespace OGameLikeBO
{
    public interface IDbEntity
    {
        long? Id { get; }
    }
}
