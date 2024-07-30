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
    public partial class riders : Form
    {
        public riders()
        {
            InitializeComponent();
        }
        SqlConnection conn=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\courierdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtRDname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddR_Click(object sender, EventArgs e)
        {
            if (txtRDname.Text=="")
            {
                MessageBox.Show("empty");
            }
            else
            {
                try
                {
                    conn.Open();
                    var cmd= new SqlCommand("insert into Riders (RiderName,RiderID,RiderPN) values(@RN,@RID,@RPN)",conn);
                    cmd.Parameters.AddWithValue("@RN", (txtRDname.Text));
                    cmd.Parameters.AddWithValue("@RID",(txtRID.Text));
                    cmd.Parameters.AddWithValue("@RPN",(txtRPN.Text));
                    cmd.GetType();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("sucsusspull");
                    conn.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            

        }

        private void riders_Load(object sender, EventArgs e)
        {
            this.Location = new Point(255, 130);
        

            conn.Open();
            string query = "select * from Riders";
            SqlDataAdapter sad = new SqlDataAdapter(query, conn);
            SqlCommandBuilder bul = new SqlCommandBuilder(sad);
            var ds = new DataSet();
            sad.Fill(ds);
            gunaDataGridView1.DataSource = ds.Tables[0];
            //conn.Close();
            //conn.Open();
            string query1 = "select * from ParcelTb";
            SqlDataAdapter sad1 = new SqlDataAdapter(query1, conn);
            SqlCommandBuilder bul1 = new SqlCommandBuilder(sad1);
            var ds1 = new DataSet();
            sad1.Fill(ds1);
            gunaDataGridView2.DataSource = ds1.Tables[0];
            conn.Close();

        }

        private void BtnDash_Click(object sender, EventArgs e)
        {
            Dashbord v = new Dashbord();
            v.Show();
            this.Hide();
        }

        private void BtnParcels_Click(object sender, EventArgs e)
        {
            parcels s = new parcels();
            s.Show();
            this.Hide();
        }

        private void Btnrates_Click(object sender, EventArgs e)
        {
            DeliveryRates v = new DeliveryRates();
            v.Show();
            this.Hide();
        }

        private void BtnCous_Click(object sender, EventArgs e)
        {
            Coustermers v = new Coustermers();
            v.Show();
            this.Hide();
        }

        private void BtnAddParcels_Click(object sender, EventArgs e)
        {
            Parcels2 v = new Parcels2();
            v.Show();
            this.Hide();
        }

        private void BtnHeip_Click(object sender, EventArgs e)
        {
            Help v = new Help();
            v.Show();
            this.Hide();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            Form1 v = new Form1();
            v.Show();
            this.Hide();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
