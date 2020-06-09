using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Management;
using System.IO;
using System.Globalization;
using System.Web;
using System.Collections.ObjectModel;
using System.Drawing.Drawing2D;
using System.Windows.Forms.DataVisualization.Charting;


namespace Projekt_wielki_piec
{
    public partial class Form1 : Form
    {
        private int FZoomLevel = 0;

        public Form1()
        {
            InitializeComponent();
            comboBox_View_Data.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_gradient.DropDownStyle = ComboBoxStyle.DropDownList;
            Sensor_chart.Titles["title_x"].Visible = false;
            Sensor_chart.Titles["title_y"].Visible = false;
            Sensor_chart.MouseWheel += Sensor_chart_MouseWheel; //Mouse event
            this.FormBorderStyle = FormBorderStyle.None;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            comboBox_gradient.SelectedIndex = 0;

        }

        bool flag_sens_1 = true;
        bool flag_sens_2 = true;
        bool flag_sens_3 = true;
        bool flag_chart_valv = true;
        bool screen_max_min = true;
        bool flag_messages = true;
        List<Sensor_data_txt> lstsensor_1 = new List<Sensor_data_txt>();
        List<Sensor_data_txt> lstsensor_2 = new List<Sensor_data_txt>();
        List<Sensor_data_txt> lstsensor_3 = new List<Sensor_data_txt>();
        List<Every_Sensor_data> lstfinalsensor = new List<Every_Sensor_data>();
        List<Every_Sensor_data> lstfinalsensor_read_chart = new List<Every_Sensor_data>();
        List<DateTime> list_for_data = new List<DateTime>();
        FolderBrowserDialog Find_byclicking = new FolderBrowserDialog();
        string currentPath = Directory.GetCurrentDirectory();
        string currentMyComboBoxText;
     
        int pos_lst = 0, pos_lst1 = 0, pos_lst2 = 0, pos_lst3 = 0;
        Point lastPoint;
        int max_value_chart_list;
        int max_textbox_value;
        int min_textbox_value;
        int display_message_box = 0;
        double L_textbox_value;
        double delta_p;
        double sensor_31_delta;
        double sensor_32_delta;
        double sensor_21_delta;
        double Minvalue_read_1 = double.MinValue;
        double Minvalue_read_2 = double.MinValue;
        double Minvalue_read_3 = double.MinValue;
        double MinValue_to_label_1 = double.MinValue;
        double MinValue_to_label_2 = double.MinValue;
        double MinValue_to_label_3 = double.MinValue;

        int raise_1 = 0, raise_2 = 0, raise_3 = 0;
        string read_files_to_combox;
        int currentMyComboBoxIndex;




        private void Form1_Load(object sender, EventArgs e)
        {

            this.Text = "Program wielki piec";
            if (!Directory.Exists(Path.Combine(currentPath, "Zapisane_dane_pomiarowe")))
                Directory.CreateDirectory(Path.Combine(currentPath, "Zapisane_dane_pomiarowe"));

            read_files_to_combox = currentPath + @"\Zapisane_dane_pomiarowe";
            string[] files = Directory.GetFiles(read_files_to_combox);
            comboBox_View_Data.Items.Clear();

            foreach (string filePath in files)
            {
                comboBox_View_Data.Items.Add(Path.GetFileName(filePath));
            }

        }

        private void comboBox_View_Data_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentMyComboBoxText = Convert.ToString(comboBox_View_Data.SelectedItem);
            currentMyComboBoxText = currentMyComboBoxText.Replace("Sensor_data", "");
            currentMyComboBoxText = currentMyComboBoxText.Replace("_", "  ");
            currentMyComboBoxIndex = comboBox_View_Data.SelectedIndex;

        }

        private void comboBox_gradient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((L_textbox_value > 0) && (Convert.ToInt64(textBox_gradient.TextLength)>0))
            {
                label_gradient_OBL.Visible = true;
                switch (comboBox_gradient.SelectedIndex)
                {

                    case 0:
                        delta_p = sensor_32_delta / L_textbox_value;
                        label_gradient_OBL.Text = "Calculated gradient:" + "\n" + String.Format("{0:0.00}", delta_p) + " Pa/m";
                        break;//ΔPa3 - 2

                    case 1:
                        delta_p = sensor_31_delta / L_textbox_value;
                        label_gradient_OBL.Text = "Calculated gradient:" + "\n" + String.Format("{0:0.00}", delta_p) + " Pa/m";
                        break; //ΔPa3 - 1

                    case 2:
                        delta_p = sensor_21_delta / L_textbox_value;
                        label_gradient_OBL.Text = "Calculated gradient:" + "\n" + String.Format("{0:0.00}", delta_p) + " Pa/m";
                        break; //ΔPa2 - 1
                }
            }
            else { if (flag_messages == true && display_message_box>0) { MessageBox.Show("Wprowadz prawidłową wartość L przed wyświetleniem"); } }
            display_message_box++;
        }
        private void button_confirm_Click(object sender, EventArgs e)
        {

            if ((max_textbox_value > min_textbox_value) && (1 <= min_textbox_value) && (max_textbox_value < max_value_chart_list))
            {
                Clear_series_chart();
                for (int a1 = min_textbox_value - 1; a1 < max_textbox_value; a1++)
                {
                    double value1_pascal = double.Parse(lstfinalsensor_read_chart[a1].value_1, CultureInfo.InvariantCulture) * 98.0665; //przeliczanie na pascale
                    double value2_pascal = double.Parse(lstfinalsensor_read_chart[a1].value_2, CultureInfo.InvariantCulture) * 98.0665;
                    double value3_pascal = double.Parse(lstfinalsensor_read_chart[a1].value_3, CultureInfo.InvariantCulture) * 98.0665;
                    value1_pascal = Convert.ToDouble(String.Format("{0:0.00}", value1_pascal));
                    value2_pascal = Convert.ToDouble(String.Format("{0:0.00}", value2_pascal));
                    value3_pascal = Convert.ToDouble(String.Format("{0:0.00}", value3_pascal));
                    this.Sensor_chart.Series["Sensor_1"].Points.AddXY(lstfinalsensor_read_chart[a1].time_every, value1_pascal);
                    this.Sensor_chart.Series["Sensor_2"].Points.AddXY(lstfinalsensor_read_chart[a1].time_every, value2_pascal);
                    this.Sensor_chart.Series["Sensor_3"].Points.AddXY(lstfinalsensor_read_chart[a1].time_every, value3_pascal);

                }
            }
            else
            {

                if ((max_value_chart_list < max_textbox_value) && (max_textbox_value > min_textbox_value) && (max_value_chart_list > min_textbox_value) && (1 <= min_textbox_value)) // ustawiany wykres gdy liczba jest za duza 
                {
                    Clear_series_chart();
                    if (flag_messages == true)
                    {
                        MessageBox.Show("Ustawiono wykres dla czasu maksymalnego");
                    }
                    textBox_stop_time.Text = Convert.ToString(max_value_chart_list -1);
                    for (int a1 = min_textbox_value - 1; a1 < max_value_chart_list; a1++)
                    {
                        double value1_pascal = double.Parse(lstfinalsensor_read_chart[a1].value_1, CultureInfo.InvariantCulture) * 98.0665; //przeliczanie na pascale
                        double value2_pascal = double.Parse(lstfinalsensor_read_chart[a1].value_2, CultureInfo.InvariantCulture) * 98.0665;
                        double value3_pascal = double.Parse(lstfinalsensor_read_chart[a1].value_3, CultureInfo.InvariantCulture) * 98.0665;
                        value1_pascal = Convert.ToDouble(String.Format("{0:0.00}", value1_pascal));
                        value2_pascal = Convert.ToDouble(String.Format("{0:0.00}", value2_pascal));
                        value3_pascal = Convert.ToDouble(String.Format("{0:0.00}", value3_pascal));
                        this.Sensor_chart.Series["Sensor_1"].Points.AddXY(lstfinalsensor_read_chart[a1].time_every, value1_pascal);
                        this.Sensor_chart.Series["Sensor_2"].Points.AddXY(lstfinalsensor_read_chart[a1].time_every, value2_pascal);
                        this.Sensor_chart.Series["Sensor_3"].Points.AddXY(lstfinalsensor_read_chart[a1].time_every, value3_pascal);
                    }
                }
                else { if (flag_messages == true) { MessageBox.Show("Wprowadz poprawne wartości"); } }
            }
        }

        private void button_clear_chart_Click(object sender, EventArgs e)
        {
            textBox_gradient.Text = " ";
            label_gradient_OBL.Visible = false;
            Clear_series_chart();
            button_pointval_chart.Enabled = false;
            button_accept_Data.Enabled = true;
            button_confirm.Enabled = false;
            button_sensor_1.BackColor = Color.Silver;
            button_sensor_2.BackColor = Color.Silver;
            button_sensor_3.BackColor = Color.Silver;
            label_sensor2_view.ForeColor = Color.Black;
            label_sensor1_view.ForeColor = Color.Black;
            label_sensor3_view.ForeColor = Color.Black;
            flag_sens_1 = true;
            flag_sens_2 = true;
            comboBox_gradient.Enabled = false;
            flag_sens_3 = true;
            button_sensor_1.Enabled = false;
            button_sensor_2.Enabled = false;
            button_sensor_3.Enabled = false;
            textBox_gradient.Enabled = false;
            button_accept_Data.Enabled = true;
            Sensor_chart.Series["Sensor_1"].Enabled = true;
            Sensor_chart.Series["Sensor_2"].Enabled = true;
            Sensor_chart.Series["Sensor_3"].Enabled = true;
            comboBox_View_Data.Enabled = true;
            Label_sensor1_value.Text = "Max pressure:";
            Label_sensor_2_value.Text = "Max pressure:";
            Label_sensor_3_value.Text = "Max pressure:";
            label_gradient21.Text = "Max gradient2-1:";
            label_gradient31.Text = "Max gradient3-1:";
            label_gradient32.Text = "Max gradient3-2:";
            label_gradient_OBL.Text = "Calculated gradient:";
            flag_chart_valv = true;
            this.Sensor_chart.Series["Sensor_1"].IsValueShownAsLabel = false;
            this.Sensor_chart.Series["Sensor_2"].IsValueShownAsLabel = false;
            this.Sensor_chart.Series["Sensor_3"].IsValueShownAsLabel = false;
            Sensor_chart.Titles["title_x"].Visible = false;
            Sensor_chart.Titles["title_y"].Visible = false;
            if (flag_messages == true) { MessageBox.Show("Wyczyszczono przestrzeń z wykresem"); }
        }



        private void check_ports_Click(object sender, EventArgs e)
        {
            comboBox_connected_ports.Visible = false;
            comboBox_connected_ports.Items.Clear(); // inaczej nowe dane beda sie nakladac z starymi danymi

            Port_Detector();

            comboBox_connected_ports.Visible = true;
            comboBox_connected_ports.DropDownStyle = ComboBoxStyle.DropDownList; //blokuje wyswietlanie sie przypadkowych rzeczy po clearu
            if (flag_messages == true) { MessageBox.Show("Sprawdzono podłączone porty"); }
        }
        //--------------------------------------------------CHART DATA---------------------------------------------
        private void button_accept_Data_Click(object sender, EventArgs e)
        {
            if (currentMyComboBoxText != null)
            {
                if (flag_messages == true) { MessageBox.Show("Wybrano dane pomiarowe z dnia: " + currentMyComboBoxText); }
                button_pointval_chart.Enabled = true;
                button_confirm.Enabled = true;
                button_sensor_1.Enabled = true;
                button_sensor_2.Enabled = true;
                button_sensor_3.Enabled = true;
                textBox_gradient.Enabled = true;
                comboBox_gradient.Enabled = true;
                button_accept_Data.Enabled = false;
                comboBox_View_Data.Enabled = false;
                Sensor_chart.Titles["title_x"].Visible = true;
                Sensor_chart.Titles["title_y"].Visible = true;



                string[] files = Directory.GetFiles(read_files_to_combox);
                if (comboBox_View_Data.SelectedIndex == currentMyComboBoxIndex)
                {
                    int zwieksz = 0;
                    string Current_sensor_data_txt = files[currentMyComboBoxIndex];

                    string line1 = File.ReadLines(Current_sensor_data_txt).First();
                    int max_lenght_of_txt_file = line1.Length;


                    foreach (string line in File.ReadLines(Current_sensor_data_txt))
                    {
                        int lenght_current_line = line.Length;
                        if (lenght_current_line >= max_lenght_of_txt_file)
                        {


                            string time_table = line.Substring(0, 8);
                            string value_sensor1 = line.Substring(10, 8);
                            string value_sensor2 = line.Substring(18, 10);
                            string value_sensor3 = line.Substring(28, 8);
                            time_table = time_table.Replace(" ", "");
                            value_sensor1 = value_sensor1.Replace(" ", "");
                            value_sensor2 = value_sensor2.Replace(" ", "");
                            value_sensor3 = value_sensor3.Replace(" ", "");

                            lstfinalsensor_read_chart.Add(new Every_Sensor_data());
                            lstfinalsensor_read_chart[zwieksz].time_every = time_table;
                            lstfinalsensor_read_chart[zwieksz].value_1 = value_sensor1;
                            lstfinalsensor_read_chart[zwieksz].value_2 = value_sensor2;
                            lstfinalsensor_read_chart[zwieksz].value_3 = value_sensor3;
                            zwieksz++;

                        }

                    }
                    for (int i = 0; i < zwieksz; i++)// wyswietlanie w labelu wartosci max
                    {
                        double value_label_1 = double.Parse(lstfinalsensor_read_chart[i].value_1, CultureInfo.InvariantCulture);
                        if (value_label_1 >= MinValue_to_label_1)
                        {
                            MinValue_to_label_1 = value_label_1;
                        }
                        double value_label_2 = double.Parse(lstfinalsensor_read_chart[i].value_2, CultureInfo.InvariantCulture);
                        if (value_label_2 >= MinValue_to_label_2)
                        {
                            MinValue_to_label_2 = value_label_2;
                        }
                        double value_label_3 = double.Parse(lstfinalsensor_read_chart[i].value_3, CultureInfo.InvariantCulture);
                        if (value_label_3 >= MinValue_to_label_3)
                        {
                            MinValue_to_label_3 = value_label_3;
                        }

                    }
                    MinValue_to_label_1 = MinValue_to_label_1 * 98.0665;
                    MinValue_to_label_2 = MinValue_to_label_2 * 98.0665;
                    MinValue_to_label_3 = MinValue_to_label_3 * 98.0665;
                    sensor_31_delta = (MinValue_to_label_3 - MinValue_to_label_1);
                    sensor_32_delta = (MinValue_to_label_3 - MinValue_to_label_2);
                    sensor_21_delta = (MinValue_to_label_2 - MinValue_to_label_1);
                    label_gradient32.Text = "Max gradientΔ3-2:" + "\n" + String.Format("{0:0.00}", (sensor_32_delta / 0.1)) + " Pa/m";
                    label_gradient21.Text = "Max gradientΔ2-1:" + "\n" + String.Format("{0:0.00}", (sensor_21_delta / 0.2)) + " Pa/m";
                    label_gradient31.Text = "Max gradientΔ3-1:" + "\n" + String.Format("{0:0.00}", (sensor_31_delta / 0.3)) + " Pa/m";
                    Label_sensor1_value.Text = "Max pressure:" + String.Format("{0:0.00}", MinValue_to_label_1) + " Pa";
                    Label_sensor_2_value.Text = "Max pressure:" + String.Format("{0:0.00}", MinValue_to_label_2) + " Pa";
                    Label_sensor_3_value.Text = "Max pressure:" + String.Format("{0:0.00}", MinValue_to_label_3) + " Pa";

                    max_value_chart_list = zwieksz;

                    MinValue_to_label_1 = double.MinValue;
                    MinValue_to_label_2 = double.MinValue;
                    MinValue_to_label_3 = double.MinValue;



                    for (int a1 = 0; a1 < zwieksz; a1++)
                    {
                        double value1_pascal = double.Parse(lstfinalsensor_read_chart[a1].value_1, CultureInfo.InvariantCulture) * 98.0665; //przeliczanie na pascale
                        double value2_pascal = double.Parse(lstfinalsensor_read_chart[a1].value_2, CultureInfo.InvariantCulture) * 98.0665;
                        double value3_pascal = double.Parse(lstfinalsensor_read_chart[a1].value_3, CultureInfo.InvariantCulture) * 98.0665;
                        value1_pascal = Convert.ToDouble(String.Format("{0:0.00}", value1_pascal));
                        value2_pascal = Convert.ToDouble(String.Format("{0:0.00}", value2_pascal));
                        value3_pascal = Convert.ToDouble(String.Format("{0:0.00}", value3_pascal));
                        this.Sensor_chart.Series["Sensor_1"].Points.AddXY(lstfinalsensor_read_chart[a1].time_every, value1_pascal);
                        this.Sensor_chart.Series["Sensor_2"].Points.AddXY(lstfinalsensor_read_chart[a1].time_every, value2_pascal);
                        this.Sensor_chart.Series["Sensor_3"].Points.AddXY(lstfinalsensor_read_chart[a1].time_every, value3_pascal);

                    }
                    button_sensor_1.BackColor = Color.Green;
                    button_sensor_2.BackColor = Color.Green;
                    button_sensor_3.BackColor = Color.Green;
                    label_sensor2_view.ForeColor = Color.Green;
                    label_sensor1_view.ForeColor = Color.Green;
                    label_sensor3_view.ForeColor = Color.Green;

                }
                else { }
            }
            else { if (flag_messages == true) { MessageBox.Show("Wybierz dane z listy"); } }

        }


        private void textBox_start_time_TextChanged(object sender, EventArgs e)
        {
            textBox_start_time.Text = string.Concat(textBox_start_time.Text.Where(char.IsDigit));
            if (textBox_start_time.TextLength > 0)
            {
                min_textbox_value = Convert.ToInt32(textBox_start_time.Text);
            }
            else { }

        }

        private void textBox_stop_time_TextChanged(object sender, EventArgs e)
        {
            textBox_stop_time.Text = string.Concat(textBox_stop_time.Text.Where(char.IsDigit));
            if (textBox_stop_time.TextLength > 0)
            {
                max_textbox_value = Convert.ToInt32(textBox_stop_time.Text);
            }
            else { }

        }
        //---------------------------------------load button

        private void button_load_new_data_Click_1(object sender, EventArgs e)
        {
            {

                if (Find_byclicking.ShowDialog() == DialogResult.OK)
                {
                    Move_files_ASM_OTHERS();

                    if (Directory.GetFiles(Find_byclicking.SelectedPath).Length <= 2)
                    {
                        if (flag_messages == true) { MessageBox.Show("Folder jest pusty lub za mało plików txt"); }

                    }
                    else
                    {
                        //______________________________________________________

                        string[] files_only_txt = Directory.GetFiles(Find_byclicking.SelectedPath);
                        int files_lenght_array_txt = files_only_txt.Length;
                        string[] recent_files_txt = new string[3]; // sciezki dla najnowyszch plikow
                        for (int i = 0; i < files_lenght_array_txt; i++)
                        {
                            string full_path_name = files_only_txt[i];
                            DateTime date_modify_var = File.GetLastWriteTime(full_path_name);
                            string Data_Raw_Data = Convert.ToString(string.Format("{0:yyyy-MM-dd hh-mm-ss}", date_modify_var));
                            Data_Raw_Data = Data_Raw_Data.Replace("-", "");
                            Data_Raw_Data = Data_Raw_Data.Replace(":", "");
                            Data_Raw_Data = Data_Raw_Data.Replace(" ", "");
                            int year = Convert.ToInt32(Data_Raw_Data.Substring(0, 4));
                            int month = Convert.ToInt32(Data_Raw_Data.Substring(4, 2));
                            int day = Convert.ToInt32(Data_Raw_Data.Substring(6, 2));
                            int hour = Convert.ToInt32(Data_Raw_Data.Substring(8, 2));
                            int minute = Convert.ToInt32(Data_Raw_Data.Substring(10, 2));
                            int second = Convert.ToInt32(Data_Raw_Data.Substring(12, 2));
                            list_for_data.Add(new DateTime(year, month, day, hour, minute, second));

                            if (files_lenght_array_txt - 1 == i)
                            {
                                for (int i_1 = 0; i_1 < 3; i_1++)
                                {
                                    int maxIndex = list_for_data.ToList().IndexOf(list_for_data.Max());
                                    recent_files_txt[i_1] = files_only_txt[maxIndex];
                                    list_for_data.RemoveAt(maxIndex);
                                    var replace_data = new DateTime(2000, 10, 10, 10, 10, 10);
                                    list_for_data.Insert(maxIndex, replace_data); //dla zgodnosci indeksow 
                                }
                            }
                        }



                        //_________________________________1_________________________      
                        foreach (string line in File.ReadLines(recent_files_txt[0]))
                        {
                            if (line.Contains("cmH2O"))
                            {
                                string time_table = line.Substring(0, 9);
                                string value_table = line.Substring(20, 10);
                                string ticking_time_table = line.Substring(53, 12);
                                value_table = value_table.Replace("-", "");
                                value_table = value_table.Replace("+", "");

                                lstsensor_1.Add(new Sensor_data_txt());
                                lstsensor_1[raise_1].time = time_table;
                                lstsensor_1[raise_1].value = value_table;
                                lstsensor_1[raise_1].ticking_time = ticking_time_table;

                                raise_1++;
                            }
                            else
                            {
                            }
                        }



                        for (int i = 0; i < raise_1; i++)
                        {
                            string var_list_now = lstsensor_1[i].value;
                            var_list_now = var_list_now.Replace(" ", "");
                            double final = double.Parse(var_list_now, CultureInfo.InvariantCulture);
                            if (final >= Minvalue_read_1)
                            {
                                Minvalue_read_1 = final;
                            }

                        }

                        //______________________________________________2_____________
                        foreach (string line in File.ReadLines(recent_files_txt[1]))
                        {
                            if (line.Contains("cmH2O"))
                            {
                                string time_table = line.Substring(0, 9);
                                string value_table = line.Substring(20, 10);
                                value_table = value_table.Replace("-", "");
                                value_table = value_table.Replace("+", "");

                                string ticking_time_table = line.Substring(53, 12);

                                lstsensor_2.Add(new Sensor_data_txt());
                                lstsensor_2[raise_2].time = time_table;
                                lstsensor_2[raise_2].value = value_table;
                                lstsensor_2[raise_2].ticking_time = ticking_time_table;

                                raise_2++;
                            }
                            else
                            {
                            }
                        }

                        for (int i = 0; i < raise_2; i++)
                        {
                            string var_list_now = lstsensor_2[i].value;
                            var_list_now = var_list_now.Replace(" ", "");
                            double final = double.Parse(var_list_now, CultureInfo.InvariantCulture);
                            if (final >= Minvalue_read_2)
                            {
                                Minvalue_read_2 = final;
                            }

                        }

                        //______________________________________________3_____________
                        foreach (string line in File.ReadLines(recent_files_txt[2]))
                        {
                            if (line.Contains("cmH2O"))
                            {
                                string time_table = line.Substring(0, 9);
                                string value_table = line.Substring(20, 10);
                                string ticking_time_table = line.Substring(53, 12);
                                value_table = value_table.Replace("-", "");
                                value_table = value_table.Replace("+", "");

                                lstsensor_3.Add(new Sensor_data_txt());
                                lstsensor_3[raise_3].time = time_table;
                                lstsensor_3[raise_3].value = value_table;
                                lstsensor_3[raise_3].ticking_time = ticking_time_table;

                                raise_3++;
                            }
                            else
                            {
                            }
                        }

                        for (int i = 0; i < raise_3; i++)
                        {
                            string var_list_now = lstsensor_3[i].value;
                            var_list_now = var_list_now.Replace(" ", "");
                            double final = double.Parse(var_list_now, CultureInfo.InvariantCulture);
                            if (final >= Minvalue_read_3)
                            {
                                Minvalue_read_3 = final;
                            }

                        }
                        double[] max_value_array = new double[3];
                        max_value_array[0] = Minvalue_read_1;
                        max_value_array[1] = Minvalue_read_2;
                        max_value_array[2] = Minvalue_read_3;
                        
                        int array_id_max_sens1 = max_value_array.ToList().IndexOf(max_value_array.Max());
                        int array_id_min_sens3 = max_value_array.ToList().IndexOf(max_value_array.Min());



                        File.Delete(recent_files_txt[1]);
                        File.Delete(recent_files_txt[2]);
                        File.Delete(recent_files_txt[0]);

                        //--------------------------------------------------------------

                        DateTime sens1 = Convert.ToDateTime(lstsensor_1[0].ticking_time);
                        DateTime sens2 = Convert.ToDateTime(lstsensor_2[0].ticking_time);
                        DateTime sens3 = Convert.ToDateTime(lstsensor_3[0].ticking_time);
                        string value_final;


                        if (sens1 > sens2)
                        {
                            if (sens1 > sens3)
                            {
                                value_final = Convert.ToString(lstsensor_1[0].ticking_time);
                            }
                            else
                            {
                                value_final = Convert.ToString(lstsensor_2[0].ticking_time);
                            }
                        }
                        else
                        {
                            if (sens2 > sens3)
                            {
                                value_final = Convert.ToString(lstsensor_2[0].ticking_time);
                            }
                            else
                            {
                                value_final = Convert.ToString(lstsensor_3[0].ticking_time);
                            }
                        }


                        //__________________________________
                        DateTime date_found = Convert.ToDateTime(value_final);

                        if (lstsensor_1[0].ticking_time == value_final)
                        {

                            int maxRange_s2 = Convert.ToInt32(lstsensor_2.Max(x => x.time));
                            int maxRange_s3 = Convert.ToInt32(lstsensor_3.Max(x => x.time));




                            foreach (Sensor_data_txt line in lstsensor_1)
                            {

                                if ((pos_lst < maxRange_s2) && (pos_lst < maxRange_s3))
                                {
                                    DateTime date_lst_2 = Convert.ToDateTime(lstsensor_2[pos_lst].ticking_time);
                                    DateTime date_lst_3 = Convert.ToDateTime(lstsensor_3[pos_lst].ticking_time);
                                    lstfinalsensor.Add(new Every_Sensor_data());
                                    lstfinalsensor[pos_lst].time_every = lstsensor_1[pos_lst].time;
                                    switch (array_id_max_sens1)
                                    {
                                        case 0:

                                            switch (array_id_min_sens3)
                                            {

                                                //_____________________________________________ 1-min[2]=value1 2-avg[3]=value2 0-max[1]=value3
                                                case 1:

                                                    lstfinalsensor[pos_lst].value_3 = lstsensor_1[pos_lst].value;

                                                    if (date_lst_2 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst2].value_1 = lstsensor_2[pos_lst].value;
                                                        pos_lst2++;
                                                    }
                                                    if (date_lst_3 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst3].value_2 = lstsensor_3[pos_lst].value;
                                                        pos_lst3++;
                                                    }
                                                    break;
                                                //_____________________________________________ 2-min[3]=value1 3-avg[2]=value2 0-max[1]=value3
                                                case 2:

                                                     lstfinalsensor[pos_lst].value_3 = lstsensor_1[pos_lst].value;

                                                    if (date_lst_2 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst2].value_2 = lstsensor_2[pos_lst].value;
                                                        pos_lst2++;
                                                    }
                                                    if (date_lst_3 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst3].value_1 = lstsensor_3[pos_lst].value;
                                                        pos_lst3++;
                                                    }
                                                    break;
                                            }
                                            break;
                                        case 1:
                                            switch (array_id_min_sens3)
                                            {
                                                //_____________________________________________ 0-min[1]=value1 2-avg[3]=value2 1-max[2]=value3

                                                case 0:

                                                    lstfinalsensor[pos_lst].value_1 = lstsensor_1[pos_lst].value;

                                                    if (date_lst_2 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst2].value_3 = lstsensor_2[pos_lst].value;
                                                        pos_lst2++;
                                                    }
                                                    if (date_lst_3 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst3].value_2 = lstsensor_3[pos_lst].value;
                                                        pos_lst3++;
                                                    }
                                                    break;
                                                //_____________________________________________2-min[3]=value1 0-avg[1]=value2 1-max[2]=value3 
                                                case 2:

                                                    lstfinalsensor[pos_lst].value_2 = lstsensor_1[pos_lst].value;

                                                    if (date_lst_2 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst2].value_3 = lstsensor_2[pos_lst].value;
                                                        pos_lst2++;
                                                    }
                                                    if (date_lst_3 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst3].value_1 = lstsensor_3[pos_lst].value;
                                                        pos_lst3++;
                                                    }

                                                    break;
                                            }
                                            break;
                                        case 2:
                                            switch (array_id_min_sens3)
                                            {
                                                //_____________________________________________1-min[2]=value1 0-avg[1]=value2 2-max[3]=value3 
                                                case 1:

                                                    lstfinalsensor[pos_lst].value_2 = lstsensor_1[pos_lst].value;

                                                    if (date_lst_2 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst2].value_1 = lstsensor_2[pos_lst].value;
                                                        pos_lst2++;
                                                    }
                                                    if (date_lst_3 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst3].value_3 = lstsensor_3[pos_lst].value;
                                                        pos_lst3++;
                                                    }
                                                    break;
                                                //_____________________________________________ 0-min[1]=value1 1-avg[2]=value2 2-max[3]=value3
                                                case 0:

                                                    lstfinalsensor[pos_lst].value_1 = lstsensor_1[pos_lst].value;

                                                    if (date_lst_2 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst2].value_2 = lstsensor_2[pos_lst].value;
                                                        pos_lst2++;
                                                    }
                                                    if (date_lst_3 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst3].value_3 = lstsensor_3[pos_lst].value;
                                                        pos_lst3++;
                                                    }
                                                    break;
                                            }
                                            break;
                                    }
                                }

                                pos_lst++;

                            }

                        }

                        //------------------------------------------




                        //________________________________________________________

                        if (lstsensor_2[0].ticking_time == value_final)
                        {
                            foreach (Sensor_data_txt line2 in lstsensor_2)
                            {
                                int maxRange_s1 = Convert.ToInt32(lstsensor_1.Max(x => x.time));
                                int maxRange_s3 = Convert.ToInt32(lstsensor_3.Max(x => x.time));
                                if ((pos_lst < maxRange_s1) && (pos_lst < maxRange_s3))
                                {
                                    lstfinalsensor.Add(new Every_Sensor_data());
                                    lstfinalsensor[pos_lst].time_every = lstsensor_2[pos_lst].time;
                                    DateTime date_lst_1 = Convert.ToDateTime(lstsensor_1[pos_lst].ticking_time);
                                    DateTime date_lst_3 = Convert.ToDateTime(lstsensor_3[pos_lst].ticking_time);

                                    switch (array_id_max_sens1)
                                    {
                                        case 0:

                                            switch (array_id_min_sens3)
                                            {

                                                //_____________________________________________ 1-min[2]=value1 2-avg[3]=value2 0-max[1]=value3
                                                case 1:

                                                    lstfinalsensor[pos_lst].value_1 = lstsensor_2[pos_lst].value;

                                                    if (date_lst_1 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst1].value_3 = lstsensor_1[pos_lst].value;
                                                        pos_lst1++;
                                                    }
                                                    if (date_lst_3 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst3].value_2 = lstsensor_3[pos_lst].value;
                                                        pos_lst3++;
                                                    }
                                                    break;
                                                //_____________________________________________ 2-min[3]=value1 3-avg[2]=value2 0-max[1]=value3
                                                case 2:

                                                    lstfinalsensor[pos_lst].value_2 = lstsensor_2[pos_lst].value;

                                                    if (date_lst_1 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst1].value_3 = lstsensor_1[pos_lst].value;
                                                        pos_lst1++;
                                                    }
                                                    if (date_lst_3 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst3].value_1 = lstsensor_3[pos_lst].value;
                                                        pos_lst3++;
                                                    }
                                                    break;
                                            }
                                            break;
                                        case 1:
                                            switch (array_id_min_sens3)
                                            {
                                                //_____________________________________________ 0-min[1]=value1 2-avg[3]=value2 1-max[2]=value3

                                                case 0:

                                                    lstfinalsensor[pos_lst].value_3 = lstsensor_2[pos_lst].value;

                                                    if (date_lst_1 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst1].value_1 = lstsensor_1[pos_lst].value;
                                                        pos_lst1++;
                                                    }
                                                    if (date_lst_3 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst3].value_2 = lstsensor_3[pos_lst].value;
                                                        pos_lst3++;
                                                    }
                                                    break;
                                                //__________________________________zjebv@___________2-min[3]=value1 0-avg[1]=value2 1-max[2]=value3 
                                                case 2:

                                                    lstfinalsensor[pos_lst].value_3 = lstsensor_2[pos_lst].value;

                                                    if (date_lst_1 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst1].value_2 = lstsensor_1[pos_lst].value;
                                                        pos_lst1++;
                                                    }
                                                    if (date_lst_3 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst3].value_1 = lstsensor_3[pos_lst].value;
                                                        pos_lst3++;
                                                    }

                                                    break;
                                            }
                                            break;
                                        case 2:
                                            switch (array_id_min_sens3)
                                            {
                                                //_____________________________________________1-min[2]=value1 0-avg[1]=value2 2-max[3]=value3 
                                                case 1:

                                                    lstfinalsensor[pos_lst].value_1 = lstsensor_2[pos_lst].value;

                                                    if (date_lst_1 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst1].value_2 = lstsensor_1[pos_lst].value;
                                                        pos_lst1++;
                                                    }
                                                    if (date_lst_3 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst3].value_3 = lstsensor_3[pos_lst].value;
                                                        pos_lst3++;
                                                    }
                                                    break;
                                                //_____________________________________________ 0-min[1]=value1 1-avg[2]=value2 2-max[3]=value3
                                                case 0:

                                                    lstfinalsensor[pos_lst].value_2 = lstsensor_2[pos_lst].value;

                                                    if (date_lst_1 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst1].value_1 = lstsensor_1[pos_lst].value;
                                                        pos_lst1++;
                                                    }
                                                    if (date_lst_3 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst3].value_3 = lstsensor_3[pos_lst].value;
                                                        pos_lst3++;
                                                    }
                                                    break;
                                            }
                                            break;
                                    }

                                    pos_lst++;

                                }
                            }
                        }
                        //-----------------------------------------------
                        //---------------------------------------------------------------------
                        if (lstsensor_3[0].ticking_time == value_final)
                        {

                            foreach (Sensor_data_txt line2 in lstsensor_3)
                            {
                                int maxRange_s1 = Convert.ToInt32(lstsensor_1.Max(x => x.time));
                                int maxRange_s2 = Convert.ToInt32(lstsensor_2.Max(x => x.time));
                                if ((pos_lst < maxRange_s1) && (pos_lst < maxRange_s2))
                                {
                                    lstfinalsensor.Add(new Every_Sensor_data());
                                    lstfinalsensor[pos_lst].time_every = lstsensor_3[pos_lst].time;
                                    DateTime date_lst_1 = Convert.ToDateTime(lstsensor_1[pos_lst].ticking_time);
                                    DateTime date_lst_2 = Convert.ToDateTime(lstsensor_2[pos_lst].ticking_time);

                                    switch (array_id_max_sens1)
                                    {
                                        case 0:

                                            switch (array_id_min_sens3)
                                            {

                                                //_____________________________________________ 1-min[2]=value1 2-avg[3]=value2 0-max[1]=value3
                                                case 1:

                                                    lstfinalsensor[pos_lst].value_2 = lstsensor_3[pos_lst].value;

                                                    if (date_lst_1 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst1].value_3 = lstsensor_1[pos_lst].value;
                                                        pos_lst1++;
                                                    }
                                                    if (date_lst_2 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst2].value_1 = lstsensor_2[pos_lst].value;
                                                        pos_lst2++;
                                                    }
                                                    break;
                                                //_____________________________________________ 2-min[3]=value1 3-avg[2]=value2 0-max[1]=value3
                                                case 2:

                                                    lstfinalsensor[pos_lst].value_1 = lstsensor_3[pos_lst].value;

                                                    if (date_lst_1 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst1].value_3 = lstsensor_1[pos_lst].value;
                                                        pos_lst1++;
                                                    }
                                                    if (date_lst_2 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst2].value_2 = lstsensor_2[pos_lst].value;
                                                        pos_lst2++;
                                                    }
                                                    break;
                                            }
                                            break;
                                        case 1:
                                            switch (array_id_min_sens3)
                                            {
                                                //_____________________________________________ 0-min[1]=value1 2-avg[3]=value2 1-max[2]=value3
                                                case 0:
                                                    lstfinalsensor[pos_lst].value_2 = lstsensor_3[pos_lst].value;

                                                    if (date_lst_1 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst1].value_1 = lstsensor_1[pos_lst].value;
                                                        pos_lst1++;
                                                    }
                                                    if (date_lst_2 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst2].value_3 = lstsensor_2[pos_lst].value;
                                                        pos_lst2++;
                                                    }
                                                    break;
                                                //_____________________________________________2-min[3]=value1 0-avg[1]=value2 1-max[2]=value3 
                                                case 2:
                                                    lstfinalsensor[pos_lst].value_1 = lstsensor_3[pos_lst].value;

                                                    if (date_lst_1 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst1].value_2 = lstsensor_1[pos_lst].value;
                                                        pos_lst1++;
                                                    }
                                                    if (date_lst_2 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst2].value_3 = lstsensor_2[pos_lst].value;
                                                        pos_lst2++;
                                                    }

                                                    break;
                                            }
                                            break;
                                        case 2:
                                            switch (array_id_min_sens3)
                                            {
                                                //_____________________________________________1-min[2]=value1 0-avg[1]=value2 2-max[3]=value3 
                                                case 1:

                                                    lstfinalsensor[pos_lst].value_3 = lstsensor_3[pos_lst].value;

                                                    if (date_lst_1 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst1].value_2 = lstsensor_1[pos_lst].value;
                                                        pos_lst1++;
                                                    }
                                                    if (date_lst_2 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst2].value_1 = lstsensor_2[pos_lst].value;
                                                        pos_lst2++;
                                                    }
                                                    break;
                                                //____________________________Cos sie zjebalo tu______________ 0-min[1]=value1 1-avg[2]=value2 2-max[3]=value3
                                                case 0:

                                                    lstfinalsensor[pos_lst].value_3 = lstsensor_3[pos_lst].value;

                                                    if (date_lst_1 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst1].value_1 = lstsensor_1[pos_lst].value;
                                                        pos_lst1++;
                                                    }
                                                    if (date_lst_2 >= date_found)
                                                    {
                                                        lstfinalsensor[pos_lst2].value_2 = lstsensor_2[pos_lst].value;
                                                        pos_lst2++;
                                                    }
                                                    break;
                                            }
                                            break;
                                    }

                                    pos_lst++;
                                }
                            }
                        }

                        //--------------------------------------------



                        if (!Directory.Exists(Path.Combine(currentPath, "Zapisane_dane_pomiarowe")))
                            Directory.CreateDirectory(Path.Combine(currentPath, "Zapisane_dane_pomiarowe"));
                        var myUniqueFileName = string.Format("Sensor_data {0:yyyy-MM-dd_hh-mm-ss}", DateTime.Now);
                        TextWriter tw = new StreamWriter(myUniqueFileName);
                        string sourceFile = currentPath + @"\" + myUniqueFileName;
                        string destinationFile = currentPath + @"\Zapisane_dane_pomiarowe\" + myUniqueFileName;

                        foreach (Every_Sensor_data line_21 in lstfinalsensor)
                        {
                            tw.WriteLine(line_21.get_data_final());
                        }

                        tw.Close();
                        File.Move(sourceFile, destinationFile);
                        //-----------------------------------------------
                        read_files_to_combox = currentPath + @"\Zapisane_dane_pomiarowe";
                        string[] files = Directory.GetFiles(read_files_to_combox);
                        comboBox_View_Data.Items.Clear();

                        foreach (string filePath in files)
                        {
                            comboBox_View_Data.Items.Add(Path.GetFileName(filePath));
                        }
                        if (flag_messages == true) { MessageBox.Show("Wprowadzono dane z wybranego folderu"); }

                    }
                    cleaning_function();

                }
            }

        }

        private void button_sensor_1_Click(object sender, EventArgs e)
        {
            if (flag_sens_1 == true)
            {
                Sensor_chart.Series["Sensor_1"].Enabled = false;
                button_sensor_1.BackColor = Color.Red;
                label_sensor1_view.ForeColor = Color.Red;
                flag_sens_1 = false;

            }
            else
            {
                Sensor_chart.Series["Sensor_1"].Enabled = true;
                button_sensor_1.BackColor = Color.Green;
                label_sensor1_view.ForeColor = Color.Green;
                flag_sens_1 = true;

            }
        }

        private void button_sensor_2_Click(object sender, EventArgs e)
        {
            if (flag_sens_2 == true)
            {
                Sensor_chart.Series["Sensor_2"].Enabled = false;
                button_sensor_2.BackColor = Color.Red;
                label_sensor2_view.ForeColor = Color.Red;
                flag_sens_2 = false;
            }
            else
            {
                Sensor_chart.Series["Sensor_2"].Enabled = true;
                button_sensor_2.BackColor = Color.Green;
                label_sensor2_view.ForeColor = Color.Green;
                flag_sens_2 = true;
            }
        }

        private void button_sensor_3_Click(object sender, EventArgs e)
        {
            if (flag_sens_3 == true)
            {
                Sensor_chart.Series["Sensor_3"].Enabled = false;
                button_sensor_3.BackColor = Color.Red;
                label_sensor3_view.ForeColor = Color.Red;
                flag_sens_3 = false;
            }
            else
            {
                Sensor_chart.Series["Sensor_3"].Enabled = true;
                button_sensor_3.BackColor = Color.Green;
                label_sensor3_view.ForeColor = Color.Green;
                flag_sens_3 = true;
            }
        }

        private void button_pointval_chart_Click(object sender, EventArgs e)
        {

            if (flag_chart_valv == true)
            {
                this.Sensor_chart.Series["Sensor_1"].IsValueShownAsLabel = true;
                this.Sensor_chart.Series["Sensor_2"].IsValueShownAsLabel = true;
                this.Sensor_chart.Series["Sensor_3"].IsValueShownAsLabel = true;
                flag_chart_valv = false;
                button_pointval_chart.Text = "Hide Values on Chart";
            }
            else
            {
                this.Sensor_chart.Series["Sensor_1"].IsValueShownAsLabel = false;
                this.Sensor_chart.Series["Sensor_2"].IsValueShownAsLabel = false;
                this.Sensor_chart.Series["Sensor_3"].IsValueShownAsLabel = false;
                flag_chart_valv = true;
                button_pointval_chart.Text = "Show Values on Chart";
            }
        }


        private void button_fullscreen_Click(object sender, EventArgs e)
        {
            if (screen_max_min == true)
            { this.WindowState = FormWindowState.Maximized; screen_max_min = false; }
            else { this.WindowState = FormWindowState.Normal; screen_max_min = true; }

        }

        private void button_EXIT_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void textBox_gradient_TextChanged(object sender, EventArgs e)
        {

            textBox_gradient.Text = string.Concat(textBox_gradient.Text.Where(char.IsDigit));
            if (textBox_gradient.TextLength > 0 && 0<Convert.ToInt64(textBox_gradient.Text))
            {
                label_gradient_OBL.Visible = true;
                L_textbox_value = (Convert.ToDouble(textBox_gradient.Text)) / 1000;
                switch (comboBox_gradient.SelectedIndex)
                {

                    case 0:
                        delta_p = sensor_32_delta / L_textbox_value;
                        label_gradient_OBL.Text = "Calculated gradient:" + "\n" + String.Format("{0:0.00}", delta_p) + " Pa/m";

                        break;//ΔPa3 - 2

                    case 1:
                        delta_p = sensor_31_delta / L_textbox_value;
                        label_gradient_OBL.Text = "Calculated gradient:" + "\n" + String.Format("{0:0.00}", delta_p) + " Pa/m";
                        break; //ΔPa3 - 1

                    case 2:
                        delta_p = sensor_21_delta / L_textbox_value;
                        label_gradient_OBL.Text = "Calculated gradient:" + "\n" + String.Format("{0:0.00}", delta_p) + " Pa/m";
                        break; //ΔPa2 - 1
                }
            }
            else { }
        }

        private void button_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_pomoc_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("W celu pomocy lub zgłoszenia błędów proszę skontaktować się mailowo na adres pawel.pawlaszczyk@gmail.com");
        }
        private void button_TURN_ON_OFF_Click_1(object sender, EventArgs e)
             {
            if(flag_messages==true)
            { flag_messages = false; button_TURN_ON_OFF.Text = "Turn ON messages"; Tip_buttons.Active = false; }
            else { flag_messages = true; button_TURN_ON_OFF.Text = "Turn OFF messages"; Tip_buttons.Active = true; }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void mouse_moive(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle,
                                 Color.SlateBlue, 0, ButtonBorderStyle.None,
                                 Color.SlateBlue, 33, ButtonBorderStyle.Outset,
                                 Color.SlateBlue, 0, ButtonBorderStyle.None,
                                 Color.SlateBlue, 0, ButtonBorderStyle.None);

        }

        private void button_EXIT_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            LinearGradientBrush brush1 = new LinearGradientBrush((sender as Button).ClientRectangle, Color.DarkRed, Color.PaleVioletRed, 90F);

            GraphicsPath gp = new GraphicsPath();
            Font font = new Font("Microsoft Sans serif", 12f, FontStyle.Bold);
            e.Graphics.DrawString("EXIT", font, brush1, 25, 8);
        }
      
        //_____________________________________________________________________Void CLEAN List and others_____________________________________

        public void cleaning_function()
        {
            pos_lst2 = 0;
            pos_lst1 = 0;
            pos_lst = 0;
            pos_lst3 = 0;
            lstfinalsensor.Clear();
            lstsensor_3.Clear();
            lstsensor_1.Clear();
            Minvalue_read_1 = double.MinValue;
            Minvalue_read_2 = double.MinValue;
            Minvalue_read_3 = double.MinValue;
            raise_1 = 0; raise_2 = 0; raise_3 = 0;
            list_for_data.Clear();

        }
        //_________________________________________________________________________________VOID PORT SHOWING FUNCTION_________________________________________




        public void Port_Detector()
        {

            var Port_list = new List<string>(SerialPort.GetPortNames());
            int length_list = Port_list.Count;
            var Port_with_Device_names = new List<string>();
            ManagementObjectCollection mbsList = null;
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_SerialPort"); //pobranie wszystkich nazw podl uradzen z COM
            mbsList = mbs.Get();



            foreach (ManagementObject mo in mbsList)
            {
                comboBox_connected_ports.Items.Add(mo["Description"]); //wypisanie do comboxa samych nazw podl urzadzen z COM
            }

            for (int a = 0; a < length_list; a++)
            {
                comboBox_connected_ports.SelectedIndex = a; //pozycja pocz comboboxa

                var selected = this.comboBox_connected_ports.GetItemText(this.comboBox_connected_ports.SelectedItem); //przypisywanie z wyzszej zadelkarowanej pozycji
                var connected_value = selected + "  " + Port_list[a];

                Port_with_Device_names.Add(connected_value);
            }

            comboBox_connected_ports.Items.Clear();// czyszczenie po przypisaniu ich do listy

            foreach (var item_show_combox in Port_with_Device_names)
            {
                comboBox_connected_ports.Items.Add(item_show_combox);
            }
        }

        private void label_gradient_OBL_Click(object sender, EventArgs e)
        {

        }



        //_____________________________________________DELEETING ASM FILES FROM FOLDER___________________________________________


        public void Move_files_ASM_OTHERS()
        {
            string[] files_with_ASM_delete = Directory.GetFiles(Find_byclicking.SelectedPath);
            int files_lenght_array_ASM = files_with_ASM_delete.Length;

            for (int i = 0; i < files_lenght_array_ASM; i++)
            {
                string read_word_files = Path.GetFileName(files_with_ASM_delete[i]);
                if (read_word_files.Contains(".txt"))
                {
                }
                else
                {
                    if (read_word_files.Contains(".AsmDat"))
                    {
                        File.Delete(files_with_ASM_delete[i]);

                    }
                    else
                    {
                        if (!Directory.Exists(Path.Combine(Find_byclicking.SelectedPath, "Pliki_inny_format")))
                            Directory.CreateDirectory(Path.Combine(Find_byclicking.SelectedPath, "Pliki_inny_format"));
                        string destinationFile = Find_byclicking.SelectedPath + @"\Pliki_inny_format\" + read_word_files;
                        File.Move(files_with_ASM_delete[i], destinationFile);
                    }
                }
            }
        }
        //_____________________________________________mouse event______________________________________________________________________


        private void Chart1_MouseEnter(object sender, EventArgs e)
        {
            if (!Sensor_chart.Focused)
                Sensor_chart.Focus();
        }

        private void Chart1_MouseLeave(object sender, EventArgs e)
        {
            if (Sensor_chart.Focused)
                Sensor_chart.Parent.Focus();
        }
        //______________________________________________________________________ Zoom funct______________________________________________________________________
        private void Sensor_chart_MouseWheel(object sender, MouseEventArgs e)
        {
            int CZoomScale = 2;
            try
            {
                Axis xAxis = Sensor_chart.ChartAreas[0].AxisX;
                double xMin = xAxis.ScaleView.ViewMinimum;
                double xMax = xAxis.ScaleView.ViewMaximum;
                double xPixelPos = xAxis.PixelPositionToValue(e.Location.X);

                if (e.Delta < 0 && FZoomLevel > 0)
                {
                    // Scrolled down, meaning zoom out
                    if (--FZoomLevel <= 0)
                    {
                        FZoomLevel = 0;
                        xAxis.ScaleView.ZoomReset();
                    }
                    else
                    {
                        double xStartPos = Math.Max(xPixelPos - (xPixelPos - xMin) * CZoomScale, 0);
                        double xEndPos = Math.Min(xStartPos + (xMax - xMin) * CZoomScale, xAxis.Maximum);
                        xAxis.ScaleView.Zoom(xStartPos, xEndPos);
                    }
                }
                else if (e.Delta > 0)
                {
                    // Scrolled up, meaning zoom in
                    double xStartPos = Math.Max(xPixelPos - (xPixelPos - xMin) / CZoomScale, 0);
                    double xEndPos = Math.Min(xStartPos + (xMax - xMin) / CZoomScale, xAxis.Maximum);
                    xAxis.ScaleView.Zoom(xStartPos, xEndPos);
                    FZoomLevel++;
                }
            }
            catch { }
        }

        //-----------------------CLEAR CHART
        public void Clear_series_chart()
        {
            foreach (var series in Sensor_chart.Series)
            {
                series.Points.Clear();
            }
        }     
    }
}