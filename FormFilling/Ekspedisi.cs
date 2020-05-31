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
    public partial class Ekspedisi : Form
    {
        Bitmap nullBitmap = new Bitmap(1, 1);
        public static string pengirimNama = "", pengirimTelepon = "", pengirimProvinsi = "", pengirimKota = "", pengirimAlamat = "", pengirimKodePos = "";
        public static string penerimaNama = "", penerimaTelepon = "", penerimaProvinsi = "", penerimaKota = "", penerimaAlamat = "", penerimaKodePos = "";
        public static string barangNama = "", barangLayanan = "", barangJumlah = "", barangBerat = "", barangPanjang = "", barangLebar = "", barangTinggi = "", barangHarga = "", barangAsuransi = "", barangBiayaAsuransi = "";
        public static string kirimResi = "";
        public static double biayaKirim = 0, biayaAsuransi = 0;
        public static bool barangDimensi = false;
        public static string waktuKirim = "";

        public Ekspedisi()
        {
            InitializeComponent();
            pictureBoxSideLogo.Image = nullBitmap;
        }

        private void hideSubMenu()
        {
            if (panelKirimSubMenu.Visible == true)
                panelKirimSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
        }

        private void buttonKirim_Click(object sender, EventArgs e)
        {
            buttonClose.Visible = true;
            labelTitle.Text = "KIRIM";
            showLogo();
            showSubMenu(panelKirimSubMenu);
            unactiveButtonSubMenu(buttonPengirim);
            unactiveButtonSubMenu(buttonPenerima);
            unactiveButtonSubMenu(buttonBarang);
            unactiveButtonMenu(buttonLacak);
            unactiveButtonMenu(buttonOngkir);
            activeButton(buttonKirim);
            openChildForm(new Kirim());
        }
        
        private void buttonPengirim_Click(object sender, EventArgs e)
        {
            buttonClose.Visible = true;
            labelTitle.Text = "PENGIRIM";
            showLogo();
            unactiveButtonMenu(buttonKirim);
            unactiveButtonSubMenu(buttonPenerima);
            unactiveButtonSubMenu(buttonBarang);
            unactiveButtonMenu(buttonLacak);
            unactiveButtonMenu(buttonOngkir);
            activeButton(buttonPengirim);
            openChildForm(new Pengirim());
        }

        private void buttonPenerima_Click(object sender, EventArgs e)
        {
            buttonClose.Visible = true;
            labelTitle.Text = "PENERIMA";
            showLogo();
            unactiveButtonMenu(buttonKirim);
            unactiveButtonSubMenu(buttonPengirim);
            unactiveButtonSubMenu(buttonBarang);
            unactiveButtonMenu(buttonLacak);
            unactiveButtonMenu(buttonOngkir);
            activeButton(buttonPenerima);
            openChildForm(new Penerima());
        }

        private void buttonBarang_Click(object sender, EventArgs e)
        {

            buttonClose.Visible = true;
            labelTitle.Text = "BARANG";
            showLogo();
            unactiveButtonMenu(buttonKirim);
            unactiveButtonSubMenu(buttonPengirim);
            unactiveButtonSubMenu(buttonPenerima);
            unactiveButtonMenu(buttonLacak);
            unactiveButtonMenu(buttonOngkir);
            activeButton(buttonBarang);
            openChildForm(new Barang());
        }

        private void buttonLacak_Click(object sender, EventArgs e)
        {
            buttonClose.Visible = true;
            labelTitle.Text = "LACAK";
            showLogo();
            hideSubMenu();
            unactiveButtonMenu(buttonKirim);
            unactiveButtonSubMenu(buttonPengirim);
            unactiveButtonSubMenu(buttonPenerima);
            unactiveButtonSubMenu(buttonBarang);
            unactiveButtonMenu(buttonOngkir);
            activeButton(buttonLacak);
            openChildForm(new Lacak());
        }

        private void buttonOngkir_Click(object sender, EventArgs e)
        {
            buttonClose.Visible = true;
            labelTitle.Text = "CEK ONGKOS KIRIM";
            showLogo();
            hideSubMenu();
            unactiveButtonMenu(buttonKirim);
            unactiveButtonSubMenu(buttonPengirim);
            unactiveButtonSubMenu(buttonPenerima);
            unactiveButtonSubMenu(buttonBarang);
            unactiveButtonMenu(buttonLacak);
            activeButton(buttonOngkir);
            openChildForm(new Ongkir());
        }

        private Form activeForm;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void closeChildForm()
        {
            activeForm.Close();
        }

        private void pictureBoxSideLogo_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                closeChildForm();
            pictureBoxSideLogo.Image = nullBitmap;
            buttonClose.Visible = false;
            labelTitle.Text = "BURAQ EXPRESS";
            hideSubMenu();
            unactiveButtonMenu(buttonKirim);
            unactiveButtonSubMenu(buttonPengirim);
            unactiveButtonSubMenu(buttonPenerima);
            unactiveButtonSubMenu(buttonBarang);
            unactiveButtonMenu(buttonLacak);
            unactiveButtonMenu(buttonOngkir);
        }

        private void panelLogo_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                closeChildForm();
                pictureBoxSideLogo.Image = nullBitmap;
            }
            else
                showLogo();
            hideSubMenu();
            unactiveButtonMenu(buttonKirim);
            unactiveButtonSubMenu(buttonPengirim);
            unactiveButtonSubMenu(buttonPenerima);
            unactiveButtonSubMenu(buttonBarang);
            unactiveButtonMenu(buttonLacak);
            unactiveButtonMenu(buttonOngkir);
        }

        private void showLogo()
        {
            pictureBoxSideLogo.Visible = true;
            pictureBoxSideLogo.Image = Properties.Resources.buraq;
        }

        private void activeButton(Button button)
        {
            button.BackColor = Color.FromArgb(111, 75, 165);
        }

        private void unactiveButtonMenu(Button button)
        {
            button.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void unactiveButtonSubMenu(Button button)
        {
            button.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.Transparent;
        }

        private void buttonClose_MouseEnter(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.FromArgb(231, 76, 60);
        }

        private void labelTitle_Paint(object sender, PaintEventArgs e)
        {
            int a = panelTop.Width - labelTitle.Width;
            int b = panelTop.Height - labelTitle.Height;
            labelTitle.Left = a / 2;
            labelTitle.Top = b / 2;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                closeChildForm();
            pictureBoxSideLogo.Image = nullBitmap;
            buttonClose.Visible = false;
            labelTitle.Text = "BURAQ EXPRESS";
            hideSubMenu();
            unactiveButtonMenu(buttonKirim);
            unactiveButtonSubMenu(buttonPengirim);
            unactiveButtonSubMenu(buttonPenerima);
            unactiveButtonSubMenu(buttonBarang);
            unactiveButtonMenu(buttonLacak);
            unactiveButtonMenu(buttonOngkir);
        }

        private void pictureBoxMainLogo_Paint(object sender, PaintEventArgs e)
        {
            int a = panelChildForm.Width - pictureBoxMainLogo.Width;
            int b = panelChildForm.Height - pictureBoxMainLogo.Height;
            pictureBoxMainLogo.Left = a / 2;
            pictureBoxMainLogo.Top = b / 2;
        }
    }
}