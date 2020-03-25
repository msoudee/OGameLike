using System;

namespace OGameLikeBO
{
    public class Ressource : IDbEntity
    {
        public string Nom { get; set; }
        public int? DerniereQuantite { get; set; }
        public DateTime DerniereMAJ { get; set; }
    }
}