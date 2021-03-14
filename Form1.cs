using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
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
        //xl
        Excel.Range xlRange;
        Excel.Workbook xlBook;
        Excel.Worksheet xlSheet;
        int iLastRow, iLastCol, cnt;

        //form variables
        public string DBPath;
        public string XLPath;

        //access
        public static string connectDB;
        private OleDbConnection newDBConnect;

        tApp app = new tApp();

        public Form1()
        {
            InitializeComponent();
            this.Height = 190;
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

                //load xl
                Excel.Application xlApp = new Excel.Application();
                xlBook = xlApp.Workbooks.Open(XLPath);
                cnt = xlApp.Sheets.Count;

                //option without scroll
                //_ = (cnt > 2) ? listBox1.Height = listBox1.Height + cnt * 12 : listBox1.Height;

                for (int i = 1; i <= cnt; i++)
                {
                    listBox1.Items.Add(xlApp.Sheets[i].Name);

                    //option with buttons
                    //Button btn = new Button();
                    //btn.Text = xlApp.Sheets[i].Name;
                    //btn.Size = new Size(60, 20);
                    //btn.Location = new Point(135, 70 + 20 * i);
                    ////btn.Click += new EventHandler(btn_Click);
                    //this.Controls.Add(btn);
                }

                xlBook.Close(true);
                xlApp.Quit();
                //xlApp.Quit();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTest0.Text = "Выбранный лист: " + listBox1.SelectedItem.ToString() + ". Нажми для подробностей";

            Excel.Application xlApp = new Excel.Application();
            xlBook = xlApp.Workbooks.Open(XLPath);
            xlSheet = xlApp.Worksheets[listBox1.SelectedItem.ToString()];

            iLastRow = xlSheet.Cells[xlSheet.Rows.Count, "A"].End[Excel.XlDirection.xlUp].Row;
            iLastCol = xlSheet.Cells[1, xlSheet.Columns.Count].End(Excel.XlDirection.xlToLeft).Column;

            xlRange = (Excel.Range)xlSheet.Range["A1", xlSheet.Cells[iLastRow, iLastCol]];
            var dataArr = (object[,])xlRange.Value;

            xlBook.Close(true);
            xlApp.Quit();
            releaseObject(xlSheet);
            releaseObject(xlBook);
            releaseObject(xlApp);

            DataTable dt = new DataTable();
            DataRow dtRow;

            if (dataArr != null) 
            { 
                for (int i = 1; i <= dataArr.GetUpperBound(1); i++)
                    dt.Columns.Add((string)dataArr[1, i]);

                for (int i = 2; i <= dataArr.GetUpperBound(0); i++)
                {
                    dtRow = dt.NewRow();
                    for (int n = 1; n <= dataArr.GetUpperBound(1); n++)
                    {
                        dtRow[n - 1] = dataArr[i, n];
                    }
                    dt.Rows.Add(dtRow);
                }
            }
            else
            {
                lblTest1.Text = "Выбранный лист пуст";
            }
            this.dataGridView1.DataSource = dt;
        }

        private void lblTest0_Click(object sender, EventArgs e)
        {
            _ = (this.Height == 190) ? this.Height = 380 : this.Height = 190;
        }

        private void btnAddToDB_Click(object sender, EventArgs e)
        {
            if (DBPath != null)
            {
                //connect to db
                connectDB = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBPath;
                newDBConnect = new OleDbConnection(connectDB);
                newDBConnect.Open();

                //nado peredelat', chtobi dobavlyalos' v vibranniy list, v nujnie stolbi; nije prosto shablon;
                string query = "INSERT INTO LIST5 (description, reg, enabled) VALUES ('new string', '7', false)";
                OleDbCommand cmd = new OleDbCommand(query, newDBConnect);
                cmd.ExecuteNonQuery();
                lblTest0.Text = "Данные добавлены в БД";

                //close connect to db
                newDBConnect.Close();
            }
            else
            {
                lblTest0.Text = "Выберите БД";
            }
        }

        private void btnOpenDB_Click(object sender, EventArgs e)
        {
            app.Run(DBPath, "DB");
        }

        private void btnOpenXL_Click(object sender, EventArgs e)
        {
            app.Run(XLPath, "XL");
        }

        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
