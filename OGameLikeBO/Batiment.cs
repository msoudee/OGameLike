using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGameLikeBO
{
    public abstract class Batiment : IDbEntity
    {
        public string Nom { get; set; }
        public int? niveau { get; set; }

        public int? NumeroCellule()
        {
            return 0;
        }

        public List<Ressource> coutTotal()
        {
            return null;
        }

        public List<Ressource> CoutSuivant()
        {
            return null;
        }
    }
}
