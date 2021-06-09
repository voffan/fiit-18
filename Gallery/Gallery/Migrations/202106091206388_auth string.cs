namespace Gallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class authstring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Auth", "Password", c => c.String(maxLength: 16));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Auth", "Password", c => c.Binary(maxLength: 16));
        }
    }
}
