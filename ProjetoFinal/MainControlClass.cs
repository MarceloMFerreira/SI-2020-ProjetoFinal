using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    class MainControlClass
    {
        public static void showControl(System.Windows.Forms.Control control, System.Windows.Forms.Control panel2)
        {
            panel2.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            panel2.Controls.Add(control);

        }
        
    }
}
