using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OGameLikeBO
{
    public class SystemeSolaire : IDbEntity
    {
        [StringLength(20, MinimumLength = 5)]
        public string Nom { get; set; }

        public virtual List<Planete> Planetes { get; set; }
    }
}
