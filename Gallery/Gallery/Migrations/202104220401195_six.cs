namespace Gallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class six : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Artist", "BirthYear", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Artist", "DeathYear", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Artist", "DeathYear", c => c.Int(nullable: false));
            AlterColumn("dbo.Artist", "BirthYear", c => c.Int(nullable: false));
        }
    }
}
