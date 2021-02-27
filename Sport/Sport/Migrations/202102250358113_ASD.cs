namespace Sport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ASD : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Competition",
                c => new
                    {
                        SportKind = c.String(nullable: false, maxLength: 128),
                        Level = c.String(),
                        Place = c.String(),
                        OpenDate = c.DateTime(nullable: false),
                        CloseDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SportKind);
            
            CreateTable(
                "dbo.Results",
                c => new
                    {
                        SportKind = c.String(nullable: false, maxLength: 128),
                        Place = c.String(),
                        Sportsman = c.String(),
                        Result = c.Single(nullable: false),
                        Competition_SportKind = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.SportKind)
                .ForeignKey("dbo.Competition", t => t.Competition_SportKind)
                .Index(t => t.Competition_SportKind);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Results", "Competition_SportKind", "dbo.Competition");
            DropIndex("dbo.Results", new[] { "Competition_SportKind" });
            DropTable("dbo.Results");
            DropTable("dbo.Competition");
        }
    }
}
