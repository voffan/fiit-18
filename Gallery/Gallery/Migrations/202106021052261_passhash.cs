namespace Gallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class passhash : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Auth", "Password", c => c.Binary());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Auth", "Password", c => c.String());
        }
    }
}
