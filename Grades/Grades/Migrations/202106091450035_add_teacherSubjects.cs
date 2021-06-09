namespace Grades.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_teacherSubjects : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TeacherSubjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(),
                        SubjectId = c.Int(),
                        ClassId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Class", t => t.ClassId)
                .ForeignKey("dbo.Employee", t => t.EmployeeId)
                .ForeignKey("dbo.Subject", t => t.SubjectId)
                .Index(t => t.EmployeeId)
                .Index(t => t.SubjectId)
                .Index(t => t.ClassId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeacherSubjects", "SubjectId", "dbo.Subject");
            DropForeignKey("dbo.TeacherSubjects", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.TeacherSubjects", "ClassId", "dbo.Class");
            DropIndex("dbo.TeacherSubjects", new[] { "ClassId" });
            DropIndex("dbo.TeacherSubjects", new[] { "SubjectId" });
            DropIndex("dbo.TeacherSubjects", new[] { "EmployeeId" });
            DropTable("dbo.TeacherSubjects");
        }
    }
}
