using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NortWind_DAL_Data_Access_Layer_;
using NortWind_DAL_Data_Access_Layer_.Entities;

namespace WindowsForms_UI_User_Interface_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Urunler U = new Urunler();
            dataGridView_Urunler.DataSource= Urunler.listele();
            comboBox1.DataSource= Kategoriler.Listele();
            comboBox1.DisplayMember= "KategoriAdi";
            comboBox1.ValueMember= "KategoriID";

            comboBoxtedarikciler.DataSource= Tedarikciler.Listele();
            comboBoxtedarikciler.DisplayMember="SirketAdi";
            comboBoxtedarikciler.ValueMember="TedarikciID";

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Urun u = new Urun();
            u.UrunAdi = textBoxurunadi.Text;
            u.BirimFiyati = short.Parse( textBoxfiyat.Text);
            u.HedefStokDüzeyi =short.Parse (textBoxhedefstok.Text);     
            u.KategoriID = (int) comboBox1.SelectedValue;
            u.TedarikciID = (int) comboBoxtedarikciler.SelectedValue;
            bool sonuc =Urunler.UrunEkle(u) ;
            dataGridView_Urunler.DataSource = Urunler.listele();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kategori_Form kategori_Form = new Kategori_Form();
            kategori_Form.ShowDialog();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urunler.UrunSil((int)dataGridView_Urunler.CurrentRow.Cells["UrunID"].Value );
            dataGridView_Urunler.DataSource = Urunler.listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }
    }
}
