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
    public class Context
    {
        private state_abstract _state = null;

        public Context(state_abstract state)
        {
            this._state = state;
            this._state.SetContext(this);
        }
        public void Request1(TextBox box)
        {
            this._state.state1(box);
        }

        public void Request2(TextBox box)
        {
            this._state.state2(box);
        }

    }
}

