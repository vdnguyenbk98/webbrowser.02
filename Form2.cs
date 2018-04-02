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

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void ketnoi()
        {
            SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-VGNG2FP;Initial Catalog=lichsuweb;Integrated Security=True");
            kn.Open();
            string sql = "select * from dbo.history";
            SqlCommand commandsql = new SqlCommand(sql,kn);
            SqlDataAdapter com = new SqlDataAdapter(commandsql);
            DataTable table = new DataTable();
            com.Fill(table);
            dataGridView1.DataSource = table;


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ketnoi();
        }
    }
}
