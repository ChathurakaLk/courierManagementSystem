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
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\courierdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void alphaBlendTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void alphaBlendTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            TxtUN.Text="";
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLoginClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            signUp signUp = new signUp();
            signUp.Show();
            this.Hide();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter sad = new SqlDataAdapter("select count(*) from signupTb where UserName ='"+TxtUN.Text+"' and Password ='"+TxtPass.Text+"'", conn);
            DataTable Dt = new DataTable();
            sad.Fill(Dt);
            if (Dt.Rows[0][0].ToString()=="1")
            {
                Dashbord x = new Dashbord();
                x.Show();
                this.Hide();
            }
            conn.Close();
            if (TxtUN.Text=="Admin"||TxtPass.Text=="1234")
            {
                Dashbord x = new Dashbord(); 
                x.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Eror");
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            //textBox11.Clear();
        }

        private void textBox11_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void TxtUN_MouseClick(object sender, MouseEventArgs e)
        {
            TxtUN.Clear();
        }

        private void TxtUN_TextChanged(object sender, EventArgs e)
        {

        }

        private void alphaBlendTextBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void alphaBlendTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void csll_MouseClick(object sender, MouseEventArgs e)
        {
             

        }

        private void TxtPass_MouseClick(object sender, MouseEventArgs e)
        {
            TxtPass.Clear();
        }

        private void BtnLogEye_Click(object sender, EventArgs e)
        {
            if (BtnLogEye.Text==" ")
            {
                BtnLogEye.Text="  ";

               
                TxtPass.PasswordChar= '\0';
            }
            else
            {
                BtnLogEye.Text=" ";
                TxtPass.PasswordChar= '*';
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
