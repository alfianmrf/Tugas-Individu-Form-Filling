using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormFilling
{
    public partial class Kirim : Form
    {
        public Kirim()
        {
            InitializeComponent();

            labelPengirimNama.Text = Ekspedisi.pengirimNama;
            labelPengirimTelepon.Text = Ekspedisi.pengirimTelepon;
            labelPengirimAsal.Text = Ekspedisi.pengirimKota + ", " + Ekspedisi.pengirimProvinsi;
            labelPengirimAlamat.Text = Ekspedisi.pengirimAlamat;
            labelPengirimKodePos.Text = Ekspedisi.pengirimKodePos;

            labelPenerimaNama.Text = Ekspedisi.penerimaNama;
            labelPenerimaTelepon.Text = Ekspedisi.penerimaTelepon;
            labelPenerimaTujuan.Text = Ekspedisi.penerimaKota + ", " + Ekspedisi.penerimaProvinsi;
            labelPenerimaAlamat.Text = Ekspedisi.penerimaAlamat;
            labelPenerimaKodePos.Text = Ekspedisi.penerimaKodePos;

            labelBarangNama.Text = Ekspedisi.barangNama;
            labelBarangLayanan.Text = Ekspedisi.barangLayanan;
            labelBarangJumlah.Text = Ekspedisi.barangJumlah + " Pcs";
            labelBarangBerat.Text = Ekspedisi.barangBerat + " KG";
            labelBarangAsuransi.Text += Ekspedisi.barangAsuransi;

            panelKirimResi.Width = this.Width;
            panelKirimResi.Height = this.Height;
            panelKirimResi.Dock = DockStyle.Fill;
            panelKirimResi.BringToFront();
        }

        private void labelPengirim_Paint(object sender, PaintEventArgs e)
        {
            int a = panelPengirimTop.Width - labelPengirim.Width;
            int b = panelPengirimTop.Height - labelPengirim.Height;
            labelPengirim.Left = a / 2;
            labelPengirim.Top = b / 2;
        }

        private void labelPenerima_Paint(object sender, PaintEventArgs e)
        {
            int a = panelPenerimaTop.Width - labelPenerima.Width;
            int b = panelPenerimaTop.Height - labelPenerima.Height;
            labelPenerima.Left = a / 2;
            labelPenerima.Top = b / 2;
        }

        private void labelBarang_Paint(object sender, PaintEventArgs e)
        {
            int a = panelBarangTop.Width - labelBarang.Width;
            int b = panelBarangTop.Height - labelBarang.Height;
            labelBarang.Left = a / 2;
            labelBarang.Top = b / 2;
        }

        private void labelPengirimNama_Paint(object sender, PaintEventArgs e)
        {
            int a = panelPengirim.Width - labelPengirimNama.Width;
            int b = panelPengirim.Height - labelPengirimNama.Height;
            labelPengirimNama.Left = a / 2;
            labelPengirimNama.Top = b / 8 * 2;
        }

        private void labelPengirimTelepon_Paint(object sender, PaintEventArgs e)
        {
            int a = panelPengirim.Width - labelPengirimTelepon.Width;
            int b = panelPengirim.Height - labelPengirimTelepon.Height;
            labelPengirimTelepon.Left = a / 2;
            labelPengirimTelepon.Top = b / 8 * 3;
        }

        private void labelPengirimAsal_Paint(object sender, PaintEventArgs e)
        {
            int a = panelPengirim.Width - labelPengirimAsal.Width;
            int b = panelPengirim.Height - labelPengirimAsal.Height;
            labelPengirimAsal.Left = a / 2;
            labelPengirimAsal.Top = b / 8 * 4;
        }

        private void labelPengirimAlamat_Paint(object sender, PaintEventArgs e)
        {
            int a = panelPengirim.Width - labelPengirimAlamat.Width;
            int b = panelPengirim.Height - labelPengirimAlamat.Height;
            labelPengirimAlamat.Left = a / 2;
            labelPengirimAlamat.Top = b / 8 * 5;
        }

        private void labelPengirimKodePos_Paint(object sender, PaintEventArgs e)
        {
            int a = panelPengirim.Width - labelPengirimKodePos.Width;
            int b = panelPengirim.Height - labelPengirimKodePos.Height;
            labelPengirimKodePos.Left = a / 2;
            labelPengirimKodePos.Top = b / 8 * 6;
        }

        private void labelKosong_Paint(object sender, PaintEventArgs e)
        {
            int a = panelPengirim.Width - labelPengirimKosong.Width;
            int b = panelPengirim.Height - labelPengirimKosong.Height;
            labelPengirimKosong.Left = a / 2;
            labelPengirimKosong.Top = b / 2;

            if (labelPengirimNama.Text != "" && labelPengirimTelepon.Text != "" && labelPengirimAsal.Text != "" && labelPengirimAlamat.Text != "" && labelPengirimKodePos.Text != "")
                labelPengirimKosong.Visible = false;
        }

        private void labelPenerimaNama_Paint(object sender, PaintEventArgs e)
        {
            int a = panelPenerima.Width - labelPenerimaNama.Width;
            int b = panelPengirim.Height - labelPenerimaNama.Height;
            labelPenerimaNama.Left = a / 2;
            labelPenerimaNama.Top = b / 8 * 2;
        }

        private void labelPenerimaTelepon_Paint(object sender, PaintEventArgs e)
        {
            int a = panelPenerima.Width - labelPenerimaTelepon.Width;
            int b = panelPenerima.Height - labelPenerimaTelepon.Height;
            labelPenerimaTelepon.Left = a / 2;
            labelPenerimaTelepon.Top = b / 8 * 3;
        }

        private void labelPenerimaAsal_Paint(object sender, PaintEventArgs e)
        {
            int a = panelPenerima.Width - labelPenerimaTujuan.Width;
            int b = panelPenerima.Height - labelPenerimaTujuan.Height;
            labelPenerimaTujuan.Left = a / 2;
            labelPenerimaTujuan.Top = b / 8 * 4;
        }

        private void labelPenerimaAlamat_Paint(object sender, PaintEventArgs e)
        {
            int a = panelPenerima.Width - labelPenerimaAlamat.Width;
            int b = panelPenerima.Height - labelPenerimaAlamat.Height;
            labelPenerimaAlamat.Left = a / 2;
            labelPenerimaAlamat.Top = b / 8 * 5;
        }

        private void labelPenerimaKodePos_Paint(object sender, PaintEventArgs e)
        {
            int a = panelPenerima.Width - labelPenerimaKodePos.Width;
            int b = panelPenerima.Height - labelPenerimaKodePos.Height;
            labelPenerimaKodePos.Left = a / 2;
            labelPenerimaKodePos.Top = b / 8 * 6;
        }

        private void labelPenerimaKosong_Paint(object sender, PaintEventArgs e)
        {
            int a = panelPenerima.Width - labelPenerimaKosong.Width;
            int b = panelPenerima.Height - labelPenerimaKosong.Height;
            labelPenerimaKosong.Left = a / 2;
            labelPenerimaKosong.Top = b / 2;

            if (labelPenerimaNama.Text != "" && labelPenerimaTelepon.Text != "" && labelPenerimaTujuan.Text != "" && labelPenerimaAlamat.Text != "" && labelPenerimaKodePos.Text != "")
                labelPenerimaKosong.Visible = false;
        }

        private void labelBarangKosong_Paint(object sender, PaintEventArgs e)
        {
            int a = panelBarang.Width - labelBarangKosong.Width;
            int b = panelBarang.Height - labelBarangKosong.Height;
            labelBarangKosong.Left = a / 2;
            labelBarangKosong.Top = b / 2;

            if (labelBarangNama.Text == "")
            {
                labelBarangKosong.Visible = true;
                labelBarangJumlah.Visible = false;
                labelBarangBerat.Visible = false;
                labelBarangAsuransi.Visible = false;
            }
            else
            {
                labelBarangKosong.Visible = false;
                labelBarangJumlah.Visible = true;
                labelBarangBerat.Visible = true;
                labelBarangAsuransi.Visible = true;
            }
        }

        private void labelBarangNama_Paint(object sender, PaintEventArgs e)
        {
            int a = panelBarang.Width - labelBarangNama.Width;
            int b = panelBarang.Height - labelBarangNama.Height;
            labelBarangNama.Left = a / 2;
            labelBarangNama.Top = b / 8 * 2;
        }

        private void labelBarangLayanan_Paint(object sender, PaintEventArgs e)
        {
            int a = panelBarang.Width - labelBarangLayanan.Width;
            int b = panelBarang.Height - labelBarangLayanan.Height;
            labelBarangLayanan.Left = a / 2;
            labelBarangLayanan.Top = b / 8 * 3;
        }

        private void labelBarangJumlah_Paint(object sender, PaintEventArgs e)
        {
            int a = panelBarang.Width - labelBarangJumlah.Width;
            int b = panelBarang.Height - labelBarangJumlah.Height;
            labelBarangJumlah.Left = a / 2;
            labelBarangJumlah.Top = b / 8 * 4;
        }

        private void labelBarangBerat_Paint(object sender, PaintEventArgs e)
        {
            int a = panelBarang.Width - labelBarangBerat.Width;
            int b = panelBarang.Height - labelBarangBerat.Height;
            labelBarangBerat.Left = a / 2;
            labelBarangBerat.Top = b / 8 * 5;
        }

        private void labelBarangAsuransi_Paint(object sender, PaintEventArgs e)
        {
            int a = panelBarang.Width - labelBarangAsuransi.Width;
            int b = panelBarang.Height - labelBarangAsuransi.Height;
            labelBarangAsuransi.Left = a / 2;
            labelBarangAsuransi.Top = b / 8 * 6;
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("dd-MM-yyyy HH:mm");
        }
        private void buttonKirimResi_Click(object sender, EventArgs e)
        {
            if(labelPengirimKosong.Visible==false && labelPenerimaKosong.Visible==false && labelBarangKosong.Visible==false)
            {
                if (Ekspedisi.kirimResi == "")
                {
                    Ekspedisi.kirimResi = RandomString(10);
                }
                if (labelResiPengirim.Text == "Pengirim : ")
                {
                    labelResiPengirim.Text = labelResiPengirim.Text + Ekspedisi.pengirimNama;
                    labelResiAlamatPengirim.Text = Ekspedisi.pengirimTelepon + ", " + Ekspedisi.pengirimAlamat;
                    labelResiKotaPengirim.Text = Ekspedisi.pengirimKota + ", " + Ekspedisi.pengirimProvinsi + " - " + Ekspedisi.pengirimKodePos;
                }
                if (labelResiPenerima.Text == "Penerima : ")
                {
                    labelResiPenerima.Text = labelResiPenerima.Text + Ekspedisi.penerimaNama;
                    labelResiAlamatPenerima.Text = Ekspedisi.penerimaTelepon + ", " + Ekspedisi.penerimaAlamat;
                    labelResiKotaPenerima.Text = Ekspedisi.penerimaKota + ", " + Ekspedisi.penerimaProvinsi + " - " + Ekspedisi.penerimaKodePos;
                }
                labelResi.Text = Ekspedisi.kirimResi;
                labelResiBerat.Text = Ekspedisi.barangBerat + " KG";
                labelResiLayanan.Text = Ekspedisi.barangLayanan;
                labelResiBiaya.Text = labelResiBiaya.Text + "Rp. " + Ekspedisi.biayaKirim.ToString();
                if (Ekspedisi.biayaAsuransi == 0)
                {
                    labelResiAsuransi.Text = labelResiAsuransi.Text + "-";
                }
                else
                {
                    labelResiAsuransi.Text = labelResiAsuransi.Text + "Rp. " + Ekspedisi.biayaAsuransi.ToString();
                }
                labelResiBiayaTotal.Text += (Ekspedisi.biayaKirim + Ekspedisi.biayaAsuransi).ToString();
                Ekspedisi.waktuKirim = GetTimestamp(DateTime.Now);
                labelLengkap.Visible = false;
                panelKirimResi.Visible = true;
                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                pictureBoxBarCode.Image = barcode.Draw(labelResi.Text, 50);
                pictureBoxBarCode.SizeMode = PictureBoxSizeMode.StretchImage;
                Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                pictureBoxQRCode.Image = qrcode.Draw(labelResi.Text, 50);
                pictureBoxQRCode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                labelLengkap.Visible = true;
            }
        }

        private void labelResiBerat_Paint(object sender, PaintEventArgs e)
        {
            int a = panelResiBerat.Width - labelResiBerat.Width;
            int b = panelResiBerat.Height - labelResiBerat.Height;
            labelResiBerat.Left = a / 2;
            labelResiBerat.Top = b / 2;
        }

        private void labelResiLayanan_Paint(object sender, PaintEventArgs e)
        {
            int a = panelResiLayanan.Width - labelResiLayanan.Width;
            int b = panelResiLayanan.Height - labelResiLayanan.Height;
            labelResiLayanan.Left = a / 2;
            labelResiLayanan.Top = b / 2;
        }

        private void labelResiTotal_Paint(object sender, PaintEventArgs e)
        {
            int a = panelResiTotal.Width - labelResiTotal.Width;
            labelResiTotal.Left = a / 2;
        }

        private void labelResiBiayaTotal_Paint(object sender, PaintEventArgs e)
        {
            int a = panelResiTotal.Width - labelResiBiayaTotal.Width;
            labelResiBiayaTotal.Left = a / 2;
        }
    }
}
