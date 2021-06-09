namespace Gallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class authkey : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Auth");
            AlterColumn("dbo.Auth", "Login", c => c.String());
            AlterColumn("dbo.Auth", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Auth", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Auth");
            AlterColumn("dbo.Auth", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Auth", "Login", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Auth", "Login");
        }
    }
}
