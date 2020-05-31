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
    public partial class Pengirim : Form
    {
        public Pengirim()
        {
            InitializeComponent();
            this.ActiveControl = namaPengirim;
            namaPengirim.Text = Ekspedisi.pengirimNama;
            teleponPengirim.Text = Ekspedisi.pengirimTelepon;
            provinsiPengirim.Text = Ekspedisi.pengirimProvinsi;
            kotaPengirim.Text = Ekspedisi.pengirimKota;
            alamatPengirim.Text = Ekspedisi.pengirimAlamat;
            kodePosPengirim.Text = Ekspedisi.pengirimKodePos;

            panelSimpanPengirim.Width = this.Width;
            panelSimpanPengirim.Height = this.Height;
            panelSimpanPengirim.Dock = DockStyle.Fill;
            panelSimpanPengirim.BringToFront();
        }

        private void angkaPengirim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void provinsiPengirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (provinsiPengirim.Text != null)
                kotaPengirim.Visible = true;
            else
                kotaPengirim.Visible = false;

            switch (((ComboBox)sender).SelectedItem as string)
            {
                case "":
                    kotaPengirim.Items.Clear();
                    break;

                case "Bali":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Badung", "Kabupaten Bangli", "Kabupaten Buleleng", "Kabupaten Gianyar", "Kabupaten Jembrana", "Kabupaten Karangasem", "Kabupaten Klungkung", "Kabupaten Tabanan", "Kota Denpasar" });
                    break;

                case "Bangka Belitung":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Bangka", "Kabupaten Bangka Barat", "Kabupaten Bangka Selatan", "Kabupaten Bangka Tengah", "Kabupaten Belitung", "Kabupaten Belitung Timur", "Kota Pangkalpinang" });
                    break;

                case "Banten":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Lebak", "Kabupaten Pandeglang", "Kabupaten Serang", "Kabupaten Tangerang", "Kota Cilegon", "Kota Serang", "Kota Tangerang", "Kota Tangerang Selatan" });
                    break;

                case "Bengkulu":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Bengkulu Selatan", "Kabupaten Bengkulu Tengah", "Kabupaten Bengkulu Utara", "Kabupaten Kaur", "Kabupaten Kepahiang", "Kabupaten Lebong", "Kabupaten Mukomuko", "Kabupaten Rejang Lebong", "Kabupaten Seluma", "Kota Bengkulu" });
                    break;

                case "DI Yogyakarta":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Bantul", "Kabupaten Gunungkidul", "Kabupaten Kulon Progo", "Kabupaten Sleman", "Kota Yogyakarta" });
                    break;

                case "DKI Jakarta":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Administrasi Kepulauan Seribu", "Kota Administrasi Jakarta Barat", "Kota Administrasi Jakarta Pusat", "Kota Administrasi Jakarta Selatan", "Kota Administrasi Jakarta Timur", "Kota Administrasi Jakarta Utara" });
                    break;

                case "Gorontalo":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Boalemo", "Kabupaten Bone Bolango", "Kabupaten Gorontalo", "Kabupaten Gorontalo Utara", "Kabupaten Pohuwato", "Kota Gorontalo" });
                    break;

                case "Jambi":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Batanghari", "Kabupaten Bungo", "Kabupaten Kerinci", "Kabupaten Merangin", "Kabupaten Muaro Jambi", "Kabupaten Sarolangun", "Kabupaten Tanjung Jabung Barat", "Kabupaten Tanjung Jabung Timur", "Kabupaten Tebo", "Kota Jambi", "Kota Sungaipenuh" });
                    break;

                case "Jawa Barat":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Bandung", "Kabupaten Bandung Barat", "Kabupaten Bekasi", "Kabupaten Bogor", "Kabupaten Ciamis", "Kabupaten Cianjur", "Kabupaten Cirebon", "Kabupaten Garut", "Kabupaten Indramayu", "Kabupaten Karawang", "Kabupaten Kuningan", "Kabupaten Majalengka", "Kabupaten Pangandaran", "Kabupaten Purwakarta", "Kabupaten Subang", "Kabupaten Sukabumi", "Kabupaten Sumedang", "Kabupaten Tasikmalaya", "Kota Bandung", "Kota Banjar", "Kota Bekasi", "Kota Bogor", "Kota Cimahi", "Kota Cirebon", "Kota Depok", "Kota Sukabumi", "Kota Tasikmalaya" });
                    break;

                case "Jawa Tengah":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Banjarnegara", "Kabupaten Banyumas", "Kabupaten Batang", "Kabupaten Blora", "Kabupaten Boyolali", "Kabupaten Brebes", "Kabupaten Cilacap", "Kabupaten Demak", "Kabupaten Grobogan", "Kabupaten Jepara", "Kabupaten Karanganyar", "Kabupaten Kebumen", "Kabupaten Kendal", "Kabupaten Klaten", "Kabupaten Kudus", "Kabupaten Magelang", "Kabupaten Pati", "Kabupaten Pekalongan", "Kabupaten Pemalang", "Kabupaten Purbalingga", "Kabupaten Purworejo", "Kabupaten Rembang", "Kabupaten Semarang", "Kabupaten Sragen", "Kabupaten Sukoharjo", "Kabupaten Tegal", "Kabupaten Temanggung", "Kabupaten Wonogiri", "Kabupaten Wonosobo", "Kota Magelang", "Kota Pekalongan", "Kota Salatiga", "Kota Semarang", "Kota Surakarta", "Kota Tegal" });
                    break;

                case "Jawa Timur":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Bangkalan", "Kabupaten Banyuwangi", "Kabupaten Blitar", "Kabupaten Bojonegoro", "Kabupaten Bondowoso", "Kabupaten Gresik", "Kabupaten Jember", "Kabupaten Jombang", "Kabupaten Kediri", "Kabupaten Lamongan", "Kabupaten Lumajang", "Kabupaten Madiun", "Kabupaten Magetan", "Kabupaten Malang", "Kabupaten Mojokerto", "Kabupaten Nganjuk", "Kabupaten Ngawi", "Kabupaten Pacitan", "Kabupaten Pamekasan", "Kabupaten Pasuruan", "Kabupaten Ponorogo", "Kabupaten Probolinggo", "Kabupaten Sampang", "Kabupaten Sidoarjo", "Kabupaten Situbondo", "Kabupaten Sumenep", "Kabupaten Trenggalek", "Kabupaten Tuban", "Kabupaten Tulungagung", "Kota Batu", "Kota Blitar", "Kota Kediri", "Kota Madiun", "Kota Malang", "Kota Mojokerto", "Kota Pasuruan", "Kota Probolinggo", "Kota Surabaya" });
                    break;

                case "Kalimantan Barat":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Bengkayang", "Kabupaten Kapuas hulu", "Kabupaten Kayong Utara", "Kabupaten Ketapang", "Kabupaten Kubu Raya", "Kabupaten Landak", "Kabupaten Melawi", "Kabupaten Mempawah", "Kabupaten Sambas", "Kabupaten Sanggau", "Kabupaten Sekadau", "Kabupaten Sintang", "Kota Pontianak", "Kota Singkawang" });
                    break;

                case "Kalimantan Selatan":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Balangan", "Kabupaten Banjar", "Kabupaten Barito Kuala", "Kabupaten Hulu Sungai Selatan", "Kabupaten Hulu Sungai Tengah", "Kabupaten Hulu Sungai Utara", "Kabupaten Kotabaru", "Kabupaten Tabalong", "Kabupaten Tanah Bumbu", "Kabupaten Tanah Laut", "Kabupaten Tapin", "Kota Banjarbaru", "Kota Banjarmasin" });
                    break;

                case "Kalimantan Tengah":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Barito Selatan", "Kabupaten Barito Timur", "Kabupaten Barito Utara", "Kabupaten Gunung Mas", "Kabupaten Kapuas", "Kabupaten Katingan", "Kabupaten Kotawaringin Barat", "Kabupaten Kotawaringin Timur", "Kabupaten Lamandau", "Kabupaten Murung Raya", "Kabupaten Pulang Pisau", "Kabupaten Sukamar", "Kabupaten Seruyan", "Kota Palangka Raya" });
                    break;

                case "Kalimantan Timur":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Berau", "Kabupaten Kutai Barat", "Kabupaten Kutai Kartanegara", "Kabupaten Kutai Timur", "Kabupaten Mahakam Ulu", "Kabupaten Paser", "Kabupaten Penajam Paser Utara", "Kota Balikpapan", "Kota Bontang", "Kota Samarinda" });
                    break;

                case "Kalimantan Utara":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Bulungan", "Kabupaten Malinau", "Kabupaten Nunukan", "Kabupaten Tana Tidung", "Kota Tarakan" });
                    break;

                case "Kepulauan Riau":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Bintan", "Kabupaten Karimun", "Kabupaten Kepulauan Anambas", "Kabupaten Lingga", "Kabupaten Natuna", "Kota Batam", "Kota Tanjungpinang" });
                    break;

                case "Lampung":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Lampung Barat", "Kabupaten Lampung Selatan", "Kabupaten Lampung Tengah", "Kabupaten Lampung Timur", "Kabupaten Lampung Utara", "Kabupaten Mesuji", "Kabupaten Pesawaran", "Kabupaten Pesisir Barat", "Kabupaten Pringsewu", "Kabupaten Tanggamus", "Kabupaten Tulang Bawang", "Kabupaten Tulang Bawang Barat", "Kabupaten Way Kanan", "Kota Bandar Lampung", "Kota Metro" });
                    break;

                case "Maluku":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Buru", "Kabupaten Buru Selatan", "Kabupaten Kepulauan Aru", "Kabupaten Maluku Barat Daya", "Kabupaten Maluku Tengah", "Kabupaten Maluku Tenggara", "Kabupaten Kepulauan Tanimbar", "Kabupaten Seram Bagian Barat", "Kabupaten Seram Bagian Timur", "Kota Ambon", "Kota Tual" });
                    break;

                case "Maluku Utara":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Halmahera Barat", "Kabupaten Halmahera Tengah", "Kabupaten Halmahera Timur", "Kabupaten Halmahera Selatan", "Kabupaten Halmahera Utara", "Kabupaten Kepulauan Sula", "Kabupaten Pulau Morotai", "Kabupaten Pulau Taliabu", "Kota Ternate", "Kota Tidore Kepulauan" });
                    break;

                case "Nanggroe Aceh Darussalam (NAD)":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Aceh Barat", "Kabupaten Aceh Barat Daya", "Kabupaten Aceh Besar", "Kabupaten Aceh Jaya", "Kabupaten Aceh Selatan", "Kabupaten Aceh Singkil", "Kabupaten Aceh Tamiang", "Kabupaten Aceh Tengah", "Kabupaten Aceh Tenggara", "Kabupaten Aceh Timur", "Kabupaten Aceh Utara", "Kabupaten Bener Meriah", "Kabupaten Bireuen", "Kabupaten Gayo Lues", "Kabupaten Nagan Raya", "Kabupaten Pidie", "Kabupaten Pidie Jaya", "Kabupaten Simeulue", "Kota Banda Aceh", "Kota Langsa", "Kota Lhoksumawe", "Kota Sabang", "Kota Subulussalam" });
                    break;

                case "Nusa Tenggara Barat (NTB)":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Bima", "Kabupaten Dompu", "Kabupaten Lombok Barat", "Kabupaten Lombok Tengah", "Kabupaten Lombok Timur", "Kabupaten Lombok Utara", "Kabupaten Sumbawa", "Kabupaten Sumbawa Barat", "Kota Bima", "Kota Mataram" });
                    break;

                case "Nusa Tenggara Timur (NTT)":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Alor", "Kabupaten Belu", "Kabupaten Ende", "Kabupaten Flores Timur", "Kabupaten Kupang", "Kabupaten Lembata", "Kabupaten Malaka", "Kabupaten Manggarai", "Kabupaten Manggarai Barat", "Kabupaten Manggarai Timur", "Kabupaten Nagekeo", "Kabupaten Ngada", "Kabupaten Rote Ndao", "Kabupaten Sabu Raijua", "Kabupaten Sikka", "Kabupaten Sumba Barat", "Kabupaten Sumba Barat Daya", "Kabupaten Sumba Tengah", "Kabupaten Sumba Timur", "Kabupaten Timor Tengah Selatan", "Kabupaten Timor Tengah Utara", "Kota Kupang" });
                    break;

                case "Papua":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Asmat", "Kabupaten Biak Numfor", "Kabupaten Boven Dogoel", "Kabupaten Deiyai", "Kabupaten Dogiyai", "Kabupaten Intan Jaya", "Kabupaten Jayapura", "Kabupaten Jayawijaya", "Kabupaten Keerom", "Kabupaten Kepulauan Yapen", "Kabupaten Lanny Jaya", "Kabupaten Mamberamo Raya", "Kabupaten Mamberamo Tengah", "Kabupaten Mappi", "Kabupaten Merauke", "Kabupaten Mimika", "Kabupaten Nabire", "Kabupaten Nduga", "Kabupaten Paniai", "Kabupaten Pegunungan Bintang", "Kabupaten Puncak", "Kabupaten Puncak Jaya", "Kabupaten Sarmi", "Kabupaten Supiori", "Kabupaten Tolikara", "Kabupaten Waropen", "Kabupaten Yahukimo", "Kabupaten Yalimo", "Kota Jayapura" });
                    break;

                case "Papua Barat":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Fakfak", "Kabupaten Kaimana", "Kabupaten Manokwari", "Kabupaten Manokwari Selatan", "Kabupaten Maybrat", "Kabupaten Pegunungan Arfak", "Kabupaten Raja Ampat", "Kabupaten Sorong", "Kabupaten Sorong Selatan", "Kabupaten Tambrauw", "Kabupaten Teluk Bintuni", "Kabupaten Teluk Wondama", "Kota Sorong" });
                    break;

                case "Riau":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Bengkalis", "Kabupaten Indragiri Hilir", "Kabupaten Indragiri Hulu", "Kabupaten Kampar", "Kabupaten Kepulauan Meranti", "Kabupaten Kuantan Singingi", "Kabupaten Pelalawan", "Kabupaten Rokan Hilir", "Kabupaten Rokan Hulu", "Kabupaten Siak", "Kota Dumai", "Kota Pekanbaru" });
                    break;

                case "Sulawesi Barat":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Majene", "Kabupaten Mamasa", "Kabupaten Mamuju", "Kabupaten Mamuju Tengah", "Kabupaten Pasangkayu", "Kabupaten Polewali Mandar" });
                    break;

                case "Sulawesi Selatan":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Bantaeng", "Kabupaten Barru", "Kabupaten Bone", "Kabupaten Bulukumba", "Kabupaten Enrekang", "Kabupaten Gowa", "Kabupaten Jeneponto", "Kabupaten Kepulauan Selayar", "Kabupaten Luwu", "Kabupaten Luwu Timur", "Kabupaten Luwu Utara", "Kabupaten Maros", "Kabupaten Pangkajene dan Kepulauan", "Kabupaten Pinrang", "Kabupaten Sidenreng Rappang", "Kabupaten Sinjau", "Kabupaten Soppeng", "Kabupaten Takalr", "Kabupaten Tana Toraja", "Kabupaten Toraja Utara", "Kabupaten Wajo", "Kota Makassar", "Kota Palopo", "Kota Parepare" });
                    break;

                case "Sulawesi Tengah":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Banggai", "Kabupaten Banggai Kepulauan", "Kabupaten Banggai Laut", "Kabupaten Buol", "Kabupaten Donggala", "Kabupaten Morowali", "Kabupaten Morowali Utara", "Kabupaten Parigi Moutong", "Kabupaten Poso", "Kabupaten Sigi", "Kabupaten Tojo Una-una", "Kabupaten Tolitoli", "Kota Palu" });
                    break;

                case "Sulawesi Tenggara":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Bombana", "Kabupaten Buton", "Kabupaten Buton Selatan", "Kabupaten Buton Tengah", "Kabupaten Buton Utara", "Kabupaten Kolaka", "Kabupaten Kolaka Timur", "Kabupaten Kolaka Utara", "Kabupaten Konawe", "Kabupaten Konawe Kepulauan", "Kabupaten Konawe Selatan", "Kabupaten Konawe Utara", "Kabupaten Muna", "Kabupaten Muna Barat", "Kabupaten Wakatobi", "Kota Bau-bau", "Kota Kendari" });
                    break;

                case "Sulawesi Utara":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Bolaang Mongondow", "Kabupaten Bolaang Mongondow Selatan", "Kabupaten Bolaang Mongondow Timur", "Kabupaten Bolaang Mongondow Utara", "Kabupaten Kepulauan Sangihe", "Kabupaten Kepulauan Siau Tagulandang Biaro", "Kabupaten Kepulauan Talaud", "Kabupaten Minahasa", "Kabupaten Minahasa Selatan", "Kabupaten Minahasa Tenggara", "Kabupaten Minahasa Utara", "Kota Bitung", "Kota Kotamobagu", "Kota Manado", "Kota Tomohon" });
                    break;

                case "Sumatera Barat":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Agam", "Kabupaten Dharmasraya", "Kabupaten Kepulauan Mentawai", "Kabupaten Lima Puluh Kota", "Kabupaten Padang Pariaman", "Kabupaten Pasaman", "Kabupaten Pasaman Barat", "Kabupaten Pesisir Selatan", "Kabupaten Sijunjung", "Kabupaten Solok", "Kabupaten Solok Selatan", "Kabupaten Tanah Datar", "Kota Bukittinggi", "Kota Padang", "Kota Padangpanjang", "Kota Pariaman", "Kota Payakumbuh", "Kota Sawahlunto", "Kota Solok" });
                    break;

                case "Sumatera Selatan":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Banyuasin", "Kabupaten Empat Lawang", "Kabupaten Lahat", "Kabupaten Muara Enim", "Kabupaten Musi Banyuasin", "Kabupaten Musi Rawas", "Kabupaten Musi Rawas Utara", "Kabupaten Ogan Ilir", "Kabupaten Ogan Komering Ilir", "Kabupaten Ogan Komering Ulu", "Kabupaten Ogan Komering Ulu Selatan", "Kabupaten Ogan Komering Ulu Timur", "Kabupaten Penukal Abab Lematang Ilir", "Kota Lubuklinggau", "Kota Pagar Alam", "Kota Palembang", "Kota Prabumulih" });
                    break;

                case "Sumatera Utara":
                    kotaPengirim.Items.Clear();
                    kotaPengirim.Items.AddRange(new string[] { "Kabupaten Asahan", "Kabupaten Batu Bara", "Kabupaten Dairi", "Kabupaten Deli Serdang", "Kabupaten Humbang Hasundutan", "Kabupaten Karo", "Kabupaten Labuhanbatu", "Kabupaten Labuhanbatu Selatan", "Kabupaten Labuhanbatu Utara", "Kabupaten Langkat", "Kabupaten Mandailing Natal", "Kabupaten Nias", "Kabupaten Nias Barat", "Kabupaten Nias Selatan", "Kabupaten Nias Utara", "Kabupaten Padang Lawas", "Kabupaten Padang Lawas Utara", "Kabupaten Pakpak Bharat", "Kabupaten Samosir", "Kabupaten Serdang Bedagai", "Kabupaten Simalungun", "Kabupaten Tapanuli Selatan", "Kabupaten Tapanuli Tengah", "Kabupaten Tapanuli Utara", "Kabupaten Toba Samosir", "Kota Binjai", "Kota Gunungsitoli", "Kota Medan", "Kota Padangsidempuan", "Kota Pematangsiantar", "Kota Sibolga", "Kota Tanjungbalai", "Kota Tebing Tinggi" });
                    break;
            }
        }

        private void buttonPengirim_Click(object sender, EventArgs e)
        {
            if (teleponPengirim.TextLength < 9)
                labelTeleponPengirimNotif.Visible = true;
            else
                labelTeleponPengirimNotif.Visible = false;

            if (kodePosPengirim.TextLength < 5)
                labelKodePosPengirimNotif.Visible = true;
            else
                labelKodePosPengirimNotif.Visible = false;

            if (namaPengirim.Text != "" && teleponPengirim.Text != "" && provinsiPengirim.Text != "" && kotaPengirim.Text != "" && alamatPengirim.Text != "" && kodePosPengirim.Text != "")
            {
                labelNotifPengirim.Visible = false;
                Ekspedisi.pengirimNama = namaPengirim.Text;
                Ekspedisi.pengirimTelepon = "+62" + teleponPengirim.Text;
                Ekspedisi.pengirimProvinsi = provinsiPengirim.Text;
                Ekspedisi.pengirimKota = kotaPengirim.Text;
                Ekspedisi.pengirimAlamat = alamatPengirim.Text;
                Ekspedisi.pengirimKodePos = kodePosPengirim.Text;
                panelSimpanPengirim.Visible = true;
            }
            else
                labelNotifPengirim.Visible = true;
        }

        private void buttonResetPengirim_MouseEnter(object sender, EventArgs e)
        {
            buttonResetPengirim.BackColor = Color.FromArgb(57, 53, 80);
        }

        private void buttonResetPengirim_MouseLeave(object sender, EventArgs e)
        {
            buttonResetPengirim.BackColor = Color.Transparent;
        }

        private void buttonResetPengirim_Click(object sender, EventArgs e)
        {
            namaPengirim.Text = "";
            teleponPengirim.Text = "";
            provinsiPengirim.SelectedItem = null;
            kotaPengirim.Items.Clear();
            kotaPengirim.Visible = false;
            alamatPengirim.Text = "";
            kodePosPengirim.Text = "";
            labelKodePosPengirimNotif.Visible = false;
            labelNotifPengirim.Visible = false;
            labelTeleponPengirimNotif.Visible = false;
        }

        private void labelSimpanPengirim_Paint(object sender, PaintEventArgs e)
        {
            int a = panelSimpanPengirim.Width - labelSimpanPengirim.Width;
            int b = panelSimpanPengirim.Height - labelSimpanPengirim.Height;
            labelSimpanPengirim.Left = a / 2;
            labelSimpanPengirim.Top = b / 6 * 3;
        }

        private void pictureBoxSimpanPengirim_Paint(object sender, PaintEventArgs e)
        {
            int a = panelSimpanPengirim.Width - pictureBoxSimpanPengirim.Width;
            int b = panelSimpanPengirim.Height - pictureBoxSimpanPengirim.Height;
            pictureBoxSimpanPengirim.Left = a / 2;
            pictureBoxSimpanPengirim.Top = b / 6 * 2;
        }
    }
}
