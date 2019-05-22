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
    class Class_group : strategy,chain_intarface
    {
        public bool check_value(int a)
        {
            List<int> id = (from groupp in strategy.db.groups
                            where groupp.id_gr == a
                            select groupp.id_gr
             ).ToList();
            if (id.Count() != 0) return true;
            MessageBox.Show("некоректні дані");
            return false;
        }
        public void show(ref DataGrid dataGrid)
        {
            dataGrid.ItemsSource = (from group1 in strategy.db.groups
                                    select new
                                    {
                                        id = group1.id_gr,
                                        group_name = group1.group_name,
                                        students= group1.st_counts,
                                        id_flow = group1.id_fl
                                    }).ToList();
        }
    }
}
