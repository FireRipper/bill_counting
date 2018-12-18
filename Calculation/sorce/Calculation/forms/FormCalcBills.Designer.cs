namespace Calculation
{
    partial class Calculation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btn_eur = new System.Windows.Forms.Button();
            this.btn_usd = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_uah = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_hide = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.formCalculationUSD1 = new CalculationFormUSD.forms.formCalculationUSD();
            this.formCalculationUAH1 = new CalculationFormUAH.forms.formCalculationUAH();
            this.formCalculationEUR1 = new CalculationFormEUR.forms.formCalculationEUR();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.btn_eur);
            this.panel1.Controls.Add(this.btn_usd);
            this.panel1.Controls.Add(this.btn_info);
            this.panel1.Controls.Add(this.btn_uah);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 548);
            this.panel1.TabIndex = 44;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.sidePanel.Location = new System.Drawing.Point(0, 129);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(15, 59);
            this.sidePanel.TabIndex = 47;
            // 
            // btn_eur
            // 
            this.btn_eur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eur.FlatAppearance.BorderSize = 0;
            this.btn_eur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_eur.ForeColor = System.Drawing.Color.White;
            this.btn_eur.Image = ((System.Drawing.Image)(resources.GetObject("btn_eur.Image")));
            this.btn_eur.Location = new System.Drawing.Point(13, 253);
            this.btn_eur.Name = "btn_eur";
            this.btn_eur.Size = new System.Drawing.Size(143, 59);
            this.btn_eur.TabIndex = 3;
            this.btn_eur.Text = "  Банкноты EUR";
            this.btn_eur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_eur.UseVisualStyleBackColor = true;
            this.btn_eur.Click += new System.EventHandler(this.btn_eur_Click);
            // 
            // btn_usd
            // 
            this.btn_usd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_usd.FlatAppearance.BorderSize = 0;
            this.btn_usd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_usd.ForeColor = System.Drawing.Color.White;
            this.btn_usd.Image = ((System.Drawing.Image)(resources.GetObject("btn_usd.Image")));
            this.btn_usd.Location = new System.Drawing.Point(13, 191);
            this.btn_usd.Name = "btn_usd";
            this.btn_usd.Size = new System.Drawing.Size(143, 59);
            this.btn_usd.TabIndex = 2;
            this.btn_usd.Text = "  Банкноты USD";
            this.btn_usd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_usd.UseVisualStyleBackColor = true;
            this.btn_usd.Click += new System.EventHandler(this.btn_usd_Click);
            // 
            // btn_info
            // 
            this.btn_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_info.FlatAppearance.BorderSize = 0;
            this.btn_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_info.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_info.ForeColor = System.Drawing.Color.White;
            this.btn_info.Location = new System.Drawing.Point(13, 502);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(33, 34);
            this.btn_info.TabIndex = 1;
            this.btn_info.Text = "?";
            this.btn_info.UseVisualStyleBackColor = true;
            // 
            // btn_uah
            // 
            this.btn_uah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_uah.FlatAppearance.BorderSize = 0;
            this.btn_uah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_uah.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_uah.ForeColor = System.Drawing.Color.White;
            this.btn_uah.Image = ((System.Drawing.Image)(resources.GetObject("btn_uah.Image")));
            this.btn_uah.Location = new System.Drawing.Point(13, 129);
            this.btn_uah.Name = "btn_uah";
            this.btn_uah.Size = new System.Drawing.Size(143, 59);
            this.btn_uah.TabIndex = 0;
            this.btn_uah.Text = "  Банкноты UAH";
            this.btn_uah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_uah.UseVisualStyleBackColor = true;
            this.btn_uah.Click += new System.EventHandler(this.btn_uah_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 25);
            this.panel2.TabIndex = 45;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(171, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(112, 106);
            this.panel3.TabIndex = 46;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_close.ForeColor = System.Drawing.Color.Transparent;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_close.Location = new System.Drawing.Point(631, 31);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(40, 37);
            this.btn_close.TabIndex = 47;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_hide
            // 
            this.btn_hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hide.FlatAppearance.BorderSize = 0;
            this.btn_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hide.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_hide.ForeColor = System.Drawing.Color.White;
            this.btn_hide.Image = ((System.Drawing.Image)(resources.GetObject("btn_hide.Image")));
            this.btn_hide.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_hide.Location = new System.Drawing.Point(586, 31);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(40, 22);
            this.btn_hide.TabIndex = 48;
            this.btn_hide.Text = "__";
            this.btn_hide.UseVisualStyleBackColor = true;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(156, 563);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(525, 10);
            this.panel5.TabIndex = 49;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.label25.Location = new System.Drawing.Point(289, 31);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(295, 75);
            this.label25.TabIndex = 50;
            this.label25.Text = "Расчёт суммы по количеству купюр ^)";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formCalculationUSD1
            // 
            this.formCalculationUSD1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(175)))), ((int)(((byte)(172)))));
            this.formCalculationUSD1.Location = new System.Drawing.Point(156, 120);
            this.formCalculationUSD1.Name = "formCalculationUSD1";
            this.formCalculationUSD1.Size = new System.Drawing.Size(525, 443);
            this.formCalculationUSD1.TabIndex = 52;
            // 
            // formCalculationUAH1
            // 
            this.formCalculationUAH1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(175)))), ((int)(((byte)(172)))));
            this.formCalculationUAH1.Location = new System.Drawing.Point(156, 120);
            this.formCalculationUAH1.Name = "formCalculationUAH1";
            this.formCalculationUAH1.Size = new System.Drawing.Size(525, 443);
            this.formCalculationUAH1.TabIndex = 51;
            // 
            // formCalculationEUR1
            // 
            this.formCalculationEUR1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(175)))), ((int)(((byte)(172)))));
            this.formCalculationEUR1.Location = new System.Drawing.Point(156, 118);
            this.formCalculationEUR1.Name = "formCalculationEUR1";
            this.formCalculationEUR1.Size = new System.Drawing.Size(525, 443);
            this.formCalculationEUR1.TabIndex = 53;
            // 
            // Calculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(681, 573);
            this.Controls.Add(this.formCalculationEUR1);
            this.Controls.Add(this.formCalculationUSD1);
            this.Controls.Add(this.formCalculationUAH1);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculation";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_eur;
        private System.Windows.Forms.Button btn_usd;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_uah;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label25;
        private CalculationFormUAH.forms.formCalculationUAH formCalculationUAH1;
        private CalculationFormUSD.forms.formCalculationUSD formCalculationUSD1;
        private CalculationFormEUR.forms.formCalculationEUR formCalculationEUR1;
    }
}

