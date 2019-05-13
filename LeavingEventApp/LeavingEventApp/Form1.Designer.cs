namespace LeavingEventApp
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
            this.btnLeaveEvent = new System.Windows.Forms.Button();
            this.tbBraceletId = new System.Windows.Forms.TextBox();
            this.lbBrID = new System.Windows.Forms.Label();
            this.lbInformation = new System.Windows.Forms.ListBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLeaveEvent
            // 
            this.btnLeaveEvent.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnLeaveEvent.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaveEvent.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnLeaveEvent.Location = new System.Drawing.Point(845, 20);
            this.btnLeaveEvent.Name = "btnLeaveEvent";
            this.btnLeaveEvent.Size = new System.Drawing.Size(274, 124);
            this.btnLeaveEvent.TabIndex = 0;
            this.btnLeaveEvent.Text = "Leave Event";
            this.btnLeaveEvent.UseVisualStyleBackColor = false;
            this.btnLeaveEvent.Click += new System.EventHandler(this.btnLeaveEvent_Click);
            // 
            // tbBraceletId
            // 
            this.tbBraceletId.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBraceletId.Location = new System.Drawing.Point(287, 46);
            this.tbBraceletId.Name = "tbBraceletId";
            this.tbBraceletId.Size = new System.Drawing.Size(535, 98);
            this.tbBraceletId.TabIndex = 1;
            // 
            // lbBrID
            // 
            this.lbBrID.AutoSize = true;
            this.lbBrID.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrID.Location = new System.Drawing.Point(469, 6);
            this.lbBrID.Name = "lbBrID";
            this.lbBrID.Size = new System.Drawing.Size(184, 37);
            this.lbBrID.TabIndex = 2;
            this.lbBrID.Text = "Bracelet ID";
            // 
            // lbInformation
            // 
            this.lbInformation.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInformation.FormattingEnabled = true;
            this.lbInformation.ItemHeight = 46;
            this.lbInformation.Location = new System.Drawing.Point(12, 157);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(1107, 326);
            this.lbInformation.TabIndex = 3;
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(12, 20);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(220, 22);
            this.tbStatus.TabIndex = 4;
            this.tbStatus.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 495);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.lbBrID);
            this.Controls.Add(this.tbBraceletId);
            this.Controls.Add(this.btnLeaveEvent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SoD 2018";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeaveEvent;
        private System.Windows.Forms.TextBox tbBraceletId;
        private System.Windows.Forms.Label lbBrID;
        private System.Windows.Forms.ListBox lbInformation;
        private System.Windows.Forms.TextBox tbStatus;
    }
}

