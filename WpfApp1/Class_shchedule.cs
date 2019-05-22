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
    class Class_shchedule : strategy
    {
        public void show(ref DataGrid dataGrid)
        {
            dataGrid.ItemsSource = (from shchedule in strategy.db.shchedules
                                    select new
                                    {
                                        day = shchedule.day_week,
                                        pair = shchedule.pair_num,
                                        group_id = shchedule.id_group,
                                        subject_id=shchedule.id_subject,
                                        lecturer_id=shchedule.id_lecturer,
                                        campus_id=shchedule.id_campus,
                                        audience_id=shchedule.id_audience,
                                    }).ToList();
        }

        public void adding(TextBox audience_text, TextBox campus_text, TextBox lecturer_text, TextBox subject_text, TextBox group_text, TextBox pair_text, TextBox day_text)
        {
            shchedule shchedule = new shchedule();
            shchedule.id_audience = Convert.ToInt32(audience_text.Text);
            shchedule.id_campus = Convert.ToInt32(campus_text.Text);
            shchedule.id_lecturer = Convert.ToInt32(lecturer_text.Text);
            shchedule.id_subject = Convert.ToInt32(subject_text.Text);
            shchedule.id_group = Convert.ToInt32(group_text.Text);
            shchedule.pair_num = Convert.ToInt32(pair_text.Text);
            shchedule.day_week = day_text.Text;
            strategy.db.shchedules.Add(shchedule);
            strategy.db.SaveChanges();
        }
    }
}
