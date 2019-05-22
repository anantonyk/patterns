using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace WpfApp1
{
    class Groupa: Table
    {
        
        group group;
        public override void AddToDataBase()
        {
            strategy.db.groups.Add(group);
            strategy.db.SaveChanges();
        }
        public override Table CreateNew(String first, String second, String third, String four)
        {
            Groupa g = new Groupa();
            g.group = new group();
            g.group.id_gr = Convert.ToInt32(first);
            g.group.group_name = second;
            g.group.st_counts = Convert.ToInt32(third);
            g.group.id_fl = Convert.ToInt32(four);
            return g;
            
        }

       
    }

}
