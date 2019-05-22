using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1
{
    class Lector : Table
    {
        public lecturer lecturer;
        public override void AddToDataBase() {
            strategy.db.lecturers.Add(lecturer);
            strategy.db.SaveChanges();
        }
        public override Table CreateNew(String first, String second, String third, String four)
        {
            Lector l = new Lector();
            l.lecturer = new lecturer();
            l.lecturer.id_lecturer = Convert.ToInt32(first);
            l.lecturer.lect_name = second;
            l.lecturer.position = third;
            l.lecturer.kaf_lec = Convert.ToInt32(four);
            return l;
            //strategy.db.lecturers.Add(lecturer);
            //strategy.db.SaveChanges();
            
        }

    }
}
