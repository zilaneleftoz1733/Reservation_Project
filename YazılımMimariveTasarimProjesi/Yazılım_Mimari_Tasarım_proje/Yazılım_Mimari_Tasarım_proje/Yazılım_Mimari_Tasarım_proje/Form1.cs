using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Yazılım_Mimari_Tasarım_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HVCUDKM;Initial Catalog=yazilimtasarim;Integrated Security=True");


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RezervasyonGoruntuleme rezervasyonGoruntuleme = new RezervasyonGoruntuleme();
            rezervasyonGoruntuleme.ShowDialog();
            this.Close();

           string ta;
            ta = Convert.ToString(Convert.ToDateTime(dateTimePicker1.Text));
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kullanicibilgi(ad,soyad,dogumtarih,tc,ceptel) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + ta + "','" + maskedTextBox1.Text + "','" + maskedTextBox2.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            
        }
    }
}

