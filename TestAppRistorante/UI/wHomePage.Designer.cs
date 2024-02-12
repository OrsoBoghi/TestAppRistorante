namespace TestAppRistorante
{
	partial class wHomePage
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

        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInfoDevice = new Wisej.Web.Label();
            this.btnInizio = new Wisej.Web.Button();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.spacer1 = new Wisej.Web.Spacer();
            this.spacer2 = new Wisej.Web.Spacer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfoDevice
            // 
            this.lblInfoDevice.AutoSize = true;
            this.lblInfoDevice.Dock = Wisej.Web.DockStyle.Bottom;
            this.lblInfoDevice.Location = new System.Drawing.Point(1272, 3);
            this.lblInfoDevice.MaximumSize = new System.Drawing.Size(200, 100);
            this.lblInfoDevice.MinimumSize = new System.Drawing.Size(200, 100);
            this.lblInfoDevice.Name = "lblInfoDevice";
            this.lblInfoDevice.Size = new System.Drawing.Size(200, 100);
            this.lblInfoDevice.TabIndex = 2;
            this.lblInfoDevice.Text = "Dati Utente";
            this.lblInfoDevice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnInizio
            // 
            this.btnInizio.AutoSize = true;
            this.btnInizio.Dock = Wisej.Web.DockStyle.Bottom;
            this.flowLayoutPanel1.SetFillWeight(this.btnInizio, 1);
            this.btnInizio.Location = new System.Drawing.Point(555, 3);
            this.btnInizio.MaximumSize = new System.Drawing.Size(200, 50);
            this.btnInizio.MinimumSize = new System.Drawing.Size(200, 50);
            this.btnInizio.Name = "btnInizio";
            this.btnInizio.Size = new System.Drawing.Size(200, 50);
            this.btnInizio.TabIndex = 0;
            this.btnInizio.Text = "Start";
            this.btnInizio.Click += new System.EventHandler(this.btnInizio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = Wisej.Web.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new Wisej.Web.Padding(20);
            this.pictureBox1.Size = new System.Drawing.Size(1475, 507);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.spacer1);
            this.flowLayoutPanel1.Controls.Add(this.btnInizio);
            this.flowLayoutPanel1.Controls.Add(this.spacer2);
            this.flowLayoutPanel1.Controls.Add(this.lblInfoDevice);
            this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 507);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1475, 100);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // spacer1
            // 
            this.flowLayoutPanel1.SetFillWeight(this.spacer1, 1);
            this.spacer1.Location = new System.Drawing.Point(3, 3);
            this.spacer1.Name = "spacer1";
            this.spacer1.Size = new System.Drawing.Size(546, 20);
            // 
            // spacer2
            // 
            this.flowLayoutPanel1.SetFillWeight(this.spacer2, 1);
            this.spacer2.Location = new System.Drawing.Point(761, 3);
            this.spacer2.Name = "spacer2";
            this.spacer2.Size = new System.Drawing.Size(505, 20);
            // 
            // wHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
            this.ClientSize = new System.Drawing.Size(1475, 607);
            this.CloseBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.HeaderBackColor = System.Drawing.Color.FromArgb(0, 127, 255);
            this.HeaderForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wHomePage";
            this.ShowInTaskbar = false;
            this.ShowModalMask = true;
            this.Text = "Ristorante Pippo";
            this.WindowState = Wisej.Web.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Label lblInfoDevice;
        private Wisej.Web.Button btnInizio;
        private Wisej.Web.PictureBox pictureBox1;
        private Wisej.Web.FlowLayoutPanel flowLayoutPanel1;
        private Wisej.Web.Spacer spacer1;
        private Wisej.Web.Spacer spacer2;
    }
}

