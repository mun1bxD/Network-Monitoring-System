using System;
using System.Windows.Forms;

namespace Project.Opp.Cys
{

    public partial class work_st : Form
    {
       // creating object of form1
        Form1 obj1;
       
        //declaring variable for storing value of textbox 
        protected string work_name;
        protected string work_ip;
        protected string work_status;
        protected string work_cpu_usage;
        protected string work_ram_usage;
        protected string work_modelno;
        protected string work_snmp;
        protected string work_connect;
        protected string work_community_string;
        protected string mac_address;
        //store value of form1 
        protected string _ip;
        protected string _snmp;
        protected string _community ;
        //storing value of form1
        protected string _ip1;
        protected string _snmp1;
        protected string _community1;
        protected string device_name;
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public work_st(Form1 objw)
        {
            //initializing object 
            obj1 = objw;
            InitializeComponent();
        }

        private void work_st_Load(object sender, EventArgs e)
        {

        }
        
        public void button2_Click(object sender, EventArgs e)
        {
            
            work_name = comboBox4.Text;
            if (string.IsNullOrWhiteSpace(work_name))
            {
                MessageBox.Show("Device name is not selected");
            }
            work_ip = textBox1.Text;
            if (string.IsNullOrWhiteSpace(work_ip))

            {
                MessageBox.Show("Device IP is not Entered");
            }
            work_status = comboBox2.Text;
            if (string.IsNullOrWhiteSpace(work_status))
            {
                MessageBox.Show("To configure Status must be kept ON");

            }
            work_cpu_usage = textBox3.Text;
            if (string.IsNullOrWhiteSpace(work_cpu_usage))
            {
                MessageBox.Show("CPU usage is not Entered");
            }
            work_ram_usage = textBox4.Text;
            if (string.IsNullOrWhiteSpace(work_ram_usage))
            {
                MessageBox.Show("RAM usage is not Entered");
            }
            work_modelno = textBox2.Text;

            if (string.IsNullOrWhiteSpace(work_modelno))
            {
                MessageBox.Show("model number is not Entered");
            }
            work_snmp = comboBox1.Text;
            if (string.IsNullOrWhiteSpace(work_snmp))
            {
                MessageBox.Show("To communcate with manager enter SNMP version");
            }
            work_connect = comboBox3.Text;
            if (string.IsNullOrWhiteSpace(work_connect))
            {
                MessageBox.Show("No connection with distination device");
            }
            work_community_string = textBox6.Text;
            if (string.IsNullOrWhiteSpace(work_community_string))
            {
                MessageBox.Show("Enter community string ");
            }
            mac_address = textBox5.Text;
            if (string.IsNullOrWhiteSpace(mac_address))
            {
                MessageBox.Show("MAC address is not Entered");
            }
            
            if (!string.IsNullOrEmpty(work_name) && !string.IsNullOrEmpty(work_ip) && !string.IsNullOrEmpty(work_cpu_usage) && !string.IsNullOrEmpty(work_ram_usage) && !string.IsNullOrEmpty(work_modelno) && !string.IsNullOrEmpty(work_status) && !string.IsNullOrEmpty(work_snmp) && !string.IsNullOrEmpty(work_connect) && !string.IsNullOrEmpty(work_community_string) && !string.IsNullOrEmpty(mac_address))
            {
                //passing values to store (and show them in main menu form1 by press show button) 
                obj1.assign_work_values(work_name, work_ip, work_status, work_cpu_usage, work_ram_usage, work_modelno, work_snmp, work_connect, work_community_string, mac_address);
                MessageBox.Show("Saved.");
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            _ip=obj1.get_manager_ip();
            _snmp = obj1.get_manager_snmp();
            _community=obj1.get_manager_community();

            _ip1=obj1.get_work_ip();
            _community1=obj1.get_work_community1();
            _snmp1 = obj1.get_work_snmp1();
            device_name = obj1.get_manager_name();
           // MessageBox.Show(device_name + " ");
            // Create an instance of the 'trap' form
            if (device_name == "Workstation")
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