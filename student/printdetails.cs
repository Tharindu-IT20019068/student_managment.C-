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
using System.Data.Sql;

namespace student
{
    public partial class printdetails : Form
    {
        public printdetails()
        {
            InitializeComponent();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EF7TQIP\SQLEXPRESS;Initial Catalog=student;Integrated Security=True");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select * from registration", con);
            var reader = cmd1.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;

            con.Close();

        }

        private void btn_back1_Click(object sender, EventArgs e)
        {
            this.Hide();
            main dkj = new main();
            dkj.Show();
        }
    }
}
