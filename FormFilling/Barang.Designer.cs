namespace FormFilling
{
    partial class Barang
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
            this.panelSimpanBarang = new System.Windows.Forms.Panel();
            this.pictureBoxSimpanBarang = new System.Windows.Forms.PictureBox();
            this.labelSimpanBarang = new System.Windows.Forms.Label();
            this.buttonResetBarang = new System.Windows.Forms.Button();
            this.buttonBarang = new System.Windows.Forms.Button();
            this.layananBarang = new System.Windows.Forms.ComboBox();
            this.hargaBarang = new System.Windows.Forms.TextBox();
            this.jumlahBarang = new System.Windows.Forms.TextBox();
            this.labelHargaBarang = new System.Windows.Forms.Label();
            this.labelNotifBarang = new System.Windows.Forms.Label();
            this.labelHargaBarangNotif = new System.Windows.Forms.Label();
            this.labelDimensiBarangNotif = new System.Windows.Forms.Label();
            this.labelLayananBarang = new System.Windows.Forms.Label();
            this.labelNamaBarang = new System.Windows.Forms.Label();
            this.namaBarang = new System.Windows.Forms.TextBox();
            this.labelJumlahBarang = new System.Windows.Forms.Label();
            this.beratBarang = new System.Windows.Forms.TextBox();
            this.labelBeratBarang = new System.Windows.Forms.Label();
            this.labelKGBarang = new System.Windows.Forms.Label();
            this.checkBoxDimensiBarang = new System.Windows.Forms.CheckBox();
            this.panjangBarang = new System.Windows.Forms.TextBox();
            this.labelCMPanjangBarang = new System.Windows.Forms.Label();
            this.labelPanjangBarang = new System.Windows.Forms.Label();
            this.labelLebarBarang = new System.Windows.Forms.Label();
            this.lebarBarang = new System.Windows.Forms.TextBox();
            this.labelCMLebarBarang = new System.Windows.Forms.Label();
            this.labelTinggiBarang = new System.Windows.Forms.Label();
            this.tinggiBarang = new System.Windows.Forms.TextBox();
            this.labelCMTinggiBarang = new System.Windows.Forms.Label();
            this.checkBoxAsuransiBarang = new System.Windows.Forms.CheckBox();
            this.labelRPBarang = new System.Windows.Forms.Label();
            this.labelBiayaAsuransiBarang = new System.Windows.Forms.Label();
            this.labelRPAsuransi = new System.Windows.Forms.Label();
            this.labelBiayaAsuransiBarangNotif = new System.Windows.Forms.Label();
            this.labelCekAsuransiBarang = new System.Windows.Forms.Label();
            this.panelSimpanBarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSimpanBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSimpanBarang
            // 
            this.panelSimpanBarang.Controls.Add(this.pictureBoxSimpanBarang);
            this.panelSimpanBarang.Controls.Add(this.labelSimpanBarang);
            this.panelSimpanBarang.Location = new System.Drawing.Point(536, 385);
            this.panelSimpanBarang.Name = "panelSimpanBarang";
            this.panelSimpanBarang.Size = new System.Drawing.Size(200, 100);
            this.panelSimpanBarang.TabIndex = 50;
            this.panelSimpanBarang.Visible = false;
            // 
            // pictureBoxSimpanBarang
            // 
            this.pictureBoxSimpanBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxSimpanBarang.Image = global::FormFilling.Properties.Resources.icons8_tick_box_480;
            this.pictureBoxSimpanBarang.Location = new System.Drawing.Point(86, 47);
            this.pictureBoxSimpanBarang.Name = "pictureBoxSimpanBarang";
            this.pictureBoxSimpanBarang.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxSimpanBarang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSimpanBarang.TabIndex = 2;
            this.pictureBoxSimpanBarang.TabStop = false;
            this.pictureBoxSimpanBarang.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxSimpanBarang_Paint);
            // 
            // labelSimpanBarang
            // 
            this.labelSimpanBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSimpanBarang.AutoSize = true;
            this.labelSimpanBarang.Font = new System.Drawing.Font("Montserrat", 12F);
            this.labelSimpanBarang.ForeColor = System.Drawing.Color.LightGray;
            this.labelSimpanBarang.Location = new System.Drawing.Point(56, 24);
            this.labelSimpanBarang.Name = "labelSimpanBarang";
            this.labelSimpanBarang.Size = new System.Drawing.Size(181, 22);
            this.labelSimpanBarang.TabIndex = 1;
            this.labelSimpanBarang.Text = "Data Telah Tersimpan";
            this.labelSimpanBarang.Paint += new System.Windows.Forms.PaintEventHandler(this.labelSimpanBarang_Paint);
            // 
            // buttonResetBarang
            // 
            this.buttonResetBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonResetBarang.BackColor = System.Drawing.Color.Transparent;
            this.buttonResetBarang.FlatAppearance.BorderSize = 0;
            this.buttonResetBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.buttonResetBarang.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonResetBarang.Location = new System.Drawing.Point(300, 485);
            this.buttonResetBarang.Name = "buttonResetBarang";
            this.buttonResetBarang.Size = new System.Drawing.Size(100, 30);
            this.buttonResetBarang.TabIndex = 11;
            this.buttonResetBarang.Text = "Reset";
            this.buttonResetBarang.UseVisualStyleBackColor = false;
            this.buttonResetBarang.Click += new System.EventHandler(this.buttonResetBarang_Click);
            this.buttonResetBarang.MouseEnter += new System.EventHandler(this.buttonResetBarang_MouseEnter);
            this.buttonResetBarang.MouseLeave += new System.EventHandler(this.buttonResetBarang_MouseLeave);
            // 
            // buttonBarang
            // 
            this.buttonBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.buttonBarang.FlatAppearance.BorderSize = 0;
            this.buttonBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.buttonBarang.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonBarang.Location = new System.Drawing.Point(416, 485);
            this.buttonBarang.Name = "buttonBarang";
            this.buttonBarang.Size = new System.Drawing.Size(100, 30);
            this.buttonBarang.TabIndex = 10;
            this.buttonBarang.Text = "Selesai";
            this.buttonBarang.UseVisualStyleBackColor = false;
            this.buttonBarang.Click += new System.EventHandler(this.buttonBarang_Click);
            // 
            // layananBarang
            // 
            this.layananBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.layananBarang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.layananBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.layananBarang.FormattingEnabled = true;
            this.layananBarang.Items.AddRange(new object[] {
            "Ekonomi",
            "Reguler",
            "Ekspress"});
            this.layananBarang.Location = new System.Drawing.Point(158, 163);
            this.layananBarang.Name = "layananBarang";
            this.layananBarang.Size = new System.Drawing.Size(112, 26);
            this.layananBarang.TabIndex = 1;
            this.layananBarang.SelectedIndexChanged += new System.EventHandler(this.layananBarang_SelectedIndexChanged);
            // 
            // hargaBarang
            // 
            this.hargaBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hargaBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.hargaBarang.Location = new System.Drawing.Point(188, 368);
            this.hargaBarang.MaxLength = 8;
            this.hargaBarang.Name = "hargaBarang";
            this.hargaBarang.Size = new System.Drawing.Size(136, 24);
            this.hargaBarang.TabIndex = 9;
            this.hargaBarang.Visible = false;
            this.hargaBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.angkaBarang_KeyPress);
            // 
            // jumlahBarang
            // 
            this.jumlahBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.jumlahBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.jumlahBarang.Location = new System.Drawing.Point(283, 165);
            this.jumlahBarang.MaxLength = 3;
            this.jumlahBarang.Name = "jumlahBarang";
            this.jumlahBarang.Size = new System.Drawing.Size(95, 24);
            this.jumlahBarang.TabIndex = 2;
            this.jumlahBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.angkaBarang_KeyPress);
            // 
            // labelHargaBarang
            // 
            this.labelHargaBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHargaBarang.AutoSize = true;
            this.labelHargaBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelHargaBarang.ForeColor = System.Drawing.Color.LightGray;
            this.labelHargaBarang.Location = new System.Drawing.Point(154, 346);
            this.labelHargaBarang.Name = "labelHargaBarang";
            this.labelHargaBarang.Size = new System.Drawing.Size(108, 19);
            this.labelHargaBarang.TabIndex = 15;
            this.labelHargaBarang.Text = "Harga Barang";
            this.labelHargaBarang.Visible = false;
            // 
            // labelNotifBarang
            // 
            this.labelNotifBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNotifBarang.AutoSize = true;
            this.labelNotifBarang.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotifBarang.ForeColor = System.Drawing.Color.LightGray;
            this.labelNotifBarang.Location = new System.Drawing.Point(155, 485);
            this.labelNotifBarang.Name = "labelNotifBarang";
            this.labelNotifBarang.Size = new System.Drawing.Size(115, 15);
            this.labelNotifBarang.TabIndex = 14;
            this.labelNotifBarang.Text = "Data harus lengkap";
            this.labelNotifBarang.Visible = false;
            // 
            // labelHargaBarangNotif
            // 
            this.labelHargaBarangNotif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHargaBarangNotif.AutoSize = true;
            this.labelHargaBarangNotif.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHargaBarangNotif.ForeColor = System.Drawing.Color.LightGray;
            this.labelHargaBarangNotif.Location = new System.Drawing.Point(335, 373);
            this.labelHargaBarangNotif.Name = "labelHargaBarangNotif";
            this.labelHargaBarangNotif.Size = new System.Drawing.Size(329, 15);
            this.labelHargaBarangNotif.TabIndex = 13;
            this.labelHargaBarangNotif.Text = "Masukkan harga barang untuk mengetahui biaya asuransi";
            this.labelHargaBarangNotif.Visible = false;
            // 
            // labelDimensiBarangNotif
            // 
            this.labelDimensiBarangNotif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDimensiBarangNotif.AutoSize = true;
            this.labelDimensiBarangNotif.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDimensiBarangNotif.ForeColor = System.Drawing.Color.LightGray;
            this.labelDimensiBarangNotif.Location = new System.Drawing.Point(524, 271);
            this.labelDimensiBarangNotif.Name = "labelDimensiBarangNotif";
            this.labelDimensiBarangNotif.Size = new System.Drawing.Size(153, 15);
            this.labelDimensiBarangNotif.TabIndex = 12;
            this.labelDimensiBarangNotif.Text = "Masukkan dimensi barang";
            this.labelDimensiBarangNotif.Visible = false;
            // 
            // labelLayananBarang
            // 
            this.labelLayananBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLayananBarang.AutoSize = true;
            this.labelLayananBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelLayananBarang.ForeColor = System.Drawing.Color.LightGray;
            this.labelLayananBarang.Location = new System.Drawing.Point(154, 141);
            this.labelLayananBarang.Name = "labelLayananBarang";
            this.labelLayananBarang.Size = new System.Drawing.Size(67, 19);
            this.labelLayananBarang.TabIndex = 11;
            this.labelLayananBarang.Text = "Layanan";
            // 
            // labelNamaBarang
            // 
            this.labelNamaBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNamaBarang.AutoSize = true;
            this.labelNamaBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelNamaBarang.ForeColor = System.Drawing.Color.LightGray;
            this.labelNamaBarang.Location = new System.Drawing.Point(153, 77);
            this.labelNamaBarang.Name = "labelNamaBarang";
            this.labelNamaBarang.Size = new System.Drawing.Size(107, 19);
            this.labelNamaBarang.TabIndex = 16;
            this.labelNamaBarang.Text = "Nama Barang";
            // 
            // namaBarang
            // 
            this.namaBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.namaBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.namaBarang.Location = new System.Drawing.Point(157, 99);
            this.namaBarang.Name = "namaBarang";
            this.namaBarang.Size = new System.Drawing.Size(359, 24);
            this.namaBarang.TabIndex = 0;
            // 
            // labelJumlahBarang
            // 
            this.labelJumlahBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelJumlahBarang.AutoSize = true;
            this.labelJumlahBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelJumlahBarang.ForeColor = System.Drawing.Color.LightGray;
            this.labelJumlahBarang.Location = new System.Drawing.Point(279, 141);
            this.labelJumlahBarang.Name = "labelJumlahBarang";
            this.labelJumlahBarang.Size = new System.Drawing.Size(61, 19);
            this.labelJumlahBarang.TabIndex = 11;
            this.labelJumlahBarang.Text = "Jumlah";
            // 
            // beratBarang
            // 
            this.beratBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.beratBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.beratBarang.Location = new System.Drawing.Point(390, 165);
            this.beratBarang.MaxLength = 2;
            this.beratBarang.Name = "beratBarang";
            this.beratBarang.Size = new System.Drawing.Size(95, 24);
            this.beratBarang.TabIndex = 3;
            this.beratBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.angkaBarang_KeyPress);
            // 
            // labelBeratBarang
            // 
            this.labelBeratBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBeratBarang.AutoSize = true;
            this.labelBeratBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelBeratBarang.ForeColor = System.Drawing.Color.LightGray;
            this.labelBeratBarang.Location = new System.Drawing.Point(384, 141);
            this.labelBeratBarang.Name = "labelBeratBarang";
            this.labelBeratBarang.Size = new System.Drawing.Size(48, 19);
            this.labelBeratBarang.TabIndex = 11;
            this.labelBeratBarang.Text = "Berat";
            // 
            // labelKGBarang
            // 
            this.labelKGBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKGBarang.AutoSize = true;
            this.labelKGBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelKGBarang.ForeColor = System.Drawing.Color.LightGray;
            this.labelKGBarang.Location = new System.Drawing.Point(486, 168);
            this.labelKGBarang.Name = "labelKGBarang";
            this.labelKGBarang.Size = new System.Drawing.Size(30, 19);
            this.labelKGBarang.TabIndex = 27;
            this.labelKGBarang.Text = "KG";
            // 
            // checkBoxDimensiBarang
            // 
            this.checkBoxDimensiBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxDimensiBarang.AutoSize = true;
            this.checkBoxDimensiBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.checkBoxDimensiBarang.ForeColor = System.Drawing.Color.LightGray;
            this.checkBoxDimensiBarang.Location = new System.Drawing.Point(158, 212);
            this.checkBoxDimensiBarang.Name = "checkBoxDimensiBarang";
            this.checkBoxDimensiBarang.Size = new System.Drawing.Size(87, 23);
            this.checkBoxDimensiBarang.TabIndex = 4;
            this.checkBoxDimensiBarang.Text = "Dimensi";
            this.checkBoxDimensiBarang.UseVisualStyleBackColor = true;
            this.checkBoxDimensiBarang.CheckedChanged += new System.EventHandler(this.checkBoxDimensiBarang_CheckedChanged);
            // 
            // panjangBarang
            // 
            this.panjangBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panjangBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.panjangBarang.Location = new System.Drawing.Point(157, 266);
            this.panjangBarang.MaxLength = 3;
            this.panjangBarang.Name = "panjangBarang";
            this.panjangBarang.Size = new System.Drawing.Size(85, 24);
            this.panjangBarang.TabIndex = 5;
            this.panjangBarang.Visible = false;
            this.panjangBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.angkaBarang_KeyPress);
            // 
            // labelCMPanjangBarang
            // 
            this.labelCMPanjangBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCMPanjangBarang.AutoSize = true;
            this.labelCMPanjangBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelCMPanjangBarang.ForeColor = System.Drawing.Color.LightGray;
            this.labelCMPanjangBarang.Location = new System.Drawing.Point(243, 269);
            this.labelCMPanjangBarang.Name = "labelCMPanjangBarang";
            this.labelCMPanjangBarang.Size = new System.Drawing.Size(32, 19);
            this.labelCMPanjangBarang.TabIndex = 27;
            this.labelCMPanjangBarang.Text = "CM";
            this.labelCMPanjangBarang.Visible = false;
            // 
            // labelPanjangBarang
            // 
            this.labelPanjangBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPanjangBarang.AutoSize = true;
            this.labelPanjangBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelPanjangBarang.ForeColor = System.Drawing.Color.LightGray;
            this.labelPanjangBarang.Location = new System.Drawing.Point(154, 244);
            this.labelPanjangBarang.Name = "labelPanjangBarang";
            this.labelPanjangBarang.Size = new System.Drawing.Size(67, 19);
            this.labelPanjangBarang.TabIndex = 11;
            this.labelPanjangBarang.Text = "Panjang";
            this.labelPanjangBarang.Visible = false;
            // 
            // labelLebarBarang
            // 
            this.labelLebarBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLebarBarang.AutoSize = true;
            this.labelLebarBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelLebarBarang.ForeColor = System.Drawing.Color.LightGray;
            this.labelLebarBarang.Location = new System.Drawing.Point(276, 244);
            this.labelLebarBarang.Name = "labelLebarBarang";
            this.labelLebarBarang.Size = new System.Drawing.Size(48, 19);
            this.labelLebarBarang.TabIndex = 11;
            this.labelLebarBarang.Text = "Lebar";
            this.labelLebarBarang.Visible = false;
            // 
            // lebarBarang
            // 
            this.lebarBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lebarBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.lebarBarang.Location = new System.Drawing.Point(279, 266);
            this.lebarBarang.MaxLength = 3;
            this.lebarBarang.Name = "lebarBarang";
            this.lebarBarang.Size = new System.Drawing.Size(85, 24);
            this.lebarBarang.TabIndex = 6;
            this.lebarBarang.Visible = false;
            this.lebarBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.angkaBarang_KeyPress);
            // 
            // labelCMLebarBarang
            // 
            this.labelCMLebarBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCMLebarBarang.AutoSize = true;
            this.labelCMLebarBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelCMLebarBarang.ForeColor = System.Drawing.Color.LightGray;
            this.labelCMLebarBarang.Location = new System.Drawing.Point(365, 269);
            this.labelCMLebarBarang.Name = "labelCMLebarBarang";
            this.labelCMLebarBarang.Size = new System.Drawing.Size(32, 19);
            this.labelCMLebarBarang.TabIndex = 27;
            this.labelCMLebarBarang.Text = "CM";
            this.labelCMLebarBarang.Visible = false;
            // 
            // labelTinggiBarang
            // 
            this.labelTinggiBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTinggiBarang.AutoSize = true;
            this.labelTinggiBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelTinggiBarang.ForeColor = System.Drawing.Color.LightGray;
            this.labelTinggiBarang.Location = new System.Drawing.Point(397, 244);
            this.labelTinggiBarang.Name = "labelTinggiBarang";
            this.labelTinggiBarang.Size = new System.Drawing.Size(54, 19);
            this.labelTinggiBarang.TabIndex = 11;
            this.labelTinggiBarang.Text = "Tinggi";
            this.labelTinggiBarang.Visible = false;
            // 
            // tinggiBarang
            // 
            this.tinggiBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tinggiBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.tinggiBarang.Location = new System.Drawing.Point(400, 266);
            this.tinggiBarang.MaxLength = 3;
            this.tinggiBarang.Name = "tinggiBarang";
            this.tinggiBarang.Size = new System.Drawing.Size(85, 24);
            this.tinggiBarang.TabIndex = 7;
            this.tinggiBarang.Visible = false;
            this.tinggiBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.angkaBarang_KeyPress);
            // 
            // labelCMTinggiBarang
            // 
            this.labelCMTinggiBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCMTinggiBarang.AutoSize = true;
            this.labelCMTinggiBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelCMTinggiBarang.ForeColor = System.Drawing.Color.LightGray;
            this.labelCMTinggiBarang.Location = new System.Drawing.Point(486, 269);
            this.labelCMTinggiBarang.Name = "labelCMTinggiBarang";
            this.labelCMTinggiBarang.Size = new System.Drawing.Size(32, 19);
            this.labelCMTinggiBarang.TabIndex = 27;
            this.labelCMTinggiBarang.Text = "CM";
            this.labelCMTinggiBarang.Visible = false;
            // 
            // checkBoxAsuransiBarang
            // 
            this.checkBoxAsuransiBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxAsuransiBarang.AutoSize = true;
            this.checkBoxAsuransiBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.checkBoxAsuransiBarang.ForeColor = System.Drawing.Color.LightGray;
            this.checkBoxAsuransiBarang.Location = new System.Drawing.Point(157, 312);
            this.checkBoxAsuransiBarang.Name = "checkBoxAsuransiBarang";
            this.checkBoxAsuransiBarang.Size = new System.Drawing.Size(88, 23);
            this.checkBoxAsuransiBarang.TabIndex = 8;
            this.checkBoxAsuransiBarang.Text = "Asuransi";
            this.checkBoxAsuransiBarang.UseVisualStyleBackColor = true;
            this.checkBoxAsuransiBarang.CheckedChanged += new System.EventHandler(this.checkBoxAsuransiBarang_CheckedChanged);
            // 
            // labelRPBarang
            // 
            this.labelRPBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRPBarang.AutoSize = true;
            this.labelRPBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelRPBarang.ForeColor = System.Drawing.Color.LightGray;
            this.labelRPBarang.Location = new System.Drawing.Point(154, 371);
            this.labelRPBarang.Name = "labelRPBarang";
            this.labelRPBarang.Size = new System.Drawing.Size(31, 19);
            this.labelRPBarang.TabIndex = 27;
            this.labelRPBarang.Text = "Rp.";
            this.labelRPBarang.Visible = false;
            // 
            // labelBiayaAsuransiBarang
            // 
            this.labelBiayaAsuransiBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBiayaAsuransiBarang.AutoSize = true;
            this.labelBiayaAsuransiBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelBiayaAsuransiBarang.ForeColor = System.Drawing.Color.LightGray;
            this.labelBiayaAsuransiBarang.Location = new System.Drawing.Point(154, 409);
            this.labelBiayaAsuransiBarang.Name = "labelBiayaAsuransiBarang";
            this.labelBiayaAsuransiBarang.Size = new System.Drawing.Size(112, 19);
            this.labelBiayaAsuransiBarang.TabIndex = 15;
            this.labelBiayaAsuransiBarang.Text = "Biaya Asuransi";
            this.labelBiayaAsuransiBarang.Visible = false;
            // 
            // labelRPAsuransi
            // 
            this.labelRPAsuransi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRPAsuransi.AutoSize = true;
            this.labelRPAsuransi.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelRPAsuransi.ForeColor = System.Drawing.Color.LightGray;
            this.labelRPAsuransi.Location = new System.Drawing.Point(154, 434);
            this.labelRPAsuransi.Name = "labelRPAsuransi";
            this.labelRPAsuransi.Size = new System.Drawing.Size(31, 19);
            this.labelRPAsuransi.TabIndex = 27;
            this.labelRPAsuransi.Text = "Rp.";
            this.labelRPAsuransi.Visible = false;
            // 
            // labelBiayaAsuransiBarangNotif
            // 
            this.labelBiayaAsuransiBarangNotif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBiayaAsuransiBarangNotif.AutoSize = true;
            this.labelBiayaAsuransiBarangNotif.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBiayaAsuransiBarangNotif.ForeColor = System.Drawing.Color.LightGray;
            this.labelBiayaAsuransiBarangNotif.Location = new System.Drawing.Point(335, 438);
            this.labelBiayaAsuransiBarangNotif.Name = "labelBiayaAsuransiBarangNotif";
            this.labelBiayaAsuransiBarangNotif.Size = new System.Drawing.Size(210, 15);
            this.labelBiayaAsuransiBarangNotif.TabIndex = 13;
            this.labelBiayaAsuransiBarangNotif.Text = "Biaya asuransi = 0,2% x harga barang";
            this.labelBiayaAsuransiBarangNotif.Visible = false;
            // 
            // labelCekAsuransiBarang
            // 
            this.labelCekAsuransiBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCekAsuransiBarang.AutoSize = true;
            this.labelCekAsuransiBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelCekAsuransiBarang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.labelCekAsuransiBarang.Location = new System.Drawing.Point(289, 409);
            this.labelCekAsuransiBarang.Name = "labelCekAsuransiBarang";
            this.labelCekAsuransiBarang.Size = new System.Drawing.Size(35, 19);
            this.labelCekAsuransiBarang.TabIndex = 15;
            this.labelCekAsuransiBarang.Text = "Cek";
            this.labelCekAsuransiBarang.Visible = false;
            this.labelCekAsuransiBarang.Click += new System.EventHandler(this.labelCekAsuransiBarang_Click);
            // 
            // Barang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.checkBoxAsuransiBarang);
            this.Controls.Add(this.checkBoxDimensiBarang);
            this.Controls.Add(this.labelCMTinggiBarang);
            this.Controls.Add(this.labelCMLebarBarang);
            this.Controls.Add(this.labelRPAsuransi);
            this.Controls.Add(this.labelRPBarang);
            this.Controls.Add(this.labelCMPanjangBarang);
            this.Controls.Add(this.labelKGBarang);
            this.Controls.Add(this.panelSimpanBarang);
            this.Controls.Add(this.buttonResetBarang);
            this.Controls.Add(this.buttonBarang);
            this.Controls.Add(this.layananBarang);
            this.Controls.Add(this.hargaBarang);
            this.Controls.Add(this.tinggiBarang);
            this.Controls.Add(this.lebarBarang);
            this.Controls.Add(this.panjangBarang);
            this.Controls.Add(this.beratBarang);
            this.Controls.Add(this.jumlahBarang);
            this.Controls.Add(this.labelCekAsuransiBarang);
            this.Controls.Add(this.labelBiayaAsuransiBarang);
            this.Controls.Add(this.labelHargaBarang);
            this.Controls.Add(this.labelNotifBarang);
            this.Controls.Add(this.labelBiayaAsuransiBarangNotif);
            this.Controls.Add(this.labelHargaBarangNotif);
            this.Controls.Add(this.labelDimensiBarangNotif);
            this.Controls.Add(this.labelBeratBarang);
            this.Controls.Add(this.labelTinggiBarang);
            this.Controls.Add(this.labelLebarBarang);
            this.Controls.Add(this.labelJumlahBarang);
            this.Controls.Add(this.labelPanjangBarang);
            this.Controls.Add(this.labelLayananBarang);
            this.Controls.Add(this.labelNamaBarang);
            this.Controls.Add(this.namaBarang);
            this.Name = "Barang";
            this.Text = "Barang";
            this.panelSimpanBarang.ResumeLayout(false);
            this.panelSimpanBarang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSimpanBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSimpanBarang;
        private System.Windows.Forms.PictureBox pictureBoxSimpanBarang;
        private System.Windows.Forms.Label labelSimpanBarang;
        private System.Windows.Forms.Button buttonResetBarang;
        private System.Windows.Forms.Button buttonBarang;
        private System.Windows.Forms.ComboBox layananBarang;
        private System.Windows.Forms.TextBox hargaBarang;
        private System.Windows.Forms.TextBox jumlahBarang;
        private System.Windows.Forms.Label labelHargaBarang;
        private System.Windows.Forms.Label labelNotifBarang;
        private System.Windows.Forms.Label labelHargaBarangNotif;
        private System.Windows.Forms.Label labelDimensiBarangNotif;
        private System.Windows.Forms.Label labelLayananBarang;
        private System.Windows.Forms.Label labelNamaBarang;
        private System.Windows.Forms.TextBox namaBarang;
        private System.Windows.Forms.Label labelJumlahBarang;
        private System.Windows.Forms.TextBox beratBarang;
        private System.Windows.Forms.Label labelBeratBarang;
        private System.Windows.Forms.Label labelKGBarang;
        private System.Windows.Forms.CheckBox checkBoxDimensiBarang;
        private System.Windows.Forms.TextBox panjangBarang;
        private System.Windows.Forms.Label labelCMPanjangBarang;
        private System.Windows.Forms.Label labelPanjangBarang;
        private System.Windows.Forms.Label labelLebarBarang;
        private System.Windows.Forms.TextBox lebarBarang;
        private System.Windows.Forms.Label labelCMLebarBarang;
        private System.Windows.Forms.Label labelTinggiBarang;
        private System.Windows.Forms.TextBox tinggiBarang;
        private System.Windows.Forms.Label labelCMTinggiBarang;
        private System.Windows.Forms.CheckBox checkBoxAsuransiBarang;
        private System.Windows.Forms.Label labelRPBarang;
        private System.Windows.Forms.Label labelBiayaAsuransiBarang;
        private System.Windows.Forms.Label labelRPAsuransi;
        private System.Windows.Forms.Label labelBiayaAsuransiBarangNotif;
        private System.Windows.Forms.Label labelCekAsuransiBarang;
    }
}