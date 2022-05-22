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
    public partial class registration : Form
    {
        string gender = "";
        public registration()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (ra_male.Checked)
            {
                gender = "male";
            }
            if (ra_female.Checked)
            {
                gender = "female";
            }

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EF7TQIP\SQLEXPRESS;Initial Catalog=student;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO registration(regno,firstname,lastname,dateofbirth,gender,address1,email,mobilephone,homephone,parentname,nic,contactno) values('" + cmd_reg.Text + "','" + txt_first.Text + "', '" + txt_last.Text + "', '" + dateTimePicker1.Value.ToString() + "', '" + gender + "', '" + txt_address.Text + "','" + txt_email.Text + "','" + txt_mobile.Text + "','" + txt_home.Text + "','" + txt_parent.Text + "', '" + txt_nic.Text + "', '" + txt_contact.Text + "')", con);

            int i;
            i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                MessageBox.Show(" Data successfully saved");
            }
            else
            {
                MessageBox.Show("Data error ");
            }

            cmd.Connection = con;

            
        }

        private void btn_clear2_Click(object sender, EventArgs e)
        {

            txt_first.Clear();
            txt_last.Clear();
            txt_address.Clear();
            txt_email.Clear();
            txt_mobile.Clear();
            txt_home.Clear();
            txt_parent.Clear();
            txt_nic.Clear();
            txt_contact.Clear();
            
        }

        private void btn_exit2_Click(object sender, EventArgs e)
        {
            this.Hide();
            main dkc = new main();
            dkc.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EF7TQIP\SQLEXPRESS;Initial Catalog=student;Integrated Security=True");
            con.Open();
            
            SqlCommand cmd = new SqlCommand ("update registration set regno ='" + cmd_reg.Text + "',firstname = '" + txt_first.Text + "',lastname = '" + txt_last.Text + "',dateofbirth = '" + dateTimePicker1.Value.ToString() + "',gender = '" + gender + "',address1 = '" + txt_address.Text + "',email = '" + txt_email.Text + "',mobilephone = '" + txt_mobile.Text + "',homephone = '" + txt_home.Text + "',parentname = '" + txt_parent.Text + "',nic = '" + txt_nic.Text + "',contactno = '" + txt_contact.Text + "' where regno = '" + cmd_reg.Text + "' ",con );
            
            int i;
            i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                MessageBox.Show(" Data successfully Updated");
            }
            else
            {
                MessageBox.Show("Data error ");
            }

            cmd.Connection = con;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EF7TQIP\SQLEXPRESS;Initial Catalog=student;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Delete registration where regno = '" + cmd_reg.Text + "'",con);
            int i;
            i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                MessageBox.Show(" Data successfully Deleted");
            }
            else
            {
                MessageBox.Show("Data error ");
            }

            cmd.Connection = con;
        }
    }
}
