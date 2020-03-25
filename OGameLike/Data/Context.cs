using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OGameLike.Data
{
    public class Context : DbContext
    {    
        public Context() : base("name=Context")
        {
        }

        public System.Data.Entity.DbSet<OGameLikeBO.SystemeSolaire> SystemeSolaires { get; set; }

        public System.Data.Entity.DbSet<OGameLikeBO.Planete> Planetes { get; set; }

        public System.Data.Entity.DbSet<OGameLikeBO.Ressource> Ressources { get; set; }

        public System.Data.Entity.DbSet<OGameLikeBO.Batiment> Batiments { get; set; }
    }
}
