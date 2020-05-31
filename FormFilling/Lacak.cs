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
    public partial class Lacak : Form
    {
        public Lacak()
        {
            InitializeComponent();
            textBoxNomorResi.Left = (this.Width - textBoxNomorResi.Width) / 2;
            panelDetailResi.Width = this.Width;
            panelDetailResi.BringToFront();
        }

        private void labelInputCekResi_Paint(object sender, PaintEventArgs e)
        {
            int a = this.Width - labelInputCekResi.Width;
            labelInputCekResi.Left = a / 2;
        }

        private void textBoxNomorResi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonCekResi_Paint(object sender, PaintEventArgs e)
        {
            int a = this.Width - buttonCekResi.Width;
            buttonCekResi.Left = a / 2;
        }

        private void buttonCekResi_Click(object sender, EventArgs e)
        {
            if (textBoxNomorResi.Text == Ekspedisi.kirimResi && textBoxNomorResi.Text != "")
            {
                labelResiNotif.Visible = false;
                labelNoResi.Text = Ekspedisi.kirimResi;
                labelLayanan.Text = Ekspedisi.barangLayanan;
                labelTanggalKirim.Text = Ekspedisi.waktuKirim;
                labelNamaPengirim.Text = Ekspedisi.pengirimNama;
                labelNamaPenerima.Text = Ekspedisi.penerimaNama;
                labelKotaPengirim.Text = Ekspedisi.pengirimKota + ", " + Ekspedisi.pengirimProvinsi;
                labelKotaPenerima.Text = Ekspedisi.penerimaKota + ", " + Ekspedisi.penerimaProvinsi;
                labelTanggal.Text = Ekspedisi.waktuKirim;
                labelKeterangan.Text = labelKeterangan.Text + "[" + Ekspedisi.pengirimKota + "]";
                panelDetailResi.Visible = true;
            }
            else
            {
                labelResiNotif.Visible = true;
                panelDetailResi.Visible = false;
            }
        }
    }
}
