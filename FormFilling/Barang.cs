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
    public partial class Barang : Form
    {
        private double layanan = 0;
        public Barang()
        {
            InitializeComponent();
            this.ActiveControl = namaBarang;

            namaBarang.Text = Ekspedisi.barangNama;
            layananBarang.Text = Ekspedisi.barangLayanan;
            jumlahBarang.Text = Ekspedisi.barangJumlah;
            beratBarang.Text = Ekspedisi.barangBerat;

            if (Ekspedisi.barangDimensi == true)
            {
                checkBoxDimensiBarang.Checked = true;
                panjangBarang.Text = Ekspedisi.barangPanjang;
                lebarBarang.Text = Ekspedisi.barangLebar;
                tinggiBarang.Text = Ekspedisi.barangTinggi;
            }
            else
            {
                checkBoxDimensiBarang.Checked = false;
                panjangBarang.Text = "";
                lebarBarang.Text = "";
                tinggiBarang.Text = "";
            }
            if (Ekspedisi.barangAsuransi == "Ya")
            {
                checkBoxAsuransiBarang.Checked = true;
                hargaBarang.Text = Ekspedisi.barangHarga;
                labelRPAsuransi.Text = Ekspedisi.barangBiayaAsuransi;
            }
            else
            {
                checkBoxAsuransiBarang.Checked = false;
                hargaBarang.Text = "";
                labelRPAsuransi.Text = "Rp. ";
            }

            panelSimpanBarang.Width = this.Width;
            panelSimpanBarang.Height = this.Height;
            panelSimpanBarang.Dock = DockStyle.Fill;
            panelSimpanBarang.BringToFront();
        }

        private void angkaBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void labelSimpanBarang_Paint(object sender, PaintEventArgs e)
        {
            int a = panelSimpanBarang.Width - labelSimpanBarang.Width;
            int b = panelSimpanBarang.Height - labelSimpanBarang.Height;
            labelSimpanBarang.Left = a / 2;
            labelSimpanBarang.Top = b / 6 * 3;
        }

        private void pictureBoxSimpanBarang_Paint(object sender, PaintEventArgs e)
        {
            int a = panelSimpanBarang.Width - pictureBoxSimpanBarang.Width;
            int b = panelSimpanBarang.Height - pictureBoxSimpanBarang.Height;
            pictureBoxSimpanBarang.Left = a / 2;
            pictureBoxSimpanBarang.Top = b / 6 * 2;
        }

        private void checkBoxDimensiBarang_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDimensiBarang.Checked)
            {
                panjangBarang.Visible = true;
                labelCMPanjangBarang.Visible = true;
                labelPanjangBarang.Visible = true;
                lebarBarang.Visible = true;
                labelCMLebarBarang.Visible = true;
                labelLebarBarang.Visible = true;
                tinggiBarang.Visible = true;
                labelCMTinggiBarang.Visible = true;
                labelTinggiBarang.Visible = true;
            }
            else
            {
                panjangBarang.Visible = false;
                labelCMPanjangBarang.Visible = false;
                labelPanjangBarang.Visible = false;
                lebarBarang.Visible = false;
                labelCMLebarBarang.Visible = false;
                labelLebarBarang.Visible = false;
                tinggiBarang.Visible = false;
                labelCMTinggiBarang.Visible = false;
                labelTinggiBarang.Visible = false;
                panjangBarang.Text = "";
                lebarBarang.Text = "";
                tinggiBarang.Text = "";
                labelDimensiBarangNotif.Visible = false;
            }
        }

        private void checkBoxAsuransiBarang_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAsuransiBarang.Checked)
            {
                labelHargaBarang.Visible = true;
                labelRPBarang.Visible = true;
                hargaBarang.Visible = true;
                labelBiayaAsuransiBarang.Visible = true;
                labelRPAsuransi.Visible = true;
                labelCekAsuransiBarang.Visible = true;
            }
            else
            {
                labelHargaBarang.Visible = false;
                labelRPBarang.Visible = false;
                hargaBarang.Visible = false;
                labelBiayaAsuransiBarang.Visible = false;
                labelRPAsuransi.Visible = false;
                labelCekAsuransiBarang.Visible = false;
                hargaBarang.Text = "";
                labelRPAsuransi.Text = "Rp. ";
                labelHargaBarangNotif.Visible = false;
                labelBiayaAsuransiBarangNotif.Visible = false;
            }
        }

        private void buttonResetBarang_MouseEnter(object sender, EventArgs e)
        {
            buttonResetBarang.BackColor = Color.FromArgb(57, 53, 80);
        }

        private void buttonResetBarang_MouseLeave(object sender, EventArgs e)
        {
            buttonResetBarang.BackColor = Color.Transparent;
        }

        private void buttonResetBarang_Click(object sender, EventArgs e)
        {
            namaBarang.Text = "";
            layananBarang.SelectedItem = null;
            jumlahBarang.Text = "";
            beratBarang.Text = "";
            checkBoxDimensiBarang.Checked = false;
            panjangBarang.Text = "";
            lebarBarang.Text = "";
            tinggiBarang.Text = "";
            checkBoxAsuransiBarang.Checked = false;
            hargaBarang.Text = "";
            labelRPAsuransi.Text = "Rp. ";
            labelBiayaAsuransiBarangNotif.Visible = false;
            labelDimensiBarangNotif.Visible = false;
            labelHargaBarangNotif.Visible = false;
            labelNotifBarang.Visible = false;
        }

        private void labelCekAsuransiBarang_Click(object sender, EventArgs e)
        {
            if (hargaBarang.Text == "")
            {
                labelHargaBarangNotif.Visible = true;
                labelBiayaAsuransiBarangNotif.Visible = false;
                labelRPAsuransi.Text = "Rp. ";
            }
            else
            {
                labelHargaBarangNotif.Visible = false;
                labelBiayaAsuransiBarangNotif.Visible = true;
                labelRPAsuransi.Text = "Rp. " + (Double.Parse(hargaBarang.Text)*0.002).ToString();
                Ekspedisi.biayaAsuransi = Double.Parse(hargaBarang.Text) * 0.002;
            }
        }

        private void simpanBarang()
        {
            if (namaBarang.Text != "" && layananBarang.Text != "" && jumlahBarang.Text != "" && beratBarang.Text != "")
            {
                Ekspedisi.barangNama = namaBarang.Text;
                Ekspedisi.barangLayanan = layananBarang.Text;
                Ekspedisi.barangJumlah = jumlahBarang.Text;
                Ekspedisi.barangBerat = beratBarang.Text;
                Ekspedisi.barangDimensi = true;
                Ekspedisi.barangPanjang = panjangBarang.Text;
                Ekspedisi.barangLebar = lebarBarang.Text;
                Ekspedisi.barangTinggi = tinggiBarang.Text;
                Ekspedisi.barangAsuransi = "Ya";
                Ekspedisi.barangHarga = hargaBarang.Text;
                Ekspedisi.barangBiayaAsuransi = labelRPAsuransi.Text;
                Ekspedisi.biayaKirim = layanan * Double.Parse(beratBarang.Text);

                if (!checkBoxDimensiBarang.Checked)
                {
                    Ekspedisi.barangPanjang = "-";
                    Ekspedisi.barangLebar = "-";
                    Ekspedisi.barangTinggi = "-";
                    Ekspedisi.barangDimensi = false;
                }

                if (!checkBoxAsuransiBarang.Checked)
                {
                    Ekspedisi.biayaAsuransi = 0;
                    Ekspedisi.barangHarga = "-";
                    Ekspedisi.barangBiayaAsuransi = "-";
                    Ekspedisi.barangAsuransi = "Tidak";
                }
                labelNotifBarang.Visible = false;
                panelSimpanBarang.Visible = true;
            }
            else
                labelNotifBarang.Visible = true;
        }

        private void buttonBarang_Click(object sender, EventArgs e)
        {
            if (checkBoxDimensiBarang.Checked)
            {
                if (panjangBarang.Text == "" || lebarBarang.Text == "" || tinggiBarang.Text == "")
                {
                    labelDimensiBarangNotif.Visible = true;
                    labelNotifBarang.Visible = true;
                }
                else
                {
                    labelDimensiBarangNotif.Visible = false;
                    labelNotifBarang.Visible = false;

                    if (checkBoxAsuransiBarang.Checked)
                    {
                        if (hargaBarang.Text == "")
                        {
                            labelBiayaAsuransiBarangNotif.Visible = true;
                            labelNotifBarang.Visible = true;
                        }
                        else
                        {
                            labelBiayaAsuransiBarangNotif.Visible = false;
                            labelNotifBarang.Visible = false;
                            simpanBarang();
                        }
                    }
                    else
                        simpanBarang();
                }
            }
            else
            {
                if (checkBoxAsuransiBarang.Checked)
                {
                    if (hargaBarang.Text == "")
                    {
                        labelBiayaAsuransiBarangNotif.Visible = true;
                        labelNotifBarang.Visible = true;
                    }
                    else
                    {
                        labelBiayaAsuransiBarangNotif.Visible = false;
                        labelNotifBarang.Visible = false;
                        simpanBarang();
                    }
                }
                else
                    simpanBarang();
            }
        }

        private void layananBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).SelectedItem as string)
            {
                case "Ekonomi":
                    layanan = 5000;
                    break;

                case "Reguler":
                    layanan = 10000;
                    break;

                case "Ekspress":
                    layanan = 15000;
                    break;
            }
        }
    }
}
