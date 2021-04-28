namespace Gallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seven : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Artist", "BirthYear", c => c.String());
            AlterColumn("dbo.Artist", "DeathYear", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Artist", "DeathYear", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Artist", "BirthYear", c => c.DateTime(nullable: false));
        }
    }
}
