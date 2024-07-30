using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _0._12Login
{
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
            getData();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\courierdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Dashbord_Load(object sender, EventArgs e)
        {
            this.Location = new Point(255, 130);
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Parcels2 v = new Parcels2();
            v.Show();
            this.Hide();
        }
        private void getData()
        {
            conn.Open();
            SqlDataAdapter sad = new SqlDataAdapter("select count(*) from ParcelTb", conn);
            DataTable dt = new DataTable();
            sad.Fill(dt);
            lblAll.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 fn = new Form1();
            fn.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
         
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            Form1 v = new Form1();
            v.Show();
            this.Hide();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            DeliveryRates v=new DeliveryRates();
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

        private void BtnAddParcels_Click(object sender, EventArgs e)
        {
            parcels s = new parcels();
            s.Show();
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

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRiders_Click(object sender, EventArgs e)
        {
            riders v = new riders();
            v.Show();
            this.Hide();
        }

        private void BtnDash_Click(object sender, EventArgs e)
        {

        }

        private void lblAll_Click(object sender, EventArgs e)
        {

        }

        private void BtnAllParcells_Click(object sender, EventArgs e)
        {

        }
    }
}
