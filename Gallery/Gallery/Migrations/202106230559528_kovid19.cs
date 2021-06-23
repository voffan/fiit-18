namespace Gallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kovid19 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Sell", "SellPainting_Id", "dbo.SellPainting");
            DropIndex("dbo.Sell", new[] { "SellPainting_Id" });
            DropColumn("dbo.Sell", "SellPainting_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sell", "SellPainting_Id", c => c.Int());
            CreateIndex("dbo.Sell", "SellPainting_Id");
            AddForeignKey("dbo.Sell", "SellPainting_Id", "dbo.SellPainting", "Id");
        }
    }
}
