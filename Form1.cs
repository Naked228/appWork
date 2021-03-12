using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace appWork
{
    public partial class Form1 : Form
    {
        public string DBPath;
        public string XLPath;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnDBPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Microsoft Access Database | *.mdb";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DBPath = ofd.FileName;
                lblDBPath.Text = DBPath;
            }
        }

        private void btnXLPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Microsoft Excel 97-2003 | *.xls";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                XLPath = ofd.FileName;
                lblXLPath.Text = XLPath;
            }
        }

        private void выходAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
