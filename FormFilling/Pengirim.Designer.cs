namespace FormFilling
{
    partial class Pengirim
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
            this.namaPengirim = new System.Windows.Forms.TextBox();
            this.labelNamaPengirim = new System.Windows.Forms.Label();
            this.teleponPengirim = new System.Windows.Forms.TextBox();
            this.labelTeleponPengirim = new System.Windows.Forms.Label();
            this.label62Pengirim = new System.Windows.Forms.Label();
            this.labelAsalPengirim = new System.Windows.Forms.Label();
            this.provinsiPengirim = new System.Windows.Forms.ComboBox();
            this.alamatPengirim = new System.Windows.Forms.TextBox();
            this.labelAlamatPengirim = new System.Windows.Forms.Label();
            this.labelKodePosPengirim = new System.Windows.Forms.Label();
            this.kodePosPengirim = new System.Windows.Forms.TextBox();
            this.buttonPengirim = new System.Windows.Forms.Button();
            this.kotaPengirim = new System.Windows.Forms.ComboBox();
            this.buttonResetPengirim = new System.Windows.Forms.Button();
            this.labelTeleponPengirimNotif = new System.Windows.Forms.Label();
            this.labelKodePosPengirimNotif = new System.Windows.Forms.Label();
            this.labelNotifPengirim = new System.Windows.Forms.Label();
            this.panelSimpanPengirim = new System.Windows.Forms.Panel();
            this.labelSimpanPengirim = new System.Windows.Forms.Label();
            this.pictureBoxSimpanPengirim = new System.Windows.Forms.PictureBox();
            this.panelSimpanPengirim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSimpanPengirim)).BeginInit();
            this.SuspendLayout();
            // 
            // namaPengirim
            // 
            this.namaPengirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.namaPengirim.Font = new System.Drawing.Font("Montserrat", 10F);
            this.namaPengirim.Location = new System.Drawing.Point(157, 99);
            this.namaPengirim.Name = "namaPengirim";
            this.namaPengirim.Size = new System.Drawing.Size(359, 24);
            this.namaPengirim.TabIndex = 0;
            // 
            // labelNamaPengirim
            // 
            this.labelNamaPengirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNamaPengirim.AutoSize = true;
            this.labelNamaPengirim.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelNamaPengirim.ForeColor = System.Drawing.Color.LightGray;
            this.labelNamaPengirim.Location = new System.Drawing.Point(153, 77);
            this.labelNamaPengirim.Name = "labelNamaPengirim";
            this.labelNamaPengirim.Size = new System.Drawing.Size(51, 19);
            this.labelNamaPengirim.TabIndex = 1;
            this.labelNamaPengirim.Text = "Nama";
            // 
            // teleponPengirim
            // 
            this.teleponPengirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.teleponPengirim.Font = new System.Drawing.Font("Montserrat", 10F);
            this.teleponPengirim.Location = new System.Drawing.Point(198, 163);
            this.teleponPengirim.MaxLength = 12;
            this.teleponPengirim.Name = "teleponPengirim";
            this.teleponPengirim.Size = new System.Drawing.Size(202, 24);
            this.teleponPengirim.TabIndex = 1;
            this.teleponPengirim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.angkaPengirim_KeyPress);
            // 
            // labelTeleponPengirim
            // 
            this.labelTeleponPengirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTeleponPengirim.AutoSize = true;
            this.labelTeleponPengirim.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelTeleponPengirim.ForeColor = System.Drawing.Color.LightGray;
            this.labelTeleponPengirim.Location = new System.Drawing.Point(154, 141);
            this.labelTeleponPengirim.Name = "labelTeleponPengirim";
            this.labelTeleponPengirim.Size = new System.Drawing.Size(63, 19);
            this.labelTeleponPengirim.TabIndex = 1;
            this.labelTeleponPengirim.Text = "Telepon";
            // 
            // label62Pengirim
            // 
            this.label62Pengirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label62Pengirim.AutoSize = true;
            this.label62Pengirim.Font = new System.Drawing.Font("Montserrat", 10F);
            this.label62Pengirim.ForeColor = System.Drawing.Color.LightGray;
            this.label62Pengirim.Location = new System.Drawing.Point(158, 166);
            this.label62Pengirim.Name = "label62Pengirim";
            this.label62Pengirim.Size = new System.Drawing.Size(34, 19);
            this.label62Pengirim.TabIndex = 3;
            this.label62Pengirim.Text = "+62";
            // 
            // labelAsalPengirim
            // 
            this.labelAsalPengirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAsalPengirim.AutoSize = true;
            this.labelAsalPengirim.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelAsalPengirim.ForeColor = System.Drawing.Color.LightGray;
            this.labelAsalPengirim.Location = new System.Drawing.Point(154, 206);
            this.labelAsalPengirim.Name = "labelAsalPengirim";
            this.labelAsalPengirim.Size = new System.Drawing.Size(38, 19);
            this.labelAsalPengirim.TabIndex = 1;
            this.labelAsalPengirim.Text = "Asal";
            // 
            // provinsiPengirim
            // 
            this.provinsiPengirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.provinsiPengirim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provinsiPengirim.Font = new System.Drawing.Font("Montserrat", 10F);
            this.provinsiPengirim.FormattingEnabled = true;
            this.provinsiPengirim.Items.AddRange(new object[] {
            "Bali",
            "Bangka Belitung",
            "Banten",
            "Bengkulu",
            "DI Yogyakarta",
            "DKI Jakarta",
            "Gorontalo",
            "Jambi",
            "Jawa Barat",
            "Jawa Tengah",
            "Jawa Timur",
            "Kalimantan Barat",
            "Kalimantan Selatan",
            "Kalimantan Tengah",
            "Kalimantan Timur",
            "Kalimantan Utara",
            "Kepulauan Riau",
            "Lampung",
            "Maluku",
            "Maluku Utara",
            "Nanggroe Aceh Darussalam (NAD)",
            "Nusa Tenggara Barat (NTB)",
            "Nusa Tenggara Timur (NTT)",
            "Papua",
            "Papua Barat",
            "Riau",
            "Sulawesi Barat",
            "Sulawesi Selatan",
            "Sulawesi Tengah",
            "Sulawesi Tenggara",
            "Sulawesi Utara",
            "Sumatera Barat",
            "Sumatera Selatan",
            "Sumatera Utara"});
            this.provinsiPengirim.Location = new System.Drawing.Point(157, 228);
            this.provinsiPengirim.Name = "provinsiPengirim";
            this.provinsiPengirim.Size = new System.Drawing.Size(243, 26);
            this.provinsiPengirim.TabIndex = 2;
            this.provinsiPengirim.SelectedIndexChanged += new System.EventHandler(this.provinsiPengirim_SelectedIndexChanged);
            // 
            // alamatPengirim
            // 
            this.alamatPengirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alamatPengirim.Font = new System.Drawing.Font("Montserrat", 10F);
            this.alamatPengirim.Location = new System.Drawing.Point(157, 324);
            this.alamatPengirim.Multiline = true;
            this.alamatPengirim.Name = "alamatPengirim";
            this.alamatPengirim.Size = new System.Drawing.Size(359, 70);
            this.alamatPengirim.TabIndex = 4;
            // 
            // labelAlamatPengirim
            // 
            this.labelAlamatPengirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAlamatPengirim.AutoSize = true;
            this.labelAlamatPengirim.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelAlamatPengirim.ForeColor = System.Drawing.Color.LightGray;
            this.labelAlamatPengirim.Location = new System.Drawing.Point(154, 302);
            this.labelAlamatPengirim.Name = "labelAlamatPengirim";
            this.labelAlamatPengirim.Size = new System.Drawing.Size(60, 19);
            this.labelAlamatPengirim.TabIndex = 1;
            this.labelAlamatPengirim.Text = "Alamat";
            // 
            // labelKodePosPengirim
            // 
            this.labelKodePosPengirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKodePosPengirim.AutoSize = true;
            this.labelKodePosPengirim.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelKodePosPengirim.ForeColor = System.Drawing.Color.LightGray;
            this.labelKodePosPengirim.Location = new System.Drawing.Point(153, 409);
            this.labelKodePosPengirim.Name = "labelKodePosPengirim";
            this.labelKodePosPengirim.Size = new System.Drawing.Size(75, 19);
            this.labelKodePosPengirim.TabIndex = 1;
            this.labelKodePosPengirim.Text = "Kode Pos";
            // 
            // kodePosPengirim
            // 
            this.kodePosPengirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kodePosPengirim.Font = new System.Drawing.Font("Montserrat", 10F);
            this.kodePosPengirim.Location = new System.Drawing.Point(157, 431);
            this.kodePosPengirim.MaxLength = 5;
            this.kodePosPengirim.Name = "kodePosPengirim";
            this.kodePosPengirim.Size = new System.Drawing.Size(136, 24);
            this.kodePosPengirim.TabIndex = 5;
            this.kodePosPengirim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.angkaPengirim_KeyPress);
            // 
            // buttonPengirim
            // 
            this.buttonPengirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPengirim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.buttonPengirim.FlatAppearance.BorderSize = 0;
            this.buttonPengirim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPengirim.Font = new System.Drawing.Font("Montserrat", 10F);
            this.buttonPengirim.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonPengirim.Location = new System.Drawing.Point(416, 485);
            this.buttonPengirim.Name = "buttonPengirim";
            this.buttonPengirim.Size = new System.Drawing.Size(100, 30);
            this.buttonPengirim.TabIndex = 6;
            this.buttonPengirim.Text = "Selesai";
            this.buttonPengirim.UseVisualStyleBackColor = false;
            this.buttonPengirim.Click += new System.EventHandler(this.buttonPengirim_Click);
            // 
            // kotaPengirim
            // 
            this.kotaPengirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kotaPengirim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kotaPengirim.Font = new System.Drawing.Font("Montserrat", 10F);
            this.kotaPengirim.FormattingEnabled = true;
            this.kotaPengirim.Location = new System.Drawing.Point(157, 260);
            this.kotaPengirim.Name = "kotaPengirim";
            this.kotaPengirim.Size = new System.Drawing.Size(243, 26);
            this.kotaPengirim.TabIndex = 3;
            this.kotaPengirim.Visible = false;
            // 
            // buttonResetPengirim
            // 
            this.buttonResetPengirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonResetPengirim.BackColor = System.Drawing.Color.Transparent;
            this.buttonResetPengirim.FlatAppearance.BorderSize = 0;
            this.buttonResetPengirim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetPengirim.Font = new System.Drawing.Font("Montserrat", 10F);
            this.buttonResetPengirim.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonResetPengirim.Location = new System.Drawing.Point(300, 485);
            this.buttonResetPengirim.Name = "buttonResetPengirim";
            this.buttonResetPengirim.Size = new System.Drawing.Size(100, 30);
            this.buttonResetPengirim.TabIndex = 7;
            this.buttonResetPengirim.Text = "Reset";
            this.buttonResetPengirim.UseVisualStyleBackColor = false;
            this.buttonResetPengirim.Click += new System.EventHandler(this.buttonResetPengirim_Click);
            this.buttonResetPengirim.MouseEnter += new System.EventHandler(this.buttonResetPengirim_MouseEnter);
            this.buttonResetPengirim.MouseLeave += new System.EventHandler(this.buttonResetPengirim_MouseLeave);
            // 
            // labelTeleponPengirimNotif
            // 
            this.labelTeleponPengirimNotif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTeleponPengirimNotif.AutoSize = true;
            this.labelTeleponPengirimNotif.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeleponPengirimNotif.ForeColor = System.Drawing.Color.LightGray;
            this.labelTeleponPengirimNotif.Location = new System.Drawing.Point(406, 168);
            this.labelTeleponPengirimNotif.Name = "labelTeleponPengirimNotif";
            this.labelTeleponPengirimNotif.Size = new System.Drawing.Size(214, 15);
            this.labelTeleponPengirimNotif.TabIndex = 1;
            this.labelTeleponPengirimNotif.Text = "Masukkan nomor telepon yang benar";
            this.labelTeleponPengirimNotif.Visible = false;
            // 
            // labelKodePosPengirimNotif
            // 
            this.labelKodePosPengirimNotif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKodePosPengirimNotif.AutoSize = true;
            this.labelKodePosPengirimNotif.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKodePosPengirimNotif.ForeColor = System.Drawing.Color.LightGray;
            this.labelKodePosPengirimNotif.Location = new System.Drawing.Point(299, 436);
            this.labelKodePosPengirimNotif.Name = "labelKodePosPengirimNotif";
            this.labelKodePosPengirimNotif.Size = new System.Drawing.Size(181, 15);
            this.labelKodePosPengirimNotif.TabIndex = 1;
            this.labelKodePosPengirimNotif.Text = "Masukkan kode pos yang benar";
            this.labelKodePosPengirimNotif.Visible = false;
            // 
            // labelNotifPengirim
            // 
            this.labelNotifPengirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNotifPengirim.AutoSize = true;
            this.labelNotifPengirim.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotifPengirim.ForeColor = System.Drawing.Color.LightGray;
            this.labelNotifPengirim.Location = new System.Drawing.Point(155, 485);
            this.labelNotifPengirim.Name = "labelNotifPengirim";
            this.labelNotifPengirim.Size = new System.Drawing.Size(115, 15);
            this.labelNotifPengirim.TabIndex = 1;
            this.labelNotifPengirim.Text = "Data harus lengkap";
            this.labelNotifPengirim.Visible = false;
            // 
            // panelSimpanPengirim
            // 
            this.panelSimpanPengirim.Controls.Add(this.pictureBoxSimpanPengirim);
            this.panelSimpanPengirim.Controls.Add(this.labelSimpanPengirim);
            this.panelSimpanPengirim.Location = new System.Drawing.Point(536, 385);
            this.panelSimpanPengirim.Name = "panelSimpanPengirim";
            this.panelSimpanPengirim.Size = new System.Drawing.Size(200, 100);
            this.panelSimpanPengirim.TabIndex = 8;
            this.panelSimpanPengirim.Visible = false;
            // 
            // labelSimpanPengirim
            // 
            this.labelSimpanPengirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSimpanPengirim.AutoSize = true;
            this.labelSimpanPengirim.Font = new System.Drawing.Font("Montserrat", 12F);
            this.labelSimpanPengirim.ForeColor = System.Drawing.Color.LightGray;
            this.labelSimpanPengirim.Location = new System.Drawing.Point(56, 24);
            this.labelSimpanPengirim.Name = "labelSimpanPengirim";
            this.labelSimpanPengirim.Size = new System.Drawing.Size(181, 22);
            this.labelSimpanPengirim.TabIndex = 1;
            this.labelSimpanPengirim.Text = "Data Telah Tersimpan";
            this.labelSimpanPengirim.Paint += new System.Windows.Forms.PaintEventHandler(this.labelSimpanPengirim_Paint);
            // 
            // pictureBoxSimpanPengirim
            // 
            this.pictureBoxSimpanPengirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxSimpanPengirim.Image = global::FormFilling.Properties.Resources.icons8_tick_box_480;
            this.pictureBoxSimpanPengirim.Location = new System.Drawing.Point(86, 47);
            this.pictureBoxSimpanPengirim.Name = "pictureBoxSimpanPengirim";
            this.pictureBoxSimpanPengirim.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxSimpanPengirim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSimpanPengirim.TabIndex = 2;
            this.pictureBoxSimpanPengirim.TabStop = false;
            this.pictureBoxSimpanPengirim.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxSimpanPengirim_Paint);
            // 
            // Pengirim
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.panelSimpanPengirim);
            this.Controls.Add(this.buttonResetPengirim);
            this.Controls.Add(this.buttonPengirim);
            this.Controls.Add(this.kotaPengirim);
            this.Controls.Add(this.provinsiPengirim);
            this.Controls.Add(this.label62Pengirim);
            this.Controls.Add(this.kodePosPengirim);
            this.Controls.Add(this.teleponPengirim);
            this.Controls.Add(this.labelAsalPengirim);
            this.Controls.Add(this.labelKodePosPengirim);
            this.Controls.Add(this.labelNotifPengirim);
            this.Controls.Add(this.labelKodePosPengirimNotif);
            this.Controls.Add(this.labelTeleponPengirimNotif);
            this.Controls.Add(this.labelTeleponPengirim);
            this.Controls.Add(this.labelAlamatPengirim);
            this.Controls.Add(this.alamatPengirim);
            this.Controls.Add(this.labelNamaPengirim);
            this.Controls.Add(this.namaPengirim);
            this.Name = "Pengirim";
            this.Text = "Pengirim";
            this.panelSimpanPengirim.ResumeLayout(false);
            this.panelSimpanPengirim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSimpanPengirim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namaPengirim;
        private System.Windows.Forms.Label labelNamaPengirim;
        private System.Windows.Forms.TextBox teleponPengirim;
        private System.Windows.Forms.Label labelTeleponPengirim;
        private System.Windows.Forms.Label label62Pengirim;
        private System.Windows.Forms.Label labelAsalPengirim;
        private System.Windows.Forms.ComboBox provinsiPengirim;
        private System.Windows.Forms.TextBox alamatPengirim;
        private System.Windows.Forms.Label labelAlamatPengirim;
        private System.Windows.Forms.Label labelKodePosPengirim;
        private System.Windows.Forms.TextBox kodePosPengirim;
        private System.Windows.Forms.Button buttonPengirim;
        private System.Windows.Forms.ComboBox kotaPengirim;
        private System.Windows.Forms.Button buttonResetPengirim;
        private System.Windows.Forms.Label labelTeleponPengirimNotif;
        private System.Windows.Forms.Label labelKodePosPengirimNotif;
        private System.Windows.Forms.Label labelNotifPengirim;
        private System.Windows.Forms.Panel panelSimpanPengirim;
        private System.Windows.Forms.Label labelSimpanPengirim;
        private System.Windows.Forms.PictureBox pictureBoxSimpanPengirim;
    }
}

