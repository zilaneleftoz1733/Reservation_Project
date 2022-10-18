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
    public partial class FormREZRV : Form
    {
        public FormREZRV()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HVCUDKM;Initial Catalog=yazilimtasarim;Integrated Security=True");

        private void FormREZRV_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string sql = "select * From ulasimkonaklama";
            SqlDataAdapter adtp = new SqlDataAdapter(sql, baglanti);
            DataTable dt = new DataTable();
            adtp.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

            baglanti.Open();
            string sqll = "select * From kullanicibilgi";
            SqlDataAdapter adtpp = new SqlDataAdapter(sqll, baglanti);
            DataTable dtt = new DataTable();
            adtpp.Fill(dtt);
            dataGridView2.DataSource = dtt;
            baglanti.Close();


        }
    }
}
