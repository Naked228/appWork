
namespace appWork
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходAltF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenXL = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnOpenDB = new System.Windows.Forms.Button();
            this.BtnAddDB = new System.Windows.Forms.Button();
            this.labelList = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enabled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходAltF4ToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходAltF4ToolStripMenuItem
            // 
            this.выходAltF4ToolStripMenuItem.Name = "выходAltF4ToolStripMenuItem";
            this.выходAltF4ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.выходAltF4ToolStripMenuItem.Text = "Выход Alt+F4";
            this.выходAltF4ToolStripMenuItem.Click += new System.EventHandler(this.выходAltF4ToolStripMenuItem_Click);
            // 
            // btnOpenXL
            // 
            this.btnOpenXL.Location = new System.Drawing.Point(12, 69);
            this.btnOpenXL.Name = "btnOpenXL";
            this.btnOpenXL.Size = new System.Drawing.Size(75, 23);
            this.btnOpenXL.TabIndex = 1;
            this.btnOpenXL.Text = "Открыть XL";
            this.btnOpenXL.UseVisualStyleBackColor = true;
            this.btnOpenXL.Click += new System.EventHandler(this.btnOpenXL_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(213, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(211, 283);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnOpenDB
            // 
            this.btnOpenDB.Location = new System.Drawing.Point(12, 40);
            this.btnOpenDB.Name = "btnOpenDB";
            this.btnOpenDB.Size = new System.Drawing.Size(121, 23);
            this.btnOpenDB.TabIndex = 5;
            this.btnOpenDB.Text = "Открыть Object.mdb";
            this.btnOpenDB.UseVisualStyleBackColor = true;
            this.btnOpenDB.Click += new System.EventHandler(this.btnOpenDB_Click);
            // 
            // BtnAddDB
            // 
            this.BtnAddDB.Location = new System.Drawing.Point(12, 98);
            this.BtnAddDB.Name = "BtnAddDB";
            this.BtnAddDB.Size = new System.Drawing.Size(121, 23);
            this.BtnAddDB.TabIndex = 6;
            this.BtnAddDB.Text = "Добавить в Object";
            this.BtnAddDB.UseVisualStyleBackColor = true;
            this.BtnAddDB.Click += new System.EventHandler(this.BtnAddDB_Click);
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Location = new System.Drawing.Point(210, 24);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(35, 13);
            this.labelList.TabIndex = 7;
            this.labelList.Text = "label1";
            this.labelList.Click += new System.EventHandler(this.labelList_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 215);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(185, 108);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reg,
            this.description,
            this.enabled});
            this.dataGridView1.Location = new System.Drawing.Point(444, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(317, 283);
            this.dataGridView1.TabIndex = 10;
            // 
            // reg
            // 
            this.reg.HeaderText = "reg ";
            this.reg.Name = "reg";
            // 
            // description
            // 
            this.description.HeaderText = "description";
            this.description.Name = "description";
            // 
            // enabled
            // 
            this.enabled.HeaderText = "enable";
            this.enabled.Name = "enabled";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 344);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.BtnAddDB);
            this.Controls.Add(this.btnOpenDB);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnOpenXL);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходAltF4ToolStripMenuItem;
        private System.Windows.Forms.Button btnOpenXL;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnOpenDB;
        private System.Windows.Forms.Button BtnAddDB;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reg;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn enabled;
    }
}

