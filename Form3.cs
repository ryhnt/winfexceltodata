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


namespace winfexcel
{
    public partial class Form3 : Form

    {
        
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmdb;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-9U5K7JLD\\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True");
            con.Open();
            da = new SqlDataAdapter("Select * from Employees", con);
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Employees");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            da.Update(ds, "Employees");
            MessageBox.Show("Kayıt güncellendi");
        }

        private void exit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
