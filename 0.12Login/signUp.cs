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
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }
        SqlConnection con=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\courierdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void BtnSignUpClose_Click(object sender, EventArgs e)
        {
            Form1 a=new Form1();
            a.Show();
            this.Hide();
        }

        private void BtnSignUpSave_Click(object sender, EventArgs e)
        {
            if (TxtSignUN.Text=="")
            {
                MessageBox.Show("Enter your details");
            }
            else
            {
                try
                {
                    con.Open();
                    var cmd = new SqlCommand("insert into signupTb(UserName,Password,NIC,PhoneNumber,Email)values(@UN,@PS,@NI,@PN,@EM)", con);
                    cmd.Parameters.AddWithValue("@UN", (TxtSignUN.Text));
                    cmd.Parameters.AddWithValue("@PS", (TxtSignPass.Text));
                    cmd.Parameters.AddWithValue("@NI", (TxtSignNic.Text));
                    cmd.Parameters.AddWithValue("@PN", (TxtSignPN.Text));
                    cmd.Parameters.AddWithValue("@EM", (TxtSignEmail.Text));


                    cmd.GetType();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfull save");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSignUpClear_Click(object sender, EventArgs e)
        {
            TxtSignEmail.Text="";
            TxtSignNic.Text="";
            TxtSignPass.Text="";
            TxtSignPN.Text="";
            TxtSignUN.Text="";
        }

        private void signUp_Load(object sender, EventArgs e)
        {























        }
    }
}
