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
        Excel.Workbook XLBook;
        Excel.Worksheet XLLIST;
        Excel.Range range;

        public Form1()
        {
            InitializeComponent();
        }

        private void выходAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            string fileName = @"D:\test\CopyMe.txt";
            string PathPaste = @"D:\test\paste\CopyMe.txt";

            System.IO.File.Copy(fileName, PathPaste);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"D:\Dor\object\object.mdb";
            StreamWriter sw = new StreamWriter(path);
            //StreamWriter sw = new StreamWriter("test.txt", true, System.Text.Encoding.Default);
            Console.WriteLine(textBox1.Text);
            Console.WriteLine(path);
            sw.WriteLine(textBox1.Text);
            sw.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string path = @"D:\Dor\XL\tester.xlsx";
            //StreamReader sr = new StreamReader(path, System.Text.Encoding.Default);
            //string a = sr.ReadToEnd();
            //Console.WriteLine(a);
            //richTextBox1.Text = a;
            //sr.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
