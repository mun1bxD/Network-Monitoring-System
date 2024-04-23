using Project.Opp.Cys.Properties;
using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Project.Opp.Cys
{
    public partial class Manager : Form
    {
        //creating object of form1  
        Form1 obj5;

        //variable to store manager  variable
        protected string Device_name;
        protected string Device_ip;
        protected string Manager_snmp_ver;
        protected string community_string;
        protected string status;
        protected string connection;

        //variable to store value of getter function of form1
        protected string _ip;
        protected string _snmp;
        protected string _connect;
        protected string _community;
        protected string _status;
        protected string concatenate;
        
        private void button1_Click(object sender, EventArgs e)
        {

            if (Device_name == "Workstation")
            {
                //storing value in variable
                _ip = obj5.get_work_ip();
                _snmp = obj5.get_work_snmp1();
                _connect = obj5.get_work_connect1();
                _community = obj5.get_work_community1();
                _status = obj5.get_work_status();
                if (Device_ip != _ip || Manager_snmp_ver != _snmp || community_string != _community || _connect != connection || _status != status)
                {
                    //calling function
                    Appending2();
                }
                else
                {
                    // calling function
                    Appending1();
                }
            }
            else if (Device_name == "switch")
            {
                //storing value in variable
                _ip = obj5.get_sw_ip();
                _snmp = obj5.get_sw_snmp();
                _connect = obj5.get_sw_conn();
                _community = obj5.get_sw_community();
                _status = obj5.get_sw_status();

                if (Device_ip != _ip || Manager_snmp_ver != _snmp || community_string != _community || _connect != connection || _status != status || _status == "OFF")
                {
                    //calling function 
                    Appending2();
                }
                else
                {
                    //calling function
                    Appending1();
                }
            }
            else if (Device_name == "Hub")
            {
                //calling function
                Appending2();

            }
            else if (Device_name == "Router")
            {
                //storing value in variable
                _ip = obj5.get_ru_ip();
                _snmp = obj5.get_ru_snmp();
                _connect = obj5.get_ru_connection();
                _community = obj5.get_ru_community();
                _status = obj5.get_ru_status();
                if (Device_ip != _ip || Manager_snmp_ver != _snmp || community_string != _community || _connect != connection || _status != status || _status == "OFF")
                {
                    
                    Appending2();
                }
                else
                {
                    Appending1();
                }
            }
            else if (Device_name == "firewall")
            {
                _ip = obj5.get_fr_ip();
                _snmp = obj5.get_fr_snmp();
                _community = obj5.get_fr_community();
                if (Device_ip != _ip || Manager_snmp_ver != _snmp || community_string != _community)
                {

                    Appending1();
                }
                else
                {
                    Appending1();
                }
            }

            else
            {
                MessageBox.Show("No such device exist in the Network");
            }
        }
        

        private void Manager_Load(object sender, EventArgs e)
        {
           
        }
            //constructor 
        public Manager(Form1 obj5e)
        {
        //initializing form1 object
            InitializeComponent();
            obj5 = obj5e;
        }

        //storing value of text boxes and combobox in variable
        private void button2_Click(object sender, EventArgs e)
        {
            Device_name = comboBox1.Text;
            if (string.IsNullOrEmpty(Device_name))
            {
                MessageBox.Show("Device name is not Selected");
            }
            Device_ip = textBox1.Text;
            if (string.IsNullOrEmpty(Device_ip))
            {
                MessageBox.Show("ip address of device is not entered");
            }
            Manager_snmp_ver = comboBox2.Text;
            if (string.IsNullOrEmpty(Manager_snmp_ver))
            {
                MessageBox.Show("Select Manager SNMP VER.");
            }
            community_string = textBox2.Text;
            if (string.IsNullOrEmpty(community_string))
            {
                MessageBox.Show("Enter Community String");
            }
            status = comboBox3.Text;
            if (string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Device is currenltly OFF");
            }
            connection = comboBox4.Text;
            if (string.IsNullOrEmpty(connection))
            {
                MessageBox.Show("Manager is currently disable");
            }
            //assigning value to form1 variable
            if(!string.IsNullOrEmpty(Device_name) && !string.IsNullOrEmpty(Device_ip) && !string.IsNullOrEmpty(Manager_snmp_ver) && !string.IsNullOrEmpty(community_string) && !string.IsNullOrEmpty(status) && !string.IsNullOrEmpty(connection))
            {
                obj5.assign_manager_value(Device_name, Device_ip, Manager_snmp_ver, community_string, status, connection);
                MessageBox.Show("Saved.");
            }
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //function to close form
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        //using async type to print variable after setted time
        public async Task Appending1()
        {

            TextBox textBox = new TextBox();
            //creating object of Command prompt form
            Command_Prompt obj = new Command_Prompt(textBox);
            obj.Show();
            //using await task to delay message by 1000 milli second=1s
            await Task.Delay(1000);
            //using Enviroment.Newline to print mesage in newline
            obj.messageshow(">ping " + _ip + Environment.NewLine);
            await Task.Delay(1000);
            obj.messageshow("Pinging " + _ip + " with 32 bytes of data" + Environment.NewLine);
            await Task.Delay(1000);
            obj.messageshow("Reply from " + _ip + ": bytes = 32 time < 1ms TTL = 128" + Environment.NewLine);
            await Task.Delay(1000);
            obj.messageshow("Reply from " + _ip + ": bytes = 32 time < 1ms TTL = 128" + Environment.NewLine);
            await Task.Delay(1000);
            obj.messageshow("Reply from " + _ip + ": bytes = 32 time < 1ms TTL = 128" + Environment.NewLine);
            await Task.Delay(1000);
            obj.messageshow("Reply from " + _ip + ": bytes = 32 time < 1ms TTL = 128" + Environment.NewLine);
            await Task.Delay(1000);
            obj.messageshow("ping statistics f0r " + _ip + ":" + Environment.NewLine);
            await Task.Delay(1000);
            obj.messageshow("     Packets: sent = 4, Received = 4, Lost = 0 (0% loss)," + Environment.NewLine);
            await Task.Delay(1000);
            obj.messageshow("Approximate round trip times is milli-second" + Environment.NewLine);
        }
        public async Task Appending2()
        {
            TextBox textBox = new TextBox();
            Command_Prompt obj = new Command_Prompt(textBox);
            obj.Show();

            await Task.Delay(1000);
            obj.messageshow(">ping " + _ip + Environment.NewLine);
            await Task.Delay(1000);
            obj.messageshow("Pinging " + _ip + " with 32 bytes of data" + Environment.NewLine);
            await Task.Delay(1000);
            obj.messageshow("Request timed out." + Environment.NewLine);
            await Task.Delay(1000);
            obj.messageshow("Request timed out." + Environment.NewLine);
            await Task.Delay(1000);
            obj.messageshow("Request timed out." + Environment.NewLine);
            await Task.Delay(1000);
            obj.messageshow("Request timed out." + Environment.NewLine);
            await Task.Delay(1000);
            obj.messageshow("ping statistics for " + _ip + ":" + Environment.NewLine);
            await Task.Delay(1000);
            obj.messageshow("     Packets: sent = 4, Received = 0, Lost = 4 (100% loss)," + Environment.NewLine);
            await Task.Delay(1000);
            obj.messageshow("Approximate round trip times is milli-second" + Environment.NewLine);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



