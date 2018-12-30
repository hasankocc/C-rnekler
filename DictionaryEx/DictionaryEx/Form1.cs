using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, Urun> liste;
        private void Form1_Load(object sender, EventArgs e)
        {
            liste = new Dictionary<string, Urun>();
        }
        private void clearAll()
        {
            txtAd.Clear();
            txtBolum.Clear();
            txtNumara.Clear();
            txtSoyad.Clear();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string key = Guid.NewGuid().ToString();//rastgele unique bir değer oluşturur.
            Urun u = new Urun();
            u.ad = txtAd.Text;
            u.soyad = txtSoyad.Text;
            u.numara = txtNumara.Text;
            u.bolum = txtBolum.Text;
            liste.Add(key, u);
            MessageBox.Show("key:" + key + "kaydedildi!");
            dataGridView1.DataSource = liste.Values.ToList();
            clearAll();
            txtAd.Focus();
        }


    }
}
