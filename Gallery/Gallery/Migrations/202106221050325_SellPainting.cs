namespace Gallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SellPainting : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SellPainting", "SellId", "dbo.Sell");
            DropIndex("dbo.SellPainting", new[] { "SellId" });
            RenameColumn(table: "dbo.SellPainting", name: "SellId", newName: "Sell_Id");
            AlterColumn("dbo.SellPainting", "Sell_Id", c => c.Int());
            CreateIndex("dbo.SellPainting", "Sell_Id");
            AddForeignKey("dbo.SellPainting", "Sell_Id", "dbo.Sell", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SellPainting", "Sell_Id", "dbo.Sell");
            DropIndex("dbo.SellPainting", new[] { "Sell_Id" });
            AlterColumn("dbo.SellPainting", "Sell_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.SellPainting", name: "Sell_Id", newName: "SellId");
            CreateIndex("dbo.SellPainting", "SellId");
            AddForeignKey("dbo.SellPainting", "SellId", "dbo.Sell", "Id", cascadeDelete: true);
        }
    }
}
