using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OGameLikeBO
{
    public class Planete : IDbEntity
    {
        public long? Id => throw new NotImplementedException();

        [StringLength(20, MinimumLength = 5)]
        public string Nom { get; set; }

        [Range(0, Int32.MaxValue)]
        public int? CaseNb { get; set; }

        [ValiditeListeRessources(ErrorMessage = "Une planete ne peut avoir que 4 types de ressources différentes : Énergie, Oxygène, Acier et Uranium")]
        public virtual List<Ressource> Ressources { get; set; }

        public virtual List<Batiment> Batiments{ get; set; }

        
    }

    class ValiditeListeRessources : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var valid = true;

            var list = value as IList;
            if (list == null || list.Count > 4)
            {
                valid = false;
            }
            return valid;
        }
    }
}
