namespace _0._12Login
{
    partial class CustomMsgBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMsgBox));
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.LblMsgBox = new Guna.UI.WinForms.GunaLabel();
            this.gunaGradient2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.gunaGradientButton1);
            this.gunaGradient2Panel1.Controls.Add(this.LblMsgBox);
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.Cyan;
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.White;
            this.gunaGradient2Panel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            resources.ApplyResources(this.gunaGradient2Panel1, "gunaGradient2Panel1");
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaGradient2Panel1_Paint);
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.RoyalBlue;
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.DarkSlateBlue;
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.gunaGradientButton1, "gunaGradientButton1");
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.Image = null;
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // LblMsgBox
            // 
            resources.ApplyResources(this.LblMsgBox, "LblMsgBox");
            this.LblMsgBox.Name = "LblMsgBox";
            this.LblMsgBox.Click += new System.EventHandler(this.LblMsgBox_Click);
            // 
            // CustomMsgBox
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaGradient2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomMsgBox";
            this.Load += new System.EventHandler(this.CustomMsgBox_Load);
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradient2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI.WinForms.GunaLabel LblMsgBox;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
    }
}