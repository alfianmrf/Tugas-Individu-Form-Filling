namespace FormFilling
{
    partial class Ekspedisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ekspedisi));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.buttonOngkir = new System.Windows.Forms.Button();
            this.buttonLacak = new System.Windows.Forms.Button();
            this.panelKirimSubMenu = new System.Windows.Forms.Panel();
            this.buttonBarang = new System.Windows.Forms.Button();
            this.buttonPenerima = new System.Windows.Forms.Button();
            this.buttonPengirim = new System.Windows.Forms.Button();
            this.buttonKirim = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxSideLogo = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.pictureBoxMainLogo = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelKirimSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSideLogo)).BeginInit();
            this.panelChildForm.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.buttonOngkir);
            this.panelSideMenu.Controls.Add(this.buttonLacak);
            this.panelSideMenu.Controls.Add(this.panelKirimSubMenu);
            this.panelSideMenu.Controls.Add(this.buttonKirim);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 561);
            this.panelSideMenu.TabIndex = 0;
            // 
            // buttonOngkir
            // 
            this.buttonOngkir.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOngkir.FlatAppearance.BorderSize = 0;
            this.buttonOngkir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOngkir.Font = new System.Drawing.Font("Montserrat", 10F);
            this.buttonOngkir.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonOngkir.Image = global::FormFilling.Properties.Resources.Ongkir;
            this.buttonOngkir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOngkir.Location = new System.Drawing.Point(0, 437);
            this.buttonOngkir.Name = "buttonOngkir";
            this.buttonOngkir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonOngkir.Size = new System.Drawing.Size(250, 60);
            this.buttonOngkir.TabIndex = 4;
            this.buttonOngkir.Text = "            Cek Ongkos Kirim";
            this.buttonOngkir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOngkir.UseVisualStyleBackColor = true;
            this.buttonOngkir.Click += new System.EventHandler(this.buttonOngkir_Click);
            // 
            // buttonLacak
            // 
            this.buttonLacak.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLacak.FlatAppearance.BorderSize = 0;
            this.buttonLacak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLacak.Font = new System.Drawing.Font("Montserrat", 10F);
            this.buttonLacak.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLacak.Image = global::FormFilling.Properties.Resources.Lacak;
            this.buttonLacak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLacak.Location = new System.Drawing.Point(0, 377);
            this.buttonLacak.Name = "buttonLacak";
            this.buttonLacak.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonLacak.Size = new System.Drawing.Size(250, 60);
            this.buttonLacak.TabIndex = 3;
            this.buttonLacak.Text = "            Lacak";
            this.buttonLacak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLacak.UseVisualStyleBackColor = true;
            this.buttonLacak.Click += new System.EventHandler(this.buttonLacak_Click);
            // 
            // panelKirimSubMenu
            // 
            this.panelKirimSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelKirimSubMenu.Controls.Add(this.buttonBarang);
            this.panelKirimSubMenu.Controls.Add(this.buttonPenerima);
            this.panelKirimSubMenu.Controls.Add(this.buttonPengirim);
            this.panelKirimSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKirimSubMenu.Location = new System.Drawing.Point(0, 197);
            this.panelKirimSubMenu.Name = "panelKirimSubMenu";
            this.panelKirimSubMenu.Size = new System.Drawing.Size(250, 180);
            this.panelKirimSubMenu.TabIndex = 2;
            this.panelKirimSubMenu.Visible = false;
            // 
            // buttonBarang
            // 
            this.buttonBarang.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBarang.FlatAppearance.BorderSize = 0;
            this.buttonBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.buttonBarang.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonBarang.Image = global::FormFilling.Properties.Resources.Barang;
            this.buttonBarang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBarang.Location = new System.Drawing.Point(0, 120);
            this.buttonBarang.Name = "buttonBarang";
            this.buttonBarang.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonBarang.Size = new System.Drawing.Size(250, 60);
            this.buttonBarang.TabIndex = 2;
            this.buttonBarang.Text = "            Barang";
            this.buttonBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBarang.UseVisualStyleBackColor = true;
            this.buttonBarang.Click += new System.EventHandler(this.buttonBarang_Click);
            // 
            // buttonPenerima
            // 
            this.buttonPenerima.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPenerima.FlatAppearance.BorderSize = 0;
            this.buttonPenerima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPenerima.Font = new System.Drawing.Font("Montserrat", 10F);
            this.buttonPenerima.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonPenerima.Image = global::FormFilling.Properties.Resources.Penerima;
            this.buttonPenerima.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPenerima.Location = new System.Drawing.Point(0, 60);
            this.buttonPenerima.Name = "buttonPenerima";
            this.buttonPenerima.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonPenerima.Size = new System.Drawing.Size(250, 60);
            this.buttonPenerima.TabIndex = 1;
            this.buttonPenerima.Text = "            Penerima";
            this.buttonPenerima.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPenerima.UseVisualStyleBackColor = true;
            this.buttonPenerima.Click += new System.EventHandler(this.buttonPenerima_Click);
            // 
            // buttonPengirim
            // 
            this.buttonPengirim.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPengirim.FlatAppearance.BorderSize = 0;
            this.buttonPengirim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPengirim.Font = new System.Drawing.Font("Montserrat", 10F);
            this.buttonPengirim.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonPengirim.Image = global::FormFilling.Properties.Resources.Pengirim;
            this.buttonPengirim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPengirim.Location = new System.Drawing.Point(0, 0);
            this.buttonPengirim.Name = "buttonPengirim";
            this.buttonPengirim.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonPengirim.Size = new System.Drawing.Size(250, 60);
            this.buttonPengirim.TabIndex = 0;
            this.buttonPengirim.Text = "            Pengirim";
            this.buttonPengirim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPengirim.UseVisualStyleBackColor = true;
            this.buttonPengirim.Click += new System.EventHandler(this.buttonPengirim_Click);
            // 
            // buttonKirim
            // 
            this.buttonKirim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonKirim.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonKirim.FlatAppearance.BorderSize = 0;
            this.buttonKirim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKirim.Font = new System.Drawing.Font("Montserrat", 10F);
            this.buttonKirim.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonKirim.Image = ((System.Drawing.Image)(resources.GetObject("buttonKirim.Image")));
            this.buttonKirim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKirim.Location = new System.Drawing.Point(0, 137);
            this.buttonKirim.Name = "buttonKirim";
            this.buttonKirim.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonKirim.Size = new System.Drawing.Size(250, 60);
            this.buttonKirim.TabIndex = 1;
            this.buttonKirim.Text = "            Kirim";
            this.buttonKirim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKirim.UseVisualStyleBackColor = true;
            this.buttonKirim.Click += new System.EventHandler(this.buttonKirim_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBoxSideLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 137);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Click += new System.EventHandler(this.panelLogo_Click);
            // 
            // pictureBoxSideLogo
            // 
            this.pictureBoxSideLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxSideLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSideLogo.ErrorImage")));
            this.pictureBoxSideLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSideLogo.Image")));
            this.pictureBoxSideLogo.Location = new System.Drawing.Point(20, 20);
            this.pictureBoxSideLogo.Name = "pictureBoxSideLogo";
            this.pictureBoxSideLogo.Size = new System.Drawing.Size(212, 96);
            this.pictureBoxSideLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSideLogo.TabIndex = 0;
            this.pictureBoxSideLogo.TabStop = false;
            this.pictureBoxSideLogo.Visible = false;
            this.pictureBoxSideLogo.Click += new System.EventHandler(this.pictureBoxSideLogo_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.panelTop);
            this.panelChildForm.Controls.Add(this.pictureBoxMainLogo);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(684, 561);
            this.panelChildForm.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Controls.Add(this.buttonClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(684, 50);
            this.panelTop.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Montserrat", 12F);
            this.labelTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitle.Location = new System.Drawing.Point(255, 14);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(150, 22);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "BURAQ EXPRESS";
            this.labelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.labelTitle_Paint);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Montserrat", 12F);
            this.buttonClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonClose.Location = new System.Drawing.Point(0, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(50, 50);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Visible = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.MouseEnter += new System.EventHandler(this.buttonClose_MouseEnter);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonClose_MouseLeave);
            // 
            // pictureBoxMainLogo
            // 
            this.pictureBoxMainLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxMainLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMainLogo.ErrorImage")));
            this.pictureBoxMainLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMainLogo.Image")));
            this.pictureBoxMainLogo.Location = new System.Drawing.Point(167, 106);
            this.pictureBoxMainLogo.Name = "pictureBoxMainLogo";
            this.pictureBoxMainLogo.Size = new System.Drawing.Size(360, 210);
            this.pictureBoxMainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMainLogo.TabIndex = 0;
            this.pictureBoxMainLogo.TabStop = false;
            this.pictureBoxMainLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxMainLogo_Paint);
            // 
            // Ekspedisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Ekspedisi";
            this.panelSideMenu.ResumeLayout(false);
            this.panelKirimSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSideLogo)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonLacak;
        private System.Windows.Forms.Panel panelKirimSubMenu;
        private System.Windows.Forms.Button buttonBarang;
        private System.Windows.Forms.Button buttonPenerima;
        private System.Windows.Forms.Button buttonKirim;
        private System.Windows.Forms.PictureBox pictureBoxMainLogo;
        private System.Windows.Forms.PictureBox pictureBoxSideLogo;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonOngkir;
        private System.Windows.Forms.Label labelTitle;
        public System.Windows.Forms.Button buttonPengirim;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button buttonClose;
    }
}