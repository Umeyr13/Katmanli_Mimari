using NortWind_DAL_Data_Access_Layer_;
using NortWind_DAL_Data_Access_Layer_.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_UI_User_Interface_
{
    public partial class Kategori_Form : Form
    {
        public Kategori_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  Kategori12 ktg = new Kategori12();
            //  ktg.KategoriAdi = textBox1.Text;
            //  ktg.Tanim = textBox2.Text;
            //bool sonuc = Kategoriler.Ekle(ktg);

            if (Kategoriler.Ekle(new Kategori() { KategoriAdi = textBox1.Text, Tanim = textBox2.Text}))
            {
                MessageBox.Show("Başarılı");
                dataGridView1.DataSource = Kategoriler.Listele();
            }



        }

        private void Kategori_Form_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=  Kategoriler.Listele();
        }
    }
}
