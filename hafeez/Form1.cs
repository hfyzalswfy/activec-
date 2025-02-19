using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace hafeez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            

        }

        private void lbloutput_Click(object sender, EventArgs e)
        {

        }
        private void AddInformation()
        {
            if (txtname.Text == "")
            {
                lbloutput.Text = "";
                MessageBox.Show("please enter user name","field requere",MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtname.Focus();
                
                return;
            }
            else if (txtemail.Text == "")
            {
                MessageBox.Show("please enter your email", "field requere", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtemail.Focus();
                return;
            }
            else if (txtpassword.Text == "")
            {
                lbloutput.Text = "";
                MessageBox.Show("please enter user password", "field requere", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtpassword.Focus();
                return;
            }
            else
            {
                string chick = "male";
                if (rdofemale.Checked)
                {
                    chick = "female";
                }
                else if (rdothers.Checked)
                {
                    chick = "others";
                }
                else
                {
                    chick = "male";
                }

                DateTime dt = brdate.Value;
                lbldata.Text = "YOUR DATA IS:";
                lbloutput.Text = "name: " + txtname.Text
                    + "\t\n" + "email: " + txtemail.Text
                    + "\t\n" + "password: " + txtpassword.Text
                    + "\n gender: " + chick
                    + "\n brith date: " + dt.ToString()
                    + "\n countre: " + cbxcountre.Text;
            }
        }
       

        private void button1_Click(object sender, EventArgs e)
        {


            
            string email = txtemail.Text;
            Regex regex = new Regex(@"^\w+([-_.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");

            if (regex.IsMatch(email))
            {

                AddInformation();



             

            }
            else
            {
                lbloutput.Text = "";
                MessageBox.Show("please enter correct Email", "field requere", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtemail.Focus();
                
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;

            }
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
