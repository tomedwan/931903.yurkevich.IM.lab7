using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automast
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();

        int obsl, salaries, stream_income, monthCounter = 0;
        int KOLmasla, KOLremont, KOLzamen, KOLpeopleAD;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        double clients, zapchasti, ADbudg, curSum;
        double ADcoef;

        private void btNextMonth_Click(object sender, EventArgs e)
        {
            monthCounter++;
            stream_income = 0; KOLmasla = 0; KOLpeopleAD = 0; KOLremont = 0; KOLzamen = 0;
            clients = 0; zapchasti = 0; ADbudg = 0; curSum = 0; ADcoef = 0;
            obsl = Convert.ToInt32(textBox1.Text);
            salaries = Convert.ToInt32(textBox2.Text);

            KOLmasla = random.Next(10, 100);
            KOLremont = random.Next(10, 100);
            KOLzamen = random.Next(10, 100);
            KOLpeopleAD = random.Next(0, 50);
            
           

            clients = KOLzamen + KOLremont + KOLmasla - KOLpeopleAD;
          //  zapchasti = KOLmasla * 1000 + KOLremont * 2000 + KOLzamen * 20000;
            stream_income = KOLmasla * 3000 + KOLremont * 5000 + KOLzamen * 30000;


            // замена масла         (2000 1000)
            // ремонт автозапчастей (3000 2000)
            // замена автозапчастей  (10000 20000)
            //

            curSum = stream_income - obsl - salaries;
            ADbudg = ADcoef * curSum;
            curSum = curSum - ADbudg;

            textBox3.Text = curSum.ToString();
            textBox4.Text = clients.ToString();
            textBox5.Text = KOLmasla.ToString();
            textBox6.Text = KOLremont.ToString();
            textBox7.Text = KOLzamen.ToString();
            chart1.Series[0].Points.AddXY(monthCounter, curSum);



        }
    }
}
