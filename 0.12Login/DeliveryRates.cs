using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0._12Login
{
    public partial class DeliveryRates : Form
    {
        public DeliveryRates()
        {
            InitializeComponent();
        }
        private void calculateWeight()
        {
            miss();
            
            double c = 50;
            double w = 100;
            double a = double.Parse(TxtWeight.Text.ToString());
            double v = a*350;
          
            //lblout.Text = v.ToString();
            if (a<=1&&a>0)
            {
                v=v/a;
                LblWeight.Text = v.ToString();


            }
            else if (a>1&&a<=5)
            {
                v=v+c*(a-1);
                LblWeight.Text = v.ToString();

            }
            else if (a>5&&a<=10)
            {
                v=w*(a-5)+v;
                LblWeight.Text = v.ToString();

            }
            else
            {
                MessageBox.Show("missing info");
            }
           
        }
        private void miss()
        {
            if (TxtWeight.Text=="")
            {
                MessageBox.Show("fil");
                DeliveryRates v = new DeliveryRates();
                v.Show();
            }
        }
        private void calculateCartoonSize()
        {
            miss2();
            double  parima = 0;
            double with = 0;
            double higth = 0;
            double lenth = 0;
            with=double.Parse(TxtWeight.Text.ToString());
            higth=double.Parse(TxtHight.Text.ToString());
            lenth=double.Parse(TxtLength.Text.ToString());
            parima=with*higth*lenth;
            double cz = 350;
            
            if (parima<=2000&&parima>=1000)
            {
                LblCartoon.Text=cz.ToString();
            }
            else if (parima>2000&&parima<=5000)
            {
                cz=cz*2;
                LblCartoon.Text = cz.ToString();
            }
            else
            {
                MessageBox.Show("hshs");
            }
            

        }
        private void miss2()
        {
            if (TxtHight.Text==""||TxtLength.Text==""||TxtWidth.Text=="")
            {
                MessageBox.Show("fil2");
            }
        }

        private void ww()
        {
            double n = double.Parse(LblWeight.Text.ToString());
            double m = double.Parse(LblCartoon.Text.ToString());
            if (n<m)
            {
                LblShowTotl.Text=m.ToString();
            }
            else
            {
                LblShowTotl.Text=n.ToString();
            }
        }

        private void DeliveryRates_Load(object sender, EventArgs e)
        {
            this.Location = new Point(255, 130);
        }

        private void BtnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAddParcels_Click(object sender, EventArgs e)
        {
            parcels s = new parcels();
            s.Show();
            this.Hide();
        }

        private void BtnDash_Click(object sender, EventArgs e)
        {
            Dashbord v = new Dashbord();
            v.Show();
            this.Hide();
        }

        private void BtnCous_Click(object sender, EventArgs e)
        {
            Coustermers v = new Coustermers();
            v.Show();
            this.Hide();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            Form1 v=new Form1();
            v.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void BtnHeip_Click(object sender, EventArgs e)
        {
            Help v = new Help();
            v.Show();
            this.Hide();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            calculateWeight();
            calculateCartoonSize();
            ww();
            miss();
            miss2();
        }

        private void btnRiders_Click(object sender, EventArgs e)
        {
            riders v=new riders();
            v.Show();
            this.Hide();
        }

        private void BtnParcels_Click(object sender, EventArgs e)
        {
            Parcels2 v=new Parcels2();
            v.Show();
            this.Hide();
        }
    }
}
