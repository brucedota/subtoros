namespace SubScribertoRos
{
    partial class MainForm
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.rtxRecv = new System.Windows.Forms.RichTextBox();
            this.rtxSend = new System.Windows.Forms.RichTextBox();
            this.btnDisconn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(43, 77);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(69, 29);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(63, 13);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(91, 21);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "192.168.1.111";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(63, 41);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(91, 21);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "10001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(43, 194);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(99, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(43, 255);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(99, 23);
            this.btnRead.TabIndex = 6;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // rtxRecv
            // 
            this.rtxRecv.Location = new System.Drawing.Point(53, 285);
            this.rtxRecv.Name = "rtxRecv";
            this.rtxRecv.Size = new System.Drawing.Size(89, 49);
            this.rtxRecv.TabIndex = 8;
            this.rtxRecv.Text = "";
            // 
            // rtxSend
            // 
            this.rtxSend.Location = new System.Drawing.Point(53, 128);
            this.rtxSend.Name = "rtxSend";
            this.rtxSend.Size = new System.Drawing.Size(89, 49);
            this.rtxSend.TabIndex = 9;
            this.rtxSend.Text = "";
            // 
            // btnDisconn
            // 
            this.btnDisconn.Location = new System.Drawing.Point(119, 77);
            this.btnDisconn.Name = "btnDisconn";
            this.btnDisconn.Size = new System.Drawing.Size(74, 28);
            this.btnDisconn.TabIndex = 10;
            this.btnDisconn.Text = "disconnect";
            this.btnDisconn.UseVisualStyleBackColor = true;
            this.btnDisconn.Click += new System.EventHandler(this.btnDisconn_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(227, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 308);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDisconn);
            this.Controls.Add(this.rtxSend);
            this.Controls.Add(this.rtxRecv);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnConnect);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.RichTextBox rtxRecv;
        private System.Windows.Forms.RichTextBox rtxSend;
        private System.Windows.Forms.Button btnDisconn;
        private System.Windows.Forms.Panel panel1;
    }
}

