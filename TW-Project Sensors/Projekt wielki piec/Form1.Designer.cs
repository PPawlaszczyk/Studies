namespace Projekt_wielki_piec
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Tip_buttons = new System.Windows.Forms.ToolTip(this.components);
            this.button_load_new_data = new System.Windows.Forms.Button();
            this.button_sensor_1 = new System.Windows.Forms.Button();
            this.button_sensor_2 = new System.Windows.Forms.Button();
            this.button_sensor_3 = new System.Windows.Forms.Button();
            this.button_accept_Data = new System.Windows.Forms.Button();
            this.Check_ports = new System.Windows.Forms.Button();
            this.button_clear_chart = new System.Windows.Forms.Button();
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_pointval_chart = new System.Windows.Forms.Button();
            this.comboBox_gradient = new System.Windows.Forms.ComboBox();
            this.button_TURN_ON_OFF = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label_sensor1_value = new System.Windows.Forms.Label();
            this.Label_sensor_2_value = new System.Windows.Forms.Label();
            this.Label_sensor_3_value = new System.Windows.Forms.Label();
            this.comboBox_View_Data = new System.Windows.Forms.ComboBox();
            this.Sensor_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_load_data = new System.Windows.Forms.Label();
            this.label_connect_ports = new System.Windows.Forms.Label();
            this.label_range = new System.Windows.Forms.Label();
            this.textBox_start_time = new System.Windows.Forms.TextBox();
            this.textBox_stop_time = new System.Windows.Forms.TextBox();
            this.label_sensor2_view = new System.Windows.Forms.Label();
            this.label_sensor1_view = new System.Windows.Forms.Label();
            this.label_sensor3_view = new System.Windows.Forms.Label();
            this.comboBox_connected_ports = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_EXIT = new System.Windows.Forms.Button();
            this.button_fullscreen = new System.Windows.Forms.Button();
            this.button_minimize = new System.Windows.Forms.Button();
            this.button_pomoc = new System.Windows.Forms.Button();
            this.textBox_gradient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_pick = new System.Windows.Forms.Label();
            this.Label_L_100 = new System.Windows.Forms.Label();
            this.label_L_300 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_gradient21 = new System.Windows.Forms.Label();
            this.label_gradient32 = new System.Windows.Forms.Label();
            this.label_gradient31 = new System.Windows.Forms.Label();
            this.label_gradient_OBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sensor_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Tip_buttons
            // 
            this.Tip_buttons.AutoPopDelay = 10000;
            this.Tip_buttons.InitialDelay = 500;
            this.Tip_buttons.ReshowDelay = 100;
            // 
            // button_load_new_data
            // 
            this.button_load_new_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_load_new_data.Location = new System.Drawing.Point(-1, -1);
            this.button_load_new_data.Name = "button_load_new_data";
            this.button_load_new_data.Size = new System.Drawing.Size(100, 35);
            this.button_load_new_data.TabIndex = 38;
            this.button_load_new_data.Text = "Load new data";
            this.Tip_buttons.SetToolTip(this.button_load_new_data, "Kliknij, aby wczytać z folderu dokonane pomiary z 3 czujników. Pamiętaj, aby wszy" +
        "stkie \r\npliki z pomiaru czujników były zapisane w jednym folderze.");
            this.button_load_new_data.UseVisualStyleBackColor = true;
            this.button_load_new_data.Click += new System.EventHandler(this.button_load_new_data_Click_1);
            // 
            // button_sensor_1
            // 
            this.button_sensor_1.BackColor = System.Drawing.Color.Silver;
            this.button_sensor_1.Enabled = false;
            this.button_sensor_1.Location = new System.Drawing.Point(380, 61);
            this.button_sensor_1.MaximumSize = new System.Drawing.Size(180, 38);
            this.button_sensor_1.Name = "button_sensor_1";
            this.button_sensor_1.Size = new System.Drawing.Size(140, 38);
            this.button_sensor_1.TabIndex = 3;
            this.button_sensor_1.Text = "Sensor 1";
            this.Tip_buttons.SetToolTip(this.button_sensor_1, "Kliknij, aby wyświetlić lub ukryć dane z wykresu odpowiadające\r\nza czujnik, który" +
        " znajduje się na górze.\r\nKolor zielony -> Czujnik aktywny\r\nKolor zielony -> Czuj" +
        "nik nieaktywny");
            this.button_sensor_1.UseVisualStyleBackColor = false;
            this.button_sensor_1.Click += new System.EventHandler(this.button_sensor_1_Click);
            // 
            // button_sensor_2
            // 
            this.button_sensor_2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_sensor_2.BackColor = System.Drawing.Color.Silver;
            this.button_sensor_2.Enabled = false;
            this.button_sensor_2.Location = new System.Drawing.Point(611, 61);
            this.button_sensor_2.MaximumSize = new System.Drawing.Size(180, 38);
            this.button_sensor_2.Name = "button_sensor_2";
            this.button_sensor_2.Size = new System.Drawing.Size(140, 38);
            this.button_sensor_2.TabIndex = 4;
            this.button_sensor_2.Text = "Sensor 2";
            this.Tip_buttons.SetToolTip(this.button_sensor_2, "Kliknij, aby wyświetlić lub ukryć dane z wykresu odpowiadające\r\nza czujnik, który" +
        " znajduje się pośrodku.\r\nKolor zielony -> Czujnik aktywny\r\nKolor zielony -> Czuj" +
        "nik nieaktywny");
            this.button_sensor_2.UseVisualStyleBackColor = false;
            this.button_sensor_2.Click += new System.EventHandler(this.button_sensor_2_Click);
            // 
            // button_sensor_3
            // 
            this.button_sensor_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_sensor_3.BackColor = System.Drawing.Color.Silver;
            this.button_sensor_3.Enabled = false;
            this.button_sensor_3.Location = new System.Drawing.Point(842, 61);
            this.button_sensor_3.MaximumSize = new System.Drawing.Size(180, 38);
            this.button_sensor_3.Name = "button_sensor_3";
            this.button_sensor_3.Size = new System.Drawing.Size(140, 38);
            this.button_sensor_3.TabIndex = 5;
            this.button_sensor_3.Text = "Sensor 3";
            this.Tip_buttons.SetToolTip(this.button_sensor_3, "Kliknij, aby wyświetlić lub ukryć dane z wykresu odpowiadające\r\nza czujnik. który" +
        " znajduje się na dole. \r\nKolor zielony -> Czujnik aktywny\r\nKolor zielony -> Czuj" +
        "nik nieaktywny");
            this.button_sensor_3.UseVisualStyleBackColor = false;
            this.button_sensor_3.Click += new System.EventHandler(this.button_sensor_3_Click);
            // 
            // button_accept_Data
            // 
            this.button_accept_Data.Location = new System.Drawing.Point(26, 382);
            this.button_accept_Data.Name = "button_accept_Data";
            this.button_accept_Data.Size = new System.Drawing.Size(150, 47);
            this.button_accept_Data.TabIndex = 9;
            this.button_accept_Data.Text = "Accept and view";
            this.Tip_buttons.SetToolTip(this.button_accept_Data, "Klknij, aby wyświetlić dane z czujników z wybranego dnia w rozwijającej się liści" +
        "e znajdującej się \r\nponiżej \"Detected Ports\" na wykresie.\r\n");
            this.button_accept_Data.UseVisualStyleBackColor = true;
            this.button_accept_Data.Click += new System.EventHandler(this.button_accept_Data_Click);
            // 
            // Check_ports
            // 
            this.Check_ports.Location = new System.Drawing.Point(26, 532);
            this.Check_ports.Name = "Check_ports";
            this.Check_ports.Size = new System.Drawing.Size(150, 30);
            this.Check_ports.TabIndex = 14;
            this.Check_ports.Text = "Check Ports";
            this.Tip_buttons.SetToolTip(this.Check_ports, resources.GetString("Check_ports.ToolTip"));
            this.Check_ports.UseVisualStyleBackColor = true;
            this.Check_ports.Click += new System.EventHandler(this.check_ports_Click);
            // 
            // button_clear_chart
            // 
            this.button_clear_chart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear_chart.Location = new System.Drawing.Point(1073, 120);
            this.button_clear_chart.Name = "button_clear_chart";
            this.button_clear_chart.Size = new System.Drawing.Size(97, 30);
            this.button_clear_chart.TabIndex = 19;
            this.button_clear_chart.Text = "Clear Chart";
            this.Tip_buttons.SetToolTip(this.button_clear_chart, "Kliknij jeśli chcesz wyczyścić dane z wykresem oraz uzywając\r\nprzycisku \"Accept a" +
        "nd view\" wybrać nowe dane wyświetlane \r\nna wykresie.\r\n");
            this.button_clear_chart.UseVisualStyleBackColor = true;
            this.button_clear_chart.Click += new System.EventHandler(this.button_clear_chart_Click);
            // 
            // button_confirm
            // 
            this.button_confirm.Enabled = false;
            this.button_confirm.Location = new System.Drawing.Point(202, 243);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(89, 56);
            this.button_confirm.TabIndex = 23;
            this.button_confirm.Text = "Confirm\r\nRange";
            this.Tip_buttons.SetToolTip(this.button_confirm, "Kliknij,aby wyświetlić na wykresie zakresu danych wpisanych w okienka tekstowe,\r\n" +
        "które znajdują się po lewej stronie.\r\n");
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // button_pointval_chart
            // 
            this.button_pointval_chart.Enabled = false;
            this.button_pointval_chart.Location = new System.Drawing.Point(26, 458);
            this.button_pointval_chart.Name = "button_pointval_chart";
            this.button_pointval_chart.Size = new System.Drawing.Size(150, 50);
            this.button_pointval_chart.TabIndex = 30;
            this.button_pointval_chart.Text = "Show Values on Chart";
            this.Tip_buttons.SetToolTip(this.button_pointval_chart, "Kliknij, aby włączyć lub wyłączyć widoku danych na wykresie");
            this.button_pointval_chart.UseVisualStyleBackColor = true;
            this.button_pointval_chart.Click += new System.EventHandler(this.button_pointval_chart_Click);
            // 
            // comboBox_gradient
            // 
            this.comboBox_gradient.Enabled = false;
            this.comboBox_gradient.FormattingEnabled = true;
            this.comboBox_gradient.Items.AddRange(new object[] {
            "PaΔ3-2",
            "PaΔ3-1",
            "PaΔ2-1"});
            this.comboBox_gradient.Location = new System.Drawing.Point(26, 108);
            this.comboBox_gradient.Name = "comboBox_gradient";
            this.comboBox_gradient.Size = new System.Drawing.Size(108, 21);
            this.comboBox_gradient.TabIndex = 43;
            this.Tip_buttons.SetToolTip(this.comboBox_gradient, "Kliknij, aby wybrać dla których czujników chcesz obliczyć \r\ngradient.\r\nNp: PaΔ2-1" +
        "=(Sensor 2(Max_Pa)-Sensor 1(Max_Pa))/L");
            this.comboBox_gradient.SelectedIndexChanged += new System.EventHandler(this.comboBox_gradient_SelectedIndexChanged);
            // 
            // button_TURN_ON_OFF
            // 
            this.button_TURN_ON_OFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_TURN_ON_OFF.Location = new System.Drawing.Point(26, 672);
            this.button_TURN_ON_OFF.Name = "button_TURN_ON_OFF";
            this.button_TURN_ON_OFF.Size = new System.Drawing.Size(150, 35);
            this.button_TURN_ON_OFF.TabIndex = 52;
            this.button_TURN_ON_OFF.Text = "Turn OFF messages";
            this.Tip_buttons.SetToolTip(this.button_TURN_ON_OFF, "Kliknij, jesli chcesz włączyć lub wyłączyć powiadomienia \r\ni podpowiedzi w progra" +
        "mie.");
            this.button_TURN_ON_OFF.UseVisualStyleBackColor = true;
            this.button_TURN_ON_OFF.Click += new System.EventHandler(this.button_TURN_ON_OFF_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Projekt_wielki_piec.Properties.Resources._123;
            this.pictureBox1.Location = new System.Drawing.Point(181, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 149);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Label_sensor1_value
            // 
            this.Label_sensor1_value.AutoSize = true;
            this.Label_sensor1_value.Location = new System.Drawing.Point(380, 120);
            this.Label_sensor1_value.Name = "Label_sensor1_value";
            this.Label_sensor1_value.Size = new System.Drawing.Size(73, 13);
            this.Label_sensor1_value.TabIndex = 0;
            this.Label_sensor1_value.Text = "Max pressure:";
            // 
            // Label_sensor_2_value
            // 
            this.Label_sensor_2_value.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_sensor_2_value.AutoSize = true;
            this.Label_sensor_2_value.Location = new System.Drawing.Point(611, 120);
            this.Label_sensor_2_value.Name = "Label_sensor_2_value";
            this.Label_sensor_2_value.Size = new System.Drawing.Size(73, 13);
            this.Label_sensor_2_value.TabIndex = 1;
            this.Label_sensor_2_value.Text = "Max pressure:";
            // 
            // Label_sensor_3_value
            // 
            this.Label_sensor_3_value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_sensor_3_value.AutoSize = true;
            this.Label_sensor_3_value.Location = new System.Drawing.Point(842, 120);
            this.Label_sensor_3_value.Name = "Label_sensor_3_value";
            this.Label_sensor_3_value.Size = new System.Drawing.Size(73, 13);
            this.Label_sensor_3_value.TabIndex = 2;
            this.Label_sensor_3_value.Text = "Max pressure:";
            // 
            // comboBox_View_Data
            // 
            this.comboBox_View_Data.FormattingEnabled = true;
            this.comboBox_View_Data.Location = new System.Drawing.Point(26, 336);
            this.comboBox_View_Data.Name = "comboBox_View_Data";
            this.comboBox_View_Data.Size = new System.Drawing.Size(238, 21);
            this.comboBox_View_Data.TabIndex = 7;
            this.comboBox_View_Data.SelectedIndexChanged += new System.EventHandler(this.comboBox_View_Data_SelectedIndexChanged);
            // 
            // Sensor_chart
            // 
            this.Sensor_chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.Sensor_chart.ChartAreas.Add(chartArea1);
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            legend1.IsTextAutoFit = false;
            legend1.MaximumAutoSize = 15F;
            legend1.Name = "Legend1";
            this.Sensor_chart.Legends.Add(legend1);
            this.Sensor_chart.Location = new System.Drawing.Point(300, 148);
            this.Sensor_chart.Name = "Sensor_chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Sensor_1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Sensor_2";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Sensor_3";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.Sensor_chart.Series.Add(series1);
            this.Sensor_chart.Series.Add(series2);
            this.Sensor_chart.Series.Add(series3);
            this.Sensor_chart.Size = new System.Drawing.Size(870, 581);
            this.Sensor_chart.TabIndex = 11;
            this.Sensor_chart.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.BottomRight;
            title1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            title1.Name = "title_x";
            title1.Position.Auto = false;
            title1.Position.Height = 4F;
            title1.Position.Width = 100F;
            title1.Position.Y = 94.62547F;
            title1.Text = "Time[s]";
            title2.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            title2.Name = "title_y";
            title2.Position.Auto = false;
            title2.Position.Height = 20F;
            title2.Position.Width = 2F;
            title2.Position.X = 2F;
            title2.Position.Y = 1F;
            title2.Text = "Pressure[Pa]";
            title2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            this.Sensor_chart.Titles.Add(title1);
            this.Sensor_chart.Titles.Add(title2);
            // 
            // label_load_data
            // 
            this.label_load_data.AutoSize = true;
            this.label_load_data.Location = new System.Drawing.Point(25, 320);
            this.label_load_data.Name = "label_load_data";
            this.label_load_data.Size = new System.Drawing.Size(107, 13);
            this.label_load_data.TabIndex = 12;
            this.label_load_data.Text = "Previous saved data:";
            // 
            // label_connect_ports
            // 
            this.label_connect_ports.AutoSize = true;
            this.label_connect_ports.Location = new System.Drawing.Point(29, 574);
            this.label_connect_ports.Name = "label_connect_ports";
            this.label_connect_ports.Size = new System.Drawing.Size(81, 13);
            this.label_connect_ports.TabIndex = 13;
            this.label_connect_ports.Text = "Detected Ports:";
            // 
            // label_range
            // 
            this.label_range.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_range.AutoSize = true;
            this.label_range.Location = new System.Drawing.Point(26, 227);
            this.label_range.Name = "label_range";
            this.label_range.Size = new System.Drawing.Size(60, 13);
            this.label_range.TabIndex = 20;
            this.label_range.Text = "View range";
            // 
            // textBox_start_time
            // 
            this.textBox_start_time.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_start_time.Location = new System.Drawing.Point(26, 243);
            this.textBox_start_time.MaxLength = 9;
            this.textBox_start_time.Name = "textBox_start_time";
            this.textBox_start_time.Size = new System.Drawing.Size(70, 20);
            this.textBox_start_time.TabIndex = 21;
            this.textBox_start_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_start_time.TextChanged += new System.EventHandler(this.textBox_start_time_TextChanged);
            // 
            // textBox_stop_time
            // 
            this.textBox_stop_time.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_stop_time.Location = new System.Drawing.Point(28, 279);
            this.textBox_stop_time.MaxLength = 9;
            this.textBox_stop_time.Name = "textBox_stop_time";
            this.textBox_stop_time.Size = new System.Drawing.Size(68, 20);
            this.textBox_stop_time.TabIndex = 22;
            this.textBox_stop_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_stop_time.TextChanged += new System.EventHandler(this.textBox_stop_time_TextChanged);
            // 
            // label_sensor2_view
            // 
            this.label_sensor2_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_sensor2_view.AutoSize = true;
            this.label_sensor2_view.Location = new System.Drawing.Point(282, 108);
            this.label_sensor2_view.Name = "label_sensor2_view";
            this.label_sensor2_view.Size = new System.Drawing.Size(49, 13);
            this.label_sensor2_view.TabIndex = 26;
            this.label_sensor2_view.Text = "Sensor 2";
            // 
            // label_sensor1_view
            // 
            this.label_sensor1_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_sensor1_view.AutoSize = true;
            this.label_sensor1_view.Location = new System.Drawing.Point(149, 64);
            this.label_sensor1_view.Name = "label_sensor1_view";
            this.label_sensor1_view.Size = new System.Drawing.Size(49, 13);
            this.label_sensor1_view.TabIndex = 27;
            this.label_sensor1_view.Text = "Sensor 1";
            // 
            // label_sensor3_view
            // 
            this.label_sensor3_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_sensor3_view.AutoSize = true;
            this.label_sensor3_view.Location = new System.Drawing.Point(149, 157);
            this.label_sensor3_view.Name = "label_sensor3_view";
            this.label_sensor3_view.Size = new System.Drawing.Size(49, 13);
            this.label_sensor3_view.TabIndex = 28;
            this.label_sensor3_view.Text = "Sensor 3";
            // 
            // comboBox_connected_ports
            // 
            this.comboBox_connected_ports.FormattingEnabled = true;
            this.comboBox_connected_ports.Location = new System.Drawing.Point(30, 590);
            this.comboBox_connected_ports.Name = "comboBox_connected_ports";
            this.comboBox_connected_ports.Size = new System.Drawing.Size(238, 21);
            this.comboBox_connected_ports.TabIndex = 29;
            this.comboBox_connected_ports.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(99, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "<--Start time[s]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(99, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "<--Stop time[s]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(0, 725);
            this.label3.MaximumSize = new System.Drawing.Size(200, 16);
            this.label3.MinimumSize = new System.Drawing.Size(118, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Made by Paweł Pawlaszczyk/ KKwiaton";
            // 
            // button_EXIT
            // 
            this.button_EXIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_EXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_EXIT.Location = new System.Drawing.Point(1083, -1);
            this.button_EXIT.Name = "button_EXIT";
            this.button_EXIT.Size = new System.Drawing.Size(100, 35);
            this.button_EXIT.TabIndex = 35;
            this.button_EXIT.UseVisualStyleBackColor = true;
            this.button_EXIT.Click += new System.EventHandler(this.button_EXIT_Click_1);
            this.button_EXIT.Paint += new System.Windows.Forms.PaintEventHandler(this.button_EXIT_Paint);
            // 
            // button_fullscreen
            // 
            this.button_fullscreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_fullscreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_fullscreen.Location = new System.Drawing.Point(985, -1);
            this.button_fullscreen.Name = "button_fullscreen";
            this.button_fullscreen.Size = new System.Drawing.Size(100, 35);
            this.button_fullscreen.TabIndex = 36;
            this.button_fullscreen.Text = "Full Screen";
            this.button_fullscreen.UseVisualStyleBackColor = true;
            this.button_fullscreen.Click += new System.EventHandler(this.button_fullscreen_Click);
            // 
            // button_minimize
            // 
            this.button_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_minimize.Location = new System.Drawing.Point(887, -1);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(100, 35);
            this.button_minimize.TabIndex = 39;
            this.button_minimize.Text = "Minimize";
            this.button_minimize.UseVisualStyleBackColor = true;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            // 
            // button_pomoc
            // 
            this.button_pomoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_pomoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_pomoc.Location = new System.Drawing.Point(789, -1);
            this.button_pomoc.Name = "button_pomoc";
            this.button_pomoc.Size = new System.Drawing.Size(100, 35);
            this.button_pomoc.TabIndex = 40;
            this.button_pomoc.Text = "Help";
            this.button_pomoc.UseVisualStyleBackColor = true;
            this.button_pomoc.Click += new System.EventHandler(this.button_pomoc_Click_1);
            // 
            // textBox_gradient
            // 
            this.textBox_gradient.Enabled = false;
            this.textBox_gradient.Location = new System.Drawing.Point(26, 65);
            this.textBox_gradient.MaxLength = 17;
            this.textBox_gradient.Name = "textBox_gradient";
            this.textBox_gradient.Size = new System.Drawing.Size(108, 20);
            this.textBox_gradient.TabIndex = 41;
            this.textBox_gradient.TextChanged += new System.EventHandler(this.textBox_gradient_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(24, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Insert L[mm]";
            // 
            // label_pick
            // 
            this.label_pick.AutoSize = true;
            this.label_pick.Location = new System.Drawing.Point(24, 92);
            this.label_pick.Name = "label_pick";
            this.label_pick.Size = new System.Drawing.Size(110, 13);
            this.label_pick.TabIndex = 44;
            this.label_pick.Text = "Calculate gradient for:";
            // 
            // Label_L_100
            // 
            this.Label_L_100.AutoSize = true;
            this.Label_L_100.Location = new System.Drawing.Point(128, 174);
            this.Label_L_100.MinimumSize = new System.Drawing.Size(0, 9);
            this.Label_L_100.Name = "Label_L_100";
            this.Label_L_100.Size = new System.Drawing.Size(53, 13);
            this.Label_L_100.TabIndex = 45;
            this.Label_L_100.Text = "L=100mm";
            // 
            // label_L_300
            // 
            this.label_L_300.AutoSize = true;
            this.label_L_300.Location = new System.Drawing.Point(291, 43);
            this.label_L_300.Name = "label_L_300";
            this.label_L_300.Size = new System.Drawing.Size(53, 13);
            this.label_L_300.TabIndex = 46;
            this.label_L_300.Text = "L=300mm";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-1, -67);
            this.panel1.MinimumSize = new System.Drawing.Size(5000, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5000, 100);
            this.panel1.TabIndex = 47;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_moive);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label_gradient21
            // 
            this.label_gradient21.AutoSize = true;
            this.label_gradient21.Location = new System.Drawing.Point(519, 65);
            this.label_gradient21.Name = "label_gradient21";
            this.label_gradient21.Size = new System.Drawing.Size(93, 13);
            this.label_gradient21.TabIndex = 48;
            this.label_gradient21.Text = "Max gradientΔ2-1:";
            // 
            // label_gradient32
            // 
            this.label_gradient32.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_gradient32.AutoSize = true;
            this.label_gradient32.Location = new System.Drawing.Point(750, 65);
            this.label_gradient32.Name = "label_gradient32";
            this.label_gradient32.Size = new System.Drawing.Size(93, 13);
            this.label_gradient32.TabIndex = 49;
            this.label_gradient32.Text = "Max gradientΔ3-2:";
            // 
            // label_gradient31
            // 
            this.label_gradient31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_gradient31.AutoSize = true;
            this.label_gradient31.Location = new System.Drawing.Point(981, 65);
            this.label_gradient31.Name = "label_gradient31";
            this.label_gradient31.Size = new System.Drawing.Size(93, 13);
            this.label_gradient31.TabIndex = 50;
            this.label_gradient31.Text = "Max gradientΔ3-1:";
            // 
            // label_gradient_OBL
            // 
            this.label_gradient_OBL.AutoSize = true;
            this.label_gradient_OBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_gradient_OBL.Location = new System.Drawing.Point(26, 141);
            this.label_gradient_OBL.Name = "label_gradient_OBL";
            this.label_gradient_OBL.Size = new System.Drawing.Size(106, 15);
            this.label_gradient_OBL.TabIndex = 51;
            this.label_gradient_OBL.Text = " Calculated gradient:";
            this.label_gradient_OBL.Visible = false;
            this.label_gradient_OBL.Click += new System.EventHandler(this.label_gradient_OBL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 741);
            this.Controls.Add(this.button_TURN_ON_OFF);
            this.Controls.Add(this.label_gradient_OBL);
            this.Controls.Add(this.label_gradient31);
            this.Controls.Add(this.label_gradient32);
            this.Controls.Add(this.label_gradient21);
            this.Controls.Add(this.label_L_300);
            this.Controls.Add(this.label_pick);
            this.Controls.Add(this.comboBox_gradient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_gradient);
            this.Controls.Add(this.button_pomoc);
            this.Controls.Add(this.button_minimize);
            this.Controls.Add(this.button_load_new_data);
            this.Controls.Add(this.button_fullscreen);
            this.Controls.Add(this.button_EXIT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_pointval_chart);
            this.Controls.Add(this.comboBox_connected_ports);
            this.Controls.Add(this.label_sensor3_view);
            this.Controls.Add(this.label_sensor1_view);
            this.Controls.Add(this.label_sensor2_view);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.textBox_stop_time);
            this.Controls.Add(this.textBox_start_time);
            this.Controls.Add(this.label_range);
            this.Controls.Add(this.button_clear_chart);
            this.Controls.Add(this.Check_ports);
            this.Controls.Add(this.label_connect_ports);
            this.Controls.Add(this.label_load_data);
            this.Controls.Add(this.Sensor_chart);
            this.Controls.Add(this.button_accept_Data);
            this.Controls.Add(this.comboBox_View_Data);
            this.Controls.Add(this.button_sensor_3);
            this.Controls.Add(this.button_sensor_2);
            this.Controls.Add(this.button_sensor_1);
            this.Controls.Add(this.Label_sensor_3_value);
            this.Controls.Add(this.Label_sensor_2_value);
            this.Controls.Add(this.Label_sensor1_value);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Label_L_100);
            this.Name = "Form1";
            this.Text = "Manometer converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_moive);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sensor_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip Tip_buttons;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label_sensor1_value;
        private System.Windows.Forms.Label Label_sensor_2_value;
        private System.Windows.Forms.Label Label_sensor_3_value;
        private System.Windows.Forms.Button button_sensor_1;
        private System.Windows.Forms.Button button_sensor_2;
        private System.Windows.Forms.Button button_sensor_3;
        private System.Windows.Forms.ComboBox comboBox_View_Data;
        private System.Windows.Forms.Button button_accept_Data;
        private System.Windows.Forms.DataVisualization.Charting.Chart Sensor_chart;
        private System.Windows.Forms.Label label_load_data;
        private System.Windows.Forms.Label label_connect_ports;
        private System.Windows.Forms.Button Check_ports;
        private System.Windows.Forms.Button button_clear_chart;
        private System.Windows.Forms.Label label_range;
        private System.Windows.Forms.TextBox textBox_start_time;
        private System.Windows.Forms.TextBox textBox_stop_time;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Label label_sensor2_view;
        private System.Windows.Forms.Label label_sensor1_view;
        private System.Windows.Forms.Label label_sensor3_view;
        private System.Windows.Forms.ComboBox comboBox_connected_ports;
        private System.Windows.Forms.Button button_pointval_chart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_EXIT;
        private System.Windows.Forms.Button button_fullscreen;
        private System.Windows.Forms.Button button_load_new_data;
        private System.Windows.Forms.Button button_minimize;
        private System.Windows.Forms.Button button_pomoc;
        private System.Windows.Forms.TextBox textBox_gradient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_gradient;
        private System.Windows.Forms.Label label_pick;
        private System.Windows.Forms.Label Label_L_100;
        private System.Windows.Forms.Label label_L_300;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_gradient21;
        private System.Windows.Forms.Label label_gradient32;
        private System.Windows.Forms.Label label_gradient31;
        private System.Windows.Forms.Label label_gradient_OBL;
        private System.Windows.Forms.Button button_TURN_ON_OFF;
    }
}

