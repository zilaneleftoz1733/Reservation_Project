using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Windows.Forms;


namespace Yazılım_Mimari_Tasarım_proje
{
    class Export : Connection
    {
        public DataTable Tab = new DataTable();
        public DataTable GetData()
        {
            Tab = base.LoadDataWithAllColumns();
            return Tab;
        }
        public DataTable GetData(string[] columns)
        {
            Tab = base.LoadDataWithParticularColumns(columns);
            return Tab;
        }
        public DataTable GetData(string query)
        {
            Tab = base.LoadDataFromQuery(query);
            return Tab;
        }


        public void To_HTML()
        {
            try
            {
                string filename = null;
                SaveFileDialog SaveHtml = new SaveFileDialog();
                SaveHtml.Filter = "HTML5 files *.html";
                SaveHtml.FileName = "HtmlData.html";
                if (SaveHtml.ShowDialog() == DialogResult.OK)
                {
                    filename = SaveHtml.FileName;
                }
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    FileInfo fileInfo = new FileInfo(filename);
                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("<!--HTML Raporu | {0}-->", DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToShortDateString());
                    sb.Append("<!DOCTYPE html>");
                    sb.AppendFormat("html lang='en'>");
                    sb.AppendFormat("<head>");
                    sb.AppendFormat("<title>HTML Raporu | {0}</title>", DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToShortDateString());
                    sb.AppendFormat("</head>");
                    sb.AppendFormat("<body>");
                    sb.AppendFormat("<h1>{0}</h1>", fileInfo.Name.ToUpper() + "Data");
                    sb.AppendFormat("<table>");
                    sb.AppendFormat("<thead>");
                    sb.AppendFormat("<tr>");
                    foreach (DataColumn column in Tab.Columns)
                    {
                        sb.AppendFormat("<th>{0}</th>", column.ColumnName.ToUpper());
                    }
                    sb.AppendFormat("</tr>");
                    sb.AppendFormat("</head>");
                    sb.AppendFormat("<tbody>");
                    foreach (DataRow row in Tab.Rows)
                    {
                        sb.AppendFormat("<tr>");
                        for (int i = 0; i < Tab.Columns.Count; i++)
                        {
                            sb.AppendFormat("<td>{0}</<td>", row[i].ToString());
                        }
                        sb.AppendFormat("</tr>");
                    }
                    sb.AppendFormat("</tbody>");
                    sb.AppendFormat("</table>");
                    sb.AppendFormat("</body>");
                    sb.AppendFormat("</html>");
                    sw.Write(sb.ToString());
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "eror");
            }
        }
    }
}
