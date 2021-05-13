using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class CourseLogic
    {
       public static void AddCourse(int SubjectId, int ClassId, int GroupId, int EmployeeId,  Context db)
        {
            Course epl = new Course();
            epl.SubjectId = SubjectId;
            epl.ClassId = ClassId;
            epl.GroupId = GroupId;
            epl.EmployeeId = EmployeeId;
            db.Courses.Add(epl);
            db.SaveChanges();
        }

        public static void DeleteCourse(Context db, int id)
        {
            Course epl = db.Courses.Where(e => e.Id == id).FirstOrDefault();
            db.Courses.Remove(epl);
            db.SaveChanges();
        }
    }
}
