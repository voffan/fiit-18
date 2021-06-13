namespace Gallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Artist",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Surname = c.String(maxLength: 255),
                        Name = c.String(maxLength: 255),
                        Middle_Name = c.String(maxLength: 255),
                        BirthYear = c.String(),
                        DeathYear = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Painting",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GenreId = c.Int(nullable: false),
                        ExhibitionId = c.Int(),
                        NamePainting = c.String(),
                        ArtistId = c.Int(nullable: false),
                        PaintingStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Artist", t => t.ArtistId, cascadeDelete: true)
                .ForeignKey("dbo.Exhibition", t => t.ExhibitionId)
                .ForeignKey("dbo.Genre", t => t.GenreId, cascadeDelete: true)
                .Index(t => t.GenreId)
                .Index(t => t.ExhibitionId)
                .Index(t => t.ArtistId);
            
            CreateTable(
                "dbo.Exhibition",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameExhibition = c.String(),
                        CountryId = c.Int(nullable: false),
                        City = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Country", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Country",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Genre",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameGenre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Auth",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(maxLength: 16),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Person", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Surname = c.String(maxLength: 255),
                        Name = c.String(maxLength: 255),
                        Middle_Name = c.String(maxLength: 255),
                        Passport_id = c.Int(nullable: false),
                        Passport_series = c.Int(nullable: false),
                        Phone = c.String(maxLength: 100),
                        Position = c.Int(),
                        DepId = c.Int(),
                        Status = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departament", t => t.DepId, cascadeDelete: true)
                .Index(t => t.DepId);
            
            CreateTable(
                "dbo.Departament",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sell",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Long(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Person", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.SellPainting",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SellId = c.Int(nullable: false),
                        PaintingId = c.Int(nullable: false),
                        Cost = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Painting", t => t.PaintingId, cascadeDelete: true)
                .ForeignKey("dbo.Sell", t => t.SellId, cascadeDelete: true)
                .Index(t => t.SellId)
                .Index(t => t.PaintingId);
            
            CreateTable(
                "dbo.Journal",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmpId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        SrcId = c.Int(),
                        ExhId = c.Int(),
                        PaintingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Person", t => t.EmpId, cascadeDelete: true)
                .ForeignKey("dbo.Exhibition", t => t.ExhId)
                .ForeignKey("dbo.Painting", t => t.PaintingId, cascadeDelete: true)
                .ForeignKey("dbo.Departament", t => t.SrcId)
                .Index(t => t.EmpId)
                .Index(t => t.SrcId)
                .Index(t => t.ExhId)
                .Index(t => t.PaintingId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Journal", "SrcId", "dbo.Departament");
            DropForeignKey("dbo.Journal", "PaintingId", "dbo.Painting");
            DropForeignKey("dbo.Journal", "ExhId", "dbo.Exhibition");
            DropForeignKey("dbo.Journal", "EmpId", "dbo.Person");
            DropForeignKey("dbo.SellPainting", "SellId", "dbo.Sell");
            DropForeignKey("dbo.SellPainting", "PaintingId", "dbo.Painting");
            DropForeignKey("dbo.Sell", "CustomerId", "dbo.Person");
            DropForeignKey("dbo.Auth", "EmployeeId", "dbo.Person");
            DropForeignKey("dbo.Person", "DepId", "dbo.Departament");
            DropForeignKey("dbo.Painting", "GenreId", "dbo.Genre");
            DropForeignKey("dbo.Painting", "ExhibitionId", "dbo.Exhibition");
            DropForeignKey("dbo.Exhibition", "CountryId", "dbo.Country");
            DropForeignKey("dbo.Painting", "ArtistId", "dbo.Artist");
            DropIndex("dbo.Journal", new[] { "PaintingId" });
            DropIndex("dbo.Journal", new[] { "ExhId" });
            DropIndex("dbo.Journal", new[] { "SrcId" });
            DropIndex("dbo.Journal", new[] { "EmpId" });
            DropIndex("dbo.SellPainting", new[] { "PaintingId" });
            DropIndex("dbo.SellPainting", new[] { "SellId" });
            DropIndex("dbo.Sell", new[] { "CustomerId" });
            DropIndex("dbo.Person", new[] { "DepId" });
            DropIndex("dbo.Auth", new[] { "EmployeeId" });
            DropIndex("dbo.Exhibition", new[] { "CountryId" });
            DropIndex("dbo.Painting", new[] { "ArtistId" });
            DropIndex("dbo.Painting", new[] { "ExhibitionId" });
            DropIndex("dbo.Painting", new[] { "GenreId" });
            DropTable("dbo.Journal");
            DropTable("dbo.SellPainting");
            DropTable("dbo.Sell");
            DropTable("dbo.Departament");
            DropTable("dbo.Person");
            DropTable("dbo.Auth");
            DropTable("dbo.Genre");
            DropTable("dbo.Country");
            DropTable("dbo.Exhibition");
            DropTable("dbo.Painting");
            DropTable("dbo.Artist");
        }
    }
}
