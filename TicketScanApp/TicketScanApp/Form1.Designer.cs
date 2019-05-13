namespace TicketScanApp
{
    partial class TicketScanForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketScanForm));
            this.videoViewer = new Ozeki.Media.VideoViewerWF();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnManualInput = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listBoxDetails = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.videoViewerWF1 = new Ozeki.Media.VideoViewerWF();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbBraceletId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTicketId = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnBuyTicket = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxSunday = new System.Windows.Forms.CheckBox();
            this.checkBoxSaturday = new System.Windows.Forms.CheckBox();
            this.checkBoxFriday = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNewTicket = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoViewer
            // 
            this.videoViewer.BackColor = System.Drawing.Color.Black;
            this.videoViewer.ContextMenuEnabled = true;
            this.videoViewer.FlipMode = Ozeki.Media.FlipMode.None;
            this.videoViewer.FrameStretch = Ozeki.Media.FrameStretch.Uniform;
            this.videoViewer.FullScreenEnabled = true;
            this.videoViewer.Location = new System.Drawing.Point(0, 0);
            this.videoViewer.Name = "videoViewer";
            this.videoViewer.RotateAngle = 0;
            this.videoViewer.Size = new System.Drawing.Size(0, 0);
            this.videoViewer.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1677, 857);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage2.Size = new System.Drawing.Size(1669, 809);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Scan Ticket";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnManualInput);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.listBoxDetails);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(855, 19);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox3.Size = new System.Drawing.Size(684, 702);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manual Input";
            // 
            // btnManualInput
            // 
            this.btnManualInput.BackColor = System.Drawing.Color.Black;
            this.btnManualInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManualInput.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManualInput.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnManualInput.Location = new System.Drawing.Point(265, 32);
            this.btnManualInput.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnManualInput.Name = "btnManualInput";
            this.btnManualInput.Size = new System.Drawing.Size(164, 38);
            this.btnManualInput.TabIndex = 9;
            this.btnManualInput.Text = "Manual Input";
            this.btnManualInput.UseVisualStyleBackColor = false;
            this.btnManualInput.Click += new System.EventHandler(this.btnManualInput_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.Enabled = false;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.Location = new System.Drawing.Point(491, 101);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(151, 38);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listBoxDetails
            // 
            this.listBoxDetails.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDetails.FormattingEnabled = true;
            this.listBoxDetails.ItemHeight = 35;
            this.listBoxDetails.Location = new System.Drawing.Point(45, 171);
            this.listBoxDetails.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listBoxDetails.Name = "listBoxDetails";
            this.listBoxDetails.Size = new System.Drawing.Size(597, 494);
            this.listBoxDetails.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "TicketID:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(163, 101);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(282, 39);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.videoViewerWF1);
            this.groupBox2.Location = new System.Drawing.Point(35, 19);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Size = new System.Drawing.Size(761, 506);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camera";
            // 
            // videoViewerWF1
            // 
            this.videoViewerWF1.BackColor = System.Drawing.Color.Black;
            this.videoViewerWF1.ContextMenuEnabled = true;
            this.videoViewerWF1.FlipMode = Ozeki.Media.FlipMode.None;
            this.videoViewerWF1.ForeColor = System.Drawing.Color.Black;
            this.videoViewerWF1.FrameStretch = Ozeki.Media.FrameStretch.Uniform;
            this.videoViewerWF1.FullScreenEnabled = true;
            this.videoViewerWF1.Location = new System.Drawing.Point(12, 32);
            this.videoViewerWF1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.videoViewerWF1.Name = "videoViewerWF1";
            this.videoViewerWF1.RotateAngle = 0;
            this.videoViewerWF1.Size = new System.Drawing.Size(737, 465);
            this.videoViewerWF1.TabIndex = 8;
            this.videoViewerWF1.Text = "videoViewerWF3";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbStatus);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.tbBraceletId);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbTicketId);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage1.Size = new System.Drawing.Size(1669, 809);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Assign Bracelet";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(766, 84);
            this.tbStatus.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.Size = new System.Drawing.Size(277, 43);
            this.tbStatus.TabIndex = 11;
            this.tbStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(653, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 35);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(796, 304);
            this.button1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 66);
            this.button1.TabIndex = 9;
            this.button1.Text = "Assign";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbBraceletId
            // 
            this.tbBraceletId.Location = new System.Drawing.Point(766, 236);
            this.tbBraceletId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbBraceletId.Name = "tbBraceletId";
            this.tbBraceletId.ReadOnly = true;
            this.tbBraceletId.Size = new System.Drawing.Size(277, 43);
            this.tbBraceletId.TabIndex = 3;
            this.tbBraceletId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 35);
            this.label4.TabIndex = 2;
            this.label4.Text = "BraceletID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 35);
            this.label3.TabIndex = 1;
            this.label3.Text = "TicketID:";
            // 
            // tbTicketId
            // 
            this.tbTicketId.Location = new System.Drawing.Point(766, 154);
            this.tbTicketId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbTicketId.Name = "tbTicketId";
            this.tbTicketId.ReadOnly = true;
            this.tbTicketId.Size = new System.Drawing.Size(277, 43);
            this.tbTicketId.TabIndex = 0;
            this.tbTicketId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxNewTicket);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.btnBuyTicket);
            this.tabPage3.Controls.Add(this.tbEmail);
            this.tabPage3.Controls.Add(this.tbLname);
            this.tabPage3.Controls.Add(this.tbFname);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage3.Size = new System.Drawing.Size(1669, 809);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Buy Ticket";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnBuyTicket
            // 
            this.btnBuyTicket.BackColor = System.Drawing.Color.Black;
            this.btnBuyTicket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuyTicket.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyTicket.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuyTicket.Location = new System.Drawing.Point(530, 393);
            this.btnBuyTicket.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnBuyTicket.Name = "btnBuyTicket";
            this.btnBuyTicket.Size = new System.Drawing.Size(247, 66);
            this.btnBuyTicket.TabIndex = 10;
            this.btnBuyTicket.Text = "Buy";
            this.btnBuyTicket.UseVisualStyleBackColor = false;
            this.btnBuyTicket.Click += new System.EventHandler(this.btnBuyTicket_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(339, 216);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(438, 43);
            this.tbEmail.TabIndex = 7;
            // 
            // tbLname
            // 
            this.tbLname.Location = new System.Drawing.Point(339, 167);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(438, 43);
            this.tbLname.TabIndex = 6;
            // 
            // tbFname
            // 
            this.tbFname.Location = new System.Drawing.Point(339, 118);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(438, 43);
            this.tbFname.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxSunday);
            this.groupBox1.Controls.Add(this.checkBoxSaturday);
            this.groupBox1.Controls.Add(this.checkBoxFriday);
            this.groupBox1.Location = new System.Drawing.Point(336, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 98);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxSunday
            // 
            this.checkBoxSunday.AutoSize = true;
            this.checkBoxSunday.Checked = true;
            this.checkBoxSunday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSunday.Location = new System.Drawing.Point(306, 38);
            this.checkBoxSunday.Name = "checkBoxSunday";
            this.checkBoxSunday.Size = new System.Drawing.Size(139, 39);
            this.checkBoxSunday.TabIndex = 2;
            this.checkBoxSunday.Text = "Sunday";
            this.checkBoxSunday.UseVisualStyleBackColor = true;
            // 
            // checkBoxSaturday
            // 
            this.checkBoxSaturday.AutoSize = true;
            this.checkBoxSaturday.Checked = true;
            this.checkBoxSaturday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSaturday.Location = new System.Drawing.Point(141, 38);
            this.checkBoxSaturday.Name = "checkBoxSaturday";
            this.checkBoxSaturday.Size = new System.Drawing.Size(160, 39);
            this.checkBoxSaturday.TabIndex = 1;
            this.checkBoxSaturday.Text = "Saturday";
            this.checkBoxSaturday.UseVisualStyleBackColor = true;
            // 
            // checkBoxFriday
            // 
            this.checkBoxFriday.AutoSize = true;
            this.checkBoxFriday.Checked = true;
            this.checkBoxFriday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFriday.Location = new System.Drawing.Point(7, 38);
            this.checkBoxFriday.Name = "checkBoxFriday";
            this.checkBoxFriday.Size = new System.Drawing.Size(128, 39);
            this.checkBoxFriday.TabIndex = 0;
            this.checkBoxFriday.Text = "Friday";
            this.checkBoxFriday.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(227, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 35);
            this.label8.TabIndex = 3;
            this.label8.Text = "Days:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 35);
            this.label7.TabIndex = 2;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 35);
            this.label6.TabIndex = 1;
            this.label6.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(384, 490);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 35);
            this.label9.TabIndex = 12;
            this.label9.Text = "TicketID:";
            // 
            // textBoxNewTicket
            // 
            this.textBoxNewTicket.Location = new System.Drawing.Point(530, 482);
            this.textBoxNewTicket.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxNewTicket.Name = "textBoxNewTicket";
            this.textBoxNewTicket.ReadOnly = true;
            this.textBoxNewTicket.Size = new System.Drawing.Size(247, 43);
            this.textBoxNewTicket.TabIndex = 13;
            this.textBoxNewTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TicketScanForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1686, 873);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "TicketScanForm";
            this.Text = "SOD2018";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TicketScanForm_FormClosing);
            this.Load += new System.EventHandler(this.TicketScanForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Ozeki.Media.VideoViewerWF videoViewer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Ozeki.Media.VideoViewerWF videoViewerWF1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbBraceletId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTicketId;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnManualInput;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxSunday;
        private System.Windows.Forms.CheckBox checkBoxSaturday;
        private System.Windows.Forms.CheckBox checkBoxFriday;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuyTicket;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNewTicket;
    }
}

