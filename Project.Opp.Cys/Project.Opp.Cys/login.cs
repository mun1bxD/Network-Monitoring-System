using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project.Opp.Cys
{
    public partial class login : Form
    {
        private string name;
        private string password;
        public login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //storing value in variable of picture boxes
             name=textBox1.Text;
             password = textBox2.Text;

            //input validation

                if ((name=="munib" && password == "admin123") ||( name=="abdullah" && password == "admin123" )|| (name == "cr" && password == "admin123" )||( name=="husnain" || name == "adminadmin" && password=="admin123" ))
                {
                    this.Close();
                    new Form1().Show();

                }
                else
                {
                    MessageBox.Show("Invalid Username or password");
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //command to close the app by pressing close button
            Application.Exit();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                      
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
       
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
    
}
