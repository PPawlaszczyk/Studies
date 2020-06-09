
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc.Domain;
using NCalc;
using ZedGraph;
using System.Threading;

namespace paraller_programing_charts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //zmienne
        int pozycja_x = 0;
        int pozycja_y = 0;
        bool wyczysc_wykres = true;
        double ile_razy_obl_pochodna;
        double krok_pochodna;
        double x_pochodna_min;
        double x_pochodna_max;
        string wpisana_funkcja_pochodna;
        int ile_razy_przelecialo = 0;
        int ile_powinno_przeleciec_w_petli = 0;
        int ile_w_linijc = 0;
        int wpozycj_y = 0;
        string czas_watek1;
        string czas_watek2;
        string czas_watek3;
        string czas_watek4;
        string czas_wezwatku;
        string czas_watek1_2watkowo;
        string czas_watek2_2watkowo;
        ZedGraphControl[,] ilosc_wykresow = new ZedGraphControl[4, 2];
        private void Form1_Load(object sender, EventArgs e)
        {
           

           

        }




        private void Button_oblicz_pochodna_Click(object sender, EventArgs e)
        {
            if (wyczysc_wykres == true)
            {
                deklaracja_zmiennych_pochodna();
                //   clearChart();
                tworzenie_charakteresytyk();
                Thread.Sleep(100);
                Thread t1 = new Thread(Thread_1_obliczenia);
                Thread t2 = new Thread(Thread_2_obliczenia);
                Thread t3 = new Thread(Thread_3_obliczenia);
                Thread t4 = new Thread(Thread_4_obliczenia);
                t1.Start();
                t2.Start();

                t3.Start();
                t4.Start();

                wyczysc_wykres = false;
            }
           else
            {
                MessageBox.Show("Wyczyść najpierw wykres!");
            }

        }






        ///////////////////////////////////////////////moje funkcje


        //////////////////////////////////////////Rysowanie wykresu
        ///
        private void rysowanie_wykresu_podstawowego()
        {
            
            int ile_razy_przelecialo_poch_1 = 0;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (ile_razy_przelecialo_poch_1 < ile_powinno_przeleciec_w_petli)
                    {
                        GraphPane myPane = ilosc_wykresow[0, 0].GraphPane;
                        myPane.Title.Text = Convert.ToString("y(" + Convert.ToString(ile_razy_przelecialo+1) + ")=  "+textBox_wpiszfunkcje_dla_pochodnej.Text);
                        myPane.XAxis.Title.Text = "x";
                        myPane.YAxis.Title.Text = "y";

                        Expression expres = new Expression(wpisana_funkcja_pochodna);
                        PointPairList SerValues = new PointPairList();
                        for (double x = x_pochodna_min; x <= x_pochodna_max; x = x + krok_pochodna)
                        {
                            expres.Parameters["x"] = x;
                            var wynik = expres.Evaluate();
                            double d = double.Parse(wynik.ToString());
                            SerValues.Add(x, d);
                        }

                        LineItem valCurve = myPane.AddCurve("Funkcja y ",
                              SerValues, Color.Red, SymbolType.None);

                        ilosc_wykresow[0, 0].AxisChange();
                        ilosc_wykresow[0, 0].Invalidate();
                       // ile_razy_przelecialo_poch_1++;
                    }
                }
            }
        }


        private void rysowanie_wykresu_przeciwny_znak()
        {

            int ile_razy_przelecialo_poch_1 = 0;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (ile_razy_przelecialo_poch_1 < ile_powinno_przeleciec_w_petli)
                    {
                        GraphPane myPane = ilosc_wykresow[pozycja_y, pozycja_x].GraphPane;
                    //    myPane.Title.Text = Convert.ToString("y(" + Convert.ToString(ile_razy_przelecialo + 1) + ")=  " + textBox_wpiszfunkcje_dla_pochodnej.Text);
                        myPane.XAxis.Title.Text = "x";
                        myPane.YAxis.Title.Text = "y";

                        Expression expres = new Expression("-(" + wpisana_funkcja_pochodna + ")");
                        PointPairList SerValues = new PointPairList();
                        for (double x = x_pochodna_min; x <= x_pochodna_max; x = x + krok_pochodna)
                        {
                            expres.Parameters["x"] = x;
                            var wynik = expres.Evaluate();
                            double d = double.Parse(wynik.ToString());
                            SerValues.Add(x, d);
                        }

                        LineItem valCurve = myPane.AddCurve("Funkcja y ",
                              SerValues, Color.Red, SymbolType.None);

                        ilosc_wykresow[pozycja_y, pozycja_x].AxisChange();
                        ilosc_wykresow[pozycja_y, pozycja_x].Invalidate();
                        // ile_razy_przelecialo_poch_1++;
                    }
                }
            }
        }

        private void rysowanie_wykresu_lewo()
        {

            int ile_razy_przelecialo_poch_1 = 0;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (ile_razy_przelecialo_poch_1 < ile_powinno_przeleciec_w_petli)
                    {
                        GraphPane myPane = ilosc_wykresow[pozycja_y, pozycja_x].GraphPane;
                     //   myPane.Title.Text = Convert.ToString("y(" + Convert.ToString(ile_razy_przelecialo + 1) + ")=  " + textBox_wpiszfunkcje_dla_pochodnej.Text);
                        myPane.XAxis.Title.Text = "x";
                        myPane.YAxis.Title.Text = "y";

                        Expression expres = new Expression("-(" + wpisana_funkcja_pochodna + ")");
                        PointPairList SerValues = new PointPairList();
                        for (double x = x_pochodna_min; x <= x_pochodna_max; x = x + krok_pochodna)
                        {
                            expres.Parameters["x"] = x;
                            var wynik = expres.Evaluate();
                            double d = double.Parse(wynik.ToString());
                            SerValues.Add(d, x);
                        }

                        LineItem valCurve = myPane.AddCurve("Funkcja y ",
                              SerValues, Color.Red, SymbolType.None);

                        ilosc_wykresow[pozycja_y, pozycja_x].AxisChange();
                        ilosc_wykresow[pozycja_y, pozycja_x].Invalidate();
                        // ile_razy_przelecialo_poch_1++;
                    }
                }
            }
        }


        private void rysowanie_wykresu_prawo()
        {

            int ile_razy_przelecialo_poch_1 = 0;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (ile_razy_przelecialo_poch_1 < ile_powinno_przeleciec_w_petli)
                    {
                        GraphPane myPane = ilosc_wykresow[pozycja_y, pozycja_x].GraphPane;
                       // myPane.Title.Text = Convert.ToString("y(" + Convert.ToString(ile_razy_przelecialo + 1) + ")=  " + textBox_wpiszfunkcje_dla_pochodnej.Text);
                        myPane.XAxis.Title.Text = "x";
                        myPane.YAxis.Title.Text = "y";

                        Expression expres = new Expression( wpisana_funkcja_pochodna );
                        PointPairList SerValues = new PointPairList();
                        for (double x = x_pochodna_min; x <= x_pochodna_max; x = x + krok_pochodna)
                        {
                            expres.Parameters["x"] = x;
                            var wynik = expres.Evaluate();
                            double d = double.Parse(wynik.ToString());
                            SerValues.Add(d, x);
                        }

                        LineItem valCurve = myPane.AddCurve("Funkcja y ",
                              SerValues, Color.Red, SymbolType.None);

                        ilosc_wykresow[pozycja_y, pozycja_x].AxisChange();
                        ilosc_wykresow[pozycja_y, pozycja_x].Invalidate();
                        // ile_razy_przelecialo_poch_1++;
                    }
                }
            }
        }


        /// <summary>
        /// //////////////////////////////
        /// </summary>

        private void tworzenie_charakteresytyk()
        {
            int rozmiar_tablicy = 0;
            int rozszerz_w_y = 300;
            if(Convert.ToDouble(ile_razy_obl_pochodna) ==2)
            {
                rozmiar_tablicy = 2;
            }
            else
            {
                rozmiar_tablicy = 1;
                rozszerz_w_y = 600;
            }
            obliczenie_wymiarow_tabeli_x_y();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < rozmiar_tablicy; j++)
                {
                    if (ile_razy_przelecialo < ile_powinno_przeleciec_w_petli)
                    {
                        this.ilosc_wykresow[i, j] = new ZedGraphControl();
                        this.ilosc_wykresow[i, j].Location = new System.Drawing.Point(320 + (490 * i), 20 + (330 * j));
                        this.ilosc_wykresow[i, j].Name = "Wykres_nr" + (i * 3 + j).ToString();
                        this.ilosc_wykresow[i, j].Size = new System.Drawing.Size(450, rozszerz_w_y);
                        this.ilosc_wykresow[i, j].TabIndex = 2 + (i * 3 + j);
                        this.Controls.Add(ilosc_wykresow[i, j]);
                   //     ile_razy_przelecialo++;

                    }
                }

            }
        }
        private void obliczenie_wymiarow_tabeli_x_y()
        {
            ile_razy_przelecialo = 0;
            ile_powinno_przeleciec_w_petli = Convert.ToInt32(ile_razy_obl_pochodna);
            ile_w_linijc = 0;
            wpozycj_y = Convert.ToInt32(ile_razy_obl_pochodna % 2); ;
            ile_w_linijc = ((Convert.ToInt32(ile_razy_obl_pochodna) + (wpozycj_y)) / 2);
        }


        private void deklaracja_zmiennych_pochodna()
        {
            x_pochodna_min = Convert.ToDouble(textBox_zakres_pochodnej_od.Text);
            x_pochodna_max = Convert.ToDouble(textBox_zakres_pochodnej_do.Text);
            krok_pochodna = Convert.ToDouble(textBox_krok_pochodna.Text);
            wpisana_funkcja_pochodna = textBox_wpiszfunkcje_dla_pochodnej.Text;
            ile_razy_obl_pochodna = Convert.ToDouble(textBox_ile_razy_pochodna.Text);

        }

        private void obliczanie_wzorow_na_pochodna_1_rzedu()
        {
           
                GraphPane myPane = ilosc_wykresow[0, 0].GraphPane;
            myPane.Title.Text = Convert.ToString("y(1)=  " + textBox_wpiszfunkcje_dla_pochodnej.Text)+")";
            myPane.XAxis.Title.Text = "x";
            myPane.YAxis.Title.Text = "y";

            Expression expres1 = new Expression(wpisana_funkcja_pochodna);
            Expression expres2 = new Expression(wpisana_funkcja_pochodna);

            PointPairList SerValues = new PointPairList();
            for (double x = (x_pochodna_min); x <= x_pochodna_max; x = x + krok_pochodna)
            {
                expres1.Parameters["x"] = x + 0.1;
                expres2.Parameters["x"] = x - 0.1;

                var wynik1 = expres1.Evaluate();
                var wynik2 = expres2.Evaluate();


                double d = (double.Parse(wynik1.ToString()) - double.Parse(wynik2.ToString()))/ (2 * 0.1);
         
            SerValues.Add(x, d);
            }

            LineItem valCurve = myPane.AddCurve("pochodna funkcji y ",
                  SerValues, Color.Green, SymbolType.None);

            ilosc_wykresow[0, 0].AxisChange();
            ilosc_wykresow[0, 0].Invalidate();
           
        }

        private void TextBox_ile_razy_pochodna_TextChanged(object sender, EventArgs e)
        {
            if(Convert.ToInt32(textBox_ile_razy_pochodna.Text)<2)
            {
                textBox_ile_razy_pochodna.Text = "2";
            }
            else if(Convert.ToInt32(textBox_ile_razy_pochodna.Text) > 8)
            {
                textBox_ile_razy_pochodna.Text = "8";

            }

        }
        private void obliczanie_wzorow_na_pochodna_2_rzedu()
        {


            GraphPane myPane = ilosc_wykresow[0, 1].GraphPane;
            myPane.Title.Text = Convert.ToString("y(2)= " + textBox_wpiszfunkcje_dla_pochodnej.Text);
            myPane.XAxis.Title.Text = "x";
            myPane.YAxis.Title.Text = "y";

            Expression expres1 = new Expression(wpisana_funkcja_pochodna);
            Expression expres2 = new Expression(wpisana_funkcja_pochodna);
            Expression expres4 = new Expression(wpisana_funkcja_pochodna);

            PointPairList SerValues = new PointPairList();
            for (double x = (x_pochodna_min); x <= x_pochodna_max; x = x + krok_pochodna)
            {
                expres1.Parameters["x"] = x + 0.1;
                expres2.Parameters["x"] = x - 0.1;
                expres4.Parameters["x"] = x;

                var wynik1 = expres1.Evaluate();
                var wynik2 = expres2.Evaluate();
                var wynik4 = expres4.Evaluate();


                double testy_1 = double.Parse(wynik1.ToString());
                double testy_2 = double.Parse(wynik2.ToString());
                double testy_3 = double.Parse(wynik4.ToString());
               double d = (testy_1 - (2 * testy_3) + testy_2) / (0.1 * 0.1);
                SerValues.Add(x, d);
            }

            LineItem valCurve = myPane.AddCurve("pochodna funkcji y'' ",
                  SerValues, Color.Blue, SymbolType.None);

            ilosc_wykresow[0, 1].AxisChange();
            ilosc_wykresow[0, 1].Invalidate();
        }
        private void obliczanie_wzorow_na_pochodna_1_rzedu_przeciwny()
        {


            GraphPane myPane = ilosc_wykresow[1, 0].GraphPane;
            myPane.Title.Text = Convert.ToString("y(1)= -(" + textBox_wpiszfunkcje_dla_pochodnej.Text)+")";
            myPane.XAxis.Title.Text = "x";
            myPane.YAxis.Title.Text = "y";

            Expression expres1 = new Expression("-(" + wpisana_funkcja_pochodna + ")");
            Expression expres2 = new Expression("-("+wpisana_funkcja_pochodna + ")");
 

            PointPairList SerValues = new PointPairList();
            for (double x = (x_pochodna_min); x <= x_pochodna_max; x = x + krok_pochodna)
            {
                expres1.Parameters["x"] = x + 0.1;
                expres2.Parameters["x"] = x - 0.1;

                var wynik1 = expres1.Evaluate();
                var wynik2 = expres2.Evaluate();


                double d = (double.Parse(wynik1.ToString()) - double.Parse(wynik2.ToString())) / (2 * 0.1);

                SerValues.Add(x, d);
            }

            LineItem valCurve = myPane.AddCurve("pochodna funkcji ",
                  SerValues, Color.Green, SymbolType.None);

            ilosc_wykresow[1, 0].AxisChange();
            ilosc_wykresow[1, 0].Invalidate();
        }

        private void obliczanie_wzorow_na_pochodna_2_rzedu_przeciwny()
        {


            GraphPane myPane = ilosc_wykresow[1, 1].GraphPane;
            myPane.Title.Text = Convert.ToString("y(2)= -("  + textBox_wpiszfunkcje_dla_pochodnej.Text +")");
            myPane.XAxis.Title.Text = "x";
            myPane.YAxis.Title.Text = "y";

            Expression expres1 = new Expression("-(" + wpisana_funkcja_pochodna + ")");
            Expression expres2 = new Expression("-(" + wpisana_funkcja_pochodna + ")");
            Expression expres4 = new Expression("-(" + wpisana_funkcja_pochodna + ")");

            PointPairList SerValues = new PointPairList();
            for (double x = (x_pochodna_min); x <= x_pochodna_max; x = x + krok_pochodna)
            {
                expres1.Parameters["x"] = x + 0.1;
                expres2.Parameters["x"] = x - 0.1;
                expres4.Parameters["x"] = x;

                var wynik1 = expres1.Evaluate();
                var wynik2 = expres2.Evaluate();
                var wynik4 = expres4.Evaluate();


                double testy_1 = double.Parse(wynik1.ToString());
                double testy_2 = double.Parse(wynik2.ToString());
                double testy_3 = double.Parse(wynik4.ToString());
                double d = (testy_1 - (2 * testy_3) + testy_2) / (0.1 * 0.1);
                SerValues.Add(x, d);
            }

            LineItem valCurve = myPane.AddCurve("pochodna funkcji y'' ",
                  SerValues, Color.Blue, SymbolType.None);

            ilosc_wykresow[1, 1].AxisChange();
            ilosc_wykresow[1, 1].Invalidate();
        }
        /// <summary>
        /// ////
        /// </summary>
        private void obliczanie_wzorow_na_pochodna_1_rzedu__prawo()
        {

            
            GraphPane myPane = ilosc_wykresow[2, 0].GraphPane;
            myPane.Title.Text = Convert.ToString("y(1)=  " + textBox_wpiszfunkcje_dla_pochodnej.Text);
            myPane.XAxis.Title.Text = "x";
            myPane.YAxis.Title.Text = "y";

            Expression expres1 = new Expression(wpisana_funkcja_pochodna);
            Expression expres2 = new Expression(wpisana_funkcja_pochodna);


            PointPairList SerValues = new PointPairList();
            for (double x = (x_pochodna_min); x <= x_pochodna_max; x = x + krok_pochodna)
            {
                expres1.Parameters["x"] = x + 0.1;
                expres2.Parameters["x"] =x - 0.1;

                var wynik1 = expres1.Evaluate();
                var wynik2 = expres2.Evaluate();


                double d = (double.Parse(wynik1.ToString()) - double.Parse(wynik2.ToString())) / (2 * 0.1);

                SerValues.Add(d, x);
            }

            LineItem valCurve = myPane.AddCurve("pochodna funkcji ",
                  SerValues, Color.Green, SymbolType.None);

            ilosc_wykresow[2, 0].AxisChange();
            ilosc_wykresow[2, 0].Invalidate();
        }
        /// <summary>
        /// //
        /// </summary>
        private void obliczanie_wzorow_na_pochodna_2_rzedu__prawo()
        {


            GraphPane myPane = ilosc_wykresow[2, 1].GraphPane;
            myPane.Title.Text = Convert.ToString("y(2)= (" + textBox_wpiszfunkcje_dla_pochodnej.Text + ")");
            myPane.XAxis.Title.Text = "x";
            myPane.YAxis.Title.Text = "y";

            Expression expres1 = new Expression(wpisana_funkcja_pochodna);
            Expression expres2 = new Expression(wpisana_funkcja_pochodna);
            Expression expres4 = new Expression(wpisana_funkcja_pochodna);

            PointPairList SerValues = new PointPairList();
            for (double x = (x_pochodna_min); x <= x_pochodna_max; x = x + krok_pochodna)
            {
                expres1.Parameters["x"] = x + 0.1;
                expres2.Parameters["x"] = x - 0.1;
                expres4.Parameters["x"] = x;

                var wynik1 = expres1.Evaluate();
                var wynik2 = expres2.Evaluate();
                var wynik4 = expres4.Evaluate();


                double testy_1 = double.Parse(wynik1.ToString());
                double testy_2 = double.Parse(wynik2.ToString());
                double testy_3 = double.Parse(wynik4.ToString());
                double d = (testy_1 - (2 * testy_3) + testy_2) / (0.1 * 0.1);
                SerValues.Add(d, x);
            }

            LineItem valCurve = myPane.AddCurve("pochodna funkcji y'' ",
                  SerValues, Color.Blue, SymbolType.None);

            ilosc_wykresow[2, 1].AxisChange();
            ilosc_wykresow[2, 1].Invalidate();
        }
        private void obliczanie_wzorow_na_pochodna_1_rzedu__lewo()
        {


            GraphPane myPane = ilosc_wykresow[3, 0].GraphPane;
            myPane.Title.Text = Convert.ToString("y(1)= -(" + textBox_wpiszfunkcje_dla_pochodnej.Text+")");
            myPane.XAxis.Title.Text = "x";
            myPane.YAxis.Title.Text = "y";

            Expression expres1 = new Expression("-(" + wpisana_funkcja_pochodna + ")"); ;
            Expression expres2 = new Expression("-(" + wpisana_funkcja_pochodna + ")"); ;


            PointPairList SerValues = new PointPairList();
            for (double x = (x_pochodna_min); x <= x_pochodna_max; x = x + krok_pochodna)
            {
                expres1.Parameters["x"] = -x + 0.1;
                expres2.Parameters["x"] = -x - 0.1;

                var wynik1 = expres1.Evaluate();
                var wynik2 = expres2.Evaluate();


                double d = (double.Parse(wynik1.ToString()) - double.Parse(wynik2.ToString())) / (2 * 0.1);

                SerValues.Add(d, x);
            }

            LineItem valCurve = myPane.AddCurve("pochodna funkcji ",
                  SerValues, Color.Green, SymbolType.None);

            ilosc_wykresow[3, 0].AxisChange();
            ilosc_wykresow[3, 0].Invalidate();
        }
        private void obliczanie_wzorow_na_pochodna_2_rzedu__lewo()
        {


            GraphPane myPane = ilosc_wykresow[3, 1].GraphPane;
            myPane.Title.Text = Convert.ToString("y(2)= -(" + textBox_wpiszfunkcje_dla_pochodnej.Text+")");
            myPane.XAxis.Title.Text = "x";
            myPane.YAxis.Title.Text = "y";

            Expression expres1 = new Expression("-(" + wpisana_funkcja_pochodna + ")"); 
            Expression expres2 = new Expression("-(" + wpisana_funkcja_pochodna + ")"); 
            Expression expres4 = new Expression("-(" + wpisana_funkcja_pochodna + ")");

            PointPairList SerValues = new PointPairList();
            for (double x = (x_pochodna_min); x <= x_pochodna_max; x = x + krok_pochodna)
            {
                expres1.Parameters["x"] = -x + 0.1;
                expres2.Parameters["x"] = -x - 0.1;
                expres4.Parameters["x"] = -x;

                var wynik1 = expres1.Evaluate();
                var wynik2 = expres2.Evaluate();
                var wynik4 = expres4.Evaluate();


                double testy_1 = double.Parse(wynik1.ToString());
                double testy_2 = double.Parse(wynik2.ToString());
                double testy_3 = double.Parse(wynik4.ToString());
                double d = (testy_1 - (2 * testy_3) + testy_2) / (0.1 * 0.1);
                SerValues.Add(d, x);
            }

            LineItem valCurve = myPane.AddCurve("pochodna funkcji y'' ",
                  SerValues, Color.Blue, SymbolType.None);

            ilosc_wykresow[3, 1].AxisChange();
            ilosc_wykresow[3, 1].Invalidate();
        }
        /// <summary>
        /// /
        /// </summary>
        /// 
        private void obliczanie_wzorow_na_pochodna_1_rzedu_0_1()
        {

            GraphPane myPane = ilosc_wykresow[0, 1].GraphPane;
            myPane.Title.Text = Convert.ToString("y(" + Convert.ToString(ile_razy_przelecialo + 1) + ")=  " + textBox_wpiszfunkcje_dla_pochodnej.Text);
            myPane.XAxis.Title.Text = "x";
            myPane.YAxis.Title.Text = "y";

            Expression expres1 = new Expression(wpisana_funkcja_pochodna);
            Expression expres2 = new Expression(wpisana_funkcja_pochodna);

            PointPairList SerValues = new PointPairList();
            for (double x = (x_pochodna_min); x <= x_pochodna_max; x = x + krok_pochodna)
            {
                expres1.Parameters["x"] = x + 0.1;
                expres2.Parameters["x"] = x - 0.1;

                var wynik1 = expres1.Evaluate();
                var wynik2 = expres2.Evaluate();


                double d = (double.Parse(wynik1.ToString()) - double.Parse(wynik2.ToString())) / (2 * 0.1);

                SerValues.Add(x, d);
            }

            LineItem valCurve = myPane.AddCurve("pochodna funkcji y",
                  SerValues, Color.Green, SymbolType.None);

            ilosc_wykresow[0, 1].AxisChange();
            ilosc_wykresow[0, 1].Invalidate();

        }

        private void obliczanie_wzorow_na_pochodna_1_rzedu_przeciwny_poz1_1()
        {


            GraphPane myPane = ilosc_wykresow[1, 1].GraphPane;
            myPane.Title.Text = Convert.ToString("y(" + Convert.ToString(ile_razy_przelecialo + 1) + ")=  " + textBox_wpiszfunkcje_dla_pochodnej.Text);
            myPane.XAxis.Title.Text = "x";
            myPane.YAxis.Title.Text = "y";

            Expression expres1 = new Expression("-(" + wpisana_funkcja_pochodna + ")");
            Expression expres2 = new Expression("-(" + wpisana_funkcja_pochodna + ")");


            PointPairList SerValues = new PointPairList();
            for (double x = (x_pochodna_min); x <= x_pochodna_max; x = x + krok_pochodna)
            {
                expres1.Parameters["x"] = x + 0.1;
                expres2.Parameters["x"] = x - 0.1;

                var wynik1 = expres1.Evaluate();
                var wynik2 = expres2.Evaluate();


                double d = (double.Parse(wynik1.ToString()) - double.Parse(wynik2.ToString())) / (2 * 0.1);

                SerValues.Add(x, d);
            }

            LineItem valCurve = myPane.AddCurve("pochodna funkcji y",
                  SerValues, Color.Green, SymbolType.None);

            ilosc_wykresow[1, 1].AxisChange();
            ilosc_wykresow[1, 1].Invalidate();
        }

      
        private void obliczanie_wzorow_na_pochodna_1_rzedu__prawo_poz2_1()
        {


            GraphPane myPane = ilosc_wykresow[2, 1].GraphPane;
            myPane.Title.Text = Convert.ToString("y(" + Convert.ToString(ile_razy_przelecialo + 1) + ")=  " + textBox_wpiszfunkcje_dla_pochodnej.Text);
            myPane.XAxis.Title.Text = "x";
            myPane.YAxis.Title.Text = "y";

            Expression expres1 = new Expression(wpisana_funkcja_pochodna);
            Expression expres2 = new Expression(wpisana_funkcja_pochodna);


            PointPairList SerValues = new PointPairList();
            for (double x = (x_pochodna_min); x <= x_pochodna_max; x = x + krok_pochodna)
            {
                expres1.Parameters["x"] = x + 0.1;
                expres2.Parameters["x"] = x - 0.1;

                var wynik1 = expres1.Evaluate();
                var wynik2 = expres2.Evaluate();


                double d = (double.Parse(wynik1.ToString()) - double.Parse(wynik2.ToString())) / (2 * 0.1);

                SerValues.Add(d, x);
            }

            LineItem valCurve = myPane.AddCurve("pochodna funkcji y",
                  SerValues, Color.Green, SymbolType.None);

            ilosc_wykresow[2, 1].AxisChange();
            ilosc_wykresow[2, 1].Invalidate();
        }
        
        private void obliczanie_wzorow_na_pochodna_1_rzedu__lewo_poz3_1()
        {


            GraphPane myPane = ilosc_wykresow[3, 1].GraphPane;
            myPane.Title.Text = Convert.ToString("y(" + Convert.ToString(ile_razy_przelecialo + 1) + ")=  " + textBox_wpiszfunkcje_dla_pochodnej.Text);
            myPane.XAxis.Title.Text = "x";
            myPane.YAxis.Title.Text = "y";

            Expression expres1 = new Expression("-(" + wpisana_funkcja_pochodna + ")"); ;
            Expression expres2 = new Expression("-(" + wpisana_funkcja_pochodna + ")"); ;


            PointPairList SerValues = new PointPairList();
            for (double x = (x_pochodna_min); x <= x_pochodna_max; x = x + krok_pochodna)
            {
                expres1.Parameters["x"] = -x + 0.1;
                expres2.Parameters["x"] = -x - 0.1;

                var wynik1 = expres1.Evaluate();
                var wynik2 = expres2.Evaluate();


                double d = (double.Parse(wynik1.ToString()) - double.Parse(wynik2.ToString())) / (2 * 0.1);

                SerValues.Add(d, x);
            }

            LineItem valCurve = myPane.AddCurve("pochodna funkcji y",
                  SerValues, Color.Green, SymbolType.None);

            ilosc_wykresow[3, 1].AxisChange();
            ilosc_wykresow[3, 1].Invalidate();
        }

        private void Thread_1_obliczenia()
        {
            var watch1 = System.Diagnostics.Stopwatch.StartNew();

            rysowanie_wykresu_podstawowego();
            if (ile_razy_obl_pochodna == 2)
            {

                obliczanie_wzorow_na_pochodna_1_rzedu_0_1();
            }
            pozycja_y = 1;
            pozycja_x = 0;
            rysowanie_wykresu_przeciwny_znak();
            if (ile_razy_obl_pochodna == 2)
            {

                obliczanie_wzorow_na_pochodna_1_rzedu_przeciwny_poz1_1();
            }
            watch1.Stop();
            var elapsedMs1 = watch1.ElapsedMilliseconds;
            czas_watek1 = Convert.ToString(elapsedMs1);

            //  label_watek1.Text = "Czas rysowania watek 1 [ms]:  " + Convert.ToString(elapsedMs1);
        }
        private void Thread_2_obliczenia()
        {
            var watch2 = System.Diagnostics.Stopwatch.StartNew();

            pozycja_y = 2;
            pozycja_x = 0;
            rysowanie_wykresu_prawo();

            if (ile_razy_obl_pochodna == 2)
            {

                obliczanie_wzorow_na_pochodna_1_rzedu__prawo_poz2_1();
            }
            pozycja_y = 3;
            pozycja_x = 0;
            rysowanie_wykresu_lewo();
            if (ile_razy_obl_pochodna == 2)
            {

                obliczanie_wzorow_na_pochodna_1_rzedu__lewo_poz3_1();
            }
            watch2.Stop();
             var elapsedMs2 = watch2.ElapsedMilliseconds;
            czas_watek2 = Convert.ToString(elapsedMs2);

            //  label_watek2.Text = "Czas rysowania watek 2 [ms]:  " + Convert.ToString(elapsedMs2);
        }
        private void Thread_3_obliczenia()
        {
            var watch3 = System.Diagnostics.Stopwatch.StartNew();

            obliczanie_wzorow_na_pochodna_1_rzedu();
            if (ile_razy_obl_pochodna == 2)
            {
                obliczanie_wzorow_na_pochodna_2_rzedu();
            }

            obliczanie_wzorow_na_pochodna_1_rzedu_przeciwny();
            if (ile_razy_obl_pochodna == 2)
            {
                obliczanie_wzorow_na_pochodna_2_rzedu_przeciwny();
            }
            watch3.Stop();
            var elapsedMs3 = watch3.ElapsedMilliseconds;
            czas_watek3 = Convert.ToString(elapsedMs3);

            //  label_watek3.Text = "Czas rysowania watek 3 [ms]:  " + Convert.ToString(elapsedMs3);

        }

        private void Thread_1_2_obliczenia()
        {
            var watch6 = System.Diagnostics.Stopwatch.StartNew();

            rysowanie_wykresu_podstawowego();
            if (ile_razy_obl_pochodna == 2)
            {

                obliczanie_wzorow_na_pochodna_1_rzedu_0_1();
            }
            pozycja_y = 1;
            pozycja_x = 0;
            rysowanie_wykresu_przeciwny_znak();
            if (ile_razy_obl_pochodna == 2)
            {

                obliczanie_wzorow_na_pochodna_1_rzedu_przeciwny_poz1_1();
            }

            pozycja_y = 2;
            pozycja_x = 0;
            rysowanie_wykresu_prawo();

            if (ile_razy_obl_pochodna == 2)
            {

                obliczanie_wzorow_na_pochodna_1_rzedu__prawo_poz2_1();
            }
            pozycja_y = 3;
            pozycja_x = 0;
            rysowanie_wykresu_lewo();
            if (ile_razy_obl_pochodna == 2)
            {

                obliczanie_wzorow_na_pochodna_1_rzedu__lewo_poz3_1();
            }
            watch6.Stop();
            var elapsedMs6 = watch6.ElapsedMilliseconds;
            czas_watek1_2watkowo = Convert.ToString(elapsedMs6);


        }
        private void Thread_3_4_obliczenia()
        {
            var watch5 = System.Diagnostics.Stopwatch.StartNew();

            obliczanie_wzorow_na_pochodna_1_rzedu();
            if (ile_razy_obl_pochodna == 2)
            {
                obliczanie_wzorow_na_pochodna_2_rzedu();
            }

            obliczanie_wzorow_na_pochodna_1_rzedu_przeciwny();
            if (ile_razy_obl_pochodna == 2)
            {
                obliczanie_wzorow_na_pochodna_2_rzedu_przeciwny();
            }

            obliczanie_wzorow_na_pochodna_1_rzedu__prawo();
            if (ile_razy_obl_pochodna == 2)
            {
                obliczanie_wzorow_na_pochodna_2_rzedu__prawo();
            }

            obliczanie_wzorow_na_pochodna_1_rzedu__lewo();
            if (ile_razy_obl_pochodna == 2)
            {
                obliczanie_wzorow_na_pochodna_2_rzedu__lewo();
            }
            watch5.Stop();
            var elapsedMs5 = watch5.ElapsedMilliseconds;
            czas_watek2_2watkowo = Convert.ToString(elapsedMs5);
           
        }
        private void Thread_4_obliczenia()
        {
            var watch4 = System.Diagnostics.Stopwatch.StartNew();


            obliczanie_wzorow_na_pochodna_1_rzedu__prawo();
            if (ile_razy_obl_pochodna == 2)
            {
                obliczanie_wzorow_na_pochodna_2_rzedu__prawo();
            }

            obliczanie_wzorow_na_pochodna_1_rzedu__lewo();
            if (ile_razy_obl_pochodna == 2)
            {
                obliczanie_wzorow_na_pochodna_2_rzedu__lewo();
            }
            watch4.Stop();
          var elapsedMs4 = watch4.ElapsedMilliseconds;
            czas_watek4 = Convert.ToString(elapsedMs4);
            //  label_watek4.Text = "Czas rysowania watek  4 [ms]:   " + Convert.ToString(elapsedMs4);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (wyczysc_wykres == true)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();

                deklaracja_zmiennych_pochodna();
                tworzenie_charakteresytyk();
                rysowanie_wykresu_podstawowego();
                if (ile_razy_obl_pochodna == 2)
                {

                    obliczanie_wzorow_na_pochodna_1_rzedu_0_1();
                }
                pozycja_y = 1;
                pozycja_x = 0;
                rysowanie_wykresu_przeciwny_znak();

                if (ile_razy_obl_pochodna == 2)
                {

                    obliczanie_wzorow_na_pochodna_1_rzedu_przeciwny_poz1_1();
                }



                pozycja_y = 2;
                pozycja_x = 0;
                rysowanie_wykresu_prawo();

                if (ile_razy_obl_pochodna == 2)
                {

                    obliczanie_wzorow_na_pochodna_1_rzedu__prawo_poz2_1();
                }
                pozycja_y = 3;
                pozycja_x = 0;
                rysowanie_wykresu_lewo();
                if (ile_razy_obl_pochodna == 2)
                {

                    obliczanie_wzorow_na_pochodna_1_rzedu__lewo_poz3_1();
                }



                obliczanie_wzorow_na_pochodna_1_rzedu();
                if (ile_razy_obl_pochodna == 2)
                {
                    obliczanie_wzorow_na_pochodna_2_rzedu();
                }

                obliczanie_wzorow_na_pochodna_1_rzedu_przeciwny();
                if (ile_razy_obl_pochodna == 2)
                {
                    obliczanie_wzorow_na_pochodna_2_rzedu_przeciwny();
                }



                obliczanie_wzorow_na_pochodna_1_rzedu__prawo();
                if (ile_razy_obl_pochodna == 2)
                {
                    obliczanie_wzorow_na_pochodna_2_rzedu__prawo();
                }

                obliczanie_wzorow_na_pochodna_1_rzedu__lewo();
                if (ile_razy_obl_pochodna == 2)
                {
                    obliczanie_wzorow_na_pochodna_2_rzedu__lewo();
                }
                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;
                //label_czas_rys_bez.Text = "Czas rysowania [ms]:   " + Convert.ToString(elapsedMs);
                czas_wezwatku = Convert.ToString(elapsedMs);
                wyczysc_wykres = false;
            }
            
              else
            {
                MessageBox.Show("Wyczyść najpierw wykres!");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            wyczysc_wykres = true;
            clearChart();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label_watek1.Text = "Czas rysowania watek 1 [ms]:  " + Convert.ToString(czas_watek1);
            label_watek2.Text = "Czas rysowania watek 2 [ms]:  " + Convert.ToString(czas_watek2);
            label_watek3.Text = "Czas rysowania watek 3 [ms]:  " + Convert.ToString(czas_watek3);
            label_watek4.Text = "Czas rysowania watek 4 [ms]:   " + Convert.ToString(czas_watek4);
            label_czas_rys_bez.Text = "Czas rysowania bez watku [ms]:   " + Convert.ToString(czas_wezwatku);

            label_watek_1_2watkowo.Text = "Czas rysowania watek 1 [ms]:  " + Convert.ToString(czas_watek1_2watkowo);
            label_watek_2_2watkowo.Text = "Czas rysowania watek 2 [ms]:  " + Convert.ToString(czas_watek2_2watkowo);
        }
        private void clearChart()
        {
            int ile_razy_usunac = 0;
            int ile_razy_przelecialo_poch_1 = 0;
            if (ile_razy_obl_pochodna == 2)
            {
                ile_razy_usunac = 2;
            }
            else
            {
                ile_razy_usunac = 1;
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < ile_razy_usunac; j++)
                {
                    if (ile_razy_przelecialo_poch_1 < ile_powinno_przeleciec_w_petli)
                    {
                        ilosc_wykresow[i, j].GraphPane.CurveList.Clear();
                        ilosc_wykresow[i, j].AxisChange();
                        ilosc_wykresow[i, j].Invalidate();
                        ilosc_wykresow[i, j].GraphPane.Title.Text = "";
                        // ile_razy_przelecialo_poch_1++;
                        ZedGraphControl buttonToRemove = ilosc_wykresow[i, j];
                        this.Controls.Remove(buttonToRemove);
                    }
                }
            }
            label_watek1.Text = "Czas rysowania watek 1 [ms]:";
            label_watek2.Text = "Czas rysowania watek 2 [ms]:";
            label_watek3.Text = "Czas rysowania watek 3 [ms]:";
            label_watek4.Text = "Czas rysowania watek 4 [ms]:";
            label_czas_rys_bez.Text = "Czas rysowania bez watku [ms]:";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (wyczysc_wykres == true)
            {
                deklaracja_zmiennych_pochodna();
                //   clearChart();
                tworzenie_charakteresytyk();
                Thread.Sleep(100);
                Thread t1 = new Thread(Thread_1_2_obliczenia);
                Thread t2 = new Thread(Thread_3_4_obliczenia);
                t1.Start();
                t2.Start();
                wyczysc_wykres = false;
            }
            else
            {
                MessageBox.Show("Wyczyść najpierw wykres!");
            }
        }
    }
}
    
