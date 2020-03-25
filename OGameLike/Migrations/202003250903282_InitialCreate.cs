namespace OGameLike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Batiments",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nom = c.String(),
                        niveau = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Planete_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Planetes", t => t.Planete_Id)
                .Index(t => t.Planete_Id);
            
            CreateTable(
                "dbo.Planetes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        CaseNb = c.Int(),
                        SystemeSolaire_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SystemeSolaires", t => t.SystemeSolaire_Id)
                .Index(t => t.SystemeSolaire_Id);
            
            CreateTable(
                "dbo.Ressources",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nom = c.String(),
                        DerniereQuantite = c.Int(),
                        DerniereMAJ = c.DateTime(nullable: false),
                        Planete_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Planetes", t => t.Planete_Id)
                .Index(t => t.Planete_Id);
            
            CreateTable(
                "dbo.SystemeSolaires",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Planetes", "SystemeSolaire_Id", "dbo.SystemeSolaires");
            DropForeignKey("dbo.Ressources", "Planete_Id", "dbo.Planetes");
            DropForeignKey("dbo.Batiments", "Planete_Id", "dbo.Planetes");
            DropIndex("dbo.Ressources", new[] { "Planete_Id" });
            DropIndex("dbo.Planetes", new[] { "SystemeSolaire_Id" });
            DropIndex("dbo.Batiments", new[] { "Planete_Id" });
            DropTable("dbo.SystemeSolaires");
            DropTable("dbo.Ressources");
            DropTable("dbo.Planetes");
            DropTable("dbo.Batiments");
        }
    }
}
