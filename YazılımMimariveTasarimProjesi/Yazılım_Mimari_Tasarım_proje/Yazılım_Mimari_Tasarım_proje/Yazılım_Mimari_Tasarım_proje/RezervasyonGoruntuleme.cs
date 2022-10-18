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
    public partial class RezervasyonGoruntuleme : Form
    {
        public RezervasyonGoruntuleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HVCUDKM;Initial Catalog=yazilimtasarim;Integrated Security=True");

        private void button1_Click_1(object sender, EventArgs e)
        {



            char konaklamatipi = ' ';
            if (radioButton1.Checked)
            {
                konaklamatipi = 'H';

            }
            if (radioButton2.Checked)
            {
                konaklamatipi = 'C';

            }
            char ulasimtipi = ' ';
            if (radioButton4.Checked)
            {
                ulasimtipi = 'O';

            }
            if (radioButton3.Checked)
            {
                ulasimtipi = 'U';

            }
            string t1;
            string t2;

            /*gidiş*/
            t1 = Convert.ToString(Convert.ToDateTime(dateTimePicker1.Text));
            /*dönüş*/
            t2 = Convert.ToString(Convert.ToDateTime(dateTimePicker2.Text));
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into ulasimkonaklama(konaklamatipi,ulasimtipi,gidis,donus) values ('" + konaklamatipi + "','" + ulasimtipi + "','" + t1 + "','" + t2 + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            this.Hide();
            RaporAl raporAl = new RaporAl();
            raporAl.ShowDialog();
            this.Close();

        }

        private void RezervasyonGoruntuleme_Load(object sender, EventArgs e)
        {

        }

        
    }
}
