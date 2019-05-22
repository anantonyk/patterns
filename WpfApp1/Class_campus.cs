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
    class Class_campus:strategy, chain_intarface
    {
        public bool check_value(int a)
        {
            List<int> id = (from caampus in strategy.db.campus
                            where caampus.id_cam == a
                            select caampus.id_cam
             ).ToList();
            if (id.Count() != 0) return true;
            MessageBox.Show("введи норм дані, баран");
            return false;
        }
        public void show(ref DataGrid dataGrid)
        {
            dataGrid.ItemsSource = (from campu in strategy.db.campus
                                    select new
                                    {
                                        campus = campu.id_cam,
                                        adress=campu.address_cam
                                    }).ToList();
        }
    }
}
