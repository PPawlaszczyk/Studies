namespace paraller_programing_charts
{
    partial class Form1
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
            this.textBox_wpiszfunkcje_dla_pochodnej = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_oblicz_pochodna = new System.Windows.Forms.Button();
            this.textBox_ile_razy_pochodna = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_zakres_pochodnej_od = new System.Windows.Forms.TextBox();
            this.textBox_zakres_pochodnej_do = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_krok_pochodna = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label_czas_rys_bez = new System.Windows.Forms.Label();
            this.label_watek1 = new System.Windows.Forms.Label();
            this.label_watek2 = new System.Windows.Forms.Label();
            this.label_watek3 = new System.Windows.Forms.Label();
            this.label_watek4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label_watek_2_2watkowo = new System.Windows.Forms.Label();
            this.label_watek_1_2watkowo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_wpiszfunkcje_dla_pochodnej
            // 
            this.textBox_wpiszfunkcje_dla_pochodnej.Location = new System.Drawing.Point(10, 123);
            this.textBox_wpiszfunkcje_dla_pochodnej.Name = "textBox_wpiszfunkcje_dla_pochodnej";
            this.textBox_wpiszfunkcje_dla_pochodnej.Size = new System.Drawing.Size(269, 20);
            this.textBox_wpiszfunkcje_dla_pochodnej.TabIndex = 0;
            this.textBox_wpiszfunkcje_dla_pochodnej.Text = "x*x*x";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wpisz funkcję:";
            // 
            // button_oblicz_pochodna
            // 
            this.button_oblicz_pochodna.Location = new System.Drawing.Point(1, 297);
            this.button_oblicz_pochodna.Name = "button_oblicz_pochodna";
            this.button_oblicz_pochodna.Size = new System.Drawing.Size(95, 64);
            this.button_oblicz_pochodna.TabIndex = 2;
            this.button_oblicz_pochodna.Text = "Rysuj wykresy 4 watkowo";
            this.button_oblicz_pochodna.UseVisualStyleBackColor = true;
            this.button_oblicz_pochodna.Click += new System.EventHandler(this.Button_oblicz_pochodna_Click);
            // 
            // textBox_ile_razy_pochodna
            // 
            this.textBox_ile_razy_pochodna.Location = new System.Drawing.Point(13, 203);
            this.textBox_ile_razy_pochodna.MaxLength = 2;
            this.textBox_ile_razy_pochodna.Name = "textBox_ile_razy_pochodna";
            this.textBox_ile_razy_pochodna.Size = new System.Drawing.Size(40, 20);
            this.textBox_ile_razy_pochodna.TabIndex = 9;
            this.textBox_ile_razy_pochodna.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pochodna n-rzedu \r(1-2)";
            // 
            // textBox_zakres_pochodnej_od
            // 
            this.textBox_zakres_pochodnej_od.Location = new System.Drawing.Point(156, 193);
            this.textBox_zakres_pochodnej_od.Name = "textBox_zakres_pochodnej_od";
            this.textBox_zakres_pochodnej_od.Size = new System.Drawing.Size(40, 20);
            this.textBox_zakres_pochodnej_od.TabIndex = 11;
            this.textBox_zakres_pochodnej_od.Text = "-10";
            // 
            // textBox_zakres_pochodnej_do
            // 
            this.textBox_zakres_pochodnej_do.Location = new System.Drawing.Point(239, 193);
            this.textBox_zakres_pochodnej_do.Name = "textBox_zakres_pochodnej_do";
            this.textBox_zakres_pochodnej_do.Size = new System.Drawing.Size(40, 20);
            this.textBox_zakres_pochodnej_do.TabIndex = 12;
            this.textBox_zakres_pochodnej_do.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Zakres x od:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Zakres x do:";
            // 
            // textBox_krok_pochodna
            // 
            this.textBox_krok_pochodna.Location = new System.Drawing.Point(156, 246);
            this.textBox_krok_pochodna.Name = "textBox_krok_pochodna";
            this.textBox_krok_pochodna.Size = new System.Drawing.Size(123, 20);
            this.textBox_krok_pochodna.TabIndex = 15;
            this.textBox_krok_pochodna.Text = "0,001";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Wpisz krok:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 26);
            this.label11.TabIndex = 28;
            this.label11.Text = "Definicja pierwiastka\r\ndo wpisania = Sqrt(4)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 62);
            this.button1.TabIndex = 29;
            this.button1.Text = "Rysuj wykresy bez watkow";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(75, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 24);
            this.button2.TabIndex = 30;
            this.button2.Text = "Clear Chart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label_czas_rys_bez
            // 
            this.label_czas_rys_bez.AutoSize = true;
            this.label_czas_rys_bez.Location = new System.Drawing.Point(1, 559);
            this.label_czas_rys_bez.Name = "label_czas_rys_bez";
            this.label_czas_rys_bez.Size = new System.Drawing.Size(135, 13);
            this.label_czas_rys_bez.TabIndex = 31;
            this.label_czas_rys_bez.Text = "Czas rysowania bez watku:";
            // 
            // label_watek1
            // 
            this.label_watek1.AutoSize = true;
            this.label_watek1.Location = new System.Drawing.Point(12, 457);
            this.label_watek1.Name = "label_watek1";
            this.label_watek1.Size = new System.Drawing.Size(124, 13);
            this.label_watek1.TabIndex = 32;
            this.label_watek1.Text = "Czas rysowania watek 1:";
            // 
            // label_watek2
            // 
            this.label_watek2.AutoSize = true;
            this.label_watek2.Location = new System.Drawing.Point(12, 480);
            this.label_watek2.Name = "label_watek2";
            this.label_watek2.Size = new System.Drawing.Size(124, 13);
            this.label_watek2.TabIndex = 33;
            this.label_watek2.Text = "Czas rysowania watek 2:";
            // 
            // label_watek3
            // 
            this.label_watek3.AutoSize = true;
            this.label_watek3.Location = new System.Drawing.Point(12, 502);
            this.label_watek3.Name = "label_watek3";
            this.label_watek3.Size = new System.Drawing.Size(124, 13);
            this.label_watek3.TabIndex = 34;
            this.label_watek3.Text = "Czas rysowania watek 3:";
            // 
            // label_watek4
            // 
            this.label_watek4.AutoSize = true;
            this.label_watek4.Location = new System.Drawing.Point(12, 526);
            this.label_watek4.Name = "label_watek4";
            this.label_watek4.Size = new System.Drawing.Size(124, 13);
            this.label_watek4.TabIndex = 35;
            this.label_watek4.Text = "Czas rysowania watek 4:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(75, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 29);
            this.button3.TabIndex = 36;
            this.button3.Text = "Pokaż czasy dla wątkow";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(104, 297);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 64);
            this.button4.TabIndex = 37;
            this.button4.Text = "Rysuj wykresy 2 watkowo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label_watek_2_2watkowo
            // 
            this.label_watek_2_2watkowo.AutoSize = true;
            this.label_watek_2_2watkowo.Location = new System.Drawing.Point(12, 613);
            this.label_watek_2_2watkowo.Name = "label_watek_2_2watkowo";
            this.label_watek_2_2watkowo.Size = new System.Drawing.Size(124, 13);
            this.label_watek_2_2watkowo.TabIndex = 38;
            this.label_watek_2_2watkowo.Text = "Czas rysowania watek 2:";
            // 
            // label_watek_1_2watkowo
            // 
            this.label_watek_1_2watkowo.AutoSize = true;
            this.label_watek_1_2watkowo.Location = new System.Drawing.Point(12, 590);
            this.label_watek_1_2watkowo.Name = "label_watek_1_2watkowo";
            this.label_watek_1_2watkowo.Size = new System.Drawing.Size(124, 13);
            this.label_watek_1_2watkowo.TabIndex = 39;
            this.label_watek_1_2watkowo.Text = "Czas rysowania watek 1:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1447, 720);
            this.Controls.Add(this.label_watek_1_2watkowo);
            this.Controls.Add(this.label_watek_2_2watkowo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label_watek4);
            this.Controls.Add(this.label_watek3);
            this.Controls.Add(this.label_watek2);
            this.Controls.Add(this.label_watek1);
            this.Controls.Add(this.label_czas_rys_bez);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_krok_pochodna);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_zakres_pochodnej_do);
            this.Controls.Add(this.textBox_zakres_pochodnej_od);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ile_razy_pochodna);
            this.Controls.Add(this.button_oblicz_pochodna);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_wpiszfunkcje_dla_pochodnej);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_wpiszfunkcje_dla_pochodnej;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_oblicz_pochodna;
        private System.Windows.Forms.TextBox textBox_ile_razy_pochodna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_zakres_pochodnej_od;
        private System.Windows.Forms.TextBox textBox_zakres_pochodnej_do;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_krok_pochodna;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_czas_rys_bez;
        private System.Windows.Forms.Label label_watek1;
        private System.Windows.Forms.Label label_watek2;
        private System.Windows.Forms.Label label_watek3;
        private System.Windows.Forms.Label label_watek4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label_watek_2_2watkowo;
        private System.Windows.Forms.Label label_watek_1_2watkowo;
    }
}

