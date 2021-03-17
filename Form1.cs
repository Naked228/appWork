using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
        Excel.Workbook xlBook; //Рабочая книга
        Excel.Worksheet xlSheet; // Лист Excel
        Excel.Range xlRange; // Диапазон
        int iLastRow, iLastCol, cnt; // кол-Во строк, кол-во колонок, кол-во листов в Excel.

        public string DBPath;
        public string XLPath;
        public static string connectDB;
        private OleDbConnection newDBConnect;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenDB_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Microsoft Access Database | *.mdb";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DBPath = ofd.FileName;
                // lblDBPath.Text = DBPath;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelList.Text = "Выбран лист " + listView1.FocusedItem.Text;
        }

        private void BtnAddDB_Click(object sender, EventArgs e)
        {

            //подключаем и открываем базу Object.mdb
            connectDB = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBPath;
            newDBConnect = new OleDbConnection(connectDB);
            newDBConnect.Open();
            Excel.Application xlApp = new Excel.Application();
            xlBook = xlApp.Workbooks.Open(XLPath);

            string query = "INSERT INTO " + listView1.FocusedItem.Text + " VALUES "  " )"; // VALUES (dataArr)
            OleDbCommand cmd = new OleDbCommand(query, newDBConnect);
            cmd.ExecuteNonQuery();
            // Вычитываем колонки из листа
            //DataTable data_table = newDBConnect.GetSchema("Columns", new string[] { null, null, "listView1.FocusedItem.Text" });
            //foreach (DataRow row in data_table.Rows)
            //{
            //    string TableName = row["COLUMN_NAME"].ToString();

            //}
            //DataTable dataArr = newDBConnect.GetSchema("Values", new string[] { null, null, "listView1.FocusedItem.Text" });
            //foreach (DataRow row in dataArr.Rows)
            //{
            //    string TableName = row["Values"].ToString();
            //    listBox1.Items.Add(TableName);
            //}
        }

        private void labelList_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //подключаем и открываем базу Object.mdb
            connectDB = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBPath;
            newDBConnect = new OleDbConnection(connectDB);
            newDBConnect.Open();
            // Водит все таблицы из базы
            //DataTable tbls = newDBConnect.GetSchema("Tables", new string[] { null, null, null, "TABLE" }); //список всех таблиц
            //foreach (DataRow row in tbls.Rows)
            //{
            //    string TableName = row["TABLE_NAME"].ToString();
            //    listBox1.Items.Add(TableName);
            //}

            string val = "SELECT * FROM LIST5"; // строка запроса
            OleDbCommand dbCommand = new OleDbCommand(val, newDBConnect); // Команда
            OleDbDataReader dbReader = dbCommand.ExecuteReader(); //Считываем данные

            if (dbReader.HasRows == false)
            {
                MessageBox.Show("Данные не найдены так что иди нахуй");
            }
            else
            {
                while (dbReader.Read())
                {
                    dataGridView1.Rows.Add(dbReader ["reg"], dbReader["description"], dbReader["enabled"]);
                }
            }
            Console.WriteLine(val);
            dbReader.Close();
            newDBConnect.Close();
        }
    
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void выходAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         private void btnOpenXL_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Microsoft Excel 97-2003 | *.xls";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                XLPath = ofd.FileName;
                //lblXLPath.Text = XLPath;

                //load xl
                Excel.Application xlApp = new Excel.Application();
                xlBook = xlApp.Workbooks.Open(XLPath);
                cnt = xlApp.Sheets.Count;

                for (int i = 1; i <= cnt; i++)
                {
                    listView1.Items.Add(xlApp.Sheets[i].Name);
                }
                xlBook.Close(true);
                xlApp.Quit();
            }
        }

    }
}
