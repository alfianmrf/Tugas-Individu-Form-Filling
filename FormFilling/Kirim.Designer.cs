namespace FormFilling
{
    partial class Kirim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kirim));
            this.labelPengirim = new System.Windows.Forms.Label();
            this.labelPenerima = new System.Windows.Forms.Label();
            this.labelBarang = new System.Windows.Forms.Label();
            this.panelPengirim = new System.Windows.Forms.Panel();
            this.labelPengirimKosong = new System.Windows.Forms.Label();
            this.labelPengirimKodePos = new System.Windows.Forms.Label();
            this.labelPengirimAlamat = new System.Windows.Forms.Label();
            this.labelPengirimAsal = new System.Windows.Forms.Label();
            this.labelPengirimTelepon = new System.Windows.Forms.Label();
            this.labelPengirimNama = new System.Windows.Forms.Label();
            this.panelPengirimTop = new System.Windows.Forms.Panel();
            this.panelPenerima = new System.Windows.Forms.Panel();
            this.labelPenerimaKosong = new System.Windows.Forms.Label();
            this.panelPenerimaTop = new System.Windows.Forms.Panel();
            this.labelPenerimaKodePos = new System.Windows.Forms.Label();
            this.labelPenerimaTelepon = new System.Windows.Forms.Label();
            this.labelPenerimaAlamat = new System.Windows.Forms.Label();
            this.labelPenerimaNama = new System.Windows.Forms.Label();
            this.labelPenerimaTujuan = new System.Windows.Forms.Label();
            this.panelBarangTop = new System.Windows.Forms.Panel();
            this.panelBarang = new System.Windows.Forms.Panel();
            this.panelKirimResi = new System.Windows.Forms.Panel();
            this.panelResiTotal = new System.Windows.Forms.Panel();
            this.labelResiBiayaTotal = new System.Windows.Forms.Label();
            this.labelResiTotal = new System.Windows.Forms.Label();
            this.panelResiBiaya = new System.Windows.Forms.Panel();
            this.labelResiAsuransi = new System.Windows.Forms.Label();
            this.labelResiBiaya = new System.Windows.Forms.Label();
            this.panelResiLayanan = new System.Windows.Forms.Panel();
            this.labelResiLayanan = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelResiBerat = new System.Windows.Forms.Panel();
            this.labelResiBerat = new System.Windows.Forms.Label();
            this.pictureBoxQRCode = new System.Windows.Forms.PictureBox();
            this.panelResiPenerima = new System.Windows.Forms.Panel();
            this.labelResiKotaPenerima = new System.Windows.Forms.Label();
            this.labelResiAlamatPenerima = new System.Windows.Forms.Label();
            this.labelResiPenerima = new System.Windows.Forms.Label();
            this.panelResiPengirim = new System.Windows.Forms.Panel();
            this.labelResiKotaPengirim = new System.Windows.Forms.Label();
            this.labelResiAlamatPengirim = new System.Windows.Forms.Label();
            this.labelResiPengirim = new System.Windows.Forms.Label();
            this.pictureBoxBarCode = new System.Windows.Forms.PictureBox();
            this.pictureBoxResiLogo = new System.Windows.Forms.PictureBox();
            this.labelResi = new System.Windows.Forms.Label();
            this.labelBarangJumlah = new System.Windows.Forms.Label();
            this.labelBarangLayanan = new System.Windows.Forms.Label();
            this.labelBarangNama = new System.Windows.Forms.Label();
            this.labelBarangKosong = new System.Windows.Forms.Label();
            this.labelBarangAsuransi = new System.Windows.Forms.Label();
            this.labelBarangBerat = new System.Windows.Forms.Label();
            this.buttonKirimResi = new System.Windows.Forms.Button();
            this.labelLengkap = new System.Windows.Forms.Label();
            this.panelPengirim.SuspendLayout();
            this.panelPengirimTop.SuspendLayout();
            this.panelPenerima.SuspendLayout();
            this.panelPenerimaTop.SuspendLayout();
            this.panelBarangTop.SuspendLayout();
            this.panelBarang.SuspendLayout();
            this.panelKirimResi.SuspendLayout();
            this.panelResiTotal.SuspendLayout();
            this.panelResiBiaya.SuspendLayout();
            this.panelResiLayanan.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelResiBerat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).BeginInit();
            this.panelResiPenerima.SuspendLayout();
            this.panelResiPengirim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResiLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPengirim
            // 
            this.labelPengirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPengirim.AutoSize = true;
            this.labelPengirim.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelPengirim.ForeColor = System.Drawing.Color.LightGray;
            this.labelPengirim.Location = new System.Drawing.Point(45, 12);
            this.labelPengirim.Name = "labelPengirim";
            this.labelPengirim.Size = new System.Drawing.Size(75, 19);
            this.labelPengirim.TabIndex = 0;
            this.labelPengirim.Text = "Pengirim";
            this.labelPengirim.Paint += new System.Windows.Forms.PaintEventHandler(this.labelPengirim_Paint);
            // 
            // labelPenerima
            // 
            this.labelPenerima.AutoSize = true;
            this.labelPenerima.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelPenerima.ForeColor = System.Drawing.Color.LightGray;
            this.labelPenerima.Location = new System.Drawing.Point(45, 12);
            this.labelPenerima.Name = "labelPenerima";
            this.labelPenerima.Size = new System.Drawing.Size(77, 19);
            this.labelPenerima.TabIndex = 0;
            this.labelPenerima.Text = "Penerima";
            this.labelPenerima.Paint += new System.Windows.Forms.PaintEventHandler(this.labelPenerima_Paint);
            // 
            // labelBarang
            // 
            this.labelBarang.AutoSize = true;
            this.labelBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelBarang.ForeColor = System.Drawing.Color.LightGray;
            this.labelBarang.Location = new System.Drawing.Point(57, 12);
            this.labelBarang.Name = "labelBarang";
            this.labelBarang.Size = new System.Drawing.Size(61, 19);
            this.labelBarang.TabIndex = 0;
            this.labelBarang.Text = "Barang";
            this.labelBarang.Paint += new System.Windows.Forms.PaintEventHandler(this.labelBarang_Paint);
            // 
            // panelPengirim
            // 
            this.panelPengirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelPengirim.BackColor = System.Drawing.SystemColors.Window;
            this.panelPengirim.Controls.Add(this.labelPengirimKosong);
            this.panelPengirim.Controls.Add(this.labelPengirimKodePos);
            this.panelPengirim.Controls.Add(this.labelPengirimAlamat);
            this.panelPengirim.Controls.Add(this.labelPengirimAsal);
            this.panelPengirim.Controls.Add(this.labelPengirimTelepon);
            this.panelPengirim.Controls.Add(this.labelPengirimNama);
            this.panelPengirim.Controls.Add(this.panelPengirimTop);
            this.panelPengirim.Location = new System.Drawing.Point(38, 81);
            this.panelPengirim.Name = "panelPengirim";
            this.panelPengirim.Size = new System.Drawing.Size(175, 300);
            this.panelPengirim.TabIndex = 1;
            // 
            // labelPengirimKosong
            // 
            this.labelPengirimKosong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPengirimKosong.AutoSize = true;
            this.labelPengirimKosong.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelPengirimKosong.Location = new System.Drawing.Point(53, 212);
            this.labelPengirimKosong.Name = "labelPengirimKosong";
            this.labelPengirimKosong.Size = new System.Drawing.Size(110, 19);
            this.labelPengirimKosong.TabIndex = 2;
            this.labelPengirimKosong.Text = "Tidak ada data";
            this.labelPengirimKosong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPengirimKosong.Paint += new System.Windows.Forms.PaintEventHandler(this.labelKosong_Paint);
            // 
            // labelPengirimKodePos
            // 
            this.labelPengirimKodePos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPengirimKodePos.AutoSize = true;
            this.labelPengirimKodePos.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelPengirimKodePos.Location = new System.Drawing.Point(53, 183);
            this.labelPengirimKodePos.Name = "labelPengirimKodePos";
            this.labelPengirimKodePos.Size = new System.Drawing.Size(75, 19);
            this.labelPengirimKodePos.TabIndex = 2;
            this.labelPengirimKodePos.Text = "Kode Pos";
            this.labelPengirimKodePos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPengirimKodePos.Paint += new System.Windows.Forms.PaintEventHandler(this.labelPengirimKodePos_Paint);
            // 
            // labelPengirimAlamat
            // 
            this.labelPengirimAlamat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPengirimAlamat.AutoEllipsis = true;
            this.labelPengirimAlamat.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelPengirimAlamat.Location = new System.Drawing.Point(15, 154);
            this.labelPengirimAlamat.MinimumSize = new System.Drawing.Size(0, 20);
            this.labelPengirimAlamat.Name = "labelPengirimAlamat";
            this.labelPengirimAlamat.Size = new System.Drawing.Size(150, 20);
            this.labelPengirimAlamat.TabIndex = 2;
            this.labelPengirimAlamat.Text = "Alamat";
            this.labelPengirimAlamat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPengirimAlamat.Paint += new System.Windows.Forms.PaintEventHandler(this.labelPengirimAlamat_Paint);
            // 
            // labelPengirimAsal
            // 
            this.labelPengirimAsal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPengirimAsal.AutoEllipsis = true;
            this.labelPengirimAsal.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelPengirimAsal.Location = new System.Drawing.Point(15, 125);
            this.labelPengirimAsal.MinimumSize = new System.Drawing.Size(0, 20);
            this.labelPengirimAsal.Name = "labelPengirimAsal";
            this.labelPengirimAsal.Size = new System.Drawing.Size(150, 20);
            this.labelPengirimAsal.TabIndex = 2;
            this.labelPengirimAsal.Text = "Asal";
            this.labelPengirimAsal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPengirimAsal.Paint += new System.Windows.Forms.PaintEventHandler(this.labelPengirimAsal_Paint);
            // 
            // labelPengirimTelepon
            // 
            this.labelPengirimTelepon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPengirimTelepon.AutoSize = true;
            this.labelPengirimTelepon.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelPengirimTelepon.Location = new System.Drawing.Point(57, 95);
            this.labelPengirimTelepon.Name = "labelPengirimTelepon";
            this.labelPengirimTelepon.Size = new System.Drawing.Size(63, 19);
            this.labelPengirimTelepon.TabIndex = 2;
            this.labelPengirimTelepon.Text = "Telepon";
            this.labelPengirimTelepon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPengirimTelepon.Paint += new System.Windows.Forms.PaintEventHandler(this.labelPengirimTelepon_Paint);
            // 
            // labelPengirimNama
            // 
            this.labelPengirimNama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPengirimNama.AutoEllipsis = true;
            this.labelPengirimNama.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelPengirimNama.Location = new System.Drawing.Point(15, 62);
            this.labelPengirimNama.MinimumSize = new System.Drawing.Size(0, 20);
            this.labelPengirimNama.Name = "labelPengirimNama";
            this.labelPengirimNama.Size = new System.Drawing.Size(150, 20);
            this.labelPengirimNama.TabIndex = 2;
            this.labelPengirimNama.Text = "Nama";
            this.labelPengirimNama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPengirimNama.Paint += new System.Windows.Forms.PaintEventHandler(this.labelPengirimNama_Paint);
            // 
            // panelPengirimTop
            // 
            this.panelPengirimTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.panelPengirimTop.Controls.Add(this.labelPengirim);
            this.panelPengirimTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPengirimTop.Location = new System.Drawing.Point(0, 0);
            this.panelPengirimTop.Name = "panelPengirimTop";
            this.panelPengirimTop.Size = new System.Drawing.Size(175, 40);
            this.panelPengirimTop.TabIndex = 1;
            // 
            // panelPenerima
            // 
            this.panelPenerima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelPenerima.BackColor = System.Drawing.SystemColors.Window;
            this.panelPenerima.Controls.Add(this.labelPenerimaKosong);
            this.panelPenerima.Controls.Add(this.panelPenerimaTop);
            this.panelPenerima.Controls.Add(this.labelPenerimaKodePos);
            this.panelPenerima.Controls.Add(this.labelPenerimaTelepon);
            this.panelPenerima.Controls.Add(this.labelPenerimaAlamat);
            this.panelPenerima.Controls.Add(this.labelPenerimaNama);
            this.panelPenerima.Controls.Add(this.labelPenerimaTujuan);
            this.panelPenerima.Location = new System.Drawing.Point(255, 81);
            this.panelPenerima.Name = "panelPenerima";
            this.panelPenerima.Size = new System.Drawing.Size(175, 300);
            this.panelPenerima.TabIndex = 2;
            // 
            // labelPenerimaKosong
            // 
            this.labelPenerimaKosong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPenerimaKosong.AutoSize = true;
            this.labelPenerimaKosong.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelPenerimaKosong.Location = new System.Drawing.Point(55, 212);
            this.labelPenerimaKosong.Name = "labelPenerimaKosong";
            this.labelPenerimaKosong.Size = new System.Drawing.Size(110, 19);
            this.labelPenerimaKosong.TabIndex = 2;
            this.labelPenerimaKosong.Text = "Tidak ada data";
            this.labelPenerimaKosong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPenerimaKosong.Paint += new System.Windows.Forms.PaintEventHandler(this.labelPenerimaKosong_Paint);
            // 
            // panelPenerimaTop
            // 
            this.panelPenerimaTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.panelPenerimaTop.Controls.Add(this.labelPenerima);
            this.panelPenerimaTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPenerimaTop.Location = new System.Drawing.Point(0, 0);
            this.panelPenerimaTop.Name = "panelPenerimaTop";
            this.panelPenerimaTop.Size = new System.Drawing.Size(175, 40);
            this.panelPenerimaTop.TabIndex = 1;
            // 
            // labelPenerimaKodePos
            // 
            this.labelPenerimaKodePos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPenerimaKodePos.AutoSize = true;
            this.labelPenerimaKodePos.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelPenerimaKodePos.Location = new System.Drawing.Point(55, 183);
            this.labelPenerimaKodePos.Name = "labelPenerimaKodePos";
            this.labelPenerimaKodePos.Size = new System.Drawing.Size(75, 19);
            this.labelPenerimaKodePos.TabIndex = 2;
            this.labelPenerimaKodePos.Text = "Kode Pos";
            this.labelPenerimaKodePos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPenerimaKodePos.Paint += new System.Windows.Forms.PaintEventHandler(this.labelPenerimaKodePos_Paint);
            // 
            // labelPenerimaTelepon
            // 
            this.labelPenerimaTelepon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPenerimaTelepon.AutoSize = true;
            this.labelPenerimaTelepon.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelPenerimaTelepon.Location = new System.Drawing.Point(59, 95);
            this.labelPenerimaTelepon.Name = "labelPenerimaTelepon";
            this.labelPenerimaTelepon.Size = new System.Drawing.Size(63, 19);
            this.labelPenerimaTelepon.TabIndex = 2;
            this.labelPenerimaTelepon.Text = "Telepon";
            this.labelPenerimaTelepon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPenerimaTelepon.Paint += new System.Windows.Forms.PaintEventHandler(this.labelPenerimaTelepon_Paint);
            // 
            // labelPenerimaAlamat
            // 
            this.labelPenerimaAlamat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPenerimaAlamat.AutoEllipsis = true;
            this.labelPenerimaAlamat.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelPenerimaAlamat.Location = new System.Drawing.Point(17, 154);
            this.labelPenerimaAlamat.MinimumSize = new System.Drawing.Size(0, 20);
            this.labelPenerimaAlamat.Name = "labelPenerimaAlamat";
            this.labelPenerimaAlamat.Size = new System.Drawing.Size(150, 20);
            this.labelPenerimaAlamat.TabIndex = 2;
            this.labelPenerimaAlamat.Text = "Alamat";
            this.labelPenerimaAlamat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPenerimaAlamat.Paint += new System.Windows.Forms.PaintEventHandler(this.labelPenerimaAlamat_Paint);
            // 
            // labelPenerimaNama
            // 
            this.labelPenerimaNama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPenerimaNama.AutoEllipsis = true;
            this.labelPenerimaNama.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelPenerimaNama.Location = new System.Drawing.Point(17, 62);
            this.labelPenerimaNama.MinimumSize = new System.Drawing.Size(0, 20);
            this.labelPenerimaNama.Name = "labelPenerimaNama";
            this.labelPenerimaNama.Size = new System.Drawing.Size(150, 20);
            this.labelPenerimaNama.TabIndex = 2;
            this.labelPenerimaNama.Text = "Nama";
            this.labelPenerimaNama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPenerimaNama.Paint += new System.Windows.Forms.PaintEventHandler(this.labelPenerimaNama_Paint);
            // 
            // labelPenerimaTujuan
            // 
            this.labelPenerimaTujuan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPenerimaTujuan.AutoEllipsis = true;
            this.labelPenerimaTujuan.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelPenerimaTujuan.Location = new System.Drawing.Point(17, 125);
            this.labelPenerimaTujuan.MinimumSize = new System.Drawing.Size(0, 20);
            this.labelPenerimaTujuan.Name = "labelPenerimaTujuan";
            this.labelPenerimaTujuan.Size = new System.Drawing.Size(150, 20);
            this.labelPenerimaTujuan.TabIndex = 2;
            this.labelPenerimaTujuan.Text = "Tujuan";
            this.labelPenerimaTujuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPenerimaTujuan.Paint += new System.Windows.Forms.PaintEventHandler(this.labelPenerimaAsal_Paint);
            // 
            // panelBarangTop
            // 
            this.panelBarangTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.panelBarangTop.Controls.Add(this.labelBarang);
            this.panelBarangTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarangTop.Location = new System.Drawing.Point(0, 0);
            this.panelBarangTop.Name = "panelBarangTop";
            this.panelBarangTop.Size = new System.Drawing.Size(175, 40);
            this.panelBarangTop.TabIndex = 1;
            // 
            // panelBarang
            // 
            this.panelBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBarang.BackColor = System.Drawing.SystemColors.Window;
            this.panelBarang.Controls.Add(this.labelBarangJumlah);
            this.panelBarang.Controls.Add(this.labelBarangLayanan);
            this.panelBarang.Controls.Add(this.labelBarangNama);
            this.panelBarang.Controls.Add(this.labelBarangKosong);
            this.panelBarang.Controls.Add(this.panelBarangTop);
            this.panelBarang.Controls.Add(this.labelBarangAsuransi);
            this.panelBarang.Controls.Add(this.labelBarangBerat);
            this.panelBarang.Location = new System.Drawing.Point(469, 81);
            this.panelBarang.Name = "panelBarang";
            this.panelBarang.Size = new System.Drawing.Size(175, 300);
            this.panelBarang.TabIndex = 3;
            // 
            // panelKirimResi
            // 
            this.panelKirimResi.Controls.Add(this.panelResiTotal);
            this.panelKirimResi.Controls.Add(this.panelResiBiaya);
            this.panelKirimResi.Controls.Add(this.panelResiLayanan);
            this.panelKirimResi.Controls.Add(this.panel1);
            this.panelKirimResi.Controls.Add(this.pictureBoxQRCode);
            this.panelKirimResi.Controls.Add(this.panelResiPenerima);
            this.panelKirimResi.Controls.Add(this.panelResiPengirim);
            this.panelKirimResi.Controls.Add(this.pictureBoxBarCode);
            this.panelKirimResi.Controls.Add(this.pictureBoxResiLogo);
            this.panelKirimResi.Controls.Add(this.labelResi);
            this.panelKirimResi.Location = new System.Drawing.Point(469, 429);
            this.panelKirimResi.Name = "panelKirimResi";
            this.panelKirimResi.Size = new System.Drawing.Size(684, 560);
            this.panelKirimResi.TabIndex = 9;
            this.panelKirimResi.Visible = false;
            // 
            // panelResiTotal
            // 
            this.panelResiTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelResiTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResiTotal.Controls.Add(this.labelResiBiayaTotal);
            this.panelResiTotal.Controls.Add(this.labelResiTotal);
            this.panelResiTotal.Location = new System.Drawing.Point(301, 411);
            this.panelResiTotal.Name = "panelResiTotal";
            this.panelResiTotal.Size = new System.Drawing.Size(249, 121);
            this.panelResiTotal.TabIndex = 14;
            // 
            // labelResiBiayaTotal
            // 
            this.labelResiBiayaTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResiBiayaTotal.AutoSize = true;
            this.labelResiBiayaTotal.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResiBiayaTotal.ForeColor = System.Drawing.Color.LightGray;
            this.labelResiBiayaTotal.Location = new System.Drawing.Point(19, 59);
            this.labelResiBiayaTotal.Name = "labelResiBiayaTotal";
            this.labelResiBiayaTotal.Size = new System.Drawing.Size(63, 33);
            this.labelResiBiayaTotal.TabIndex = 10;
            this.labelResiBiayaTotal.Text = "Rp. ";
            this.labelResiBiayaTotal.Paint += new System.Windows.Forms.PaintEventHandler(this.labelResiBiayaTotal_Paint);
            // 
            // labelResiTotal
            // 
            this.labelResiTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResiTotal.AutoSize = true;
            this.labelResiTotal.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResiTotal.ForeColor = System.Drawing.Color.LightGray;
            this.labelResiTotal.Location = new System.Drawing.Point(91, 15);
            this.labelResiTotal.Name = "labelResiTotal";
            this.labelResiTotal.Size = new System.Drawing.Size(71, 26);
            this.labelResiTotal.TabIndex = 9;
            this.labelResiTotal.Text = "Total :";
            this.labelResiTotal.Paint += new System.Windows.Forms.PaintEventHandler(this.labelResiTotal_Paint);
            // 
            // panelResiBiaya
            // 
            this.panelResiBiaya.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelResiBiaya.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResiBiaya.Controls.Add(this.labelResiAsuransi);
            this.panelResiBiaya.Controls.Add(this.labelResiBiaya);
            this.panelResiBiaya.Location = new System.Drawing.Point(12, 452);
            this.panelResiBiaya.Name = "panelResiBiaya";
            this.panelResiBiaya.Size = new System.Drawing.Size(290, 80);
            this.panelResiBiaya.TabIndex = 13;
            // 
            // labelResiAsuransi
            // 
            this.labelResiAsuransi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResiAsuransi.AutoSize = true;
            this.labelResiAsuransi.Font = new System.Drawing.Font("Montserrat", 12F);
            this.labelResiAsuransi.ForeColor = System.Drawing.Color.LightGray;
            this.labelResiAsuransi.Location = new System.Drawing.Point(21, 43);
            this.labelResiAsuransi.Name = "labelResiAsuransi";
            this.labelResiAsuransi.Size = new System.Drawing.Size(89, 22);
            this.labelResiAsuransi.TabIndex = 10;
            this.labelResiAsuransi.Text = "Asuransi : ";
            // 
            // labelResiBiaya
            // 
            this.labelResiBiaya.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResiBiaya.AutoSize = true;
            this.labelResiBiaya.Font = new System.Drawing.Font("Montserrat", 12F);
            this.labelResiBiaya.ForeColor = System.Drawing.Color.LightGray;
            this.labelResiBiaya.Location = new System.Drawing.Point(21, 13);
            this.labelResiBiaya.Name = "labelResiBiaya";
            this.labelResiBiaya.Size = new System.Drawing.Size(64, 22);
            this.labelResiBiaya.TabIndex = 9;
            this.labelResiBiaya.Text = "Biaya : ";
            // 
            // panelResiLayanan
            // 
            this.panelResiLayanan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelResiLayanan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResiLayanan.Controls.Add(this.labelResiLayanan);
            this.panelResiLayanan.Location = new System.Drawing.Point(157, 411);
            this.panelResiLayanan.Name = "panelResiLayanan";
            this.panelResiLayanan.Size = new System.Drawing.Size(145, 42);
            this.panelResiLayanan.TabIndex = 15;
            // 
            // labelResiLayanan
            // 
            this.labelResiLayanan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResiLayanan.AutoSize = true;
            this.labelResiLayanan.Font = new System.Drawing.Font("Montserrat", 12F);
            this.labelResiLayanan.ForeColor = System.Drawing.Color.LightGray;
            this.labelResiLayanan.Location = new System.Drawing.Point(43, 9);
            this.labelResiLayanan.Name = "labelResiLayanan";
            this.labelResiLayanan.Size = new System.Drawing.Size(77, 22);
            this.labelResiLayanan.TabIndex = 9;
            this.labelResiLayanan.Text = "Layanan";
            this.labelResiLayanan.Paint += new System.Windows.Forms.PaintEventHandler(this.labelResiLayanan_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelResiBerat);
            this.panel1.Location = new System.Drawing.Point(12, 411);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 42);
            this.panel1.TabIndex = 13;
            // 
            // panelResiBerat
            // 
            this.panelResiBerat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelResiBerat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResiBerat.Controls.Add(this.labelResiBerat);
            this.panelResiBerat.Location = new System.Drawing.Point(-1, -1);
            this.panelResiBerat.Name = "panelResiBerat";
            this.panelResiBerat.Size = new System.Drawing.Size(145, 42);
            this.panelResiBerat.TabIndex = 14;
            // 
            // labelResiBerat
            // 
            this.labelResiBerat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResiBerat.AutoSize = true;
            this.labelResiBerat.Font = new System.Drawing.Font("Montserrat", 12F);
            this.labelResiBerat.ForeColor = System.Drawing.Color.LightGray;
            this.labelResiBerat.Location = new System.Drawing.Point(43, 9);
            this.labelResiBerat.Name = "labelResiBerat";
            this.labelResiBerat.Size = new System.Drawing.Size(53, 22);
            this.labelResiBerat.TabIndex = 9;
            this.labelResiBerat.Text = "Berat";
            this.labelResiBerat.Paint += new System.Windows.Forms.PaintEventHandler(this.labelResiBerat_Paint);
            // 
            // pictureBoxQRCode
            // 
            this.pictureBoxQRCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxQRCode.Location = new System.Drawing.Point(556, 417);
            this.pictureBoxQRCode.Name = "pictureBoxQRCode";
            this.pictureBoxQRCode.Size = new System.Drawing.Size(115, 115);
            this.pictureBoxQRCode.TabIndex = 13;
            this.pictureBoxQRCode.TabStop = false;
            // 
            // panelResiPenerima
            // 
            this.panelResiPenerima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelResiPenerima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResiPenerima.Controls.Add(this.labelResiKotaPenerima);
            this.panelResiPenerima.Controls.Add(this.labelResiAlamatPenerima);
            this.panelResiPenerima.Controls.Add(this.labelResiPenerima);
            this.panelResiPenerima.Location = new System.Drawing.Point(12, 296);
            this.panelResiPenerima.Name = "panelResiPenerima";
            this.panelResiPenerima.Size = new System.Drawing.Size(659, 116);
            this.panelResiPenerima.TabIndex = 12;
            // 
            // labelResiKotaPenerima
            // 
            this.labelResiKotaPenerima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResiKotaPenerima.AutoSize = true;
            this.labelResiKotaPenerima.Font = new System.Drawing.Font("Montserrat", 12F);
            this.labelResiKotaPenerima.ForeColor = System.Drawing.Color.LightGray;
            this.labelResiKotaPenerima.Location = new System.Drawing.Point(20, 77);
            this.labelResiKotaPenerima.Name = "labelResiKotaPenerima";
            this.labelResiKotaPenerima.Size = new System.Drawing.Size(46, 22);
            this.labelResiKotaPenerima.TabIndex = 11;
            this.labelResiKotaPenerima.Text = "Kota";
            // 
            // labelResiAlamatPenerima
            // 
            this.labelResiAlamatPenerima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResiAlamatPenerima.AutoSize = true;
            this.labelResiAlamatPenerima.Font = new System.Drawing.Font("Montserrat", 12F);
            this.labelResiAlamatPenerima.ForeColor = System.Drawing.Color.LightGray;
            this.labelResiAlamatPenerima.Location = new System.Drawing.Point(20, 47);
            this.labelResiAlamatPenerima.Name = "labelResiAlamatPenerima";
            this.labelResiAlamatPenerima.Size = new System.Drawing.Size(66, 22);
            this.labelResiAlamatPenerima.TabIndex = 10;
            this.labelResiAlamatPenerima.Text = "Alamat";
            // 
            // labelResiPenerima
            // 
            this.labelResiPenerima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResiPenerima.AutoSize = true;
            this.labelResiPenerima.Font = new System.Drawing.Font("Montserrat", 12F);
            this.labelResiPenerima.ForeColor = System.Drawing.Color.LightGray;
            this.labelResiPenerima.Location = new System.Drawing.Point(20, 17);
            this.labelResiPenerima.Name = "labelResiPenerima";
            this.labelResiPenerima.Size = new System.Drawing.Size(99, 22);
            this.labelResiPenerima.TabIndex = 9;
            this.labelResiPenerima.Text = "Penerima : ";
            // 
            // panelResiPengirim
            // 
            this.panelResiPengirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelResiPengirim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResiPengirim.Controls.Add(this.labelResiKotaPengirim);
            this.panelResiPengirim.Controls.Add(this.labelResiAlamatPengirim);
            this.panelResiPengirim.Controls.Add(this.labelResiPengirim);
            this.panelResiPengirim.Location = new System.Drawing.Point(12, 181);
            this.panelResiPengirim.Name = "panelResiPengirim";
            this.panelResiPengirim.Size = new System.Drawing.Size(659, 116);
            this.panelResiPengirim.TabIndex = 8;
            // 
            // labelResiKotaPengirim
            // 
            this.labelResiKotaPengirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResiKotaPengirim.AutoSize = true;
            this.labelResiKotaPengirim.Font = new System.Drawing.Font("Montserrat", 12F);
            this.labelResiKotaPengirim.ForeColor = System.Drawing.Color.LightGray;
            this.labelResiKotaPengirim.Location = new System.Drawing.Point(20, 77);
            this.labelResiKotaPengirim.Name = "labelResiKotaPengirim";
            this.labelResiKotaPengirim.Size = new System.Drawing.Size(46, 22);
            this.labelResiKotaPengirim.TabIndex = 11;
            this.labelResiKotaPengirim.Text = "Kota";
            // 
            // labelResiAlamatPengirim
            // 
            this.labelResiAlamatPengirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResiAlamatPengirim.AutoSize = true;
            this.labelResiAlamatPengirim.Font = new System.Drawing.Font("Montserrat", 12F);
            this.labelResiAlamatPengirim.ForeColor = System.Drawing.Color.LightGray;
            this.labelResiAlamatPengirim.Location = new System.Drawing.Point(20, 47);
            this.labelResiAlamatPengirim.Name = "labelResiAlamatPengirim";
            this.labelResiAlamatPengirim.Size = new System.Drawing.Size(66, 22);
            this.labelResiAlamatPengirim.TabIndex = 10;
            this.labelResiAlamatPengirim.Text = "Alamat";
            // 
            // labelResiPengirim
            // 
            this.labelResiPengirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResiPengirim.AutoSize = true;
            this.labelResiPengirim.Font = new System.Drawing.Font("Montserrat", 12F);
            this.labelResiPengirim.ForeColor = System.Drawing.Color.LightGray;
            this.labelResiPengirim.Location = new System.Drawing.Point(20, 17);
            this.labelResiPengirim.Name = "labelResiPengirim";
            this.labelResiPengirim.Size = new System.Drawing.Size(95, 22);
            this.labelResiPengirim.TabIndex = 9;
            this.labelResiPengirim.Text = "Pengirim : ";
            // 
            // pictureBoxBarCode
            // 
            this.pictureBoxBarCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxBarCode.Location = new System.Drawing.Point(249, 42);
            this.pictureBoxBarCode.Name = "pictureBoxBarCode";
            this.pictureBoxBarCode.Size = new System.Drawing.Size(422, 96);
            this.pictureBoxBarCode.TabIndex = 7;
            this.pictureBoxBarCode.TabStop = false;
            // 
            // pictureBoxResiLogo
            // 
            this.pictureBoxResiLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxResiLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxResiLogo.ErrorImage")));
            this.pictureBoxResiLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxResiLogo.Image")));
            this.pictureBoxResiLogo.Location = new System.Drawing.Point(12, 42);
            this.pictureBoxResiLogo.Name = "pictureBoxResiLogo";
            this.pictureBoxResiLogo.Size = new System.Drawing.Size(212, 96);
            this.pictureBoxResiLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxResiLogo.TabIndex = 6;
            this.pictureBoxResiLogo.TabStop = false;
            // 
            // labelResi
            // 
            this.labelResi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResi.AutoSize = true;
            this.labelResi.Font = new System.Drawing.Font("Montserrat", 12F);
            this.labelResi.ForeColor = System.Drawing.Color.LightGray;
            this.labelResi.Location = new System.Drawing.Point(405, 147);
            this.labelResi.Name = "labelResi";
            this.labelResi.Size = new System.Drawing.Size(85, 22);
            this.labelResi.TabIndex = 5;
            this.labelResi.Text = "No. Resi : ";
            // 
            // labelBarangJumlah
            // 
            this.labelBarangJumlah.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBarangJumlah.AutoSize = true;
            this.labelBarangJumlah.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelBarangJumlah.Location = new System.Drawing.Point(57, 126);
            this.labelBarangJumlah.Name = "labelBarangJumlah";
            this.labelBarangJumlah.Size = new System.Drawing.Size(61, 19);
            this.labelBarangJumlah.TabIndex = 2;
            this.labelBarangJumlah.Text = "Jumlah";
            this.labelBarangJumlah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBarangJumlah.Paint += new System.Windows.Forms.PaintEventHandler(this.labelBarangJumlah_Paint);
            // 
            // labelBarangLayanan
            // 
            this.labelBarangLayanan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBarangLayanan.AutoSize = true;
            this.labelBarangLayanan.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelBarangLayanan.Location = new System.Drawing.Point(57, 95);
            this.labelBarangLayanan.Name = "labelBarangLayanan";
            this.labelBarangLayanan.Size = new System.Drawing.Size(67, 19);
            this.labelBarangLayanan.TabIndex = 2;
            this.labelBarangLayanan.Text = "Layanan";
            this.labelBarangLayanan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBarangLayanan.Paint += new System.Windows.Forms.PaintEventHandler(this.labelBarangLayanan_Paint);
            // 
            // labelBarangNama
            // 
            this.labelBarangNama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBarangNama.AutoEllipsis = true;
            this.labelBarangNama.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelBarangNama.Location = new System.Drawing.Point(15, 62);
            this.labelBarangNama.MinimumSize = new System.Drawing.Size(0, 20);
            this.labelBarangNama.Name = "labelBarangNama";
            this.labelBarangNama.Size = new System.Drawing.Size(150, 20);
            this.labelBarangNama.TabIndex = 2;
            this.labelBarangNama.Text = "Nama";
            this.labelBarangNama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBarangNama.Paint += new System.Windows.Forms.PaintEventHandler(this.labelBarangNama_Paint);
            // 
            // labelBarangKosong
            // 
            this.labelBarangKosong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBarangKosong.AutoSize = true;
            this.labelBarangKosong.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelBarangKosong.Location = new System.Drawing.Point(42, 212);
            this.labelBarangKosong.Name = "labelBarangKosong";
            this.labelBarangKosong.Size = new System.Drawing.Size(110, 19);
            this.labelBarangKosong.TabIndex = 2;
            this.labelBarangKosong.Text = "Tidak ada data";
            this.labelBarangKosong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBarangKosong.Paint += new System.Windows.Forms.PaintEventHandler(this.labelBarangKosong_Paint);
            // 
            // labelBarangAsuransi
            // 
            this.labelBarangAsuransi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBarangAsuransi.AutoSize = true;
            this.labelBarangAsuransi.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelBarangAsuransi.Location = new System.Drawing.Point(57, 183);
            this.labelBarangAsuransi.Name = "labelBarangAsuransi";
            this.labelBarangAsuransi.Size = new System.Drawing.Size(81, 19);
            this.labelBarangAsuransi.TabIndex = 2;
            this.labelBarangAsuransi.Text = "Asuransi? ";
            this.labelBarangAsuransi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBarangAsuransi.Paint += new System.Windows.Forms.PaintEventHandler(this.labelBarangAsuransi_Paint);
            // 
            // labelBarangBerat
            // 
            this.labelBarangBerat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBarangBerat.AutoSize = true;
            this.labelBarangBerat.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelBarangBerat.Location = new System.Drawing.Point(57, 155);
            this.labelBarangBerat.Name = "labelBarangBerat";
            this.labelBarangBerat.Size = new System.Drawing.Size(48, 19);
            this.labelBarangBerat.TabIndex = 2;
            this.labelBarangBerat.Text = "Berat";
            this.labelBarangBerat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBarangBerat.Paint += new System.Windows.Forms.PaintEventHandler(this.labelBarangBerat_Paint);
            // 
            // buttonKirimResi
            // 
            this.buttonKirimResi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonKirimResi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.buttonKirimResi.FlatAppearance.BorderSize = 0;
            this.buttonKirimResi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKirimResi.Font = new System.Drawing.Font("Montserrat", 10F);
            this.buttonKirimResi.ForeColor = System.Drawing.Color.LightGray;
            this.buttonKirimResi.Location = new System.Drawing.Point(280, 429);
            this.buttonKirimResi.Name = "buttonKirimResi";
            this.buttonKirimResi.Size = new System.Drawing.Size(125, 40);
            this.buttonKirimResi.TabIndex = 4;
            this.buttonKirimResi.Text = "Kirim";
            this.buttonKirimResi.UseVisualStyleBackColor = false;
            this.buttonKirimResi.Click += new System.EventHandler(this.buttonKirimResi_Click);
            // 
            // labelLengkap
            // 
            this.labelLengkap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLengkap.AutoSize = true;
            this.labelLengkap.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelLengkap.ForeColor = System.Drawing.Color.LightGray;
            this.labelLengkap.Location = new System.Drawing.Point(263, 492);
            this.labelLengkap.Name = "labelLengkap";
            this.labelLengkap.Size = new System.Drawing.Size(157, 19);
            this.labelLengkap.TabIndex = 6;
            this.labelLengkap.Text = "Data kurang lengkap";
            this.labelLengkap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLengkap.Visible = false;
            // 
            // Kirim
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.panelKirimResi);
            this.Controls.Add(this.labelLengkap);
            this.Controls.Add(this.buttonKirimResi);
            this.Controls.Add(this.panelBarang);
            this.Controls.Add(this.panelPenerima);
            this.Controls.Add(this.panelPengirim);
            this.Name = "Kirim";
            this.Text = "Kirim";
            this.panelPengirim.ResumeLayout(false);
            this.panelPengirim.PerformLayout();
            this.panelPengirimTop.ResumeLayout(false);
            this.panelPengirimTop.PerformLayout();
            this.panelPenerima.ResumeLayout(false);
            this.panelPenerima.PerformLayout();
            this.panelPenerimaTop.ResumeLayout(false);
            this.panelPenerimaTop.PerformLayout();
            this.panelBarangTop.ResumeLayout(false);
            this.panelBarangTop.PerformLayout();
            this.panelBarang.ResumeLayout(false);
            this.panelBarang.PerformLayout();
            this.panelKirimResi.ResumeLayout(false);
            this.panelKirimResi.PerformLayout();
            this.panelResiTotal.ResumeLayout(false);
            this.panelResiTotal.PerformLayout();
            this.panelResiBiaya.ResumeLayout(false);
            this.panelResiBiaya.PerformLayout();
            this.panelResiLayanan.ResumeLayout(false);
            this.panelResiLayanan.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelResiBerat.ResumeLayout(false);
            this.panelResiBerat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).EndInit();
            this.panelResiPenerima.ResumeLayout(false);
            this.panelResiPenerima.PerformLayout();
            this.panelResiPengirim.ResumeLayout(false);
            this.panelResiPengirim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResiLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPengirim;
        private System.Windows.Forms.Label labelPenerima;
        private System.Windows.Forms.Label labelBarang;
        private System.Windows.Forms.Panel panelPengirim;
        private System.Windows.Forms.Panel panelPengirimTop;
        private System.Windows.Forms.Panel panelPenerima;
        private System.Windows.Forms.Panel panelPenerimaTop;
        private System.Windows.Forms.Panel panelBarangTop;
        private System.Windows.Forms.Panel panelBarang;
        private System.Windows.Forms.Label labelPengirimNama;
        private System.Windows.Forms.Label labelPengirimTelepon;
        private System.Windows.Forms.Label labelPengirimAsal;
        private System.Windows.Forms.Label labelPengirimAlamat;
        private System.Windows.Forms.Label labelPengirimKodePos;
        private System.Windows.Forms.Label labelPengirimKosong;
        private System.Windows.Forms.Label labelPenerimaKosong;
        private System.Windows.Forms.Label labelPenerimaKodePos;
        private System.Windows.Forms.Label labelPenerimaTelepon;
        private System.Windows.Forms.Label labelPenerimaAlamat;
        private System.Windows.Forms.Label labelPenerimaNama;
        private System.Windows.Forms.Label labelPenerimaTujuan;
        private System.Windows.Forms.Label labelBarangKosong;
        private System.Windows.Forms.Label labelBarangNama;
        private System.Windows.Forms.Label labelBarangLayanan;
        private System.Windows.Forms.Label labelBarangAsuransi;
        private System.Windows.Forms.Label labelBarangBerat;
        private System.Windows.Forms.Label labelBarangJumlah;
        private System.Windows.Forms.Button buttonKirimResi;
        private System.Windows.Forms.Label labelResi;
        private System.Windows.Forms.Label labelLengkap;
        private System.Windows.Forms.Panel panelKirimResi;
        private System.Windows.Forms.PictureBox pictureBoxResiLogo;
        private System.Windows.Forms.PictureBox pictureBoxBarCode;
        private System.Windows.Forms.Panel panelResiPengirim;
        private System.Windows.Forms.Label labelResiPengirim;
        private System.Windows.Forms.Label labelResiAlamatPengirim;
        private System.Windows.Forms.Label labelResiKotaPengirim;
        private System.Windows.Forms.Panel panelResiPenerima;
        private System.Windows.Forms.Label labelResiKotaPenerima;
        private System.Windows.Forms.Label labelResiAlamatPenerima;
        private System.Windows.Forms.Label labelResiPenerima;
        private System.Windows.Forms.PictureBox pictureBoxQRCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelResiBerat;
        private System.Windows.Forms.Label labelResiBerat;
        private System.Windows.Forms.Panel panelResiLayanan;
        private System.Windows.Forms.Label labelResiLayanan;
        private System.Windows.Forms.Panel panelResiBiaya;
        private System.Windows.Forms.Label labelResiAsuransi;
        private System.Windows.Forms.Label labelResiBiaya;
        private System.Windows.Forms.Panel panelResiTotal;
        private System.Windows.Forms.Label labelResiTotal;
        private System.Windows.Forms.Label labelResiBiayaTotal;
    }
}