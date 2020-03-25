using System.ComponentModel.DataAnnotations;

namespace OGameLikeBO
{
    public abstract class IDbEntity
    {
        public long Id { get; }
    }
}
