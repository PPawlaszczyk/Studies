using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using ZedGraph;
namespace WindowsFormsApp1
{
    public partial class form_show_data : Form
    {
        public form_show_data()
        {
            InitializeComponent();

        }
        OpenFileDialog Find_byclicking2 = new OpenFileDialog();
                string path_read;
        int raise_line_seperate;
        List<raw_data_read> raw_data_readed_list = new List<raw_data_read>();
        List<recalculated_data> recalculated_data_list = new List<recalculated_data>();
        PointPairList userClickrList = new PointPairList();
        LineItem userClickCurve = new LineItem("userClickCurve");
        PointPairList userClickrList2 = new PointPairList();
        LineItem userClickCurve2 = new LineItem("userClickCurve");
        int i_for_lines = 1;
        bool lock_line1 = true;
        bool lock_line2 = true;
        int i_for_lockers1 = 1;
        int i_for_lockers2 = 1;
        double xVal1;
        double yVal1;
        double xVal2;
        double yVal2;
        double epsilon_1;
        double epsilon_2;
        double Total_stretch;
        bool read_empty_file = true;
        int time = 0;

        private void button_read_data_Click(object sender, EventArgs e)
        {
           
                zedGraphControl1.GraphPane.CurveList.Clear();
                zedGraphControl1.GraphPane.GraphObjList.Clear();

                Change_Format();
                raise_line_seperate = 0;
            if (read_empty_file == true)
            {
                seperate_raw_data();
                recalculate_data();

                Total_stretch = recalculated_data_list.Max(t => t.Strain_calc);
                textBox_total.Text = Convert.ToString(Math.Round((Total_stretch), 8) + " mm");

                PointPairList list = new PointPairList();
                for (int i = 0; i < recalculated_data_list.Count(); i++)
                {
                    list.Add(new PointPair(recalculated_data_list[i].time_calc, recalculated_data_list[i].Strain_calc));
                }
                GraphPane mypane = zedGraphControl1.GraphPane;

                zedGraphControl1.ZoomOut(mypane);



                mypane.Title.Text = "Creep (deformation)";
                mypane.XAxis.Title.Text = "Time, hours";
                mypane.YAxis.Title.Text = "Warp, mm";
                mypane.XAxis.Scale.Min = 0.0;
                mypane.YAxis.Scale.Min = 0.0;



                var pointsCurve = mypane.AddCurve("", list, Color.Transparent);
                pointsCurve.Line.IsVisible = false;


                // Create your own scale of colors.
                pointsCurve.Symbol.Fill = new Fill(new Color[] { Color.Blue, Color.Green, Color.Red });
                pointsCurve.Symbol.Fill.Type = FillType.GradientByZ;
                pointsCurve.Symbol.Fill.RangeMin = 0;
                pointsCurve.Symbol.Fill.RangeMax = 30;
                pointsCurve.Symbol.Type = SymbolType.Circle;

                zedGraphControl1.RestoreScale(mypane);


                mypane.AxisChange();
                zedGraphControl1.Refresh();
            }


        }


        private void zedGraphControl1_MouseClick_1(object sender, MouseEventArgs e)
        {
            GraphPane myPane = zedGraphControl1.GraphPane;

            if(lock_line2 == false && lock_line1 == false)
            {
            }
           else if ((i_for_lines == 1 && lock_line1 == true) || lock_line2==false)
            {
   
                userClickrList.Clear();

                myPane.Legend.IsVisible = false;
              
                myPane.ReverseTransform(e.Location, out xVal1, out yVal1);

                userClickrList.Add(xVal1, myPane.YAxis.Scale.Max);
                userClickrList.Add(xVal1, myPane.YAxis.Scale.Min);


                userClickCurve = myPane.AddCurve(" ", userClickrList, Color.Red, SymbolType.None);

                zedGraphControl1.Refresh();
                xVal1 = Math.Round(xVal1, 8);
                label_xvalue2.Text = Convert.ToString("Time 1: " + xVal1 + " h");
                find_value();
                label_epsilon1.Text = Convert.ToString("Epsilon 1: " + epsilon_1 + " mm");
            }

            else if ((i_for_lines == 2 && lock_line2 == true) || lock_line1 == false)
            {  
                userClickrList2.Clear();

                myPane.Legend.IsVisible = false;

                myPane.ReverseTransform(e.Location, out xVal2, out yVal2);

                userClickrList2.Add(xVal2, myPane.YAxis.Scale.Max);
                userClickrList2.Add(xVal2, myPane.YAxis.Scale.Min);

                userClickCurve2 = myPane.AddCurve(" ", userClickrList2, Color.Blue, SymbolType.None);
                zedGraphControl1.Refresh();
                xVal2 = Math.Round(xVal2, 8);

                label_xval1.Text = Convert.ToString("Time 2: " + xVal2 +" h");
                find_value2();
                label_epsilon2.Text = Convert.ToString("Epsilon 2: " + epsilon_2 + " mm");

            }
            if (i_for_lines == 2)
            {
                i_for_lines = 0;
            }
            i_for_lines++;         
        }

    

        private void button_lock_epsile2_Click(object sender, EventArgs e)
        {
            switch (i_for_lockers1)
            {
                case 1:
                    lock_line1 = false;
                    break;
                case 2:
                    lock_line1 = true;
                    i_for_lockers1 = 0;
                    break;
            }
            i_for_lockers1++;
        }

        private void button_lock_epsil1_Click(object sender, EventArgs e)
        {    
          
            switch (i_for_lockers2)
            {
                case 1:
                    lock_line2 = false;
                    break;
                case 2:
                    lock_line2 = true;
                    i_for_lockers2 = 0;
                    break;
            }
            i_for_lockers2++;
        }











        //____________________________________________________________ FORMAT PLIKU ZMIANA na txt_______________________________________________________________________________

        void Change_Format()
            {
            read_empty_file = true;
                Find_byclicking2.Filter = "Text file (.txt)|*.txt|TRA file (.Tra)|*.Tra| Comma-separated values (.csv)|*.csv|All files (.txt, .csv, .Tra)|*.txt;*.csv;*.Tra";
            if (Find_byclicking2.ShowDialog() == DialogResult.OK && (read_empty_file ==true))
            {

                path_read = Path.GetFullPath(Find_byclicking2.FileName);
                File.Move(path_read, Path.ChangeExtension(path_read, ".txt"));
                path_read= Path.ChangeExtension(path_read, ".txt"); 
            }
            else
            {
                MessageBox.Show("nie dodano pliku");
                read_empty_file=false;
            }


        }

            //____________________________________________________________ seperate to LIST_______________________________________________________________________________
            void seperate_raw_data()
            {
                foreach (string line in File.ReadLines(path_read ))
                {

                    if (line.Contains("0") || line.Contains("."))
                    {

                        string seperator_line = "\t";
                        string[] splitContent_Data_read = line.Split(seperator_line.ToCharArray());


                        raw_data_readed_list.Add(new raw_data_read());
                        raw_data_readed_list[raise_line_seperate].Strain = double.Parse(splitContent_Data_read[0],CultureInfo.InvariantCulture);
                        raw_data_readed_list[raise_line_seperate].Standart_force = double.Parse(splitContent_Data_read[1], CultureInfo.InvariantCulture);
                        raw_data_readed_list[raise_line_seperate].time = double.Parse(splitContent_Data_read[2], CultureInfo.InvariantCulture);
                        raise_line_seperate++;
                    }
                    else
                    {


                    }
                }
            }
        //____________________________________________________________ recalculate______________________________________________________________________________


        void recalculate_data()
        {
            recalculated_data_list.Add(new recalculated_data());
            recalculated_data_list[0].Strain_calc = raw_data_readed_list[0].Strain;
         //   recalculated_data_list[0].Standart_force_calc = raw_data_readed_list[0].Standart_force;
            recalculated_data_list[0].time_calc = raw_data_readed_list[0].time;

            for (int i = 1; i < raw_data_readed_list.Count; i++)
            {
                // MessageBox.Show(Convert.ToString(raw_data_readed_list.Count));
                recalculated_data_list.Add(new recalculated_data());
                recalculated_data_list[i].Strain_calc = raw_data_readed_list[i].Strain + recalculated_data_list[i - 1].Strain_calc;
               // recalculated_data_list[i].Standart_force_calc = raw_data_readed_list[i].Standart_force;
                recalculated_data_list[i].time_calc = raw_data_readed_list[i].time;
            }

        }


        void find_value()
        {
             epsilon_1 = recalculated_data_list.Where(a => a.time_calc >= xVal1 )
                     .Select(a => a.Strain_calc)
                     .FirstOrDefault();
            epsilon_1 = Math.Round(epsilon_1, 8);

        }

        void find_value2()
        {
             epsilon_2 = recalculated_data_list.Where(a => a.time_calc >= xVal2)
                                 .Select(a => a.Strain_calc)
                                 .FirstOrDefault();
            epsilon_2 = Math.Round(epsilon_2, 8);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox_speed.Text = Convert.ToString(Math.Round(((epsilon_2 - epsilon_1)/(xVal2-xVal1)),8)+ " mm/h");
            textBox_immediate.Text = Convert.ToString(Math.Round((Total_stretch - epsilon_1 ),8) + " mm");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(time>=10)
            {
                pictureBox_spring.Visible = true;
                pictureBox_tense.Visible = false;
            }
            if ((time<30) && (10<time))
            {
              pictureBox_spring.Visible = false;
              pictureBox_tense.Visible = true;

           }
           if (time==30)
            {
                time = -1;
            }
            time++;
        }

        private void form_show_data_Load(object sender, EventArgs e)
        {
            GraphPane mypane = zedGraphControl1.GraphPane;

            mypane.Title.Text = "Creep (deformation)";
            mypane.XAxis.Title.Text = "Time, hours";
            mypane.YAxis.Title.Text = "Warp, mm";
        }
    }
   

}