namespace PetClinicAppointmentSystem
{
    partial class Splash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            pctreB1 = new PictureBox();
            label1 = new Label();
            pgBar1 = new ProgressBar();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pctreB1).BeginInit();
            SuspendLayout();
            // 
            // pctreB1
            // 
            pctreB1.BackColor = Color.Transparent;
            pctreB1.Image = (Image)resources.GetObject("pctreB1.Image");
            pctreB1.Location = new Point(278, 85);
            pctreB1.Name = "pctreB1";
            pctreB1.Size = new Size(87, 89);
            pctreB1.SizeMode = PictureBoxSizeMode.StretchImage;
            pctreB1.TabIndex = 0;
            pctreB1.TabStop = false;
            pctreB1.Click += pctreB1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(82, 32);
            label1.Name = "label1";
            label1.Size = new Size(495, 29);
            label1.TabIndex = 1;
            label1.Text = "Pawfect Duo Clinic Appointment System";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pgBar1
            // 
            pgBar1.Location = new Point(116, 209);
            pgBar1.Name = "pgBar1";
            pgBar1.Size = new Size(433, 29);
            pgBar1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(116, 186);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 3;
            label2.Text = "Loading: Modules";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(292, 262);
            label3.Name = "label3";
            label3.Size = new Size(59, 34);
            label3.TabIndex = 4;
            label3.Text = "%%";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(661, 321);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pgBar1);
            Controls.Add(label1);
            Controls.Add(pctreB1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pctreB1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pctreB1;
        private Label label1;
        private ProgressBar pgBar1;
        private Label label2;
        private Label label3;
    }
}
