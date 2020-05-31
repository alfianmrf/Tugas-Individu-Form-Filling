namespace FormFilling
{
    partial class Lacak
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
            this.labelInputCekResi = new System.Windows.Forms.Label();
            this.textBoxNomorResi = new System.Windows.Forms.TextBox();
            this.buttonCekResi = new System.Windows.Forms.Button();
            this.panelDetailResi = new System.Windows.Forms.Panel();
            this.labelDetailResi = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNoResi = new System.Windows.Forms.Label();
            this.labelLayanan = new System.Windows.Forms.Label();
            this.labelTanggalKirim = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelNamaPengirim = new System.Windows.Forms.Label();
            this.labelKotaPenerima = new System.Windows.Forms.Label();
            this.labelNamaPenerima = new System.Windows.Forms.Label();
            this.labelKotaPengirim = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.labelKeterangan = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.labelResiNotif = new System.Windows.Forms.Label();
            this.panelDetailResi.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInputCekResi
            // 
            this.labelInputCekResi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInputCekResi.AutoSize = true;
            this.labelInputCekResi.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelInputCekResi.Location = new System.Drawing.Point(242, 50);
            this.labelInputCekResi.Name = "labelInputCekResi";
            this.labelInputCekResi.Size = new System.Drawing.Size(195, 22);
            this.labelInputCekResi.TabIndex = 0;
            this.labelInputCekResi.Text = "Masukkan Nomor Resi";
            this.labelInputCekResi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelInputCekResi.Paint += new System.Windows.Forms.PaintEventHandler(this.labelInputCekResi_Paint);
            // 
            // textBoxNomorResi
            // 
            this.textBoxNomorResi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNomorResi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNomorResi.Location = new System.Drawing.Point(156, 89);
            this.textBoxNomorResi.MaxLength = 12;
            this.textBoxNomorResi.Name = "textBoxNomorResi";
            this.textBoxNomorResi.Size = new System.Drawing.Size(360, 24);
            this.textBoxNomorResi.TabIndex = 1;
            this.textBoxNomorResi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNomorResi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNomorResi_KeyPress);
            // 
            // buttonCekResi
            // 
            this.buttonCekResi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCekResi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.buttonCekResi.FlatAppearance.BorderSize = 0;
            this.buttonCekResi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCekResi.Font = new System.Drawing.Font("Montserrat", 10F);
            this.buttonCekResi.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCekResi.Location = new System.Drawing.Point(283, 132);
            this.buttonCekResi.Name = "buttonCekResi";
            this.buttonCekResi.Size = new System.Drawing.Size(100, 30);
            this.buttonCekResi.TabIndex = 11;
            this.buttonCekResi.Text = "Cek";
            this.buttonCekResi.UseVisualStyleBackColor = false;
            this.buttonCekResi.Click += new System.EventHandler(this.buttonCekResi_Click);
            this.buttonCekResi.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonCekResi_Paint);
            // 
            // panelDetailResi
            // 
            this.panelDetailResi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDetailResi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelDetailResi.Controls.Add(this.tableLayoutPanel4);
            this.panelDetailResi.Controls.Add(this.tableLayoutPanel3);
            this.panelDetailResi.Controls.Add(this.tableLayoutPanel2);
            this.panelDetailResi.Controls.Add(this.tableLayoutPanel1);
            this.panelDetailResi.Controls.Add(this.labelDetailResi);
            this.panelDetailResi.Location = new System.Drawing.Point(0, 168);
            this.panelDetailResi.Name = "panelDetailResi";
            this.panelDetailResi.Size = new System.Drawing.Size(686, 346);
            this.panelDetailResi.TabIndex = 51;
            this.panelDetailResi.Visible = false;
            // 
            // labelDetailResi
            // 
            this.labelDetailResi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDetailResi.AutoSize = true;
            this.labelDetailResi.Font = new System.Drawing.Font("Montserrat", 12F);
            this.labelDetailResi.ForeColor = System.Drawing.Color.LightGray;
            this.labelDetailResi.Location = new System.Drawing.Point(14, 11);
            this.labelDetailResi.Name = "labelDetailResi";
            this.labelDetailResi.Size = new System.Drawing.Size(94, 22);
            this.labelDetailResi.TabIndex = 1;
            this.labelDetailResi.Text = "Detail Resi";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.46688F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.53312F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 329F));
            this.tableLayoutPanel1.Controls.Add(this.labelTanggalKirim, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelLayanan, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelNoResi, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 47);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(647, 70);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(44, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nomor Resi";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(214, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Layanan";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(407, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tanggal Pengiriman";
            // 
            // labelNoResi
            // 
            this.labelNoResi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNoResi.AutoSize = true;
            this.labelNoResi.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelNoResi.ForeColor = System.Drawing.Color.LightGray;
            this.labelNoResi.Location = new System.Drawing.Point(30, 42);
            this.labelNoResi.Name = "labelNoResi";
            this.labelNoResi.Size = new System.Drawing.Size(119, 19);
            this.labelNoResi.TabIndex = 6;
            this.labelNoResi.Text = "1234567890QW";
            // 
            // labelLayanan
            // 
            this.labelLayanan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLayanan.AutoSize = true;
            this.labelLayanan.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelLayanan.ForeColor = System.Drawing.Color.LightGray;
            this.labelLayanan.Location = new System.Drawing.Point(212, 42);
            this.labelLayanan.Name = "labelLayanan";
            this.labelLayanan.Size = new System.Drawing.Size(70, 19);
            this.labelLayanan.TabIndex = 7;
            this.labelLayanan.Text = "Ekspress";
            // 
            // labelTanggalKirim
            // 
            this.labelTanggalKirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTanggalKirim.AutoSize = true;
            this.labelTanggalKirim.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelTanggalKirim.ForeColor = System.Drawing.Color.LightGray;
            this.labelTanggalKirim.Location = new System.Drawing.Point(416, 42);
            this.labelTanggalKirim.Name = "labelTanggalKirim";
            this.labelTanggalKirim.Size = new System.Drawing.Size(130, 19);
            this.labelTanggalKirim.TabIndex = 8;
            this.labelTanggalKirim.Text = "26-04-2000 09:55";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.labelKotaPengirim, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelKotaPenerima, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelNamaPengirim, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelNamaPenerima, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(18, 138);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(647, 105);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(126, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pengirim";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(447, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Penerima";
            // 
            // labelNamaPengirim
            // 
            this.labelNamaPengirim.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNamaPengirim.AutoSize = true;
            this.labelNamaPengirim.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelNamaPengirim.ForeColor = System.Drawing.Color.LightGray;
            this.labelNamaPengirim.Location = new System.Drawing.Point(4, 42);
            this.labelNamaPengirim.Name = "labelNamaPengirim";
            this.labelNamaPengirim.Size = new System.Drawing.Size(51, 19);
            this.labelNamaPengirim.TabIndex = 6;
            this.labelNamaPengirim.Text = "Nama";
            // 
            // labelKotaPenerima
            // 
            this.labelKotaPenerima.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelKotaPenerima.AutoSize = true;
            this.labelKotaPenerima.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelKotaPenerima.ForeColor = System.Drawing.Color.LightGray;
            this.labelKotaPenerima.Location = new System.Drawing.Point(327, 77);
            this.labelKotaPenerima.Name = "labelKotaPenerima";
            this.labelKotaPenerima.Size = new System.Drawing.Size(106, 19);
            this.labelKotaPenerima.TabIndex = 7;
            this.labelKotaPenerima.Text = "Kota, Provinsi";
            // 
            // labelNamaPenerima
            // 
            this.labelNamaPenerima.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNamaPenerima.AutoSize = true;
            this.labelNamaPenerima.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelNamaPenerima.ForeColor = System.Drawing.Color.LightGray;
            this.labelNamaPenerima.Location = new System.Drawing.Point(327, 42);
            this.labelNamaPenerima.Name = "labelNamaPenerima";
            this.labelNamaPenerima.Size = new System.Drawing.Size(51, 19);
            this.labelNamaPenerima.TabIndex = 8;
            this.labelNamaPenerima.Text = "Nama";
            // 
            // labelKotaPengirim
            // 
            this.labelKotaPengirim.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelKotaPengirim.AutoSize = true;
            this.labelKotaPengirim.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelKotaPengirim.ForeColor = System.Drawing.Color.LightGray;
            this.labelKotaPengirim.Location = new System.Drawing.Point(4, 77);
            this.labelKotaPengirim.Name = "labelKotaPengirim";
            this.labelKotaPengirim.Size = new System.Drawing.Size(106, 19);
            this.labelKotaPengirim.TabIndex = 9;
            this.labelKotaPengirim.Text = "Kota, Provinsi";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.39938F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.60062F));
            this.tableLayoutPanel3.Controls.Add(this.labelKeterangan, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelTanggal, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(18, 296);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(647, 35);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // labelTanggal
            // 
            this.labelTanggal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelTanggal.ForeColor = System.Drawing.Color.LightGray;
            this.labelTanggal.Location = new System.Drawing.Point(4, 8);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(130, 19);
            this.labelTanggal.TabIndex = 10;
            this.labelTanggal.Text = "26-04-2000 09:55";
            // 
            // labelKeterangan
            // 
            this.labelKeterangan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelKeterangan.AutoSize = true;
            this.labelKeterangan.Font = new System.Drawing.Font("Montserrat", 10F);
            this.labelKeterangan.ForeColor = System.Drawing.Color.LightGray;
            this.labelKeterangan.Location = new System.Drawing.Point(181, 8);
            this.labelKeterangan.Name = "labelKeterangan";
            this.labelKeterangan.Size = new System.Drawing.Size(255, 19);
            this.labelKeterangan.TabIndex = 11;
            this.labelKeterangan.Text = "Paket diterima oleh Buraq Express ";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(18, 262);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(647, 35);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(4, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Riwayat";
            // 
            // labelResiNotif
            // 
            this.labelResiNotif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResiNotif.AutoSize = true;
            this.labelResiNotif.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResiNotif.ForeColor = System.Drawing.Color.LightGray;
            this.labelResiNotif.Location = new System.Drawing.Point(405, 140);
            this.labelResiNotif.Name = "labelResiNotif";
            this.labelResiNotif.Size = new System.Drawing.Size(145, 15);
            this.labelResiNotif.TabIndex = 52;
            this.labelResiNotif.Text = "Nomor resi tidak tersedia";
            this.labelResiNotif.Visible = false;
            // 
            // Lacak
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.labelResiNotif);
            this.Controls.Add(this.panelDetailResi);
            this.Controls.Add(this.buttonCekResi);
            this.Controls.Add(this.textBoxNomorResi);
            this.Controls.Add(this.labelInputCekResi);
            this.Font = new System.Drawing.Font("Montserrat", 10F);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Name = "Lacak";
            this.Text = "Lacak";
            this.panelDetailResi.ResumeLayout(false);
            this.panelDetailResi.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInputCekResi;
        private System.Windows.Forms.TextBox textBoxNomorResi;
        private System.Windows.Forms.Button buttonCekResi;
        private System.Windows.Forms.Panel panelDetailResi;
        private System.Windows.Forms.Label labelDetailResi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelKeterangan;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelKotaPengirim;
        private System.Windows.Forms.Label labelKotaPenerima;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelNamaPengirim;
        private System.Windows.Forms.Label labelNamaPenerima;
        private System.Windows.Forms.Label labelTanggalKirim;
        private System.Windows.Forms.Label labelLayanan;
        private System.Windows.Forms.Label labelNoResi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelResiNotif;
    }
}