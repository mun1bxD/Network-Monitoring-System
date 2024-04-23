using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Opp.Cys
{
    public partial class hub1 : Form
    {
        //creating object of form1
        Form1 obj4;
        protected string hub_name;

        //initializing form 1 object
        public hub1(Form1 obj4e)
        {
            InitializeComponent();
            this.obj4 = obj4e;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ///variable to store textbox and combobox boxes
            hub_name = comboBox1.Text;
            if (string.IsNullOrEmpty(hub_name))
            {
                MessageBox.Show("Select device");
            }
            else if (hub_name == "Hub")
            {
                MessageBox.Show("HUB doesnot support SNMP protocol");
            }
            obj4.assign_hub_value(hub_name);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hub1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //to close form
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
