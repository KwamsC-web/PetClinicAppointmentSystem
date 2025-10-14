namespace PetClinicAppointmentSystem.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            eyeClse = new PictureBox();
            eyeOpn = new PictureBox();
            linkLabel2 = new LinkLabel();
            label4 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            textBox2 = new TextBox();
            pictureBox3 = new PictureBox();
            textBox1 = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eyeClse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eyeOpn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(74, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(76, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(302, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(eyeClse);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(eyeOpn);
            panel2.Controls.Add(linkLabel2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(451, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(449, 524);
            panel2.TabIndex = 1;
            // 
            // eyeClse
            // 
            eyeClse.BackColor = Color.White;
            eyeClse.Image = (Image)resources.GetObject("eyeClse.Image");
            eyeClse.Location = new Point(352, 228);
            eyeClse.Name = "eyeClse";
            eyeClse.Size = new Size(46, 40);
            eyeClse.SizeMode = PictureBoxSizeMode.Zoom;
            eyeClse.TabIndex = 22;
            eyeClse.TabStop = false;
            eyeClse.Click += eyeOpn_Click;
            // 
            // eyeOpn
            // 
            eyeOpn.BackColor = Color.White;
            eyeOpn.Image = (Image)resources.GetObject("eyeOpn.Image");
            eyeOpn.Location = new Point(352, 228);
            eyeOpn.Name = "eyeOpn";
            eyeOpn.Size = new Size(46, 40);
            eyeOpn.SizeMode = PictureBoxSizeMode.Zoom;
            eyeOpn.TabIndex = 21;
            eyeOpn.TabStop = false;
            eyeOpn.Click += eyeClse_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.FromArgb(0, 0, 192);
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabel2.Location = new Point(288, 385);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(55, 17);
            linkLabel2.TabIndex = 20;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Sign up";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(107, 382);
            label4.Name = "label4";
            label4.Size = new Size(175, 21);
            label4.TabIndex = 19;
            label4.Text = "Don't have an account?";
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(55, 322);
            button1.Name = "button1";
            button1.Size = new Size(345, 47);
            button1.TabIndex = 18;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(244, 67, 54);
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(254, 282);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(146, 21);
            linkLabel1.TabIndex = 17;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(156, 33);
            label3.Name = "label3";
            label3.Size = new Size(140, 34);
            label3.TabIndex = 16;
            label3.Text = "Paw-Sign";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(16, 226);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(33, 42);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Cursor = Cursors.Hand;
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(55, 226);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(345, 44);
            textBox2.TabIndex = 15;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(16, 138);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.Hand;
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(55, 138);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Username";
            textBox1.Size = new Size(345, 42);
            textBox1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 247);
            label2.Name = "label2";
            label2.Size = new Size(0, 23);
            label2.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBox5);
            panel3.Location = new Point(-3, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(464, 524);
            panel3.TabIndex = 2;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(15, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(433, 501);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 23;
            pictureBox5.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(900, 525);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)eyeClse).EndInit();
            ((System.ComponentModel.ISupportInitialize)eyeOpn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox4;
        private TextBox textBox2;
        private PictureBox pictureBox3;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
        private Button button1;
        private Label label4;
        private LinkLabel linkLabel2;
        private PictureBox eyeClse;
        private PictureBox eyeOpn;
        private Panel panel3;
        private PictureBox pictureBox5;
    }
}