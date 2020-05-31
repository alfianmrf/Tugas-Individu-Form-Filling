namespace FormFilling
{
    partial class Ongkir
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
            this.kotaPengirim = new System.Windows.Forms.ComboBox();
            this.provinsiPengirim = new System.Windows.Forms.ComboBox();
            this.kotaPenerima = new System.Windows.Forms.ComboBox();
            this.provinsiPenerima = new System.Windows.Forms.ComboBox();
            this.labelKGBarang = new System.Windows.Forms.Label();
            this.beratBarang = new System.Windows.Forms.TextBox();
            this.labelBeratBarang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxAsuransiBarang = new System.Windows.Forms.CheckBox();
            this.checkBoxDimensiBarang = new System.Windows.Forms.CheckBox();
            this.labelCMTinggiBarang = new System.Windows.Forms.Label();
            this.labelCMLebarBarang = new System.Windows.Forms.Label();
            this.labelRPBarang = new System.Windows.Forms.Label();
            this.labelCMPanjangBarang = new System.Windows.Forms.Label();
            this.hargaBarang = new System.Windows.Forms.TextBox();
            this.tinggiBarang = new System.Windows.Forms.TextBox();
            this.lebarBarang = new System.Windows.Forms.TextBox();
            this.panjangBarang = new System.Windows.Forms.TextBox();
            this.labelHargaBarang = new System.Windows.Forms.Label();
            this.labelNotifBarang = new System.Windows.Forms.Label();
            this.labelDimensiBarangNotif = new System.Windows.Forms.Label();
            this.labelTinggiBarang = new System.Windows.Forms.Label();
            this.labelLebarBarang = new System.Windows.Forms.Label();
            this.labelPanjangBarang = new System.Windows.Forms.Label();
            this.labelHargaBarangNotif = new System.Windows.Forms.Label();
            this.buttonCekOngkir = new System.Windows.Forms.Button();
            this.tableLayoutPanelOngkir = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTotalEkonomi = new System.Windows.Forms.Label();
            this.labelTotalReguler = new System.Windows.Forms.Label();
            this.labelTotalEkspress = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelOngkirEkonomi = new System.Windows.Forms.Label();
            this.labelOngkirEkspress = new System.Windows.Forms.Label();
            this.labelOngkirReguler = new System.Windows.Forms.Label();
            this.labelAsuransiEkonomi = new System.Windows.Forms.Label();
            this.labelAsuransiReguler = new System.Windows.Forms.Label();
            this.labelAsuransiEkspress = new System.Windows.Forms.Label();
            this.tableLayoutPanelOngkir.SuspendLayout();
            this.SuspendLayout();
            // 
            // kotaPengirim
            // 
            this.kotaPengirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kotaPengirim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kotaPengirim.Font = new System.Drawing.Font("Montserrat", 10F);
            this.kotaPengirim.FormattingEnabled = true;
            this.kotaPengirim.Location = new System.Drawing.Point(26, 114);
            this.kotaPengirim.Name = "kotaPengirim";
            this.kotaPengirim.Size = new System.Drawing.Size(243, 26);
            this.kotaPengirim.TabIndex = 5;
            this.kotaPengirim.Visible = false;
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
            this.provinsiPengirim.Location = new System.Drawing.Point(26, 82);
            this.provinsiPengirim.Name = "provinsiPengirim";
            this.provinsiPengirim.Size = new System.Drawing.Size(243, 26);
            this.provinsiPengirim.TabIndex = 4;
            this.provinsiPengirim.SelectedIndexChanged += new System.EventHandler(this.provinsiOngkirPengirim_SelectedIndexChanged);
            // 
            // kotaPenerima
            // 
            this.kotaPenerima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kotaPenerima.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kotaPenerima.Font = new System.Drawing.Font("Montserrat", 10F);
            this.kotaPenerima.FormattingEnabled = true;
            this.kotaPenerima.Location = new System.Drawing.Point(283, 114);
            this.kotaPenerima.Name = "kotaPenerima";
            this.kotaPenerima.Size = new System.Drawing.Size(243, 26);
            this.kotaPenerima.TabIndex = 7;
            this.kotaPenerima.Visible = false;
            // 
            // provinsiPenerima
            // 
            this.provinsiPenerima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.provinsiPenerima.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provinsiPenerima.Font = new System.Drawing.Font("Montserrat", 10F);
            this.provinsiPenerima.FormattingEnabled = true;
            this.provinsiPenerima.Items.AddRange(new object[] {
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
            this.provinsiPenerima.Location = new System.Drawing.Point(283, 82);
            this.provinsiPenerima.Name = "provinsiPenerima";
            this.provinsiPenerima.Size = new System.Drawing.Size(243, 26);
            this.provinsiPenerima.TabIndex = 6;
            this.provinsiPenerima.SelectedIndexChanged += new System.EventHandler(this.provinsiOngkirPenerima_SelectedIndexChanged);
            // 
            // labelKGBarang
            // 
            this.labelKGBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKGBarang.AutoSize = true;
            this.labelKGBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelKGBarang.ForeColor = System.Drawing.Color.LightGray;
            this.labelKGBarang.Location = new System.Drawing.Point(635, 86);
            this.labelKGBarang.Name = "labelKGBarang";
            this.labelKGBarang.Size = new System.Drawing.Size(30, 19);
            this.labelKGBarang.TabIndex = 30;
            this.labelKGBarang.Text = "KG";
            // 
            // beratBarang
            // 
            this.beratBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.beratBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.beratBarang.Location = new System.Drawing.Point(539, 83);
            this.beratBarang.MaxLength = 2;
            this.beratBarang.Name = "beratBarang";
            this.beratBarang.Size = new System.Drawing.Size(95, 24);
            this.beratBarang.TabIndex = 28;
            this.beratBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.angkaOngkir_KeyPress);
            // 
            // labelBeratBarang
            // 
            this.labelBeratBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBeratBarang.AutoSize = true;
            this.labelBeratBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelBeratBarang.ForeColor = System.Drawing.Color.LightGray;
            this.labelBeratBarang.Location = new System.Drawing.Point(533, 59);
            this.labelBeratBarang.Name = "labelBeratBarang";
            this.labelBeratBarang.Size = new System.Drawing.Size(48, 19);
            this.labelBeratBarang.TabIndex = 29;
            this.labelBeratBarang.Text = "Berat";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10F);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(279, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Ke";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10F);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(22, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Dari";
            // 
            // checkBoxAsuransiBarang
            // 
            this.checkBoxAsuransiBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxAsuransiBarang.AutoSize = true;
            this.checkBoxAsuransiBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.checkBoxAsuransiBarang.ForeColor = System.Drawing.Color.LightGray;
            this.checkBoxAsuransiBarang.Location = new System.Drawing.Point(438, 159);
            this.checkBoxAsuransiBarang.Name = "checkBoxAsuransiBarang";
            this.checkBoxAsuransiBarang.Size = new System.Drawing.Size(88, 23);
            this.checkBoxAsuransiBarang.TabIndex = 37;
            this.checkBoxAsuransiBarang.Text = "Asuransi";
            this.checkBoxAsuransiBarang.UseVisualStyleBackColor = true;
            this.checkBoxAsuransiBarang.CheckedChanged += new System.EventHandler(this.checkBoxAsuransiBarang_CheckedChanged);
            // 
            // checkBoxDimensiBarang
            // 
            this.checkBoxDimensiBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxDimensiBarang.AutoSize = true;
            this.checkBoxDimensiBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.checkBoxDimensiBarang.ForeColor = System.Drawing.Color.LightGray;
            this.checkBoxDimensiBarang.Location = new System.Drawing.Point(26, 159);
            this.checkBoxDimensiBarang.Name = "checkBoxDimensiBarang";
            this.checkBoxDimensiBarang.Size = new System.Drawing.Size(87, 23);
            this.checkBoxDimensiBarang.TabIndex = 33;
            this.checkBoxDimensiBarang.Text = "Dimensi";
            this.checkBoxDimensiBarang.UseVisualStyleBackColor = true;
            this.checkBoxDimensiBarang.CheckedChanged += new System.EventHandler(this.checkBoxDimensiBarang_CheckedChanged);
            // 
            // labelCMTinggiBarang
            // 
            this.labelCMTinggiBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCMTinggiBarang.AutoSize = true;
            this.labelCMTinggiBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelCMTinggiBarang.ForeColor = System.Drawing.Color.LightGray;
            this.labelCMTinggiBarang.Location = new System.Drawing.Point(354, 216);
            this.labelCMTinggiBarang.Name = "labelCMTinggiBarang";
            this.labelCMTinggiBarang.Size = new System.Drawing.Size(32, 19);
            this.labelCMTinggiBarang.TabIndex = 48;
            this.labelCMTinggiBarang.Text = "CM";
            this.labelCMTinggiBarang.Visible = false;
            // 
            // labelCMLebarBarang
            // 
            this.labelCMLebarBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCMLebarBarang.AutoSize = true;
            this.labelCMLebarBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelCMLebarBarang.ForeColor = System.Drawing.Color.LightGray;
            this.labelCMLebarBarang.Location = new System.Drawing.Point(233, 216);
            this.labelCMLebarBarang.Name = "labelCMLebarBarang";
            this.labelCMLebarBarang.Size = new System.Drawing.Size(32, 19);
            this.labelCMLebarBarang.TabIndex = 47;
            this.labelCMLebarBarang.Text = "CM";
            this.labelCMLebarBarang.Visible = false;
            // 
            // labelRPBarang
            // 
            this.labelRPBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRPBarang.AutoSize = true;
            this.labelRPBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelRPBarang.ForeColor = System.Drawing.Color.LightGray;
            this.labelRPBarang.Location = new System.Drawing.Point(435, 218);
            this.labelRPBarang.Name = "labelRPBarang";
            this.labelRPBarang.Size = new System.Drawing.Size(31, 19);
            this.labelRPBarang.TabIndex = 49;
            this.labelRPBarang.Text = "Rp.";
            this.labelRPBarang.Visible = false;
            // 
            // labelCMPanjangBarang
            // 
            this.labelCMPanjangBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCMPanjangBarang.AutoSize = true;
            this.labelCMPanjangBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelCMPanjangBarang.ForeColor = System.Drawing.Color.LightGray;
            this.labelCMPanjangBarang.Location = new System.Drawing.Point(111, 216);
            this.labelCMPanjangBarang.Name = "labelCMPanjangBarang";
            this.labelCMPanjangBarang.Size = new System.Drawing.Size(32, 19);
            this.labelCMPanjangBarang.TabIndex = 46;
            this.labelCMPanjangBarang.Text = "CM";
            this.labelCMPanjangBarang.Visible = false;
            // 
            // hargaBarang
            // 
            this.hargaBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hargaBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.hargaBarang.Location = new System.Drawing.Point(469, 215);
            this.hargaBarang.MaxLength = 8;
            this.hargaBarang.Name = "hargaBarang";
            this.hargaBarang.Size = new System.Drawing.Size(165, 24);
            this.hargaBarang.TabIndex = 38;
            this.hargaBarang.Visible = false;
            this.hargaBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.angkaOngkir_KeyPress);
            // 
            // tinggiBarang
            // 
            this.tinggiBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tinggiBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.tinggiBarang.Location = new System.Drawing.Point(268, 213);
            this.tinggiBarang.MaxLength = 3;
            this.tinggiBarang.Name = "tinggiBarang";
            this.tinggiBarang.Size = new System.Drawing.Size(85, 24);
            this.tinggiBarang.TabIndex = 36;
            this.tinggiBarang.Visible = false;
            this.tinggiBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.angkaOngkir_KeyPress);
            // 
            // lebarBarang
            // 
            this.lebarBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lebarBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.lebarBarang.Location = new System.Drawing.Point(147, 213);
            this.lebarBarang.MaxLength = 3;
            this.lebarBarang.Name = "lebarBarang";
            this.lebarBarang.Size = new System.Drawing.Size(85, 24);
            this.lebarBarang.TabIndex = 35;
            this.lebarBarang.Visible = false;
            this.lebarBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.angkaOngkir_KeyPress);
            // 
            // panjangBarang
            // 
            this.panjangBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panjangBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.panjangBarang.Location = new System.Drawing.Point(25, 213);
            this.panjangBarang.MaxLength = 3;
            this.panjangBarang.Name = "panjangBarang";
            this.panjangBarang.Size = new System.Drawing.Size(85, 24);
            this.panjangBarang.TabIndex = 34;
            this.panjangBarang.Visible = false;
            this.panjangBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.angkaOngkir_KeyPress);
            // 
            // labelHargaBarang
            // 
            this.labelHargaBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHargaBarang.AutoSize = true;
            this.labelHargaBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelHargaBarang.ForeColor = System.Drawing.Color.LightGray;
            this.labelHargaBarang.Location = new System.Drawing.Point(435, 193);
            this.labelHargaBarang.Name = "labelHargaBarang";
            this.labelHargaBarang.Size = new System.Drawing.Size(108, 19);
            this.labelHargaBarang.TabIndex = 45;
            this.labelHargaBarang.Text = "Harga Barang";
            this.labelHargaBarang.Visible = false;
            // 
            // labelNotifBarang
            // 
            this.labelNotifBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNotifBarang.AutoSize = true;
            this.labelNotifBarang.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotifBarang.ForeColor = System.Drawing.Color.LightGray;
            this.labelNotifBarang.Location = new System.Drawing.Point(411, 302);
            this.labelNotifBarang.Name = "labelNotifBarang";
            this.labelNotifBarang.Size = new System.Drawing.Size(115, 15);
            this.labelNotifBarang.TabIndex = 44;
            this.labelNotifBarang.Text = "Data harus lengkap";
            this.labelNotifBarang.Visible = false;
            // 
            // labelDimensiBarangNotif
            // 
            this.labelDimensiBarangNotif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDimensiBarangNotif.AutoSize = true;
            this.labelDimensiBarangNotif.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDimensiBarangNotif.ForeColor = System.Drawing.Color.LightGray;
            this.labelDimensiBarangNotif.Location = new System.Drawing.Point(23, 253);
            this.labelDimensiBarangNotif.Name = "labelDimensiBarangNotif";
            this.labelDimensiBarangNotif.Size = new System.Drawing.Size(153, 15);
            this.labelDimensiBarangNotif.TabIndex = 42;
            this.labelDimensiBarangNotif.Text = "Masukkan dimensi barang";
            this.labelDimensiBarangNotif.Visible = false;
            // 
            // labelTinggiBarang
            // 
            this.labelTinggiBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTinggiBarang.AutoSize = true;
            this.labelTinggiBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelTinggiBarang.ForeColor = System.Drawing.Color.LightGray;
            this.labelTinggiBarang.Location = new System.Drawing.Point(265, 191);
            this.labelTinggiBarang.Name = "labelTinggiBarang";
            this.labelTinggiBarang.Size = new System.Drawing.Size(54, 19);
            this.labelTinggiBarang.TabIndex = 40;
            this.labelTinggiBarang.Text = "Tinggi";
            this.labelTinggiBarang.Visible = false;
            // 
            // labelLebarBarang
            // 
            this.labelLebarBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLebarBarang.AutoSize = true;
            this.labelLebarBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelLebarBarang.ForeColor = System.Drawing.Color.LightGray;
            this.labelLebarBarang.Location = new System.Drawing.Point(144, 191);
            this.labelLebarBarang.Name = "labelLebarBarang";
            this.labelLebarBarang.Size = new System.Drawing.Size(48, 19);
            this.labelLebarBarang.TabIndex = 39;
            this.labelLebarBarang.Text = "Lebar";
            this.labelLebarBarang.Visible = false;
            // 
            // labelPanjangBarang
            // 
            this.labelPanjangBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPanjangBarang.AutoSize = true;
            this.labelPanjangBarang.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelPanjangBarang.ForeColor = System.Drawing.Color.LightGray;
            this.labelPanjangBarang.Location = new System.Drawing.Point(22, 191);
            this.labelPanjangBarang.Name = "labelPanjangBarang";
            this.labelPanjangBarang.Size = new System.Drawing.Size(67, 19);
            this.labelPanjangBarang.TabIndex = 41;
            this.labelPanjangBarang.Text = "Panjang";
            this.labelPanjangBarang.Visible = false;
            // 
            // labelHargaBarangNotif
            // 
            this.labelHargaBarangNotif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHargaBarangNotif.AutoSize = true;
            this.labelHargaBarangNotif.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHargaBarangNotif.ForeColor = System.Drawing.Color.LightGray;
            this.labelHargaBarangNotif.Location = new System.Drawing.Point(435, 253);
            this.labelHargaBarangNotif.Name = "labelHargaBarangNotif";
            this.labelHargaBarangNotif.Size = new System.Drawing.Size(142, 15);
            this.labelHargaBarangNotif.TabIndex = 43;
            this.labelHargaBarangNotif.Text = "Masukkan harga barang";
            this.labelHargaBarangNotif.Visible = false;
            // 
            // buttonCekOngkir
            // 
            this.buttonCekOngkir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCekOngkir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.buttonCekOngkir.FlatAppearance.BorderSize = 0;
            this.buttonCekOngkir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCekOngkir.Font = new System.Drawing.Font("Montserrat", 10F);
            this.buttonCekOngkir.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCekOngkir.Location = new System.Drawing.Point(286, 294);
            this.buttonCekOngkir.Name = "buttonCekOngkir";
            this.buttonCekOngkir.Size = new System.Drawing.Size(100, 30);
            this.buttonCekOngkir.TabIndex = 50;
            this.buttonCekOngkir.Text = "Cek";
            this.buttonCekOngkir.UseVisualStyleBackColor = false;
            this.buttonCekOngkir.Click += new System.EventHandler(this.buttonCekOngkir_Click);
            this.buttonCekOngkir.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonCekOngkir_Paint);
            // 
            // tableLayoutPanelOngkir
            // 
            this.tableLayoutPanelOngkir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelOngkir.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelOngkir.ColumnCount = 4;
            this.tableLayoutPanelOngkir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelOngkir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelOngkir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelOngkir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelOngkir.Controls.Add(this.labelAsuransiEkonomi, 2, 1);
            this.tableLayoutPanelOngkir.Controls.Add(this.labelAsuransiReguler, 2, 2);
            this.tableLayoutPanelOngkir.Controls.Add(this.labelAsuransiEkspress, 2, 3);
            this.tableLayoutPanelOngkir.Controls.Add(this.labelOngkirEkonomi, 1, 1);
            this.tableLayoutPanelOngkir.Controls.Add(this.labelOngkirReguler, 1, 2);
            this.tableLayoutPanelOngkir.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanelOngkir.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanelOngkir.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanelOngkir.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanelOngkir.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanelOngkir.Controls.Add(this.labelTotalEkonomi, 3, 1);
            this.tableLayoutPanelOngkir.Controls.Add(this.labelTotalReguler, 3, 2);
            this.tableLayoutPanelOngkir.Controls.Add(this.labelTotalEkspress, 3, 3);
            this.tableLayoutPanelOngkir.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanelOngkir.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanelOngkir.Controls.Add(this.labelOngkirEkspress, 1, 3);
            this.tableLayoutPanelOngkir.Location = new System.Drawing.Point(26, 355);
            this.tableLayoutPanelOngkir.Name = "tableLayoutPanelOngkir";
            this.tableLayoutPanelOngkir.RowCount = 4;
            this.tableLayoutPanelOngkir.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelOngkir.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelOngkir.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelOngkir.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelOngkir.Size = new System.Drawing.Size(639, 140);
            this.tableLayoutPanelOngkir.TabIndex = 51;
            this.tableLayoutPanelOngkir.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(47, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 52;
            this.label3.Text = "Layanan";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(187, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 53;
            this.label4.Text = "Ongkos Kirim";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(364, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 54;
            this.label5.Text = "Asuransi";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(537, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 55;
            this.label6.Text = "Total";
            // 
            // labelTotalEkonomi
            // 
            this.labelTotalEkonomi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTotalEkonomi.AutoSize = true;
            this.labelTotalEkonomi.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalEkonomi.ForeColor = System.Drawing.Color.LightGray;
            this.labelTotalEkonomi.Location = new System.Drawing.Point(541, 42);
            this.labelTotalEkonomi.Name = "labelTotalEkonomi";
            this.labelTotalEkonomi.Size = new System.Drawing.Size(34, 18);
            this.labelTotalEkonomi.TabIndex = 56;
            this.labelTotalEkonomi.Text = "Rp. ";
            // 
            // labelTotalReguler
            // 
            this.labelTotalReguler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTotalReguler.AutoSize = true;
            this.labelTotalReguler.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalReguler.ForeColor = System.Drawing.Color.LightGray;
            this.labelTotalReguler.Location = new System.Drawing.Point(541, 76);
            this.labelTotalReguler.Name = "labelTotalReguler";
            this.labelTotalReguler.Size = new System.Drawing.Size(34, 18);
            this.labelTotalReguler.TabIndex = 57;
            this.labelTotalReguler.Text = "Rp. ";
            // 
            // labelTotalEkspress
            // 
            this.labelTotalEkspress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTotalEkspress.AutoSize = true;
            this.labelTotalEkspress.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalEkspress.ForeColor = System.Drawing.Color.LightGray;
            this.labelTotalEkspress.Location = new System.Drawing.Point(541, 112);
            this.labelTotalEkspress.Name = "labelTotalEkspress";
            this.labelTotalEkspress.Size = new System.Drawing.Size(34, 18);
            this.labelTotalEkspress.TabIndex = 58;
            this.labelTotalEkspress.Text = "Rp. ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 10F);
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(44, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 19);
            this.label7.TabIndex = 52;
            this.label7.Text = "Ekonomi";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 10F);
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(48, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 59;
            this.label8.Text = "Reguler";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 10F);
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(45, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 19);
            this.label9.TabIndex = 60;
            this.label9.Text = "Ekspress";
            // 
            // labelOngkirEkonomi
            // 
            this.labelOngkirEkonomi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOngkirEkonomi.AutoSize = true;
            this.labelOngkirEkonomi.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelOngkirEkonomi.ForeColor = System.Drawing.Color.LightGray;
            this.labelOngkirEkonomi.Location = new System.Drawing.Point(221, 42);
            this.labelOngkirEkonomi.Name = "labelOngkirEkonomi";
            this.labelOngkirEkonomi.Size = new System.Drawing.Size(35, 19);
            this.labelOngkirEkonomi.TabIndex = 61;
            this.labelOngkirEkonomi.Text = "Rp. ";
            // 
            // labelOngkirEkspress
            // 
            this.labelOngkirEkspress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOngkirEkspress.AutoSize = true;
            this.labelOngkirEkspress.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelOngkirEkspress.ForeColor = System.Drawing.Color.LightGray;
            this.labelOngkirEkspress.Location = new System.Drawing.Point(221, 111);
            this.labelOngkirEkspress.Name = "labelOngkirEkspress";
            this.labelOngkirEkspress.Size = new System.Drawing.Size(35, 19);
            this.labelOngkirEkspress.TabIndex = 62;
            this.labelOngkirEkspress.Text = "Rp. ";
            // 
            // labelOngkirReguler
            // 
            this.labelOngkirReguler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOngkirReguler.AutoSize = true;
            this.labelOngkirReguler.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelOngkirReguler.ForeColor = System.Drawing.Color.LightGray;
            this.labelOngkirReguler.Location = new System.Drawing.Point(221, 76);
            this.labelOngkirReguler.Name = "labelOngkirReguler";
            this.labelOngkirReguler.Size = new System.Drawing.Size(35, 19);
            this.labelOngkirReguler.TabIndex = 63;
            this.labelOngkirReguler.Text = "Rp. ";
            // 
            // labelAsuransiEkonomi
            // 
            this.labelAsuransiEkonomi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAsuransiEkonomi.AutoSize = true;
            this.labelAsuransiEkonomi.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelAsuransiEkonomi.ForeColor = System.Drawing.Color.LightGray;
            this.labelAsuransiEkonomi.Location = new System.Drawing.Point(380, 42);
            this.labelAsuransiEkonomi.Name = "labelAsuransiEkonomi";
            this.labelAsuransiEkonomi.Size = new System.Drawing.Size(35, 19);
            this.labelAsuransiEkonomi.TabIndex = 64;
            this.labelAsuransiEkonomi.Text = "Rp. ";
            // 
            // labelAsuransiReguler
            // 
            this.labelAsuransiReguler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAsuransiReguler.AutoSize = true;
            this.labelAsuransiReguler.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelAsuransiReguler.ForeColor = System.Drawing.Color.LightGray;
            this.labelAsuransiReguler.Location = new System.Drawing.Point(380, 76);
            this.labelAsuransiReguler.Name = "labelAsuransiReguler";
            this.labelAsuransiReguler.Size = new System.Drawing.Size(35, 19);
            this.labelAsuransiReguler.TabIndex = 66;
            this.labelAsuransiReguler.Text = "Rp. ";
            // 
            // labelAsuransiEkspress
            // 
            this.labelAsuransiEkspress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAsuransiEkspress.AutoSize = true;
            this.labelAsuransiEkspress.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelAsuransiEkspress.ForeColor = System.Drawing.Color.LightGray;
            this.labelAsuransiEkspress.Location = new System.Drawing.Point(380, 111);
            this.labelAsuransiEkspress.Name = "labelAsuransiEkspress";
            this.labelAsuransiEkspress.Size = new System.Drawing.Size(35, 19);
            this.labelAsuransiEkspress.TabIndex = 65;
            this.labelAsuransiEkspress.Text = "Rp. ";
            // 
            // Ongkir
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.tableLayoutPanelOngkir);
            this.Controls.Add(this.buttonCekOngkir);
            this.Controls.Add(this.checkBoxAsuransiBarang);
            this.Controls.Add(this.checkBoxDimensiBarang);
            this.Controls.Add(this.labelCMTinggiBarang);
            this.Controls.Add(this.labelCMLebarBarang);
            this.Controls.Add(this.labelRPBarang);
            this.Controls.Add(this.labelCMPanjangBarang);
            this.Controls.Add(this.hargaBarang);
            this.Controls.Add(this.tinggiBarang);
            this.Controls.Add(this.lebarBarang);
            this.Controls.Add(this.panjangBarang);
            this.Controls.Add(this.labelHargaBarang);
            this.Controls.Add(this.labelNotifBarang);
            this.Controls.Add(this.labelHargaBarangNotif);
            this.Controls.Add(this.labelDimensiBarangNotif);
            this.Controls.Add(this.labelTinggiBarang);
            this.Controls.Add(this.labelLebarBarang);
            this.Controls.Add(this.labelPanjangBarang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelKGBarang);
            this.Controls.Add(this.beratBarang);
            this.Controls.Add(this.labelBeratBarang);
            this.Controls.Add(this.kotaPenerima);
            this.Controls.Add(this.provinsiPenerima);
            this.Controls.Add(this.kotaPengirim);
            this.Controls.Add(this.provinsiPengirim);
            this.Font = new System.Drawing.Font("Montserrat", 10F);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ongkir";
            this.Text = "Ongkir";
            this.tableLayoutPanelOngkir.ResumeLayout(false);
            this.tableLayoutPanelOngkir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox kotaPengirim;
        private System.Windows.Forms.ComboBox provinsiPengirim;
        private System.Windows.Forms.ComboBox kotaPenerima;
        private System.Windows.Forms.ComboBox provinsiPenerima;
        private System.Windows.Forms.Label labelKGBarang;
        private System.Windows.Forms.TextBox beratBarang;
        private System.Windows.Forms.Label labelBeratBarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxAsuransiBarang;
        private System.Windows.Forms.CheckBox checkBoxDimensiBarang;
        private System.Windows.Forms.Label labelCMTinggiBarang;
        private System.Windows.Forms.Label labelCMLebarBarang;
        private System.Windows.Forms.Label labelRPBarang;
        private System.Windows.Forms.Label labelCMPanjangBarang;
        private System.Windows.Forms.TextBox hargaBarang;
        private System.Windows.Forms.TextBox tinggiBarang;
        private System.Windows.Forms.TextBox lebarBarang;
        private System.Windows.Forms.TextBox panjangBarang;
        private System.Windows.Forms.Label labelHargaBarang;
        private System.Windows.Forms.Label labelNotifBarang;
        private System.Windows.Forms.Label labelDimensiBarangNotif;
        private System.Windows.Forms.Label labelTinggiBarang;
        private System.Windows.Forms.Label labelLebarBarang;
        private System.Windows.Forms.Label labelPanjangBarang;
        private System.Windows.Forms.Label labelHargaBarangNotif;
        private System.Windows.Forms.Button buttonCekOngkir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOngkir;
        private System.Windows.Forms.Label labelAsuransiEkonomi;
        private System.Windows.Forms.Label labelAsuransiReguler;
        private System.Windows.Forms.Label labelAsuransiEkspress;
        private System.Windows.Forms.Label labelOngkirEkonomi;
        private System.Windows.Forms.Label labelOngkirReguler;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotalEkonomi;
        private System.Windows.Forms.Label labelTotalReguler;
        private System.Windows.Forms.Label labelTotalEkspress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelOngkirEkspress;
    }
}