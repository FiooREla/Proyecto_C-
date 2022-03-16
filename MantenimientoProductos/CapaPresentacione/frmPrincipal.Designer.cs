namespace CapaPresentacione
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.sideBar = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Panel();
            this.wraper = new System.Windows.Forms.Panel();
            this.apagar = new System.Windows.Forms.PictureBox();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apagar)).BeginInit();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(270, 940);
            this.sideBar.TabIndex = 0;
            // 
            // header
            // 
            this.header.Controls.Add(this.apagar);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(270, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1170, 60);
            this.header.TabIndex = 1;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.header_Paint);
            // 
            // wraper
            // 
            this.wraper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wraper.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.wraper.Location = new System.Drawing.Point(270, 60);
            this.wraper.Name = "wraper";
            this.wraper.Size = new System.Drawing.Size(1170, 880);
            this.wraper.TabIndex = 2;
            // 
            // apagar
            // 
            this.apagar.Image = ((System.Drawing.Image)(resources.GetObject("apagar.Image")));
            this.apagar.Location = new System.Drawing.Point(1106, 12);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(33, 33);
            this.apagar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.apagar.TabIndex = 0;
            this.apagar.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1440, 940);
            this.Controls.Add(this.wraper);
            this.Controls.Add(this.header);
            this.Controls.Add(this.sideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.apagar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel wraper;
        private System.Windows.Forms.PictureBox apagar;
    }
}