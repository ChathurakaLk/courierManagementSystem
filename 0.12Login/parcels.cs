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
    public partial class parcels : Form
    {
        public parcels()
        {
            InitializeComponent();
        }
        SqlConnection conn= new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\courierdb.mdf;Integrated Security=True;Connect Timeout=30");


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClearOrder_Click(object sender, EventArgs e)
        {
            TxtCity.Text="";
            TxtCouNo.Text="";
            TxtDelAddress.Text="";
            TxtOrderDis.Text="";
            TxtOrderNo.Text="";
            TxtPhoNumber.Text="";
            TxtPhoNumber.Text="";
            TxtPrice.Text="";
            TxtTrack.Text="";
            COMdis.SelectedIndex=-1;
            TxtNote.Text="";
            TxtNic.Text="";
            COMii.SelectedIndex=-1;
        }

        private void parcels_Load(object sender, EventArgs e)
        {
            this.Location = new Point(255, 130);
        }

        private void BtnDash_Click(object sender, EventArgs e)
        {
            Dashbord v = new Dashbord();
            v.Show();
            this.Hide();
        }

        private void gunaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (COMii.SelectedItem=="other")
            {
               TxtNote.Select();
              
            }
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            Form1 v = new Form1();
            v.Show();
            this.Hide();
        }

        private void BtnCous_Click(object sender, EventArgs e)
        {
            Coustermers v = new Coustermers();
            v.Show();
            this.Hide();
        }

        private void BtnRates_Click(object sender, EventArgs e)
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

        private void BtnParcels_Click(object sender, EventArgs e)
        {
            Parcels2 v = new Parcels2();
            v.Show();
            this.Hide();
        }

        private void BtnSaveOrder_Click(object sender, EventArgs e)
        {
            if (TxtCouNo.Text=="")
            {
                MessageBox.Show("fill");
            }
            else
            {
                try
                {
                    conn.Open();
                    var cmd = new SqlCommand("insert into ParcelTb(TrackingNo,OderNum,CusName,CusNIC,PhNo,OderDiscription,District,City,AddPrice,ImportanItems,DeliveryAddress,Note)values(@TN,@ON,@CN,@CNIC,@PN,@OD,@DIS,@CT,@AP,@II,@DA,@NT)", conn);
                    cmd.Parameters.AddWithValue("@TN", (TxtTrack.Text));
                    cmd.Parameters.AddWithValue("@ON", (TxtOrderNo.Text));
                    cmd.Parameters.AddWithValue("@CN", (TxtCouNo.Text));
                    cmd.Parameters.AddWithValue("@CNIC", (TxtNic.Text));
                    cmd.Parameters.AddWithValue("@PN", (TxtPhoNumber.Text));
                    cmd.Parameters.AddWithValue("@OD", (TxtOrderDis.Text));
                    cmd.Parameters.AddWithValue("@DIS", (COMdis.SelectedItem.ToString()));
                    cmd.Parameters.AddWithValue("@CT", (TxtCity.Text));
                    cmd.Parameters.AddWithValue("@AP", (TxtPrice.Text));
                    cmd.Parameters.AddWithValue("@II", (COMii.SelectedItem.ToString()));
                    cmd.Parameters.AddWithValue("@DA", (TxtDelAddress.Text));
                    cmd.Parameters.AddWithValue("@NT", (TxtNote.Text));
                    cmd.GetType();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sucsussfull Save");
                    conn.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnRiders_Click(object sender, EventArgs e)
        {
            riders v=new riders();
            v.Show();
            this.Hide();
        }
    }
}
