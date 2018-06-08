using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;  

namespace PP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double ileRazy;
        static int[] tablica;
        static Random rnd = new Random();
        static int n;
        static int k;

        static double czasSortBez;
        static double czasSortWar;
        static double czasSortRef;

        static double czasSilniaBez;
        static double czasSilniaWar;
        static double czasSilniaRef;

        static double czasNewBez;
        static double czasNewWar;
        static double czasNewRef;




        protected double LiczPierwszaPetle(double ileRazy)
        {
            double wynik = 0;
            double wynik1 = 1.0;
            double wynik2 = 1.0;
            for (double i = 1.0; i <= ileRazy; i++)
            {
                wynik1 *= i;
                wynik2 = LiczDrugaPetle(ileRazy);
                wynik = wynik1 * wynik2; 
            }
                return wynik;
        }

        protected double LiczDrugaPetle(double ileRazy)
        {
            double wynik = 1.0;
            for (double j = 1.0; j < ileRazy; j++)
            {
                wynik *= j;
            }
            return wynik;

        }
        protected double LiczPierwszaPetleRef(ref double ileRazy)
        {
            double wynik = 0;
            double wynik1 = 1.0;
            double wynik2 = 1.0;
            for (double i = 1.0; i <= ileRazy; i++)
            {
                wynik1 *= i;
                wynik2 = LiczDrugaPetleRef(ref ileRazy);
                wynik = wynik1 * wynik2;
            }
            return wynik;
        }
        protected double LiczDrugaPetleRef(ref double ileRazy)
        {
            double wynik = 1.0;
            for (double j = 1.0; j < ileRazy; j++)
            {
                wynik *= j;
            }
            return wynik;

        }
        private void btnLiczSilnie_Click(object sender, EventArgs e)
        {
            ileRazy = (int)numericSilnia.Value;

            double wynik = 0.0;
            double wynik1 = 1.0;
            double wynik2 = 1.0;
            DateTime startTime1 = DateTime.Now;
            for (double i = 1.0; i <= ileRazy; i++)
            {
                wynik1 *= i;
                for(double j=1.0;j<ileRazy;j++)
                {
                    wynik2 *=i;
                }
                wynik = wynik1 * wynik2;
            }
            DateTime stopTime1 = DateTime.Now;

            TimeSpan roznica1 = stopTime1 - startTime1;
            

            

            DateTime startTime2 = DateTime.Now;
            LiczPierwszaPetle(ileRazy);
            DateTime stopTime2 = DateTime.Now;
            TimeSpan roznica2 = stopTime2 - stopTime1;
            //tbBezSilnia.Text = roznica1.TotalMilliseconds.ToString();
            //tbWartoscSilnia.Text = roznica2.TotalMilliseconds.ToString();


            DateTime startTime3 = DateTime.Now;
            LiczPierwszaPetleRef(ref ileRazy);
            DateTime stopTime3 = DateTime.Now;
            TimeSpan roznica3 = stopTime3 - stopTime3;

            //string tm = roznica3.TotalMilliseconds.ToString();
            czasSilniaBez = roznica1.TotalMilliseconds;
            czasSilniaWar = roznica2.TotalMilliseconds;
            czasSilniaRef = roznica3.TotalMilliseconds;


            if (czasSilniaBez == 0)
            {
                tbBezSort.Text = "pomijalne";
            }
            else
            {
                tbBezSilnia.Text = czasSilniaBez.ToString();
            }
            if (czasSilniaWar == 0)
            {
                tbWartoscSilnia.Text = "pomijalne";
            }
            else
            {
                tbWartoscSilnia.Text = czasSilniaWar.ToString();
            }
            if (czasSilniaRef == 0)
            {
                tbRefSilnia.Text = "pomijalne";
            }
            else
            {
                tbRefSilnia.Text = czasSilniaRef.ToString();
            }

        }

        private void linkSortowanie_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tab.SelectTab(1);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tab.SelectTab(2);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tab.SelectTab(3);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tab.SelectTab(4);
        }

        private int [] SortujPrzezWar(int [] tab)
        {
            int n = tab.Length;

            do
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        int tmp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = tmp;
                    }
                }
                n--;
            }
            while (n > 1);
           
            return tab;
        }

        private int [] SortujPrzezRef(ref int[] tab)
        {
            int n = tab.Length;

            do
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        int tmp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = tmp;
                    }
                }
                n--;
            }
            while (n > 1);
            
            return tab;
        }
        private void btnLiczSort_Click(object sender, EventArgs e)
        {
            int elementy = (int)numeric.Value;
            tablica = new int[elementy];
            
            int n = tablica.Length;
            int[] tablica2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                tablica[i] = rnd.Next(0, 10000);
            }
            for (int i = 0; i < n; i++)
            {
                tablica2[i] = tablica[i];
            }

            DateTime startTime1 = DateTime.Now;

            do
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (tablica[i] > tablica[i + 1])
                    {
                        int tmp = tablica[i];
                        tablica[i] = tablica[i + 1];
                        tablica[i + 1] = tmp;
                    }
                }
                n--;
            }
            while (n > 1);
           


            DateTime stopTime1 = DateTime.Now;

            TimeSpan roznica1 = stopTime1 - startTime1;
            tbBezSort.Text = roznica1.TotalMilliseconds.ToString();

            DateTime startTime2 = DateTime.Now;
            SortujPrzezWar(tablica2);
            DateTime stopTime2 = DateTime.Now;

            TimeSpan roznica2 = stopTime2 - startTime2;
            tbWartoscSort.Text = roznica2.TotalMilliseconds.ToString();

            DateTime startTime3 = DateTime.Now;
            SortujPrzezRef(ref tablica2);
            DateTime stopTime3 = DateTime.Now;

            TimeSpan roznica3 = stopTime3 - startTime3;

            czasSortBez = roznica1.TotalMilliseconds;
            czasSortWar = roznica2.TotalMilliseconds;
            czasSortRef = roznica3.TotalMilliseconds;

            if (czasSortBez == 0)
            {
                tbBezSort.Text = "pomijalne";
            }
            else
            {
                tbBezSort.Text = czasSortBez.ToString();
            }
            if (czasSortWar == 0)
            {
                tbWartoscSort.Text = "pomijalne";
            }
            else
            {
                tbWartoscSort.Text = czasSortWar.ToString();
            }
            if (czasSortRef == 0)
            {
                tbRefSort.Text = "pomijalne";
            }
            else
            {
                tbRefSort.Text = czasSortRef.ToString();
            }
        }
        private long LiczNewtonWartosc (int n, int k)
        {
            long Wynik = 1;       

            for (int i = 1; i <= k; i++)
            {
                Wynik = Wynik * (n - i + 1) / i;
                for (int j = 1; j <= k; j++)
                {
                    Wynik = Wynik * (n - j + 1) / j;
                    for (int l = 1; l <= k; l++)
                    {
                        Wynik = Wynik * (n - l + 1) / l;
                    }
                }
            }

            return Wynik;   
        }
        private long LiczNewtonRef(ref int n, ref int k)
        {
            long Wynik = 1;

            for (int i = 1; i <= k; i++)
            {
                Wynik = Wynik * (n - i + 1) / i;
                for (int j = 1; j <= k; j++)
                {
                    Wynik = Wynik * (n - j + 1) / j;
                    for (int l = 1; l <= k; l++)
                    {
                        Wynik = Wynik * (n - l + 1) / l;
                    }
                }
            }

            return Wynik;
        }

        private void btnLiczNewton_Click(object sender, EventArgs e)
        {
            n = (int)numericN.Value;
            k = (int)numericK.Value;


            DateTime startTime1 = DateTime.Now;
            long Wynik = 1;

            for (int i = 1; i <= k; i++)
            {
                Wynik = Wynik * (n - i + 1) / i;
                for (int j = 1; j <= k; j++)
                {
                    Wynik = Wynik * (n - j + 1) / j;
                    for (int l = 1; l <= k; l++)
                    {
                        Wynik = Wynik * (n - l + 1) / l;
                    }
                }
            }

            DateTime stopTime1 = DateTime.Now;

            TimeSpan roznica1 = stopTime1 - startTime1;

            DateTime startTime2 = DateTime.Now;
            LiczNewtonWartosc(n, k);
            DateTime stopTime2 = DateTime.Now;
            TimeSpan roznica2 = stopTime2 - startTime2;

            DateTime startTime3 = DateTime.Now;
            LiczNewtonRef(ref n, ref k);
            DateTime stopTime3 = DateTime.Now;
            TimeSpan roznica3 = stopTime3 - startTime3;

            czasNewBez = roznica1.TotalMilliseconds;
            czasNewWar = roznica2.TotalMilliseconds;
            czasNewRef = roznica3.TotalMilliseconds;



            if (czasNewBez == 0)
            {
                tbBezNew.Text = "pomijalne";
            }
            else
            {
                tbBezNew.Text = czasNewBez.ToString();
            }
            if (czasNewWar == 0)
            {
                tbWartoscNew.Text = "pomijalne";
            }
            else
            {
                tbWartoscNew.Text = czasNewWar.ToString();
            }
            if (czasNewRef == 0)
            {
                tbRefNew.Text = "pomijalne";
            }
            else
            {
                tbRefNew.Text = czasNewRef.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnLiczSort_Click(sender, e);
            foreach (var series in chart.Series)
            {
                series.Points.Clear();
            }
            chart.Series[0].IsVisibleInLegend = false;
            chart.Series[1].IsVisibleInLegend = false;
            chart.Series[2].IsVisibleInLegend = false;
            chart.Series[0].Points.AddXY("Bez podprogramów", czasSortBez);
            chart.Series[0].Points.AddXY("Z pp z arg. przekaz. przez war.", czasSortWar);
            chart.Series[0].Points.AddXY("z pp z art. przekaz. przez ref.", czasSortRef);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnLiczSilnie_Click(sender, e);
            foreach (var series in chart.Series)
            {
                series.Points.Clear();
            }
            chart.Series[0].IsVisibleInLegend = false;
            chart.Series[1].IsVisibleInLegend = false;
            chart.Series[2].IsVisibleInLegend = false;
            chart.Series[0].Points.AddXY("Bez podprogramów", czasSilniaBez);
            chart.Series[0].Points.AddXY("Z pp z arg. przekaz. przez war.", czasSilniaWar);
            chart.Series[0].Points.AddXY("z pp z art. przekaz. przez ref.", czasSilniaRef);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnLiczNewton_Click(sender, e);
            foreach (var series in chart.Series)
            {
                series.Points.Clear();
            }
            chart.Series[0].IsVisibleInLegend = false;
            chart.Series[1].IsVisibleInLegend = false;
            chart.Series[2].IsVisibleInLegend = false;
            chart.Series[0].Points.AddXY("Bez podprogramów", czasNewBez);
            chart.Series[0].Points.AddXY("Z pp z arg. przekaz. przez war.", czasNewWar);
            chart.Series[0].Points.AddXY("z pp z art. przekaz. przez ref.", czasNewRef);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnLiczSort_Click(sender, e);
            btnLiczSilnie_Click(sender, e);
            btnLiczNewton_Click(sender, e);
            foreach (var series in chart.Series)
            {
                series.Points.Clear();
            }
            chart.Series[0].Points.AddXY("Bez podprogramów", czasSortBez);
            chart.Series[0].Points.AddXY("Z pp z arg. przekaz. przez war.", czasSortWar);
            chart.Series[0].Points.AddXY("z pp z art. przekaz. przez ref.", czasSortRef);

            chart.Series[0].Legend = "Legend1";
            chart.Series[0].IsVisibleInLegend = true;


            chart.Series[1].Points.AddXY("Bez podprogramów", czasSilniaBez);
            chart.Series[1].Points.AddXY("Z pp z arg. przekaz. przez war.", czasSilniaWar);
            chart.Series[1].Points.AddXY("z pp z art. przekaz. przez ref.", czasSilniaRef);

            chart.Series[1].Legend = "Legend1";
            chart.Series[1].IsVisibleInLegend = true;

            chart.Series[2].Points.AddXY("Bez podprogramów", czasNewBez);
            chart.Series[2].Points.AddXY("Z pp z arg. przekaz. przez war.", czasNewWar);
            chart.Series[2].Points.AddXY("z pp z art. przekaz. przez ref.", czasNewRef);

            chart.Series[2].Legend = "Legend1";
            chart.Series[2].IsVisibleInLegend = true;
        }

        private void tbBezSort_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbWartoscSort_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbRefSort_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
