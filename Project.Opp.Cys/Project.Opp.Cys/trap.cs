using System;
using System.Windows.Forms;

namespace Project.Opp.Cys
{
    public partial class trap : Form
    {
        private Timer click;
        private int count = 0;
        public trap()
        {
            InitializeComponent();
            //calling tomer function
            click = new Timer();
            //setting time to one second=1000 milli second
            click.Interval = 1000;
            click.Tick += Timer_Tick;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            //limit to print message
            if (count < 300)
            {
                textBox1.AppendText("Sending message to Network Manager....." + Environment.NewLine);
                count++;
            }
            else
            {
                // Stop the timer once 300 iterations are reached
                click.Stop();
            }
        }

        public void StartPrinting()
        {
            count = 0;
            textBox1.Clear();
            click.Start();
        }
        // Handle form closing event
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            click.Stop();
            click.Tick -= Timer_Tick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
