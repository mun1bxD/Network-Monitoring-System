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
    public partial class Switch : Form
    {
        //creating object of form1
        Form1 obj2;
        //declearing varibles to store value of configuration
        protected string switch_name;
        protected string switch_ip;
        protected string switch_status;
        protected string switch_modelno;
        protected string switch_snmp;
        protected string switch_connect;
        protected string switch_portno;
        protected string switch_community_string;
        //store value of form1 
        protected string _ip;
        protected string _snmp;
        protected string _community;
        //storing value of form1
        protected string _ip1;
        protected string _snmp1;
        protected string _community1;
        protected string device_name;

        private void button3_Click(object sender, EventArgs e)
        {
            //function to close form
            this.Close();
        }

        private void Switch_Load(object sender, EventArgs e)
        {

        }

        public Switch(Form1 objs)
        {
            //initializing obj of form1
            InitializeComponent();
            obj2 = objs;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //taking value of textboxes and combo boxes
            switch_name = comboBox4.Text;
            if (string.IsNullOrWhiteSpace(switch_name))
            {
                MessageBox.Show("Select Device version");
            }
            switch_ip = textBox1.Text;
            if (string.IsNullOrEmpty(switch_ip))
            {
                MessageBox.Show("Enter ip address");
            }
            switch_status = comboBox2.Text;
            if (string.IsNullOrEmpty(switch_status))
            {
                MessageBox.Show("Device is currently off");
            }
            switch_modelno = textBox2.Text;
            if (string.IsNullOrEmpty(switch_modelno))
            {
                MessageBox.Show("Model number is not entered: ");
            }
            switch_snmp = comboBox1.Text;
            if (string.IsNullOrEmpty(switch_snmp))
            {
                MessageBox.Show("Slect SNMP version");
            }
            switch_connect = comboBox3.Text;
            if (string.IsNullOrEmpty(switch_connect))
            {
                MessageBox.Show("Device is currently disconnect");
            }
            switch_portno = textBox3.Text;
            if (string.IsNullOrEmpty(switch_portno))
            {
                MessageBox.Show("Enter port number:");
            }
            switch_community_string = textBox4.Text;
            if (string.IsNullOrEmpty(switch_community_string))
            {
                MessageBox.Show("Enter community string");
            }
            if (!string.IsNullOrEmpty(switch_name) && !string.IsNullOrEmpty(switch_ip) && !string.IsNullOrEmpty(switch_status) && !string.IsNullOrEmpty(switch_modelno) && !string.IsNullOrEmpty(switch_snmp) && !string.IsNullOrEmpty(switch_connect) && !string.IsNullOrEmpty(switch_portno) && !string.IsNullOrEmpty(switch_community_string))
            {
                //passing values to store (and show them in main menu form1 by press show button) 
                obj2.assign_switch_values(switch_name, switch_ip, switch_status, switch_modelno, switch_snmp, switch_connect, switch_portno, switch_community_string);
                MessageBox.Show("Saved.");
            }    
        }
            private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {

            }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _ip = obj2.get_manager_ip();
            _snmp = obj2.get_manager_snmp();
            _community = obj2.get_manager_community();

            _ip1 = obj2.get_sw_ip();
            _community1 = obj2.get_sw_community();
            _snmp1 = obj2.get_sw_snmp();
            device_name = obj2.get_manager_name();

            // Create an instance of the 'trap' form
            if (device_name == "switch")
            {
                if (_ip == _ip1 && _snmp == _snmp1 && _community1 == _community)
                {
                    trap obj = new trap();
                    obj.Show();
                    obj.StartPrinting();
                }
                else
                {
                    MessageBox.Show("To send a trap device must be configured correctly");
                }
            }
            else
            {
                MessageBox.Show("To send a trap device must be configured correctly");
            }
        }
    }
}

