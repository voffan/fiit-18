namespace Gallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fifth : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Journal",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmpId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        SrcId = c.Int(),
                        DstId = c.Int(),
                        ExhId = c.Int(),
                        PaintingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departament", t => t.DstId)
                .ForeignKey("dbo.Person", t => t.EmpId, cascadeDelete: true)
                .ForeignKey("dbo.Exhibition", t => t.ExhId)
                .ForeignKey("dbo.Painting", t => t.PaintingId, cascadeDelete: true)
                .ForeignKey("dbo.Departament", t => t.SrcId)
                .Index(t => t.EmpId)
                .Index(t => t.SrcId)
                .Index(t => t.DstId)
                .Index(t => t.ExhId)
                .Index(t => t.PaintingId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Journal", "SrcId", "dbo.Departament");
            DropForeignKey("dbo.Journal", "PaintingId", "dbo.Painting");
            DropForeignKey("dbo.Journal", "ExhId", "dbo.Exhibition");
            DropForeignKey("dbo.Journal", "EmpId", "dbo.Person");
            DropForeignKey("dbo.Journal", "DstId", "dbo.Departament");
            DropIndex("dbo.Journal", new[] { "PaintingId" });
            DropIndex("dbo.Journal", new[] { "ExhId" });
            DropIndex("dbo.Journal", new[] { "DstId" });
            DropIndex("dbo.Journal", new[] { "SrcId" });
            DropIndex("dbo.Journal", new[] { "EmpId" });
            DropTable("dbo.Journal");
        }
    }
}
