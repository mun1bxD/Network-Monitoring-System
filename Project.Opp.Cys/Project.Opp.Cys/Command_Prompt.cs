using System;
using System.Windows.Forms;

namespace Project.Opp.Cys.Properties
{

    public partial class Command_Prompt : Form
    {
        
        private TextBox textBox;
        //initializing the textbox that is use as command prompt
        public Command_Prompt(TextBox textBox1)
        {
            InitializeComponent();
            this.textBox = textBox1;
             
        }

        private void Command_Prompt_Load(object sender, EventArgs e)
        {

        }
        public void messageshow(string message)
        {
            //using Append text to futher print a message on  the window
           textBox1.AppendText(message);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
