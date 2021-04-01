namespace Grades.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employee", "Phone", c => c.String(maxLength: 12));
            AlterColumn("dbo.School", "Phone", c => c.String());
            AlterColumn("dbo.Student", "Phone", c => c.String(maxLength: 12));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Student", "Phone", c => c.Int(nullable: false));
            AlterColumn("dbo.School", "Phone", c => c.Int(nullable: false));
            AlterColumn("dbo.Employee", "Phone", c => c.Int(nullable: false));
        }
    }
}
