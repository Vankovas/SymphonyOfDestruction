namespace WindowsFormsApp1
{
    partial class PayPopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayPopUp));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.tbBraceletId = new System.Windows.Forms.TextBox();
            this.btnPayFinal = new System.Windows.Forms.Button();
            this.tbTotalFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "BraceletID:";
            // 
            // tbStatus
            // 
            this.tbStatus.Enabled = false;
            this.tbStatus.Location = new System.Drawing.Point(280, 105);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.Size = new System.Drawing.Size(277, 31);
            this.tbStatus.TabIndex = 2;
            // 
            // tbBraceletId
            // 
            this.tbBraceletId.Enabled = false;
            this.tbBraceletId.Location = new System.Drawing.Point(280, 153);
            this.tbBraceletId.Name = "tbBraceletId";
            this.tbBraceletId.ReadOnly = true;
            this.tbBraceletId.Size = new System.Drawing.Size(277, 31);
            this.tbBraceletId.TabIndex = 3;
            // 
            // btnPayFinal
            // 
            this.btnPayFinal.BackColor = System.Drawing.Color.Black;
            this.btnPayFinal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPayFinal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPayFinal.Location = new System.Drawing.Point(413, 211);
            this.btnPayFinal.Name = "btnPayFinal";
            this.btnPayFinal.Size = new System.Drawing.Size(144, 45);
            this.btnPayFinal.TabIndex = 4;
            this.btnPayFinal.Text = "PAY";
            this.btnPayFinal.UseVisualStyleBackColor = false;
            this.btnPayFinal.Click += new System.EventHandler(this.btnPayFinal_Click);
            // 
            // tbTotalFinal
            // 
            this.tbTotalFinal.Enabled = false;
            this.tbTotalFinal.Font = new System.Drawing.Font("Rockwell", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalFinal.Location = new System.Drawing.Point(456, 31);
            this.tbTotalFinal.Multiline = true;
            this.tbTotalFinal.Name = "tbTotalFinal";
            this.tbTotalFinal.ReadOnly = true;
            this.tbTotalFinal.Size = new System.Drawing.Size(101, 59);
            this.tbTotalFinal.TabIndex = 6;
            this.tbTotalFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total:";
            // 
            // PayPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(749, 321);
            this.Controls.Add(this.tbTotalFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPayFinal);
            this.Controls.Add(this.tbBraceletId);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PayPopUp";
            this.Text = "SOD2018";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PayPopUp_FormClosing);
            this.Load += new System.EventHandler(this.PayPopUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.TextBox tbBraceletId;
        private System.Windows.Forms.Button btnPayFinal;
        public System.Windows.Forms.TextBox tbTotalFinal;
        private System.Windows.Forms.Label label3;
    }
}