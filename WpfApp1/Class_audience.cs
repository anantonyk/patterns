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
   public class Class_audience: strategy, chain_intarface
    {
        //audience audience;
        public bool check_value(int a)
        {
            List<int> id = (from aaudience in strategy.db.audiences
                      where aaudience.id_audience == a
                      select  aaudience.id_audience
             ).ToList();
            if (id.Count()!=0) return true;
            MessageBox.Show("некоректні дані");
            return false;
        } 

       public void show(ref DataGrid dataGrid)
        {
            dataGrid.ItemsSource = (from audience in strategy.db.audiences
                                    select new
                                    {
                                        id = audience.id_audience,
                                        num = audience.audience_number,
                                        coun = audience.count_st
                                    }).ToList();
        }
    }
}
