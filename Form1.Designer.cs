
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
            this.btnDBPath = new System.Windows.Forms.Button();
            this.btnXLPath = new System.Windows.Forms.Button();
            this.lblDBPath = new System.Windows.Forms.Label();
            this.lblXLPath = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходAltF4ToolStripMenuItem});
            this.файлToolStripMenuItem.Enabled = false;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходAltF4ToolStripMenuItem
            // 
            this.выходAltF4ToolStripMenuItem.Name = "выходAltF4ToolStripMenuItem";
            this.выходAltF4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходAltF4ToolStripMenuItem.Text = "Выход";
            this.выходAltF4ToolStripMenuItem.Click += new System.EventHandler(this.выходAltF4ToolStripMenuItem_Click);
            // 
            // btnDBPath
            // 
            this.btnDBPath.Location = new System.Drawing.Point(13, 28);
            this.btnDBPath.Name = "btnDBPath";
            this.btnDBPath.Size = new System.Drawing.Size(113, 23);
            this.btnDBPath.TabIndex = 1;
            this.btnDBPath.Text = "БД";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 268);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходAltF4ToolStripMenuItem;
        private System.Windows.Forms.Button btnDBPath;
        private System.Windows.Forms.Button btnXLPath;
        private System.Windows.Forms.Label lblDBPath;
        private System.Windows.Forms.Label lblXLPath;
    }
}

