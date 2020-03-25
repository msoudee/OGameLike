using System.Collections.Generic;

namespace OGameLikeBO
{
    public class Planete : IDbEntity
    {
        public string Name { get; set; }
        public int? CaseNb { get; set; }
        public virtual List<Ressource> Ressources { get; set; }
        public virtual List<Batiment> Batiments{ get; set; }
    }
}
