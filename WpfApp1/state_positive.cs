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
    public class state_positive : state_abstract
    {
        public override bool state1(TextBox textBox)
        {
            textBox.Background = Brushes.Green;
            return true;

        }
        public override bool state2(TextBox textBox)
        {
            throw new NotSupportedException();
        }
    }
}
