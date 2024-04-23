namespace Project.Opp.Cys
{
    partial class router
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(router));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SNMPVersioncomboBox = new System.Windows.Forms.ComboBox();
            this.ipbox = new System.Windows.Forms.TextBox();
            this.statuscomboBox = new System.Windows.Forms.ComboBox();
            this.modelNOtextbox = new System.Windows.Forms.TextBox();
            this.ConnectioncomboBox = new System.Windows.Forms.ComboBox();
            this.devicenamecombobox = new System.Windows.Forms.ComboBox();
            this.firmwarecomboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mistral", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(318, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROUTER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(32, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Device Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(32, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP Address :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(374, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "SNMP Version :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(377, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Model Number :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(32, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(374, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Connection :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(374, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Communnity string:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(32, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Firmware :";
            // 
            // SNMPVersioncomboBox
            // 
            this.SNMPVersioncomboBox.FormattingEnabled = true;
            this.SNMPVersioncomboBox.Items.AddRange(new object[] {
            "SNMP v1",
            "SNMP v2c",
            "SNMP v3"});
            this.SNMPVersioncomboBox.Location = new System.Drawing.Point(556, 156);
            this.SNMPVersioncomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SNMPVersioncomboBox.Name = "SNMPVersioncomboBox";
            this.SNMPVersioncomboBox.Size = new System.Drawing.Size(203, 28);
            this.SNMPVersioncomboBox.TabIndex = 9;
            this.SNMPVersioncomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ipbox
            // 
            this.ipbox.Location = new System.Drawing.Point(148, 156);
            this.ipbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ipbox.Name = "ipbox";
            this.ipbox.Size = new System.Drawing.Size(203, 26);
            this.ipbox.TabIndex = 10;
            this.ipbox.TextChanged += new System.EventHandler(this.ipbox_TextChanged);
            // 
            // statuscomboBox
            // 
            this.statuscomboBox.FormattingEnabled = true;
            this.statuscomboBox.Items.AddRange(new object[] {
            "ON",
            "OFF"});
            this.statuscomboBox.Location = new System.Drawing.Point(148, 194);
            this.statuscomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statuscomboBox.Name = "statuscomboBox";
            this.statuscomboBox.Size = new System.Drawing.Size(203, 28);
            this.statuscomboBox.TabIndex = 11;
            this.statuscomboBox.SelectedIndexChanged += new System.EventHandler(this.statuscomboBox_SelectedIndexChanged);
            // 
            // modelNOtextbox
            // 
            this.modelNOtextbox.Location = new System.Drawing.Point(556, 118);
            this.modelNOtextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modelNOtextbox.Name = "modelNOtextbox";
            this.modelNOtextbox.Size = new System.Drawing.Size(203, 26);
            this.modelNOtextbox.TabIndex = 12;
            // 
            // ConnectioncomboBox
            // 
            this.ConnectioncomboBox.FormattingEnabled = true;
            this.ConnectioncomboBox.Items.AddRange(new object[] {
            "Connected"});
            this.ConnectioncomboBox.Location = new System.Drawing.Point(556, 198);
            this.ConnectioncomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConnectioncomboBox.Name = "ConnectioncomboBox";
            this.ConnectioncomboBox.Size = new System.Drawing.Size(203, 28);
            this.ConnectioncomboBox.TabIndex = 13;
            // 
            // devicenamecombobox
            // 
            this.devicenamecombobox.FormattingEnabled = true;
            this.devicenamecombobox.Items.AddRange(new object[] {
            "Wired",
            "Gamming ",
            "Modem",
            "VPN"});
            this.devicenamecombobox.Location = new System.Drawing.Point(148, 118);
            this.devicenamecombobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.devicenamecombobox.Name = "devicenamecombobox";
            this.devicenamecombobox.Size = new System.Drawing.Size(203, 28);
            this.devicenamecombobox.TabIndex = 14;
            this.devicenamecombobox.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // firmwarecomboBox
            // 
            this.firmwarecomboBox.FormattingEnabled = true;
            this.firmwarecomboBox.Items.AddRange(new object[] {
            "2.0.1",
            "3.5.2",
            "4.1.0",
            "5.2.3"});
            this.firmwarecomboBox.Location = new System.Drawing.Point(148, 238);
            this.firmwarecomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firmwarecomboBox.Name = "firmwarecomboBox";
            this.firmwarecomboBox.Size = new System.Drawing.Size(203, 28);
            this.firmwarecomboBox.TabIndex = 15;
            this.firmwarecomboBox.SelectedIndexChanged += new System.EventHandler(this.firmwarecomboBox_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 324);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 38);
            this.button2.TabIndex = 18;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(556, 240);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 26);
            this.textBox1.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(556, 324);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 38);
            this.button3.TabIndex = 20;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 324);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 38);
            this.button1.TabIndex = 21;
            this.button1.Text = "Trap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // router
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::Project.Opp.Cys.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.firmwarecomboBox);
            this.Controls.Add(this.devicenamecombobox);
            this.Controls.Add(this.ConnectioncomboBox);
            this.Controls.Add(this.modelNOtextbox);
            this.Controls.Add(this.statuscomboBox);
            this.Controls.Add(this.ipbox);
            this.Controls.Add(this.SNMPVersioncomboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "router";
            this.Text = "Router";
            this.Load += new System.EventHandler(this.router_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox SNMPVersioncomboBox;
        private System.Windows.Forms.TextBox ipbox;
        private System.Windows.Forms.ComboBox statuscomboBox;
        private System.Windows.Forms.TextBox modelNOtextbox;
        private System.Windows.Forms.ComboBox ConnectioncomboBox;
        private System.Windows.Forms.ComboBox devicenamecombobox;
        private System.Windows.Forms.ComboBox firmwarecomboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}