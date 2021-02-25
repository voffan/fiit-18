namespace Grades.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AcademicYear",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Start = c.DateTime(nullable: false),
                        End = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Table",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(),
                        AcademicYearId = c.Int(),
                        CheckPointId = c.Int(),
                        CourseId = c.Int(),
                        MarkId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AcademicYear", t => t.AcademicYearId)
                .ForeignKey("dbo.CheckPoint", t => t.CheckPointId)
                .ForeignKey("dbo.Student", t => t.StudentId)
                .ForeignKey("dbo.Course", t => t.CourseId)
                .ForeignKey("dbo.Mark", t => t.MarkId)
                .Index(t => t.StudentId)
                .Index(t => t.AcademicYearId)
                .Index(t => t.CheckPointId)
                .Index(t => t.CourseId)
                .Index(t => t.MarkId);
            
            CreateTable(
                "dbo.CheckPoint",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubjectId = c.Int(),
                        ClassId = c.Int(),
                        GroupId = c.Int(),
                        EmployeeId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employee", t => t.EmployeeId)
                .ForeignKey("dbo.Class", t => t.ClassId)
                .ForeignKey("dbo.Group", t => t.GroupId)
                .ForeignKey("dbo.Subject", t => t.SubjectId)
                .Index(t => t.SubjectId)
                .Index(t => t.ClassId)
                .Index(t => t.GroupId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Class",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Year = c.Int(),
                        SchoolId = c.Int(),
                        EmployeeId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employee", t => t.EmployeeId)
                .ForeignKey("dbo.School", t => t.SchoolId)
                .Index(t => t.SchoolId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Surname = c.String(maxLength: 50),
                        Name = c.String(maxLength: 50),
                        MiddleName = c.String(maxLength: 50),
                        DateOfBirth = c.DateTime(nullable: false),
                        Address = c.String(maxLength: 255),
                        Phone = c.Int(nullable: false),
                        PositionId = c.Int(),
                        SchoolId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Position", t => t.PositionId)
                .ForeignKey("dbo.School", t => t.SchoolId)
                .Index(t => t.PositionId)
                .Index(t => t.SchoolId);
            
            CreateTable(
                "dbo.Position",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.School",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Address = c.String(maxLength: 50),
                        Email = c.String(maxLength: 255),
                        Phone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Surname = c.String(maxLength: 50),
                        Name = c.String(maxLength: 50),
                        MiddleName = c.String(maxLength: 50),
                        DateOfBirth = c.DateTime(nullable: false),
                        Address = c.String(maxLength: 255),
                        Phone = c.Int(nullable: false),
                        ClassId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Class", t => t.ClassId)
                .Index(t => t.ClassId);
            
            CreateTable(
                "dbo.Group",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        SubjectId = c.Int(),
                        ClassId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Class", t => t.ClassId)
                .ForeignKey("dbo.Subject", t => t.SubjectId)
                .Index(t => t.SubjectId)
                .Index(t => t.ClassId);
            
            CreateTable(
                "dbo.Subject",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Mark",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GroupStudent",
                c => new
                    {
                        Group_Id = c.Int(nullable: false),
                        Student_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Group_Id, t.Student_Id })
                .ForeignKey("dbo.Group", t => t.Group_Id, cascadeDelete: true)
                .ForeignKey("dbo.Student", t => t.Student_Id, cascadeDelete: true)
                .Index(t => t.Group_Id)
                .Index(t => t.Student_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Table", "MarkId", "dbo.Mark");
            DropForeignKey("dbo.Table", "CourseId", "dbo.Course");
            DropForeignKey("dbo.Course", "SubjectId", "dbo.Subject");
            DropForeignKey("dbo.Course", "GroupId", "dbo.Group");
            DropForeignKey("dbo.Course", "ClassId", "dbo.Class");
            DropForeignKey("dbo.Table", "StudentId", "dbo.Student");
            DropForeignKey("dbo.Group", "SubjectId", "dbo.Subject");
            DropForeignKey("dbo.GroupStudent", "Student_Id", "dbo.Student");
            DropForeignKey("dbo.GroupStudent", "Group_Id", "dbo.Group");
            DropForeignKey("dbo.Group", "ClassId", "dbo.Class");
            DropForeignKey("dbo.Student", "ClassId", "dbo.Class");
            DropForeignKey("dbo.Employee", "SchoolId", "dbo.School");
            DropForeignKey("dbo.Class", "SchoolId", "dbo.School");
            DropForeignKey("dbo.Employee", "PositionId", "dbo.Position");
            DropForeignKey("dbo.Course", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.Class", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.Table", "CheckPointId", "dbo.CheckPoint");
            DropForeignKey("dbo.Table", "AcademicYearId", "dbo.AcademicYear");
            DropIndex("dbo.GroupStudent", new[] { "Student_Id" });
            DropIndex("dbo.GroupStudent", new[] { "Group_Id" });
            DropIndex("dbo.Group", new[] { "ClassId" });
            DropIndex("dbo.Group", new[] { "SubjectId" });
            DropIndex("dbo.Student", new[] { "ClassId" });
            DropIndex("dbo.Employee", new[] { "SchoolId" });
            DropIndex("dbo.Employee", new[] { "PositionId" });
            DropIndex("dbo.Class", new[] { "EmployeeId" });
            DropIndex("dbo.Class", new[] { "SchoolId" });
            DropIndex("dbo.Course", new[] { "EmployeeId" });
            DropIndex("dbo.Course", new[] { "GroupId" });
            DropIndex("dbo.Course", new[] { "ClassId" });
            DropIndex("dbo.Course", new[] { "SubjectId" });
            DropIndex("dbo.Table", new[] { "MarkId" });
            DropIndex("dbo.Table", new[] { "CourseId" });
            DropIndex("dbo.Table", new[] { "CheckPointId" });
            DropIndex("dbo.Table", new[] { "AcademicYearId" });
            DropIndex("dbo.Table", new[] { "StudentId" });
            DropTable("dbo.GroupStudent");
            DropTable("dbo.Mark");
            DropTable("dbo.Subject");
            DropTable("dbo.Group");
            DropTable("dbo.Student");
            DropTable("dbo.School");
            DropTable("dbo.Position");
            DropTable("dbo.Employee");
            DropTable("dbo.Class");
            DropTable("dbo.Course");
            DropTable("dbo.CheckPoint");
            DropTable("dbo.Table");
            DropTable("dbo.AcademicYear");
        }
    }
}
