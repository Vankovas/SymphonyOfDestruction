namespace LoaningApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.lbSHOP = new System.Windows.Forms.ListBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.tbBraceletId = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBraceletID2 = new System.Windows.Forms.TextBox();
            this.lbInformation = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnChargerReturn = new System.Windows.Forms.Button();
            this.btnReturnUSB = new System.Windows.Forms.Button();
            this.btnLaptopReturn = new System.Windows.Forms.Button();
            this.btnCameraReturn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Font = new System.Drawing.Font("Rockwell", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Cornsilk;
            this.button1.Location = new System.Drawing.Point(991, 630);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(505, 153);
            this.button1.TabIndex = 0;
            this.button1.Text = "LOAN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbSHOP
            // 
            this.lbSHOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSHOP.FormattingEnabled = true;
            this.lbSHOP.ItemHeight = 46;
            this.lbSHOP.Location = new System.Drawing.Point(7, 18);
            this.lbSHOP.Name = "lbSHOP";
            this.lbSHOP.Size = new System.Drawing.Size(475, 510);
            this.lbSHOP.TabIndex = 2;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Rockwell", 47F);
            this.lbTotal.Location = new System.Drawing.Point(492, 608);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(340, 88);
            this.lbTotal.TabIndex = 4;
            this.lbTotal.Text = "Loan: 0$";
            // 
            // tbBraceletId
            // 
            this.tbBraceletId.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBraceletId.Location = new System.Drawing.Point(1007, 570);
            this.tbBraceletId.Name = "tbBraceletId";
            this.tbBraceletId.Size = new System.Drawing.Size(469, 54);
            this.tbBraceletId.TabIndex = 5;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnReturn.Font = new System.Drawing.Font("Rockwell", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.Crimson;
            this.btnReturn.Location = new System.Drawing.Point(7, 550);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(485, 205);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "return selected";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1632, 886);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbStatus);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.lbTotal);
            this.tabPage1.Controls.Add(this.btnReturn);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.tbBraceletId);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.lbSHOP);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1624, 857);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "LOAN ITEMS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(0, 771);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(330, 22);
            this.tbStatus.TabIndex = 10;
            this.tbStatus.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.btnChargerReturn);
            this.tabPage2.Controls.Add(this.btnReturnUSB);
            this.tabPage2.Controls.Add(this.btnLaptopReturn);
            this.tabPage2.Controls.Add(this.btnCameraReturn);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tbBraceletID2);
            this.tabPage2.Controls.Add(this.lbInformation);
            this.tabPage2.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1624, 857);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RETURN ITEMS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.WindowText;
            this.button6.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Cornsilk;
            this.button6.Location = new System.Drawing.Point(1302, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(195, 83);
            this.button6.TabIndex = 10;
            this.button6.Text = "Manual Input";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.WindowText;
            this.button7.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Crimson;
            this.button7.Location = new System.Drawing.Point(21, 444);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(600, 296);
            this.button7.TabIndex = 5;
            this.button7.Text = "RETURN ALL";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, -5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 68);
            this.label2.TabIndex = 4;
            this.label2.Text = "Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(996, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "BraceletID";
            // 
            // tbBraceletID2
            // 
            this.tbBraceletID2.Font = new System.Drawing.Font("Rockwell", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBraceletID2.Location = new System.Drawing.Point(918, 66);
            this.tbBraceletID2.Name = "tbBraceletID2";
            this.tbBraceletID2.Size = new System.Drawing.Size(333, 58);
            this.tbBraceletID2.TabIndex = 2;
            // 
            // lbInformation
            // 
            this.lbInformation.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInformation.FormattingEnabled = true;
            this.lbInformation.ItemHeight = 46;
            this.lbInformation.Location = new System.Drawing.Point(24, 66);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(588, 372);
            this.lbInformation.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlText;
            this.button5.Font = new System.Drawing.Font("Rockwell", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Gold;
            this.button5.Image = global::LoaningApp.Properties.Resources.b013ugdmjq;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(991, 295);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(505, 258);
            this.button5.TabIndex = 8;
            this.button5.Text = "USB cabel";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlText;
            this.button2.Font = new System.Drawing.Font("Rockwell", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gold;
            this.button2.Image = global::LoaningApp.Properties.Resources._280818;
            this.button2.Location = new System.Drawing.Point(523, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(462, 283);
            this.button2.TabIndex = 3;
            this.button2.Text = "Video Camera";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlText;
            this.button4.Font = new System.Drawing.Font("Rockwell", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Gold;
            this.button4.Image = global::LoaningApp.Properties.Resources.sm_thumbnail_1493732508_750;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.Location = new System.Drawing.Point(991, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(505, 283);
            this.button4.TabIndex = 7;
            this.button4.Text = "Laptop";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Rockwell", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Gold;
            this.button3.Image = global::LoaningApp.Properties.Resources._31795gKUP0L__SX355_;
            this.button3.Location = new System.Drawing.Point(523, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(462, 258);
            this.button3.TabIndex = 6;
            this.button3.Text = "Phone Charger";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnChargerReturn
            // 
            this.btnChargerReturn.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnChargerReturn.Font = new System.Drawing.Font("Rockwell", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChargerReturn.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnChargerReturn.Image = global::LoaningApp.Properties.Resources.Untitleasdasdasdasd;
            this.btnChargerReturn.Location = new System.Drawing.Point(1091, 444);
            this.btnChargerReturn.Name = "btnChargerReturn";
            this.btnChargerReturn.Size = new System.Drawing.Size(415, 316);
            this.btnChargerReturn.TabIndex = 9;
            this.btnChargerReturn.Text = "Return Charger";
            this.btnChargerReturn.UseVisualStyleBackColor = false;
            this.btnChargerReturn.Click += new System.EventHandler(this.btnChargerReturn_Click);
            // 
            // btnReturnUSB
            // 
            this.btnReturnUSB.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnReturnUSB.Font = new System.Drawing.Font("Rockwell", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnUSB.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnReturnUSB.Image = global::LoaningApp.Properties.Resources.b013ugdmjq___Copy__2_;
            this.btnReturnUSB.Location = new System.Drawing.Point(1091, 130);
            this.btnReturnUSB.Name = "btnReturnUSB";
            this.btnReturnUSB.Size = new System.Drawing.Size(415, 308);
            this.btnReturnUSB.TabIndex = 8;
            this.btnReturnUSB.Text = "Return USB Only";
            this.btnReturnUSB.UseVisualStyleBackColor = false;
            this.btnReturnUSB.Click += new System.EventHandler(this.btnReturnUSB_Click);
            // 
            // btnLaptopReturn
            // 
            this.btnLaptopReturn.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnLaptopReturn.Font = new System.Drawing.Font("Rockwell", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaptopReturn.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnLaptopReturn.Image = global::LoaningApp.Properties.Resources.sm_thumbnail_14937325081;
            this.btnLaptopReturn.Location = new System.Drawing.Point(638, 444);
            this.btnLaptopReturn.Name = "btnLaptopReturn";
            this.btnLaptopReturn.Size = new System.Drawing.Size(447, 316);
            this.btnLaptopReturn.TabIndex = 7;
            this.btnLaptopReturn.Text = "Return Laptop";
            this.btnLaptopReturn.UseVisualStyleBackColor = false;
            this.btnLaptopReturn.Click += new System.EventHandler(this.btnLaptopReturn_Click);
            // 
            // btnCameraReturn
            // 
            this.btnCameraReturn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCameraReturn.Font = new System.Drawing.Font("Rockwell", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCameraReturn.ForeColor = System.Drawing.Color.Thistle;
            this.btnCameraReturn.Image = global::LoaningApp.Properties.Resources._2808181;
            this.btnCameraReturn.Location = new System.Drawing.Point(638, 130);
            this.btnCameraReturn.Name = "btnCameraReturn";
            this.btnCameraReturn.Size = new System.Drawing.Size(447, 308);
            this.btnCameraReturn.TabIndex = 6;
            this.btnCameraReturn.Text = "Return Camera";
            this.btnCameraReturn.UseVisualStyleBackColor = false;
            this.btnCameraReturn.Click += new System.EventHandler(this.btnCameraReturn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1570, 819);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SOD2018";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbSHOP;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox tbBraceletId;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBraceletID2;
        private System.Windows.Forms.ListBox lbInformation;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnChargerReturn;
        private System.Windows.Forms.Button btnReturnUSB;
        private System.Windows.Forms.Button btnLaptopReturn;
        private System.Windows.Forms.Button btnCameraReturn;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Button button6;
    }
}

