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
    public partial class CustomMsgBox : Form
    {
        public CustomMsgBox()
        {
            InitializeComponent();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();

        }

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblMsgBox_Click(object sender, EventArgs e)
        {
           
        }

        private void CustomMsgBox_Load(object sender, EventArgs e)
        {
            this.Location=new Point(299, 400);
        }
    }
}
