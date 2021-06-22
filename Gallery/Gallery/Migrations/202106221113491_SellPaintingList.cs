namespace Gallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SellPaintingList : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SellPainting", "Sell_Id", "dbo.Sell");
            DropIndex("dbo.SellPainting", new[] { "Sell_Id" });
            AddColumn("dbo.Sell", "SellPainting_Id", c => c.Int());
            CreateIndex("dbo.Sell", "SellPainting_Id");
            AddForeignKey("dbo.Sell", "SellPainting_Id", "dbo.SellPainting", "Id");
            DropColumn("dbo.SellPainting", "Sell_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SellPainting", "Sell_Id", c => c.Int());
            DropForeignKey("dbo.Sell", "SellPainting_Id", "dbo.SellPainting");
            DropIndex("dbo.Sell", new[] { "SellPainting_Id" });
            DropColumn("dbo.Sell", "SellPainting_Id");
            CreateIndex("dbo.SellPainting", "Sell_Id");
            AddForeignKey("dbo.SellPainting", "Sell_Id", "dbo.Sell", "Id");
        }
    }
}
