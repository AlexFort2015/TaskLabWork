using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            chart1.Series.Clear();             
        }
        public void PolarFunction(double A, double B, double C)
        {
            int count = chart1.Series.Count;
            double x, y, Ro, Fi;


            chart1.Series.Add("График " + count);
            chart1.Series[count].ChartType = SeriesChartType.Polar;
           
            for (Fi = 0; Fi <= 10 * Math.PI; Fi += 0.1)
            {

                Ro = A * Math.Sin(B+Fi) * Math.Cos(C+Fi);
                x = Ro * Math.Cos(Fi);
                y = Ro * Math.Sin(Fi);
                chart1.Series[count].Points.AddXY(x, y);
            }
           

        }
    }
}
