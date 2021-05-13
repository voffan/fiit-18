using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GroupLogic
    {
        public static void AddGroup( string Name,int SubjectId, int ClassId, Context db)
        {
            Group epl = new Group();
            epl.Name = Name;
            epl.SubjectId = SubjectId;
            epl.ClassId = ClassId;
            db.Groups.Add(epl);
            db.SaveChanges();
        }

        public static void DeleteGroup(Context db, int id)
        {
            Group epl = db.Groups.Where(e => e.Id == id).FirstOrDefault();
            db.Groups.Remove(epl);
            db.SaveChanges();
        }
    }
}
