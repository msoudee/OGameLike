using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OGameLikeBO
{
    public class SystemeSolaire : IDbEntity
    {
        public long? Id => throw new NotImplementedException();

        [StringLength(20, MinimumLength = 5)]
        public string Nom { get; set; }

        [NotMapped]
        public virtual List<Planete> Planetes { get; set; }
    }
}
