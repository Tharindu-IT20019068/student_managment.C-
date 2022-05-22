using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to really Exit?", "confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes) 
            {
                Application.Exit();
            }
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            registration dk = new registration();
            dk.Show();
        }

        private void studentDetilsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            printdetails dka = new printdetails();
            dka.Show();
        }
    }
}
