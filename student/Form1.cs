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

namespace student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Are you sure,Do you want really Exit?", "Exit");
            this.Close();
        }

        private void btn_login1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EF7TQIP\SQLEXPRESS;Initial Catalog=student;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from logins where username ='" + txt_username.Text + "' and pass ='" + txt_password.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                main dk = new main();
                dk.Show();
            }
            else
            {
                MessageBox.Show("Invalid user credentials,Please Check Username and password and try again", "Invalid Login Details");
            }

        }

        private void btn_clear1_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
        }

        
    }
}
