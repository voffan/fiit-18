namespace Gallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customerasd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Person", "Position", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Person", "Position", c => c.Int(nullable: false));
        }
    }
}
