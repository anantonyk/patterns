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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }



        //pattern strategy
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tablename.Text == "audience")
            {
                Class_audience a = new Class_audience();
                a.show(ref myGrid);
            }
            else if (tablename.Text == "campus")
            {
                Class_campus a = new Class_campus();
                a.show(ref myGrid);
            }
            else if (tablename.Text == "groups")
            {
                Class_group a = new Class_group();
                a.show(ref myGrid);
            }
            else if (tablename.Text == "flow")
            {
                Class_flow a = new Class_flow();
                a.show(ref myGrid);
            }
            else if (tablename.Text == "lecturer")
            {
                Class_lecturer a = new Class_lecturer();
                a.show(ref myGrid);
            }
            else if (tablename.Text == "kafedra")
            {
                Class_kafedra a = new Class_kafedra();
                a.show(ref myGrid);
            }
            else if (tablename.Text == "subjects")
            {
                Class_subject a = new Class_subject();
                a.show(ref myGrid);
            }
            else if (tablename.Text == "shchedule")
            {
                Class_shchedule a = new Class_shchedule();
                a.show(ref myGrid);
            }
            else
            {
                txt.Text = "not valid name";
            }
        }


        //patern singleton
       Administrator administrator = Administrator.Admin();
        private void ButtonClickAdmin(object sender, RoutedEventArgs e)
        {
            
            if (administrator==Administrator.nastia)
            {
                txtAdmin.Text = "it`s an admin named nastia antonyk";
            }
            else
            {
                txtAdmin.Text = "it`s an error with administrator";
            }
        }


        //pattern chain of responsibility
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (administrator == Administrator.nastia)
            {
                if (audience_text.Text != "")
                {
                    Class_audience class_Audience = new Class_audience();
                    if (!class_Audience.check_value(Convert.ToInt32(audience_text.Text)))
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("некоректні дані");
                    return;
                }

                if (campus_text.Text != "")
                {
                    Class_campus class_Campus = new Class_campus();
                    if (!class_Campus.check_value(Convert.ToInt32(campus_text.Text))) return;
                }
                else
                {
                    MessageBox.Show("некоректні дані");
                    return;
                }
                if (lecturer_text.Text != "")
                {
                    Class_lecturer class_Lecturer = new Class_lecturer();
                    if (!class_Lecturer.check_value(Convert.ToInt32(lecturer_text.Text))) return;
                }
                else
                {
                    MessageBox.Show("некоректні дані");
                    return;
                }
                if (subject_text.Text != "")
                {
                    Class_subject class_Subject = new Class_subject();
                    if (!class_Subject.check_value(Convert.ToInt32(subject_text.Text))) return;
                }
                else
                {
                    MessageBox.Show("некоректні дані");
                    return;
                }
                if (group_text.Text != "")
                {
                    Class_group class_Group = new Class_group();
                    if (!class_Group.check_value(Convert.ToInt32(group_text.Text))) return;
                }
                else
                {
                    MessageBox.Show("некоректні дані");
                    return;
                }
                if (pair_text.Text == "" || day_text.Text == "")
                {
                    MessageBox.Show("некоректні дані");
                    return;
                }
                
   
                Class_shchedule a = new Class_shchedule();
                    a.adding(audience_text, campus_text, lecturer_text, subject_text, group_text, pair_text, day_text);

            }

        }
        //pattern state
        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Class_lecturer a = new Class_lecturer();
             btn.Background = Brushes.Blue;
            bool b= a.check_this(txtlecc.Text);
            if (b)
            {
                Context context = new Context(new state_positive());
                context.Request1(txtlecID);
            }
            else
            {
                Context contextt = new Context(new state_negative());
                contextt.Request2(txtlecID);
            }
            txtlecID.Text = b.ToString();
        }
        //pattern factory method
        private void Button_to_group(object sender, RoutedEventArgs e)
        {
            Groupa groupa =new Groupa();
            var g=groupa.CreateNew(first.Text, second.Text, third.Text, four.Text);
            g.AddToDataBase();
        }

        private void Button_to_lecturer(object sender, RoutedEventArgs e)
        {
//            Lector lector = new Lector();
            var l = new Lector().CreateNew(first.Text, second.Text, third.Text, four.Text);
            l.AddToDataBase();
        }
    }   
}
