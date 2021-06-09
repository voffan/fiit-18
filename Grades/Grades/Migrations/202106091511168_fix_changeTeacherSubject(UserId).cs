namespace Grades.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix_changeTeacherSubjectUserId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TeacherSubjects", "EmployeeId", "dbo.Employee");
            DropIndex("dbo.TeacherSubjects", new[] { "EmployeeId" });
            AddColumn("dbo.TeacherSubjects", "UserId", c => c.Int());
            CreateIndex("dbo.TeacherSubjects", "UserId");
            AddForeignKey("dbo.TeacherSubjects", "UserId", "dbo.User", "Id");
            DropColumn("dbo.TeacherSubjects", "EmployeeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TeacherSubjects", "EmployeeId", c => c.Int());
            DropForeignKey("dbo.TeacherSubjects", "UserId", "dbo.User");
            DropIndex("dbo.TeacherSubjects", new[] { "UserId" });
            DropColumn("dbo.TeacherSubjects", "UserId");
            CreateIndex("dbo.TeacherSubjects", "EmployeeId");
            AddForeignKey("dbo.TeacherSubjects", "EmployeeId", "dbo.Employee", "Id");
        }
    }
}
