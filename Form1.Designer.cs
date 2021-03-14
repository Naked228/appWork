
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
            this.btnDBPath = new System.Windows.Forms.Button();
            this.btnXLPath = new System.Windows.Forms.Button();
            this.lblDBPath = new System.Windows.Forms.Label();
            this.lblXLPath = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblTest0 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTest1 = new System.Windows.Forms.Label();
            this.btnAddToDB = new System.Windows.Forms.Button();
            this.btnOpenDB = new System.Windows.Forms.Button();
            this.btnOpenXL = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Enabled = false;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(24, 20);
            this.файлToolStripMenuItem.Text = "?";
            // 
            // btnDBPath
            // 
            this.btnDBPath.Location = new System.Drawing.Point(13, 28);
            this.btnDBPath.Name = "btnDBPath";
            this.btnDBPath.Size = new System.Drawing.Size(113, 23);
            this.btnDBPath.TabIndex = 1;
            this.btnDBPath.Text = "База данных (DB)";
            this.btnDBPath.UseVisualStyleBackColor = true;
            this.btnDBPath.Click += new System.EventHandler(this.btnDBPath_Click);
            // 
            // btnXLPath
            // 
            this.btnXLPath.Location = new System.Drawing.Point(13, 58);
            this.btnXLPath.Name = "btnXLPath";
            this.btnXLPath.Size = new System.Drawing.Size(113, 23);
            this.btnXLPath.TabIndex = 2;
            this.btnXLPath.Text = "Доработка (XL)";
            this.btnXLPath.UseVisualStyleBackColor = true;
            this.btnXLPath.Click += new System.EventHandler(this.btnXLPath_Click);
            // 
            // lblDBPath
            // 
            this.lblDBPath.AutoSize = true;
            this.lblDBPath.Location = new System.Drawing.Point(132, 33);
            this.lblDBPath.Name = "lblDBPath";
            this.lblDBPath.Size = new System.Drawing.Size(115, 13);
            this.lblDBPath.TabIndex = 3;
            this.lblDBPath.Text = "Путь к базе данных";
            // 
            // lblXLPath
            // 
            this.lblXLPath.AutoSize = true;
            this.lblXLPath.Location = new System.Drawing.Point(132, 63);
            this.lblXLPath.Name = "lblXLPath";
            this.lblXLPath.Size = new System.Drawing.Size(139, 13);
            this.lblXLPath.TabIndex = 4;
            this.lblXLPath.Text = "Путь к файлу доработки";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(113, 56);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblTest0
            // 
            this.lblTest0.AutoSize = true;
            this.lblTest0.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTest0.Location = new System.Drawing.Point(146, 99);
            this.lblTest0.Name = "lblTest0";
            this.lblTest0.Size = new System.Drawing.Size(91, 13);
            this.lblTest0.TabIndex = 6;
            this.lblTest0.Text = "lblTest0. INFO";
            this.lblTest0.Click += new System.EventHandler(this.lblTest0_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(610, 160);
            this.dataGridView1.TabIndex = 7;
            // 
            // lblTest1
            // 
            this.lblTest1.AutoSize = true;
            this.lblTest1.Location = new System.Drawing.Point(262, 155);
            this.lblTest1.Name = "lblTest1";
            this.lblTest1.Size = new System.Drawing.Size(55, 13);
            this.lblTest1.TabIndex = 9;
            this.lblTest1.Text = "lblTest1";
            // 
            // btnAddToDB
            // 
            this.btnAddToDB.Location = new System.Drawing.Point(135, 121);
            this.btnAddToDB.Name = "btnAddToDB";
            this.btnAddToDB.Size = new System.Drawing.Size(113, 23);
            this.btnAddToDB.TabIndex = 10;
            this.btnAddToDB.Text = "Добавить в БД";
            this.btnAddToDB.UseVisualStyleBackColor = true;
            this.btnAddToDB.Click += new System.EventHandler(this.btnAddToDB_Click);
            // 
            // btnOpenDB
            // 
            this.btnOpenDB.Location = new System.Drawing.Point(509, 94);
            this.btnOpenDB.Name = "btnOpenDB";
            this.btnOpenDB.Size = new System.Drawing.Size(113, 23);
            this.btnOpenDB.TabIndex = 11;
            this.btnOpenDB.Text = "Открыть DB";
            this.btnOpenDB.UseVisualStyleBackColor = true;
            this.btnOpenDB.Click += new System.EventHandler(this.btnOpenDB_Click);
            // 
            // btnOpenXL
            // 
            this.btnOpenXL.Location = new System.Drawing.Point(509, 123);
            this.btnOpenXL.Name = "btnOpenXL";
            this.btnOpenXL.Size = new System.Drawing.Size(113, 23);
            this.btnOpenXL.TabIndex = 12;
            this.btnOpenXL.Text = "Открыть XL";
            this.btnOpenXL.UseVisualStyleBackColor = true;
            this.btnOpenXL.Click += new System.EventHandler(this.btnOpenXL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 341);
            this.Controls.Add(this.btnOpenXL);
            this.Controls.Add(this.btnOpenDB);
            this.Controls.Add(this.btnAddToDB);
            this.Controls.Add(this.lblTest1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTest0);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblXLPath);
            this.Controls.Add(this.lblDBPath);
            this.Controls.Add(this.btnXLPath);
            this.Controls.Add(this.btnDBPath);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "a p p W o r k";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.Button btnDBPath;
        private System.Windows.Forms.Button btnXLPath;
        private System.Windows.Forms.Label lblDBPath;
        private System.Windows.Forms.Label lblXLPath;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTest1;
        private System.Windows.Forms.Button btnAddToDB;
        private System.Windows.Forms.Button btnOpenDB;
        private System.Windows.Forms.Button btnOpenXL;
        public System.Windows.Forms.Label lblTest0;
    }
}

