using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ATMW.Class
{
    public static class Popup
    {
        public static void Show(string message)
        {
            new Thread(new ThreadStart(delegate
            {
                MessageBox.Show(message);
            })).Start();
        }
    }
}
