using System;
using System.Windows.Forms;

namespace Project.Opp.Cys
{
    public partial class router : Form
    {
        //creating object of form1
        Form1 obj1;

        // declearing variable for storing value of router
        protected string router_name;
        protected string router_ip;
        protected string router_firmware;
        protected string router_status;
        protected string router_modelno;
        protected string router_snmpversion;
        protected string router_connection;
        protected string router_community_string;
        //store value of form1 
        protected string _ip;
        protected string _snmp;
        protected string _community;
        //storing value of form1
        protected string _ip1;
        protected string _snmp1;
        protected string _community1;
        protected string device_name;
        private void firmwarecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //function to close
            this.Close();
        }

        public router(Form1 obje)
        {
            //initializing object of form1
            obj1 = obje;
            InitializeComponent();
        }

        private void router_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //storing data of textbox and combo boxes in variables
            router_name=devicenamecombobox.Text;
            //using condition to show pop up in case of empty string
            if (string.IsNullOrWhiteSpace(router_name))
            {
                MessageBox.Show("Device name is not selected");
               
            }
            router_ip = ipbox.Text;
            if (string.IsNullOrWhiteSpace(router_ip))
            {
                MessageBox.Show("Device ip is not entered");
            }
            router_status=statuscomboBox.Text;
            if (string.IsNullOrWhiteSpace(router_status))
            {
                MessageBox.Show("Status is turned off");
            }
            router_connection = ConnectioncomboBox.Text;
            if (string.IsNullOrWhiteSpace(router_connection))
            {
                MessageBox.Show("Device is currently disconnected");
            }
            router_firmware = firmwarecomboBox.Text;
            if (string.IsNullOrWhiteSpace(router_firmware))
            {
                MessageBox.Show("Selcect firmware version");
            }
            router_community_string = textBox1.Text;
            if (string.IsNullOrWhiteSpace(router_community_string))
            {
                MessageBox.Show("Enter community string");
            }
            router_snmpversion = SNMPVersioncomboBox.Text;
            if (string.IsNullOrWhiteSpace(router_snmpversion))
            {
                MessageBox.Show("Select SNMP version");
            }
            router_modelno = modelNOtextbox.Text;
            if (string.IsNullOrWhiteSpace(router_modelno))
            {
                MessageBox.Show("Enter MAC address");
            }
            if (!string.IsNullOrEmpty(router_name) && !string.IsNullOrEmpty(router_ip) && !string.IsNullOrEmpty(router_firmware) && !string.IsNullOrEmpty(router_status) && !string.IsNullOrEmpty(router_modelno) && !string.IsNullOrEmpty(router_snmpversion) && !string.IsNullOrEmpty(router_connection) && !string.IsNullOrEmpty(router_community_string))
            {
                //passing values to store (and show them in main menu form1 by press show button) 
                obj1.assign_router_values(router_name, router_ip, router_firmware, router_status, router_modelno, router_snmpversion, router_connection, router_community_string);
                MessageBox.Show("Saved.");
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void statuscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _ip = obj1.get_manager_ip();
            _snmp = obj1.get_manager_snmp();
            _community = obj1.get_manager_community();

            _ip1 = obj1.get_ru_ip();
            _community1 = obj1.get_ru_community();
            _snmp1 = obj1.get_ru_snmp();
            device_name = obj1.get_manager_name();

            // Create an instance of the 'trap' form
            if (device_name == "Router")
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

        private void ipbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
