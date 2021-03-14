using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appWork
{
    public class tApp
    {
        public void Run(string path, string typeapp)
        {
            if (path != null)
            {
                Process.Start(path);
            }
            else
            {
                MessageBox.Show("Выберите " + typeapp, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
