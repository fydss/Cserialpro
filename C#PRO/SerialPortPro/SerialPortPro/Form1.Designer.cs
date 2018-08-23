using System;

namespace SerialPortPro
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer check_port;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.open = new System.Windows.Forms.Button();
            this.portname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.baudrate = new System.Windows.Forms.ComboBox();
            this.databits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stopbits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.parity = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.send_text = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rec_text = new System.Windows.Forms.TextBox();
            this.send_button = new System.Windows.Forms.Button();
            this.send_clear = new System.Windows.Forms.Button();
            this.rec_clear = new System.Windows.Forms.Button();
            this.send_hex = new System.Windows.Forms.RadioButton();
            this.send_ascii = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rec_hex = new System.Windows.Forms.RadioButton();
            this.rec_ascii = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.open_html = new System.Windows.Forms.Button();
            check_port = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // check_port
            // 
            check_port.Enabled = true;
            check_port.Interval = 2000;
            check_port.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // open
            // 
            this.open.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.open.Location = new System.Drawing.Point(7, 265);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 0;
            this.open.Text = "打开串口";
            this.open.UseVisualStyleBackColor = true;
            // 
            // portname
            // 
            this.portname.AllowDrop = true;
            this.portname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portname.FormattingEnabled = true;
            this.portname.Location = new System.Drawing.Point(76, 18);
            this.portname.Name = "portname";
            this.portname.Size = new System.Drawing.Size(121, 20);
            this.portname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(7, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "波特率：";
            // 
            // baudrate
            // 
            this.baudrate.AllowDrop = true;
            this.baudrate.FormattingEnabled = true;
            this.baudrate.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.baudrate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200"});
            this.baudrate.Location = new System.Drawing.Point(76, 68);
            this.baudrate.Name = "baudrate";
            this.baudrate.Size = new System.Drawing.Size(121, 20);
            this.baudrate.TabIndex = 6;
            // 
            // databits
            // 
            this.databits.AllowDrop = true;
            this.databits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.databits.FormattingEnabled = true;
            this.databits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.databits.Location = new System.Drawing.Point(76, 115);
            this.databits.MinimumSize = new System.Drawing.Size(121, 0);
            this.databits.Name = "databits";
            this.databits.Size = new System.Drawing.Size(121, 20);
            this.databits.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(7, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "数据位：";
            // 
            // stopbits
            // 
            this.stopbits.AllowDrop = true;
            this.stopbits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopbits.FormattingEnabled = true;
            this.stopbits.Items.AddRange(new object[] {
            "1",
            "2",
            "1.5"});
            this.stopbits.Location = new System.Drawing.Point(76, 159);
            this.stopbits.Name = "stopbits";
            this.stopbits.Size = new System.Drawing.Size(121, 20);
            this.stopbits.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(7, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "停止位";
            // 
            // parity
            // 
            this.parity.AllowDrop = true;
            this.parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parity.FormattingEnabled = true;
            this.parity.Items.AddRange(new object[] {
            "无",
            "奇",
            "偶",
            "1",
            "0"});
            this.parity.Location = new System.Drawing.Point(76, 207);
            this.parity.Name = "parity";
            this.parity.Size = new System.Drawing.Size(121, 20);
            this.parity.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(7, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "校验位：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(6, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 14);
            this.label7.TabIndex = 15;
            this.label7.Text = "接收模式";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 16;
            this.label2.Text = "串口号：";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.databits);
            this.groupBox1.Controls.Add(this.portname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.stopbits);
            this.groupBox1.Controls.Add(this.parity);
            this.groupBox1.Controls.Add(this.baudrate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 247);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // send_text
            // 
            this.send_text.Location = new System.Drawing.Point(6, 20);
            this.send_text.Multiline = true;
            this.send_text.Name = "send_text";
            this.send_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.send_text.Size = new System.Drawing.Size(265, 115);
            this.send_text.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.send_text);
            this.groupBox2.Location = new System.Drawing.Point(223, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 142);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "发送数据";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.rec_text);
            this.groupBox3.Location = new System.Drawing.Point(223, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 142);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "接收数据";
            // 
            // rec_text
            // 
            this.rec_text.Location = new System.Drawing.Point(3, 20);
            this.rec_text.Multiline = true;
            this.rec_text.Name = "rec_text";
            this.rec_text.ReadOnly = true;
            this.rec_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rec_text.Size = new System.Drawing.Size(265, 115);
            this.rec_text.TabIndex = 18;
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(3, 3);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(75, 23);
            this.send_button.TabIndex = 21;
            this.send_button.Text = "发送";
            this.send_button.UseVisualStyleBackColor = true;
            // 
            // send_clear
            // 
            this.send_clear.Location = new System.Drawing.Point(196, 3);
            this.send_clear.Name = "send_clear";
            this.send_clear.Size = new System.Drawing.Size(75, 23);
            this.send_clear.TabIndex = 22;
            this.send_clear.Text = "清空";
            this.send_clear.UseVisualStyleBackColor = true;
            // 
            // rec_clear
            // 
            this.rec_clear.Location = new System.Drawing.Point(190, 3);
            this.rec_clear.Name = "rec_clear";
            this.rec_clear.Size = new System.Drawing.Size(75, 22);
            this.rec_clear.TabIndex = 23;
            this.rec_clear.Text = "清空";
            this.rec_clear.UseVisualStyleBackColor = true;
            // 
            // send_hex
            // 
            this.send_hex.AutoSize = true;
            this.send_hex.Location = new System.Drawing.Point(3, 3);
            this.send_hex.Name = "send_hex";
            this.send_hex.Size = new System.Drawing.Size(41, 16);
            this.send_hex.TabIndex = 25;
            this.send_hex.Text = "Hex";
            this.send_hex.UseVisualStyleBackColor = true;
            // 
            // send_ascii
            // 
            this.send_ascii.AutoSize = true;
            this.send_ascii.Checked = true;
            this.send_ascii.Location = new System.Drawing.Point(50, 3);
            this.send_ascii.Name = "send_ascii";
            this.send_ascii.Size = new System.Drawing.Size(53, 16);
            this.send_ascii.TabIndex = 24;
            this.send_ascii.TabStop = true;
            this.send_ascii.Text = "ASCII";
            this.send_ascii.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.send_hex);
            this.panel1.Controls.Add(this.send_ascii);
            this.panel1.Location = new System.Drawing.Point(84, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 22);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.rec_hex);
            this.panel2.Controls.Add(this.rec_ascii);
            this.panel2.Location = new System.Drawing.Point(72, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(106, 22);
            this.panel2.TabIndex = 27;
            // 
            // rec_hex
            // 
            this.rec_hex.AutoSize = true;
            this.rec_hex.Location = new System.Drawing.Point(3, 3);
            this.rec_hex.Name = "rec_hex";
            this.rec_hex.Size = new System.Drawing.Size(41, 16);
            this.rec_hex.TabIndex = 25;
            this.rec_hex.Text = "Hex";
            this.rec_hex.UseVisualStyleBackColor = true;
            // 
            // rec_ascii
            // 
            this.rec_ascii.AutoSize = true;
            this.rec_ascii.Checked = true;
            this.rec_ascii.Location = new System.Drawing.Point(50, 3);
            this.rec_ascii.Name = "rec_ascii";
            this.rec_ascii.Size = new System.Drawing.Size(53, 16);
            this.rec_ascii.TabIndex = 24;
            this.rec_ascii.TabStop = true;
            this.rec_ascii.Text = "ASCII";
            this.rec_ascii.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rec_clear);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(229, 337);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 28);
            this.panel3.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(this.send_clear);
            this.panel4.Controls.Add(this.send_button);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(223, 153);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(274, 29);
            this.panel4.TabIndex = 19;
            // 
            // open_html
            // 
            this.open_html.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("open_html.BackgroundImage")));
            this.open_html.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.open_html.FlatAppearance.BorderSize = 0;
            this.open_html.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_html.Location = new System.Drawing.Point(7, 303);
            this.open_html.Name = "open_html";
            this.open_html.Size = new System.Drawing.Size(210, 56);
            this.open_html.TabIndex = 27;
            this.open_html.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(511, 389);
            this.Controls.Add(this.open_html);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.open);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "串口调试";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button open;
        private System.Windows.Forms.ComboBox portname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox baudrate;
        private System.Windows.Forms.ComboBox databits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox stopbits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox parity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox send_text;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox rec_text;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.Button send_clear;
        private System.Windows.Forms.Button rec_clear;
        private System.Windows.Forms.RadioButton send_hex;
        private System.Windows.Forms.RadioButton send_ascii;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rec_hex;
        private System.Windows.Forms.RadioButton rec_ascii;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button open_html;
    }
}

