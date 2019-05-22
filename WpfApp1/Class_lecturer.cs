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
    class Class_lecturer : strategy, chain_intarface
    {
        public bool check_value(int a)
        {
            List<int> id = (from leecturer in strategy.db.lecturers
                            where leecturer.id_lecturer == a
                            select leecturer.id_lecturer
             ).ToList();
            if (id.Count() != 0) return true;
            MessageBox.Show("введи норм дані, баран");
            return false;
        }
        public void show(ref DataGrid dataGrid)
        {
            dataGrid.ItemsSource = (from lecturer in strategy.db.lecturers
                                    select new
                                    {
                                        id=  lecturer.id_lecturer,
                                        lecturer_name = lecturer.lect_name,
                                        position = lecturer.position,
                                        kafedra=lecturer.kaf_lec
                                    }).ToList();
        }

        public bool check_this(string a)
        {
            List<int> id = (from leecturer in strategy.db.lecturers
                            where leecturer.lect_name == a
                            select leecturer.id_lecturer
             ).ToList();
            if (id.Count() != 0) return true;
            return false;
        }
    }

}
