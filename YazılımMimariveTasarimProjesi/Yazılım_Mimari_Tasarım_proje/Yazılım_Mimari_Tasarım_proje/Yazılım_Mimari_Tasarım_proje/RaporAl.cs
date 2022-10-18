using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;

namespace Yazılım_Mimari_Tasarım_proje
{
    public partial class RaporAl : Form
    {
        public RaporAl()
        {
            InitializeComponent();
        }
        private string connetionString = null;
        private string tableName = null;
        Export export = null;
        //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HVCUDKM;Initial Catalog=yazilimtasarim;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {

            export.To_HTML();
        }

        private void RaporAl_Load(object sender, EventArgs e)
        {

            connetionString = @"Data Source=DESKTOP-HVCUDKM;Initial Catalog=yazilimtasarim;Integrated Security=True";
            tableName = "ulasimkonaklama";
            export = new Export();
            Connection.connectionString = connetionString;
            Connection.tableName = tableName;
            //dataGridView1.DataSource = export.GetData(new string[] { "id", "ad", "soyad", "dogumtarih", "tc", "ceptel" });

        }

        

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            FormREZRV frtt = new FormREZRV();
            frtt.Show();
        }
        
    }
}
