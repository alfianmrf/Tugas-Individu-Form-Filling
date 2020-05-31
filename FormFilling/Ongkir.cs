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
    public partial class Ongkir : Form
    {
        public Ongkir()
        {
            InitializeComponent();
        }

        private void angkaOngkir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void provinsiOngkirPengirim_SelectedIndexChanged(object sender, EventArgs e)
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

        private void provinsiOngkirPenerima_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (provinsiPenerima.Text != null)
                kotaPenerima.Visible = true;
            else
                kotaPenerima.Visible = false;

            switch (((ComboBox)sender).SelectedItem as string)
            {
                case "":
                    kotaPenerima.Items.Clear();
                    break;

                case "Bali":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Badung", "Kabupaten Bangli", "Kabupaten Buleleng", "Kabupaten Gianyar", "Kabupaten Jembrana", "Kabupaten Karangasem", "Kabupaten Klungkung", "Kabupaten Tabanan", "Kota Denpasar" });
                    break;

                case "Bangka Belitung":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Bangka", "Kabupaten Bangka Barat", "Kabupaten Bangka Selatan", "Kabupaten Bangka Tengah", "Kabupaten Belitung", "Kabupaten Belitung Timur", "Kota Pangkalpinang" });
                    break;

                case "Banten":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Lebak", "Kabupaten Pandeglang", "Kabupaten Serang", "Kabupaten Tangerang", "Kota Cilegon", "Kota Serang", "Kota Tangerang", "Kota Tangerang Selatan" });
                    break;

                case "Bengkulu":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Bengkulu Selatan", "Kabupaten Bengkulu Tengah", "Kabupaten Bengkulu Utara", "Kabupaten Kaur", "Kabupaten Kepahiang", "Kabupaten Lebong", "Kabupaten Mukomuko", "Kabupaten Rejang Lebong", "Kabupaten Seluma", "Kota Bengkulu" });
                    break;

                case "DI Yogyakarta":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Bantul", "Kabupaten Gunungkidul", "Kabupaten Kulon Progo", "Kabupaten Sleman", "Kota Yogyakarta" });
                    break;

                case "DKI Jakarta":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Administrasi Kepulauan Seribu", "Kota Administrasi Jakarta Barat", "Kota Administrasi Jakarta Pusat", "Kota Administrasi Jakarta Selatan", "Kota Administrasi Jakarta Timur", "Kota Administrasi Jakarta Utara" });
                    break;

                case "Gorontalo":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Boalemo", "Kabupaten Bone Bolango", "Kabupaten Gorontalo", "Kabupaten Gorontalo Utara", "Kabupaten Pohuwato", "Kota Gorontalo" });
                    break;

                case "Jambi":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Batanghari", "Kabupaten Bungo", "Kabupaten Kerinci", "Kabupaten Merangin", "Kabupaten Muaro Jambi", "Kabupaten Sarolangun", "Kabupaten Tanjung Jabung Barat", "Kabupaten Tanjung Jabung Timur", "Kabupaten Tebo", "Kota Jambi", "Kota Sungaipenuh" });
                    break;

                case "Jawa Barat":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Bandung", "Kabupaten Bandung Barat", "Kabupaten Bekasi", "Kabupaten Bogor", "Kabupaten Ciamis", "Kabupaten Cianjur", "Kabupaten Cirebon", "Kabupaten Garut", "Kabupaten Indramayu", "Kabupaten Karawang", "Kabupaten Kuningan", "Kabupaten Majalengka", "Kabupaten Pangandaran", "Kabupaten Purwakarta", "Kabupaten Subang", "Kabupaten Sukabumi", "Kabupaten Sumedang", "Kabupaten Tasikmalaya", "Kota Bandung", "Kota Banjar", "Kota Bekasi", "Kota Bogor", "Kota Cimahi", "Kota Cirebon", "Kota Depok", "Kota Sukabumi", "Kota Tasikmalaya" });
                    break;

                case "Jawa Tengah":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Banjarnegara", "Kabupaten Banyumas", "Kabupaten Batang", "Kabupaten Blora", "Kabupaten Boyolali", "Kabupaten Brebes", "Kabupaten Cilacap", "Kabupaten Demak", "Kabupaten Grobogan", "Kabupaten Jepara", "Kabupaten Karanganyar", "Kabupaten Kebumen", "Kabupaten Kendal", "Kabupaten Klaten", "Kabupaten Kudus", "Kabupaten Magelang", "Kabupaten Pati", "Kabupaten Pekalongan", "Kabupaten Pemalang", "Kabupaten Purbalingga", "Kabupaten Purworejo", "Kabupaten Rembang", "Kabupaten Semarang", "Kabupaten Sragen", "Kabupaten Sukoharjo", "Kabupaten Tegal", "Kabupaten Temanggung", "Kabupaten Wonogiri", "Kabupaten Wonosobo", "Kota Magelang", "Kota Pekalongan", "Kota Salatiga", "Kota Semarang", "Kota Surakarta", "Kota Tegal" });
                    break;

                case "Jawa Timur":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Bangkalan", "Kabupaten Banyuwangi", "Kabupaten Blitar", "Kabupaten Bojonegoro", "Kabupaten Bondowoso", "Kabupaten Gresik", "Kabupaten Jember", "Kabupaten Jombang", "Kabupaten Kediri", "Kabupaten Lamongan", "Kabupaten Lumajang", "Kabupaten Madiun", "Kabupaten Magetan", "Kabupaten Malang", "Kabupaten Mojokerto", "Kabupaten Nganjuk", "Kabupaten Ngawi", "Kabupaten Pacitan", "Kabupaten Pamekasan", "Kabupaten Pasuruan", "Kabupaten Ponorogo", "Kabupaten Probolinggo", "Kabupaten Sampang", "Kabupaten Sidoarjo", "Kabupaten Situbondo", "Kabupaten Sumenep", "Kabupaten Trenggalek", "Kabupaten Tuban", "Kabupaten Tulungagung", "Kota Batu", "Kota Blitar", "Kota Kediri", "Kota Madiun", "Kota Malang", "Kota Mojokerto", "Kota Pasuruan", "Kota Probolinggo", "Kota Surabaya" });
                    break;

                case "Kalimantan Barat":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Bengkayang", "Kabupaten Kapuas hulu", "Kabupaten Kayong Utara", "Kabupaten Ketapang", "Kabupaten Kubu Raya", "Kabupaten Landak", "Kabupaten Melawi", "Kabupaten Mempawah", "Kabupaten Sambas", "Kabupaten Sanggau", "Kabupaten Sekadau", "Kabupaten Sintang", "Kota Pontianak", "Kota Singkawang" });
                    break;

                case "Kalimantan Selatan":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Balangan", "Kabupaten Banjar", "Kabupaten Barito Kuala", "Kabupaten Hulu Sungai Selatan", "Kabupaten Hulu Sungai Tengah", "Kabupaten Hulu Sungai Utara", "Kabupaten Kotabaru", "Kabupaten Tabalong", "Kabupaten Tanah Bumbu", "Kabupaten Tanah Laut", "Kabupaten Tapin", "Kota Banjarbaru", "Kota Banjarmasin" });
                    break;

                case "Kalimantan Tengah":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Barito Selatan", "Kabupaten Barito Timur", "Kabupaten Barito Utara", "Kabupaten Gunung Mas", "Kabupaten Kapuas", "Kabupaten Katingan", "Kabupaten Kotawaringin Barat", "Kabupaten Kotawaringin Timur", "Kabupaten Lamandau", "Kabupaten Murung Raya", "Kabupaten Pulang Pisau", "Kabupaten Sukamar", "Kabupaten Seruyan", "Kota Palangka Raya" });
                    break;

                case "Kalimantan Timur":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Berau", "Kabupaten Kutai Barat", "Kabupaten Kutai Kartanegara", "Kabupaten Kutai Timur", "Kabupaten Mahakam Ulu", "Kabupaten Paser", "Kabupaten Penajam Paser Utara", "Kota Balikpapan", "Kota Bontang", "Kota Samarinda" });
                    break;

                case "Kalimantan Utara":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Bulungan", "Kabupaten Malinau", "Kabupaten Nunukan", "Kabupaten Tana Tidung", "Kota Tarakan" });
                    break;

                case "Kepulauan Riau":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Bintan", "Kabupaten Karimun", "Kabupaten Kepulauan Anambas", "Kabupaten Lingga", "Kabupaten Natuna", "Kota Batam", "Kota Tanjungpinang" });
                    break;

                case "Lampung":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Lampung Barat", "Kabupaten Lampung Selatan", "Kabupaten Lampung Tengah", "Kabupaten Lampung Timur", "Kabupaten Lampung Utara", "Kabupaten Mesuji", "Kabupaten Pesawaran", "Kabupaten Pesisir Barat", "Kabupaten Pringsewu", "Kabupaten Tanggamus", "Kabupaten Tulang Bawang", "Kabupaten Tulang Bawang Barat", "Kabupaten Way Kanan", "Kota Bandar Lampung", "Kota Metro" });
                    break;

                case "Maluku":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Buru", "Kabupaten Buru Selatan", "Kabupaten Kepulauan Aru", "Kabupaten Maluku Barat Daya", "Kabupaten Maluku Tengah", "Kabupaten Maluku Tenggara", "Kabupaten Kepulauan Tanimbar", "Kabupaten Seram Bagian Barat", "Kabupaten Seram Bagian Timur", "Kota Ambon", "Kota Tual" });
                    break;

                case "Maluku Utara":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Halmahera Barat", "Kabupaten Halmahera Tengah", "Kabupaten Halmahera Timur", "Kabupaten Halmahera Selatan", "Kabupaten Halmahera Utara", "Kabupaten Kepulauan Sula", "Kabupaten Pulau Morotai", "Kabupaten Pulau Taliabu", "Kota Ternate", "Kota Tidore Kepulauan" });
                    break;

                case "Nanggroe Aceh Darussalam (NAD)":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Aceh Barat", "Kabupaten Aceh Barat Daya", "Kabupaten Aceh Besar", "Kabupaten Aceh Jaya", "Kabupaten Aceh Selatan", "Kabupaten Aceh Singkil", "Kabupaten Aceh Tamiang", "Kabupaten Aceh Tengah", "Kabupaten Aceh Tenggara", "Kabupaten Aceh Timur", "Kabupaten Aceh Utara", "Kabupaten Bener Meriah", "Kabupaten Bireuen", "Kabupaten Gayo Lues", "Kabupaten Nagan Raya", "Kabupaten Pidie", "Kabupaten Pidie Jaya", "Kabupaten Simeulue", "Kota Banda Aceh", "Kota Langsa", "Kota Lhoksumawe", "Kota Sabang", "Kota Subulussalam" });
                    break;

                case "Nusa Tenggara Barat (NTB)":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Bima", "Kabupaten Dompu", "Kabupaten Lombok Barat", "Kabupaten Lombok Tengah", "Kabupaten Lombok Timur", "Kabupaten Lombok Utara", "Kabupaten Sumbawa", "Kabupaten Sumbawa Barat", "Kota Bima", "Kota Mataram" });
                    break;

                case "Nusa Tenggara Timur (NTT)":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Alor", "Kabupaten Belu", "Kabupaten Ende", "Kabupaten Flores Timur", "Kabupaten Kupang", "Kabupaten Lembata", "Kabupaten Malaka", "Kabupaten Manggarai", "Kabupaten Manggarai Barat", "Kabupaten Manggarai Timur", "Kabupaten Nagekeo", "Kabupaten Ngada", "Kabupaten Rote Ndao", "Kabupaten Sabu Raijua", "Kabupaten Sikka", "Kabupaten Sumba Barat", "Kabupaten Sumba Barat Daya", "Kabupaten Sumba Tengah", "Kabupaten Sumba Timur", "Kabupaten Timor Tengah Selatan", "Kabupaten Timor Tengah Utara", "Kota Kupang" });
                    break;

                case "Papua":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Asmat", "Kabupaten Biak Numfor", "Kabupaten Boven Dogoel", "Kabupaten Deiyai", "Kabupaten Dogiyai", "Kabupaten Intan Jaya", "Kabupaten Jayapura", "Kabupaten Jayawijaya", "Kabupaten Keerom", "Kabupaten Kepulauan Yapen", "Kabupaten Lanny Jaya", "Kabupaten Mamberamo Raya", "Kabupaten Mamberamo Tengah", "Kabupaten Mappi", "Kabupaten Merauke", "Kabupaten Mimika", "Kabupaten Nabire", "Kabupaten Nduga", "Kabupaten Paniai", "Kabupaten Pegunungan Bintang", "Kabupaten Puncak", "Kabupaten Puncak Jaya", "Kabupaten Sarmi", "Kabupaten Supiori", "Kabupaten Tolikara", "Kabupaten Waropen", "Kabupaten Yahukimo", "Kabupaten Yalimo", "Kota Jayapura" });
                    break;

                case "Papua Barat":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Fakfak", "Kabupaten Kaimana", "Kabupaten Manokwari", "Kabupaten Manokwari Selatan", "Kabupaten Maybrat", "Kabupaten Pegunungan Arfak", "Kabupaten Raja Ampat", "Kabupaten Sorong", "Kabupaten Sorong Selatan", "Kabupaten Tambrauw", "Kabupaten Teluk Bintuni", "Kabupaten Teluk Wondama", "Kota Sorong" });
                    break;

                case "Riau":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Bengkalis", "Kabupaten Indragiri Hilir", "Kabupaten Indragiri Hulu", "Kabupaten Kampar", "Kabupaten Kepulauan Meranti", "Kabupaten Kuantan Singingi", "Kabupaten Pelalawan", "Kabupaten Rokan Hilir", "Kabupaten Rokan Hulu", "Kabupaten Siak", "Kota Dumai", "Kota Pekanbaru" });
                    break;

                case "Sulawesi Barat":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Majene", "Kabupaten Mamasa", "Kabupaten Mamuju", "Kabupaten Mamuju Tengah", "Kabupaten Pasangkayu", "Kabupaten Polewali Mandar" });
                    break;

                case "Sulawesi Selatan":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Bantaeng", "Kabupaten Barru", "Kabupaten Bone", "Kabupaten Bulukumba", "Kabupaten Enrekang", "Kabupaten Gowa", "Kabupaten Jeneponto", "Kabupaten Kepulauan Selayar", "Kabupaten Luwu", "Kabupaten Luwu Timur", "Kabupaten Luwu Utara", "Kabupaten Maros", "Kabupaten Pangkajene dan Kepulauan", "Kabupaten Pinrang", "Kabupaten Sidenreng Rappang", "Kabupaten Sinjau", "Kabupaten Soppeng", "Kabupaten Takalr", "Kabupaten Tana Toraja", "Kabupaten Toraja Utara", "Kabupaten Wajo", "Kota Makassar", "Kota Palopo", "Kota Parepare" });
                    break;

                case "Sulawesi Tengah":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Banggai", "Kabupaten Banggai Kepulauan", "Kabupaten Banggai Laut", "Kabupaten Buol", "Kabupaten Donggala", "Kabupaten Morowali", "Kabupaten Morowali Utara", "Kabupaten Parigi Moutong", "Kabupaten Poso", "Kabupaten Sigi", "Kabupaten Tojo Una-una", "Kabupaten Tolitoli", "Kota Palu" });
                    break;

                case "Sulawesi Tenggara":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Bombana", "Kabupaten Buton", "Kabupaten Buton Selatan", "Kabupaten Buton Tengah", "Kabupaten Buton Utara", "Kabupaten Kolaka", "Kabupaten Kolaka Timur", "Kabupaten Kolaka Utara", "Kabupaten Konawe", "Kabupaten Konawe Kepulauan", "Kabupaten Konawe Selatan", "Kabupaten Konawe Utara", "Kabupaten Muna", "Kabupaten Muna Barat", "Kabupaten Wakatobi", "Kota Bau-bau", "Kota Kendari" });
                    break;

                case "Sulawesi Utara":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Bolaang Mongondow", "Kabupaten Bolaang Mongondow Selatan", "Kabupaten Bolaang Mongondow Timur", "Kabupaten Bolaang Mongondow Utara", "Kabupaten Kepulauan Sangihe", "Kabupaten Kepulauan Siau Tagulandang Biaro", "Kabupaten Kepulauan Talaud", "Kabupaten Minahasa", "Kabupaten Minahasa Selatan", "Kabupaten Minahasa Tenggara", "Kabupaten Minahasa Utara", "Kota Bitung", "Kota Kotamobagu", "Kota Manado", "Kota Tomohon" });
                    break;

                case "Sumatera Barat":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Agam", "Kabupaten Dharmasraya", "Kabupaten Kepulauan Mentawai", "Kabupaten Lima Puluh Kota", "Kabupaten Padang Pariaman", "Kabupaten Pasaman", "Kabupaten Pasaman Barat", "Kabupaten Pesisir Selatan", "Kabupaten Sijunjung", "Kabupaten Solok", "Kabupaten Solok Selatan", "Kabupaten Tanah Datar", "Kota Bukittinggi", "Kota Padang", "Kota Padangpanjang", "Kota Pariaman", "Kota Payakumbuh", "Kota Sawahlunto", "Kota Solok" });
                    break;

                case "Sumatera Selatan":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Banyuasin", "Kabupaten Empat Lawang", "Kabupaten Lahat", "Kabupaten Muara Enim", "Kabupaten Musi Banyuasin", "Kabupaten Musi Rawas", "Kabupaten Musi Rawas Utara", "Kabupaten Ogan Ilir", "Kabupaten Ogan Komering Ilir", "Kabupaten Ogan Komering Ulu", "Kabupaten Ogan Komering Ulu Selatan", "Kabupaten Ogan Komering Ulu Timur", "Kabupaten Penukal Abab Lematang Ilir", "Kota Lubuklinggau", "Kota Pagar Alam", "Kota Palembang", "Kota Prabumulih" });
                    break;

                case "Sumatera Utara":
                    kotaPenerima.Items.Clear();
                    kotaPenerima.Items.AddRange(new string[] { "Kabupaten Asahan", "Kabupaten Batu Bara", "Kabupaten Dairi", "Kabupaten Deli Serdang", "Kabupaten Humbang Hasundutan", "Kabupaten Karo", "Kabupaten Labuhanbatu", "Kabupaten Labuhanbatu Selatan", "Kabupaten Labuhanbatu Utara", "Kabupaten Langkat", "Kabupaten Mandailing Natal", "Kabupaten Nias", "Kabupaten Nias Barat", "Kabupaten Nias Selatan", "Kabupaten Nias Utara", "Kabupaten Padang Lawas", "Kabupaten Padang Lawas Utara", "Kabupaten Pakpak Bharat", "Kabupaten Samosir", "Kabupaten Serdang Bedagai", "Kabupaten Simalungun", "Kabupaten Tapanuli Selatan", "Kabupaten Tapanuli Tengah", "Kabupaten Tapanuli Utara", "Kabupaten Toba Samosir", "Kota Binjai", "Kota Gunungsitoli", "Kota Medan", "Kota Padangsidempuan", "Kota Pematangsiantar", "Kota Sibolga", "Kota Tanjungbalai", "Kota Tebing Tinggi" });
                    break;
            }
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
            }
            else
            {
                labelHargaBarang.Visible = false;
                labelRPBarang.Visible = false;
                hargaBarang.Visible = false;
                hargaBarang.Text = "";
                labelHargaBarangNotif.Visible = false;
            }
        }

        private void buttonCekOngkir_Paint(object sender, PaintEventArgs e)
        {
            int a = this.Width - buttonCekOngkir.Width;
            buttonCekOngkir.Left = a / 2;
        }

        private void buttonCekOngkir_Click(object sender, EventArgs e)
        {
            double ekonomi = Double.Parse(beratBarang.Text) * 5000;
            double reguler = Double.Parse(beratBarang.Text) * 10000;
            double ekspress = Double.Parse(beratBarang.Text) * 15000;

            double asuransi = 0;

            if (hargaBarang.Text != "")
                asuransi = Double.Parse(hargaBarang.Text) * 0.002;

            labelOngkirEkonomi.Text = "Rp. " + ekonomi.ToString();
            labelOngkirReguler.Text = "Rp. " + reguler.ToString();
            labelOngkirEkspress.Text = "Rp. " + ekspress.ToString();

            if (asuransi != 0)
            {
                labelAsuransiEkonomi.Text = "Rp. " + asuransi.ToString();
                labelAsuransiReguler.Text = "Rp. " + asuransi.ToString();
                labelAsuransiEkspress.Text = "Rp. " + asuransi.ToString();
            }
            else
            {
                labelAsuransiEkonomi.Text = "-";
                labelAsuransiReguler.Text = "-";
                labelAsuransiEkspress.Text = "-";
            }

            labelTotalEkonomi.Text = "Rp. " + (ekonomi + asuransi).ToString();
            labelTotalReguler.Text = "Rp. " + (reguler + asuransi).ToString();
            labelTotalEkspress.Text = "Rp. " + (ekspress + asuransi).ToString();

            if (kotaPenerima.Text == "" || provinsiPenerima.Text == "" || kotaPengirim.Text == "" || provinsiPengirim.Text == "" || beratBarang.Text == "")
            {
                labelNotifBarang.Visible = true;
                tableLayoutPanelOngkir.Visible = false;

                if (checkBoxDimensiBarang.Checked)
                {
                    if (panjangBarang.Text == "" || lebarBarang.Text == "" || tinggiBarang.Text == "")
                        labelDimensiBarangNotif.Visible = true;
                    else
                        labelDimensiBarangNotif.Visible = false;
                }
                if(checkBoxAsuransiBarang.Checked)
                {
                    if (hargaBarang.Text == "")
                        labelHargaBarangNotif.Visible = true;
                    else
                        labelHargaBarangNotif.Visible = false;
                }
            }
            else
            {
                if (checkBoxDimensiBarang.Checked)
                {
                    if (panjangBarang.Text == "" || lebarBarang.Text == "" || tinggiBarang.Text == "")
                    {
                        labelDimensiBarangNotif.Visible = true;
                        labelNotifBarang.Visible = true;
                        tableLayoutPanelOngkir.Visible = false;

                        if (checkBoxAsuransiBarang.Checked)
                        {
                            if (hargaBarang.Text == "")
                            {
                                labelNotifBarang.Visible = true;
                                labelHargaBarangNotif.Visible = true;
                                tableLayoutPanelOngkir.Visible = false;
                            }
                            else
                            {
                                labelNotifBarang.Visible = true;
                                labelHargaBarangNotif.Visible = false;
                            }
                        }
                    }
                    else
                    {
                        labelDimensiBarangNotif.Visible = false;
                        labelNotifBarang.Visible = false;

                        if (checkBoxAsuransiBarang.Checked)
                        {
                            if (hargaBarang.Text == "")
                            {
                                labelNotifBarang.Visible = true;
                                labelHargaBarangNotif.Visible = true;
                                tableLayoutPanelOngkir.Visible = false;
                            }
                            else
                            {
                                labelNotifBarang.Visible = false;
                                labelHargaBarangNotif.Visible = false;
                                tableLayoutPanelOngkir.Visible = true;
                            }
                        }
                        else
                        {
                            tableLayoutPanelOngkir.Visible = true;
                        }
                    }
                }
                else
                {
                    if (checkBoxAsuransiBarang.Checked)
                    {
                        if (hargaBarang.Text == "")
                        {
                            labelNotifBarang.Visible = true;
                            labelHargaBarangNotif.Visible = true;
                            tableLayoutPanelOngkir.Visible = false;
                        }
                        else
                        {
                            labelNotifBarang.Visible = false;
                            labelHargaBarangNotif.Visible = false;
                            tableLayoutPanelOngkir.Visible = true;
                        }
                    }
                    else
                    {
                        labelNotifBarang.Visible = false;
                        tableLayoutPanelOngkir.Visible = true;
                    }
                }
            }
        }
    }
}
