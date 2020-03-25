using System.Collections.Generic;

namespace OGameLikeBO
{
    public class SystemeSolaire : IDbEntity
    {
        public string Name { get; set; }
        public virtual List<Planete> Planetes { get; set; }
    }
}
