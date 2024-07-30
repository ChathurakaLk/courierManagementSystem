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
using Guna.UI.WinForms;

namespace _0._12Login
{
    public partial class Parcels2 : Form
    {
        public Parcels2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\courierdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnRiders_Click(object sender, EventArgs e)
        {
            riders v = new riders();
            v.Show();
            this.Hide();
        }

        private void BtnHeip_Click(object sender, EventArgs e)
        {
            Help v = new Help();
            v.Show();
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
            Form1 v = new Form1();
            v.Show();
            this.Hide();
        }

        private void BtnParcels_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddParcels_Click(object sender, EventArgs e)
        {
            parcels v = new parcels();
            v.Show();
            this.Hide();
        }

        private void Btnrates_Click(object sender, EventArgs e)
        {
            parcels v = new parcels();
            v.Show();
            this.Hide();
        }

        private void BtnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Parcels2_Load(object sender, EventArgs e)
        {
            this.Location = new Point(255, 130);


            conn.Open();
            string query = "select * from ParcelTb";
            SqlDataAdapter sad = new SqlDataAdapter(query, conn);
            SqlCommandBuilder bul = new SqlCommandBuilder(sad);
            var ds = new DataSet();
            sad.Fill(ds);
            gunaDataGridView1.DataSource = ds.Tables[0];
            conn.Close();




        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    txtRDname.Text=dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        //    txtRID.Text=dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        //}

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRDname.Text=gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtRID.Text=gunaDataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            if (txtRID.Text=="Matara")
            {
                gunaLabel1.Text="t1";
            }
        }
    }
}
