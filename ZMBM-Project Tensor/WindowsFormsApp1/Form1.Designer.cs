namespace WindowsFormsApp1
{
    partial class form_show_data
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_show_data));
            this.button_read_data = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.label_xval1 = new System.Windows.Forms.Label();
            this.button_lock_epsil2 = new System.Windows.Forms.Button();
            this.label_xvalue2 = new System.Windows.Forms.Label();
            this.button_lock_epsile1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip_formula = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox_spring = new System.Windows.Forms.PictureBox();
            this.pictureBox_tense = new System.Windows.Forms.PictureBox();
            this.textBox_speed = new System.Windows.Forms.TextBox();
            this.label_epsilon1 = new System.Windows.Forms.Label();
            this.label_epsilon2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.textBox_immediate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_spring)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tense)).BeginInit();
            this.SuspendLayout();
            // 
            // button_read_data
            // 
            this.button_read_data.BackColor = System.Drawing.Color.LightGray;
            this.button_read_data.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_read_data.FlatAppearance.BorderSize = 3;
            this.button_read_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_read_data.Location = new System.Drawing.Point(22, 12);
            this.button_read_data.Name = "button_read_data";
            this.button_read_data.Size = new System.Drawing.Size(89, 74);
            this.button_read_data.TabIndex = 0;
            this.button_read_data.Text = "Read Data";
            this.button_read_data.UseVisualStyleBackColor = false;
            this.button_read_data.Click += new System.EventHandler(this.button_read_data_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(175, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calculate Speed";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(290, 12);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(888, 611);
            this.zedGraphControl1.TabIndex = 2;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            this.zedGraphControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.zedGraphControl1_MouseClick_1);
            // 
            // label_xval1
            // 
            this.label_xval1.AutoSize = true;
            this.label_xval1.Location = new System.Drawing.Point(165, 159);
            this.label_xval1.Name = "label_xval1";
            this.label_xval1.Size = new System.Drawing.Size(42, 13);
            this.label_xval1.TabIndex = 3;
            this.label_xval1.Text = "Time 2:";
            // 
            // button_lock_epsil2
            // 
            this.button_lock_epsil2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_lock_epsil2.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_lock_epsil2.FlatAppearance.BorderSize = 3;
            this.button_lock_epsil2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_lock_epsil2.Location = new System.Drawing.Point(168, 99);
            this.button_lock_epsil2.Name = "button_lock_epsil2";
            this.button_lock_epsil2.Size = new System.Drawing.Size(96, 49);
            this.button_lock_epsil2.TabIndex = 4;
            this.button_lock_epsil2.Text = "Lock Time 2";
            this.button_lock_epsil2.UseVisualStyleBackColor = false;
            this.button_lock_epsil2.Click += new System.EventHandler(this.button_lock_epsil1_Click);
            // 
            // label_xvalue2
            // 
            this.label_xvalue2.AutoSize = true;
            this.label_xvalue2.Location = new System.Drawing.Point(17, 159);
            this.label_xvalue2.Name = "label_xvalue2";
            this.label_xvalue2.Size = new System.Drawing.Size(42, 13);
            this.label_xvalue2.TabIndex = 5;
            this.label_xvalue2.Text = "Time 1:";
            // 
            // button_lock_epsile1
            // 
            this.button_lock_epsile1.BackColor = System.Drawing.Color.LightCoral;
            this.button_lock_epsile1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_lock_epsile1.FlatAppearance.BorderSize = 3;
            this.button_lock_epsile1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_lock_epsile1.Location = new System.Drawing.Point(22, 99);
            this.button_lock_epsile1.Name = "button_lock_epsile1";
            this.button_lock_epsile1.Size = new System.Drawing.Size(96, 49);
            this.button_lock_epsile1.TabIndex = 6;
            this.button_lock_epsile1.Text = "Lock Time 1";
            this.button_lock_epsile1.UseVisualStyleBackColor = false;
            this.button_lock_epsile1.Click += new System.EventHandler(this.button_lock_epsile2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.toolTip_formula.SetToolTip(this.pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            // 
            // toolTip_formula
            // 
            this.toolTip_formula.AutoPopDelay = 20000;
            this.toolTip_formula.BackColor = System.Drawing.Color.Khaki;
            this.toolTip_formula.InitialDelay = 500;
            this.toolTip_formula.ReshowDelay = 100;
            // 
            // pictureBox_spring
            // 
            this.pictureBox_spring.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_spring.Image")));
            this.pictureBox_spring.Location = new System.Drawing.Point(9, 414);
            this.pictureBox_spring.Name = "pictureBox_spring";
            this.pictureBox_spring.Size = new System.Drawing.Size(255, 209);
            this.pictureBox_spring.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_spring.TabIndex = 16;
            this.pictureBox_spring.TabStop = false;
            this.toolTip_formula.SetToolTip(this.pictureBox_spring, "A0- wydłużenie początkowe\r\nAp - wydłużenie pełzania\r\nAc - wydłużenie całkowite\r\nA" +
        "spr - wydłużenie natychmiastowe\r\nAtr- wydłużenie trwałe");
            // 
            // pictureBox_tense
            // 
            this.pictureBox_tense.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_tense.Image")));
            this.pictureBox_tense.Location = new System.Drawing.Point(9, 452);
            this.pictureBox_tense.Name = "pictureBox_tense";
            this.pictureBox_tense.Size = new System.Drawing.Size(275, 171);
            this.pictureBox_tense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_tense.TabIndex = 17;
            this.pictureBox_tense.TabStop = false;
            this.toolTip_formula.SetToolTip(this.pictureBox_tense, "ε0- odkstzałcenie początkowe\r\nI - stadium pełzania nieustalonego\r\nII - stadium pe" +
        "łzania ustalonego\r\nIII - stadium pełzania przyśpieszonego\r\ntz- czas do zniszczen" +
        "ia próbki\r\nZ - zniszczenie");
            this.pictureBox_tense.Visible = false;
            // 
            // textBox_speed
            // 
            this.textBox_speed.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_speed.Location = new System.Drawing.Point(22, 331);
            this.textBox_speed.Name = "textBox_speed";
            this.textBox_speed.ReadOnly = true;
            this.textBox_speed.Size = new System.Drawing.Size(218, 20);
            this.textBox_speed.TabIndex = 8;
            // 
            // label_epsilon1
            // 
            this.label_epsilon1.AutoSize = true;
            this.label_epsilon1.Location = new System.Drawing.Point(6, 180);
            this.label_epsilon1.Name = "label_epsilon1";
            this.label_epsilon1.Size = new System.Drawing.Size(53, 13);
            this.label_epsilon1.TabIndex = 9;
            this.label_epsilon1.Text = "Epsilon 1:";
            // 
            // label_epsilon2
            // 
            this.label_epsilon2.AutoSize = true;
            this.label_epsilon2.Location = new System.Drawing.Point(153, 180);
            this.label_epsilon2.Name = "label_epsilon2";
            this.label_epsilon2.Size = new System.Drawing.Size(53, 13);
            this.label_epsilon2.TabIndex = 10;
            this.label_epsilon2.Text = "Epsilon 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Creep speed in secondary stage (Steady state):";
            // 
            // textBox_total
            // 
            this.textBox_total.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_total.Location = new System.Drawing.Point(137, 386);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.ReadOnly = true;
            this.textBox_total.Size = new System.Drawing.Size(103, 20);
            this.textBox_total.TabIndex = 12;
            // 
            // textBox_immediate
            // 
            this.textBox_immediate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_immediate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_immediate.Location = new System.Drawing.Point(112, 359);
            this.textBox_immediate.Name = "textBox_immediate";
            this.textBox_immediate.ReadOnly = true;
            this.textBox_immediate.Size = new System.Drawing.Size(103, 20);
            this.textBox_immediate.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total deformation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Immediate deformation:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // form_show_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 631);
            this.Controls.Add(this.pictureBox_tense);
            this.Controls.Add(this.pictureBox_spring);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_immediate);
            this.Controls.Add(this.textBox_total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_epsilon2);
            this.Controls.Add(this.label_epsilon1);
            this.Controls.Add(this.textBox_speed);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_lock_epsile1);
            this.Controls.Add(this.label_xvalue2);
            this.Controls.Add(this.button_lock_epsil2);
            this.Controls.Add(this.label_xval1);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_read_data);
            this.MaximumSize = new System.Drawing.Size(1200, 670);
            this.MinimumSize = new System.Drawing.Size(1200, 670);
            this.Name = "form_show_data";
            this.Text = "Pełzor";
            this.Load += new System.EventHandler(this.form_show_data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_spring)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_read_data;
        private System.Windows.Forms.Button button1;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Label label_xval1;
        private System.Windows.Forms.Button button_lock_epsil2;
        private System.Windows.Forms.Label label_xvalue2;
        private System.Windows.Forms.Button button_lock_epsile1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip_formula;
        private System.Windows.Forms.TextBox textBox_speed;
        private System.Windows.Forms.Label label_epsilon1;
        private System.Windows.Forms.Label label_epsilon2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.TextBox textBox_immediate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox_spring;
        private System.Windows.Forms.PictureBox pictureBox_tense;
        private System.Windows.Forms.Timer timer1;
    }
}

