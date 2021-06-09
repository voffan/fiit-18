namespace Grades.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class five : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TeacherMarksTable",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(),
                        CheckPointId = c.Int(),
                        SubjectId = c.Int(),
                        MarkId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CheckPoint", t => t.CheckPointId)
                .ForeignKey("dbo.Mark", t => t.MarkId)
                .ForeignKey("dbo.Student", t => t.StudentId)
                .ForeignKey("dbo.Subject", t => t.SubjectId)
                .Index(t => t.StudentId)
                .Index(t => t.CheckPointId)
                .Index(t => t.SubjectId)
                .Index(t => t.MarkId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeacherMarksTable", "SubjectId", "dbo.Subject");
            DropForeignKey("dbo.TeacherMarksTable", "StudentId", "dbo.Student");
            DropForeignKey("dbo.TeacherMarksTable", "MarkId", "dbo.Mark");
            DropForeignKey("dbo.TeacherMarksTable", "CheckPointId", "dbo.CheckPoint");
            DropIndex("dbo.TeacherMarksTable", new[] { "MarkId" });
            DropIndex("dbo.TeacherMarksTable", new[] { "SubjectId" });
            DropIndex("dbo.TeacherMarksTable", new[] { "CheckPointId" });
            DropIndex("dbo.TeacherMarksTable", new[] { "StudentId" });
            DropTable("dbo.TeacherMarksTable");
        }
    }
}
