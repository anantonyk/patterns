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
    class Class_subject : strategy,chain_intarface
    {

        public bool check_value(int a)
        {
            List<int> id = (from suubject in strategy.db.subjects
                            where suubject.id_sub == a
                            select suubject.id_sub
             ).ToList();
            if (id.Count() != 0) return true;
            MessageBox.Show("введи норм дані, баран");
            return false;
        }
        public void show(ref DataGrid dataGrid)
        {
            dataGrid.ItemsSource = (from subject1 in strategy.db.subjects
                                    select new
                                    {
                                        id = subject1.id_sub,
                                        subject_name = subject1.sub_name,
                                        kafedra = subject1.sab_kaf
                                    }).ToList();
        }
    }
}
