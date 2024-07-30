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
    public partial class Coustermers : Form
    {
        public Coustermers()
        {
            InitializeComponent();
        }
        SqlConnection conn= new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\courierdb.mdf;Integrated Security=True;Connect Timeout=30");


        private void BtnSettings_Click(object sender, EventArgs e)
        {
            Form1 v = new Form1();
            v.Show();
            this.Hide();
        }

        private void BtnDash_Click(object sender, EventArgs e)
        {
            Dashbord v = new Dashbord();
            v.Show();
            this.Hide();
        }

        private void BtnAddParcels_Click(object sender, EventArgs e)
        {
            parcels s = new parcels();
            s.Show();
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

        private void Coustermers_Load(object sender, EventArgs e)
        {
            this.Location = new Point(255, 130);
            conn.Open();
            string query = "select * from signupTb";
            SqlDataAdapter sad = new SqlDataAdapter(query, conn);
            SqlCommandBuilder bul = new SqlCommandBuilder(sad);
            var ds = new DataSet();
            sad.Fill(ds);
            gunaDataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void BtnCous_Click(object sender, EventArgs e)
        {

        }

        private void Btnrates_Click(object sender, EventArgs e)
        {
            DeliveryRates v = new DeliveryRates();
            v.Show();
            this.Hide();
        }

        private void BtnHeip_Click(object sender, EventArgs e)
        {
            Help v = new Help();
            v.Show();
            this.Hide();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            Parcels2 v = new Parcels2();
            v.Show();
            this.Hide();
        }

        private void BtnParcels_Click(object sender, EventArgs e)
        {

        }

        private void btnRiders_Click(object sender, EventArgs e)
        {
            riders v = new riders();
            v.Show();
            this.Hide();
        }

        private void Btnback_Click(object sender, EventArgs e)
        {

        }
    }
}
