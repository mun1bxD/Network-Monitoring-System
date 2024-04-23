using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Project.Opp.Cys
{
    public partial class Form1 : Form
    {
        // variable to store the value pass from router class
        protected string router_name;
        protected string router_ip;
        protected string router_firmware;
        protected string router_status;
        protected string router_modelno;
        protected string router_snmpversion;
        protected string router_connection;
        protected string router_community_string;

        // assigning the passed value to variable 
        public void assign_router_values(string name, string ip, string firmware, string status, string modelno, string snmpversion, string connection, string numberofinterfaces)
        {
            router_name = name;
            router_ip = ip;
            router_firmware = firmware;
            router_status = status;
            router_modelno = modelno;
            router_snmpversion = snmpversion;
            router_connection = connection;
            router_community_string = numberofinterfaces;
        }
        //to show data in configuration button
        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Router name : " + router_name + "       Router ip : " + router_ip + "\nRouter connection : " + router_connection + "       Router status : " + router_status + "\nRouter snmp version : " + router_snmpversion + "       Router interfaces" + router_community_string + "\nModel number " + router_modelno);
        }

        //getter functions for router variables of manager class
        public string get_ru_ip()
        {
            return router_ip;
        }
        public string get_ru_firmware()
        {
            return router_firmware;
        }
        public string get_ru_model()
        {
            return router_modelno;
        }
        public string get_ru_snmp()
        {
            return router_snmpversion;
        }
        public string get_ru_connection()
        {
            return router_connection;
        }
        public string get_ru_community()
        {
            return router_community_string;
        }
        public string get_ru_status()
        {
            return router_status;
        }

        // variable to store the value passed from workstation class
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

        //assigning values to workstation variables
        public void assign_work_values(string work_name1, string work_ip1, string work_status1, string work_cpu_usage1, string work_ram_usage1, string work_modelno1, string work_snmp1, string work_connect1, string work_community_string1, string mac_address1)
        {
            work_name = work_name1;
            work_ip = work_ip1;
            work_status = work_status1;
            work_modelno = work_modelno1;
            work_snmp = work_snmp1;
            work_connect = work_connect1;
            work_community_string = work_community_string1;
            work_cpu_usage = work_cpu_usage1;
            work_ram_usage = work_ram_usage1;
            mac_address = mac_address1;
        }

        //getter functions for workstation variables of manager class
        public string get_work_ip()
        {
            return work_ip;
        }
        public string get_work_name()
        {
            return work_name;
        }

        public string get_work_status()
        {
            return status;
        }
        public string get_work_cpu()
        {
            return work_cpu_usage;
        }
        public string get_work_ram()
        {
            return work_ram_usage;
        }
        public string get_work_snmp1()
        {
            return work_snmp;
        }
        public string get_work_connect1()
        {
            return work_connect;
        }
        public string get_work_community1()
        {
            return work_community_string;
        }
        public string get_work_mac()
        {
            return mac_address;
        }

        //showing configuration of workstation
        private void button6_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Station name " + work_name + "       Station ip : " + work_ip + "\n Status : " + work_status + "       CPU usage : " + work_cpu_usage + "\n RAM usage : " + work_ram_usage + "       model number : " + work_modelno + "\nSNMP version : " + work_snmp + "       connection : " + work_connect + "\ncommunity string" + work_community_string + "       MAC address" + mac_address);
        }

        protected string switch_name;
        protected string switch_ip;
        protected string switch_status;
        protected string switch_modelno;
        protected string switch_snmp;
        protected string switch_connect;
        protected string switch_portno1;
        protected string switch_community_string;

        //assigning values to the switch variables
        public void assign_switch_values(string switch_name1, string switch_ip1, string switch_status1, string switch_modelno1, string switch_snmp1, string switch_connect1, string switch_portno, string switch_community_string1)
        {
            switch_name = switch_name1;
            switch_ip = switch_ip1;
            switch_status = switch_status1;
            switch_modelno = switch_modelno1;
            switch_snmp = switch_snmp1;
            switch_connect = switch_connect1;
            switch_portno1 = switch_portno;
            switch_community_string = switch_community_string1;
        }
        //getter functions for switch variables of manager class
        public string get_sw_ip()
        {
            return switch_ip;
        }
        public string get_sw_status()
        {
            return switch_status;
        }
        public string get_sw_model()
        {
            return switch_modelno;
        }
        public string get_sw_snmp()
        {
            return switch_snmp;

        }
        public string get_sw_conn()
        {
            return switch_connect;
        }
        public string get_sw_port()
        {
            return switch_portno1;
        }
        public string get_sw_community()
        {
            return switch_community_string;
        }

        //showing configuration of switch using button
        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Switch name " + switch_name + "       switch ip : " + switch_ip + "\n Status : " + switch_status + "       model number : " + switch_modelno + "\nSNMP version : " + switch_snmp + "       connection : " + switch_connect + "\n switch port" + switch_portno1 + "       Community string" + switch_community_string);
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Manager obj5 = new Manager(this);
            obj5.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show(hub_name+"does not support snmp");
        }
        // variable to store the value pass from firewall class
        protected string fire_name;
        protected string fire_ip;
        protected string fire_modelno;
        protected string fire_snmp;
        protected string fire_vpnenable;
        protected string fire_loggingenable;
        protected string fire_community_string;

        //assigning values to firewall variables
        public void assign_firewall_value(string fire_name1, string fire_ip1, string fire_modelno1, string fire_snmp1, string fire_vpnenable1, string fire_loggingenable1, string fire_community_string1)
        {
            fire_name = fire_name1;
            fire_ip = fire_ip1;
            fire_modelno = fire_modelno1;
            fire_snmp = fire_snmp1;
            fire_vpnenable = fire_vpnenable1;
            fire_loggingenable = fire_loggingenable1;
            fire_community_string = fire_community_string1;
        }

        //getter function of firewall variable
        public string get_fr_ip()
        {
            return fire_ip;
        }
        public string get_fr_model()
        {
            return fire_modelno;
        }
        public string get_fr_snmp()
        {
            return fire_snmp;
        }
        public string get_fr_vpn()
        {
            return fire_vpnenable;

        }
        public string get_fr_logging()
        {
            return fire_loggingenable;
        }
        public string get_fr_community()
        {
            return fire_community_string;
        }

        //showing the configuration of firewall using button
        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("firewall name " + fire_name + "       firewall ip : " + fire_ip + "\nmodel number : " + fire_modelno + "       SNMP version : " + fire_snmp + "\n VPN : " + fire_vpnenable + "       logging : " + fire_loggingenable + "\n Community string" + fire_community_string);
        }

        // variable to store hub winform boxes
        protected string hub_name,hub;
         public void assign_hub_value(string hub1)
        {
            if(hub=="HUB"|| hub == "hub" || hub == "Hub" || hub == "" || hub == "h")
            {
                MessageBox.Show("HUB doesnot support SNMP protocol");
            }
            else
            {
                hub_name = hub1;
            }
        }


        // variable to store the value pass from manager 
        protected string Device_name;
        protected string Device_ip;
        protected string Manager_snmp_ver;
        protected string community_string;
        protected string status;
        protected string connection;

        //assigning value to the device in the manager 
        public void assign_manager_value(string Device_name1, string Device_ip1, string Manager_snmp_ver1, string community_string1, string status1, string connection1)
        {
            Device_name = Device_name1;
            Device_ip = Device_ip1;
            Manager_snmp_ver = Manager_snmp_ver1;
            community_string = community_string1;
            status = status1;
            connection = connection1;
        }
        //getter function for returning manager vaiable
        public string get_manager_name()
        {
            return Device_name;
        }
        public string get_manager_ip()
        {
            return Device_ip;
        }
        public string get_manager_snmp()
        {
            return Manager_snmp_ver;
        }
        public string get_manager_community()
        {
            return community_string;
        }
        public string get_manager_status()
        {
            return status;
        }
        public string get_manager_connection()
        {
            return connection;
        }

        //showing the details of the device added in the manager 
        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Device name :" + Device_name + "       Device ip : " + Device_ip + "\n Manager SNMP version : " + Manager_snmp_ver + "       Community string " + community_string + "\n Status" + status + "       Connection" + connection);
        }

        //constructor constructor of form1
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //opening configuration form of router
         
            router obj = new router(this);
            obj.Show();
        }
        
       
    private void button2_Click(object sender, EventArgs e)
        {
            //opening configuration form of switch
            Switch obj2 = new Switch(this);
        obj2.Show();
    }

        private void button3_Click(object sender, EventArgs e)
        {
            //opening configuration form of hub

            hub1 obj4 = new hub1(this);
            obj4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            work_st obj1 = new work_st(this);
            obj1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //opening configuration form of manager
            firewall obj3 = new firewall(this);
            obj3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
