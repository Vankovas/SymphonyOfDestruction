namespace WindowsFormsApp1
{
    partial class FoodAndDrinksApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodAndDrinksApp));
            this.lbBill = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlFoodDrinks = new System.Windows.Forms.TabControl();
            this.tabPageFood = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPageDrinks = new System.Windows.Forms.TabPage();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.tabControlFoodDrinks.SuspendLayout();
            this.tabPageFood.SuspendLayout();
            this.tabPageDrinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBill
            // 
            this.lbBill.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBill.FormattingEnabled = true;
            this.lbBill.ItemHeight = 26;
            this.lbBill.Location = new System.Drawing.Point(19, 51);
            this.lbBill.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbBill.Name = "lbBill";
            this.lbBill.Size = new System.Drawing.Size(395, 602);
            this.lbBill.TabIndex = 0;
            this.lbBill.SelectedIndexChanged += new System.EventHandler(this.lbBill_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "BILL";
            // 
            // tabControlFoodDrinks
            // 
            this.tabControlFoodDrinks.Controls.Add(this.tabPageFood);
            this.tabControlFoodDrinks.Controls.Add(this.tabPageDrinks);
            this.tabControlFoodDrinks.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlFoodDrinks.Location = new System.Drawing.Point(445, 16);
            this.tabControlFoodDrinks.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabControlFoodDrinks.Name = "tabControlFoodDrinks";
            this.tabControlFoodDrinks.SelectedIndex = 0;
            this.tabControlFoodDrinks.Size = new System.Drawing.Size(1387, 690);
            this.tabControlFoodDrinks.TabIndex = 2;
            // 
            // tabPageFood
            // 
            this.tabPageFood.Controls.Add(this.button17);
            this.tabPageFood.Controls.Add(this.button16);
            this.tabPageFood.Controls.Add(this.button7);
            this.tabPageFood.Controls.Add(this.button8);
            this.tabPageFood.Controls.Add(this.button5);
            this.tabPageFood.Controls.Add(this.button6);
            this.tabPageFood.Controls.Add(this.button3);
            this.tabPageFood.Controls.Add(this.button4);
            this.tabPageFood.Controls.Add(this.button1);
            this.tabPageFood.Controls.Add(this.button2);
            this.tabPageFood.Location = new System.Drawing.Point(4, 40);
            this.tabPageFood.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPageFood.Name = "tabPageFood";
            this.tabPageFood.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPageFood.Size = new System.Drawing.Size(1379, 646);
            this.tabPageFood.TabIndex = 0;
            this.tabPageFood.Text = "Food";
            this.tabPageFood.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(181, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 121);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(9, 8);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 121);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPageDrinks
            // 
            this.tabPageDrinks.Controls.Add(this.button15);
            this.tabPageDrinks.Controls.Add(this.button14);
            this.tabPageDrinks.Controls.Add(this.button12);
            this.tabPageDrinks.Controls.Add(this.button13);
            this.tabPageDrinks.Controls.Add(this.button9);
            this.tabPageDrinks.Controls.Add(this.button10);
            this.tabPageDrinks.Controls.Add(this.button11);
            this.tabPageDrinks.Controls.Add(this.btn3);
            this.tabPageDrinks.Controls.Add(this.btn2);
            this.tabPageDrinks.Controls.Add(this.btn1);
            this.tabPageDrinks.Location = new System.Drawing.Point(4, 40);
            this.tabPageDrinks.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPageDrinks.Name = "tabPageDrinks";
            this.tabPageDrinks.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPageDrinks.Size = new System.Drawing.Size(1379, 646);
            this.tabPageDrinks.TabIndex = 1;
            this.tabPageDrinks.Tag = "";
            this.tabPageDrinks.Text = "Drinks";
            this.tabPageDrinks.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Black;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn3.Location = new System.Drawing.Point(353, 8);
            this.btn3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(161, 121);
            this.btn3.TabIndex = 4;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Black;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn2.Location = new System.Drawing.Point(182, 8);
            this.btn2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(161, 121);
            this.btn2.TabIndex = 3;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btnJupiler_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Black;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn1.Location = new System.Drawing.Point(10, 8);
            this.btn1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(161, 121);
            this.btn1.TabIndex = 2;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnBavaria_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 763);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total:";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Black;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPay.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPay.Location = new System.Drawing.Point(1169, 714);
            this.btnPay.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(321, 80);
            this.btnPay.TabIndex = 9;
            this.btnPay.Text = "PAY";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.BackColor = System.Drawing.Color.Black;
            this.btnAbort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbort.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbort.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAbort.Location = new System.Drawing.Point(1507, 713);
            this.btnAbort.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(321, 80);
            this.btnAbort.TabIndex = 10;
            this.btnAbort.Text = "ABORT/CLEAR";
            this.btnAbort.UseVisualStyleBackColor = false;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Black;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemove.Location = new System.Drawing.Point(117, 665);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(194, 41);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(584, 713);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(254, 43);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(244, 734);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 68);
            this.lblTotal.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(445, 725);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "Quantity:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(524, 8);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 121);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(352, 8);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 121);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Location = new System.Drawing.Point(867, 8);
            this.button5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 121);
            this.button5.TabIndex = 9;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Location = new System.Drawing.Point(695, 8);
            this.button6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(161, 121);
            this.button6.TabIndex = 8;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button7.Location = new System.Drawing.Point(1210, 8);
            this.button7.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(161, 121);
            this.button7.TabIndex = 11;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button8.Location = new System.Drawing.Point(1038, 8);
            this.button8.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(161, 121);
            this.button8.TabIndex = 10;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Black;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button9.Location = new System.Drawing.Point(867, 8);
            this.button9.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(161, 121);
            this.button9.TabIndex = 7;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Black;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button10.Location = new System.Drawing.Point(696, 8);
            this.button10.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(161, 121);
            this.button10.TabIndex = 6;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Black;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button11.Location = new System.Drawing.Point(524, 8);
            this.button11.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(161, 121);
            this.button11.TabIndex = 5;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Black;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button12.Location = new System.Drawing.Point(1208, 8);
            this.button12.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(161, 121);
            this.button12.TabIndex = 9;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Black;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button13.Location = new System.Drawing.Point(1037, 8);
            this.button13.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(161, 121);
            this.button13.TabIndex = 8;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Black;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button14.Location = new System.Drawing.Point(10, 137);
            this.button14.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(161, 121);
            this.button14.TabIndex = 10;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Black;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button15.Location = new System.Drawing.Point(182, 137);
            this.button15.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(161, 121);
            this.button15.TabIndex = 11;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Black;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button16.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button16.Location = new System.Drawing.Point(10, 137);
            this.button16.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(161, 121);
            this.button16.TabIndex = 12;
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Black;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button17.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button17.Location = new System.Drawing.Point(181, 137);
            this.button17.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(161, 121);
            this.button17.TabIndex = 13;
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1924, 857);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControlFoodDrinks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbBill);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "SOD2018";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlFoodDrinks.ResumeLayout(false);
            this.tabPageFood.ResumeLayout(false);
            this.tabPageDrinks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox lbBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlFoodDrinks;
        private System.Windows.Forms.TabPage tabPageFood;
        private System.Windows.Forms.TabPage tabPageDrinks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
    }
}

