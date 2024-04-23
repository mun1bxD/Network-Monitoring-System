using System;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Opp.Cys
{

    public partial class firewall : Form
    {
      //  crearing obj of form1 to access variable 
        Form1 obj3;
        // firewall objf;
        //Manager objm;
       // Form1 objm1;
        protected string fire_name;
        protected string fire_ip;
        protected string fire_modelno;
        protected string fire_snmp;
        protected string fire_vpnenable;
        protected string fire_loggingenable;
        protected string fire_community_string;
        //store value of form1 
        protected string _ip2;
        protected string _snmp2;
        protected string _community2;
        //storing value of form1
        protected string _ip3;
        protected string _snmp3;
        protected string _community3;
        protected string device_name3;



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //initializing form1 object in constructor
        public firewall(Form1 obj3e)
        {
            obj3 = obj3e;
            InitializeComponent();
           // this.objm = objm1;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //storing value of text box and combo box in variable
            fire_name = comboBox4.Text;
            if (string.IsNullOrEmpty(fire_name))
            {
                MessageBox.Show("Select device name");
            }
            fire_ip = textBox1.Text;
            if (string.IsNullOrEmpty(fire_ip))
            {
                MessageBox.Show("Enter ip of Firewall");
            }
            fire_modelno = textBox2.Text;
            if (string.IsNullOrEmpty(fire_modelno))
            {
                MessageBox.Show("Enter firewall model");
            }
            fire_snmp = comboBox1.Text;
            if (string.IsNullOrEmpty(fire_snmp))
            {
                MessageBox.Show("Select SNMP version");
            }
            fire_vpnenable = checkBox1.Text;
            if (string.IsNullOrEmpty(fire_vpnenable))
            {
                MessageBox.Show("VPN is disable");
            }
            fire_loggingenable = checkBox2.Text;
            if (string.IsNullOrEmpty(fire_loggingenable))
            {
                MessageBox.Show("loging is currently disable");
            }
            fire_community_string = textBox3.Text;
            if (string.IsNullOrEmpty(fire_community_string))
            {
                MessageBox.Show("Enter community string");
            }
            
            if (!string.IsNullOrEmpty(fire_name) && !string.IsNullOrEmpty(fire_ip) && !string.IsNullOrEmpty(fire_modelno) && !string.IsNullOrEmpty(fire_snmp) && !string.IsNullOrEmpty(fire_vpnenable) && !string.IsNullOrEmpty(fire_loggingenable) && !string.IsNullOrEmpty(fire_community_string))
            {
                //passing values to store (and show them in main menu form1 by press show button) 
                obj3.assign_firewall_value(fire_name, fire_ip, fire_modelno, fire_snmp, fire_vpnenable, fire_loggingenable, fire_community_string);
                MessageBox.Show("Saved.");
            }

            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void firewall_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
       
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _ip2 = obj3.get_manager_ip();
            _snmp2 = obj3.get_manager_snmp();
            _community2 = obj3.get_manager_community();

            _ip3 = obj3.get_fr_ip();
            _community3 = obj3.get_fr_community();
            _snmp3 = obj3.get_fr_snmp();
            device_name3 = obj3.get_manager_name();
            MessageBox.Show(device_name3+"\n"+_ip2+" "+_ip3+"\n"+_snmp2+" "+_snmp3+"\n"+_community2+" "+_community3);
            // Create an instance of the 'trap' form
            if (device_name3 == "firewall")
            {
                if (_ip2 == _ip3 && _snmp2 == _snmp3 && _community2 == _community3)
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

