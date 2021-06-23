namespace Gallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kovid20 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sell", "SPId", c => c.Int(nullable: false));
            CreateIndex("dbo.Sell", "SPId");
            AddForeignKey("dbo.Sell", "SPId", "dbo.SellPainting", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sell", "SPId", "dbo.SellPainting");
            DropIndex("dbo.Sell", new[] { "SPId" });
            DropColumn("dbo.Sell", "SPId");
        }
    }
}
