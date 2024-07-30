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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            this.Location = new Point(255, 130);
        }

        private void BtnDash_Click(object sender, EventArgs e)
        {
            Dashbord v = new Dashbord();
            v.Show();
            this.Hide();
        }

        private void BtnParcels_Click(object sender, EventArgs e)
        {
            
        }

        private void Btnrates_Click(object sender, EventArgs e)
        {
            DeliveryRates v=new DeliveryRates();
            v.Show();
            this.Hide();
        }

        private void BtnAddParcels_Click(object sender, EventArgs e)
        {
            parcels v = new parcels();
            v.Show();
            this.Hide();
        }

        private void BtnCous_Click(object sender, EventArgs e)
        {
            Coustermers v = new Coustermers();
            v.Show();
            this.Hide();
        }

        private void BtnHeip_Click(object sender, EventArgs e)
        {
            Help v=new Help();
            v.Show();
            this.Hide();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            Form1 v=new Form1();
            v.Show();
            this.Hide();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BtnSettings_Click_1(object sender, EventArgs e)
        {
            Form1 v = new Form1();
            v.Show();
            this.Hide();
        }

        private void btnRiders_Click(object sender, EventArgs e)
        {
            riders v = new riders();
            v.Show();
            this.Hide();
        }

        private void BtnAddParcels_Click_1(object sender, EventArgs e)
        {
            Parcels2 v = new Parcels2();
            v.Show();
            this.Hide();
        }

        private void BtnCous_Click_1(object sender, EventArgs e)
        {
            Coustermers v = new Coustermers();
            v.Show();
            this.Hide();
        }

        private void BtnParcels_Click_1(object sender, EventArgs e)
        {
            Parcels2 v = new Parcels2();
            v.Show();
            this.Hide();
        }

        private void Btnrates_Click_1(object sender, EventArgs e)
        {
            DeliveryRates v = new DeliveryRates();
            v.Show();
            this.Hide();
        }

        private void BtnDash_Click_1(object sender, EventArgs e)
        {
            
            Dashbord v = new Dashbord();
            v.Show();
            this.Hide();
        }
    }
}
