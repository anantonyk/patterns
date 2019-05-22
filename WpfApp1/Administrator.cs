using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Administrator
    {
        public string name_admin;
        public static Administrator nastia;

        private Administrator() {

            name_admin = "nastia antonyk";
        }
        public static Administrator Admin()
        {
            if (nastia == null)
            {
                nastia = new Administrator();
            }
            return nastia;
        }
    }
}
