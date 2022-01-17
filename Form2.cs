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

using System.Data.OleDb;

namespace winfexcel
{
    public partial class Form2 : Form
    {
        SqlConnection voconn;
        SqlCommand vs_command;
        
        string vs_connstr = "Data Source=LAPTOP-9U5K7JLD\\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True";
       
        SqlDataAdapter voda;
        DataSet vodase;
        string Filess;
      
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
           

        }

      

        private void Aktar_Click(object sender, EventArgs e)
        {
           
            openFileDialog1.Filter = "Excel Dosyası |*.xlsx";
            openFileDialog1.ShowDialog();
            Filess = openFileDialog1.FileName;
            
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Filess + "; Extended Properties='Excel 12.0 xml;HDR=YES;'");
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM [Sayfa1$]", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datag.DataSource = dt.DefaultView;
            voconn = new SqlConnection(vs_connstr);


        }

        private void cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aktar_Click_1(object sender, EventArgs e)
        {
            

            for (int i = 0; i < datag.RowCount; i++)
            {
                vs_command = new SqlCommand("INSERT INTO Employees(LastName, FirstName) VALUES(@LastName, @FirstName)", voconn);
             
                vs_command.Parameters.AddWithValue("@LastName", datag.Rows[i].Cells[0].Value.ToString());
                vs_command.Parameters.AddWithValue("@FirstName", datag.Rows[i].Cells[1].Value.ToString());
                voconn.Open();
                vs_command.ExecuteNonQuery();
                voconn.Close();

            }

            MessageBox.Show("kayıtlar eklendi");

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            voconn = new SqlConnection(vs_connstr);
            voda = new SqlDataAdapter("select * from Employees", voconn);
            vodase = new DataSet();
            voconn.Open();
            voda.Fill(vodase, "Employees");
            datag.DataSource = vodase.Tables["Employees"];
            voconn.Close();
        }
    }
}
