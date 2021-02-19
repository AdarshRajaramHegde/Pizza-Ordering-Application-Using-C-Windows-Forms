namespace Simple_Order_System
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GroupBoxPizzaMenu = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.H_Pizza = new System.Windows.Forms.TextBox();
            this.P_Pizza = new System.Windows.Forms.TextBox();
            this.M_pizza = new System.Windows.Forms.TextBox();
            this.LabelHamPineapple_Pizza = new System.Windows.Forms.Label();
            this.LabelMargherita_Pizza = new System.Windows.Forms.Label();
            this.LabelPepperoni_Pizza = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.GroupBox_OrderDetails = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupBox_CompanyDetails = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.PanelOne = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.T_No = new System.Windows.Forms.TextBox();
            this.LabelTableNo = new System.Windows.Forms.Label();
            this.S_Name = new System.Windows.Forms.TextBox();
            this.LabelServerName = new System.Windows.Forms.Label();
            this.PanelTwo = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelTotalCompany_Transactions = new System.Windows.Forms.Label();
            this.labelTotalNumber_Pizzas = new System.Windows.Forms.Label();
            this.labelTotalCompany_Receipts = new System.Windows.Forms.Label();
            this.labelAverageCompany_Transaction = new System.Windows.Forms.Label();
            this.labelServer_Name = new System.Windows.Forms.Label();
            this.labelTotal_Pizzas = new System.Windows.Forms.Label();
            this.labelTotalOrder_Receipts = new System.Windows.Forms.Label();
            this.GroupBoxPizzaMenu.SuspendLayout();
            this.GroupBox_OrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GroupBox_CompanyDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PanelOne.SuspendLayout();
            this.PanelTwo.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxPizzaMenu
            // 
            this.GroupBoxPizzaMenu.Controls.Add(this.label10);
            this.GroupBoxPizzaMenu.Controls.Add(this.label9);
            this.GroupBoxPizzaMenu.Controls.Add(this.label8);
            this.GroupBoxPizzaMenu.Controls.Add(this.H_Pizza);
            this.GroupBoxPizzaMenu.Controls.Add(this.P_Pizza);
            this.GroupBoxPizzaMenu.Controls.Add(this.M_pizza);
            this.GroupBoxPizzaMenu.Controls.Add(this.LabelHamPineapple_Pizza);
            this.GroupBoxPizzaMenu.Controls.Add(this.LabelMargherita_Pizza);
            this.GroupBoxPizzaMenu.Controls.Add(this.LabelPepperoni_Pizza);
            this.GroupBoxPizzaMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxPizzaMenu.Location = new System.Drawing.Point(32, 117);
            this.GroupBoxPizzaMenu.Name = "GroupBoxPizzaMenu";
            this.GroupBoxPizzaMenu.Size = new System.Drawing.Size(803, 173);
            this.GroupBoxPizzaMenu.TabIndex = 4;
            this.GroupBoxPizzaMenu.TabStop = false;
            this.GroupBoxPizzaMenu.Text = "Pizza Menu";
            this.GroupBoxPizzaMenu.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(549, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "@ €12.79";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(549, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "@ €11.50";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(549, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "@ €9";
            // 
            // H_Pizza
            // 
            this.H_Pizza.Location = new System.Drawing.Point(350, 135);
            this.H_Pizza.Name = "H_Pizza";
            this.H_Pizza.Size = new System.Drawing.Size(74, 26);
            this.H_Pizza.TabIndex = 7;
            this.H_Pizza.Text = "0";
            this.H_Pizza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // P_Pizza
            // 
            this.P_Pizza.Location = new System.Drawing.Point(350, 92);
            this.P_Pizza.Name = "P_Pizza";
            this.P_Pizza.Size = new System.Drawing.Size(74, 26);
            this.P_Pizza.TabIndex = 6;
            this.P_Pizza.Text = "0";
            this.P_Pizza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // M_pizza
            // 
            this.M_pizza.Location = new System.Drawing.Point(350, 51);
            this.M_pizza.Name = "M_pizza";
            this.M_pizza.Size = new System.Drawing.Size(74, 26);
            this.M_pizza.TabIndex = 5;
            this.M_pizza.Text = "0";
            this.M_pizza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelHamPineapple_Pizza
            // 
            this.LabelHamPineapple_Pizza.AutoSize = true;
            this.LabelHamPineapple_Pizza.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelHamPineapple_Pizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHamPineapple_Pizza.Location = new System.Drawing.Point(27, 138);
            this.LabelHamPineapple_Pizza.Name = "LabelHamPineapple_Pizza";
            this.LabelHamPineapple_Pizza.Size = new System.Drawing.Size(183, 20);
            this.LabelHamPineapple_Pizza.TabIndex = 4;
            this.LabelHamPineapple_Pizza.Text = "HamPinaeapple Pizza";
            // 
            // LabelMargherita_Pizza
            // 
            this.LabelMargherita_Pizza.AutoSize = true;
            this.LabelMargherita_Pizza.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelMargherita_Pizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMargherita_Pizza.Location = new System.Drawing.Point(27, 54);
            this.LabelMargherita_Pizza.Name = "LabelMargherita_Pizza";
            this.LabelMargherita_Pizza.Size = new System.Drawing.Size(143, 20);
            this.LabelMargherita_Pizza.TabIndex = 3;
            this.LabelMargherita_Pizza.Text = "Margherita Pizza";
            // 
            // LabelPepperoni_Pizza
            // 
            this.LabelPepperoni_Pizza.AutoSize = true;
            this.LabelPepperoni_Pizza.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelPepperoni_Pizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPepperoni_Pizza.Location = new System.Drawing.Point(27, 95);
            this.LabelPepperoni_Pizza.Name = "LabelPepperoni_Pizza";
            this.LabelPepperoni_Pizza.Size = new System.Drawing.Size(138, 20);
            this.LabelPepperoni_Pizza.TabIndex = 2;
            this.LabelPepperoni_Pizza.Text = "Pepperoni Pizza";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(644, 13);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(107, 42);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "E&xit";
            this.toolTip1.SetToolTip(this.ExitButton, "Press to Exit the Appllication. (Use ALt+X Keyboard Shortcut to Exit)");
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(437, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 42);
            this.button4.TabIndex = 13;
            this.button4.Text = "Summary";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ButtonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClear.Location = new System.Drawing.Point(223, 13);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(116, 42);
            this.ButtonClear.TabIndex = 12;
            this.ButtonClear.Text = "&Clear";
            this.toolTip1.SetToolTip(this.ButtonClear, "Press to Clear Form for Next User. (Use ALT+C Keyboard Shortcut to Clear)");
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnOrder
            // 
            this.BtnOrder.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrder.ForeColor = System.Drawing.Color.Black;
            this.BtnOrder.Location = new System.Drawing.Point(32, 13);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(107, 42);
            this.BtnOrder.TabIndex = 11;
            this.BtnOrder.Text = "Order";
            this.BtnOrder.UseVisualStyleBackColor = false;
            this.BtnOrder.Click += new System.EventHandler(this.button2_Click);
            // 
            // GroupBox_OrderDetails
            // 
            this.GroupBox_OrderDetails.Controls.Add(this.labelTotalOrder_Receipts);
            this.GroupBox_OrderDetails.Controls.Add(this.labelTotal_Pizzas);
            this.GroupBox_OrderDetails.Controls.Add(this.labelServer_Name);
            this.GroupBox_OrderDetails.Controls.Add(this.pictureBox1);
            this.GroupBox_OrderDetails.Controls.Add(this.label12);
            this.GroupBox_OrderDetails.Controls.Add(this.label11);
            this.GroupBox_OrderDetails.Controls.Add(this.label3);
            this.GroupBox_OrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_OrderDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GroupBox_OrderDetails.Location = new System.Drawing.Point(32, 381);
            this.GroupBox_OrderDetails.Name = "GroupBox_OrderDetails";
            this.GroupBox_OrderDetails.Size = new System.Drawing.Size(800, 327);
            this.GroupBox_OrderDetails.TabIndex = 5;
            this.GroupBox_OrderDetails.TabStop = false;
            this.GroupBox_OrderDetails.Text = "Table Order Summary Details";
            this.GroupBox_OrderDetails.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(235, 199);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(100, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(206, 25);
            this.label12.TabIndex = 6;
            this.label12.Text = "Server Name";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(100, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 30);
            this.label11.TabIndex = 5;
            this.label11.Text = "Total Number of Pizza\'s";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Table  Receipts";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // GroupBox_CompanyDetails
            // 
            this.GroupBox_CompanyDetails.Controls.Add(this.labelAverageCompany_Transaction);
            this.GroupBox_CompanyDetails.Controls.Add(this.labelTotalCompany_Receipts);
            this.GroupBox_CompanyDetails.Controls.Add(this.labelTotalNumber_Pizzas);
            this.GroupBox_CompanyDetails.Controls.Add(this.labelTotalCompany_Transactions);
            this.GroupBox_CompanyDetails.Controls.Add(this.pictureBox2);
            this.GroupBox_CompanyDetails.Controls.Add(this.label15);
            this.GroupBox_CompanyDetails.Controls.Add(this.label4);
            this.GroupBox_CompanyDetails.Controls.Add(this.label13);
            this.GroupBox_CompanyDetails.Controls.Add(this.label14);
            this.GroupBox_CompanyDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_CompanyDetails.ForeColor = System.Drawing.Color.Black;
            this.GroupBox_CompanyDetails.Location = new System.Drawing.Point(63, 411);
            this.GroupBox_CompanyDetails.Name = "GroupBox_CompanyDetails";
            this.GroupBox_CompanyDetails.Size = new System.Drawing.Size(748, 325);
            this.GroupBox_CompanyDetails.TabIndex = 6;
            this.GroupBox_CompanyDetails.TabStop = false;
            this.GroupBox_CompanyDetails.Text = "Company Summary Details";
            this.GroupBox_CompanyDetails.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(249, 217);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(247, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(114, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(244, 32);
            this.label15.TabIndex = 10;
            this.label15.Text = "Average Transaction Value";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Company Transactions";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(114, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(244, 32);
            this.label13.TabIndex = 5;
            this.label13.Text = "Total Number of Pizza\'s";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(114, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(244, 32);
            this.label14.TabIndex = 4;
            this.label14.Text = "Total Company  Receipts";
            // 
            // PanelOne
            // 
            this.PanelOne.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PanelOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelOne.Controls.Add(this.button1);
            this.PanelOne.Controls.Add(this.T_No);
            this.PanelOne.Controls.Add(this.LabelTableNo);
            this.PanelOne.Controls.Add(this.S_Name);
            this.PanelOne.Controls.Add(this.LabelServerName);
            this.PanelOne.Location = new System.Drawing.Point(32, 6);
            this.PanelOne.Name = "PanelOne";
            this.PanelOne.Size = new System.Drawing.Size(803, 100);
            this.PanelOne.TabIndex = 7;
            this.PanelOne.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(642, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // T_No
            // 
            this.T_No.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.T_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_No.Location = new System.Drawing.Point(526, 42);
            this.T_No.Name = "T_No";
            this.T_No.Size = new System.Drawing.Size(74, 20);
            this.T_No.TabIndex = 8;
            this.T_No.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelTableNo
            // 
            this.LabelTableNo.AutoSize = true;
            this.LabelTableNo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelTableNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTableNo.Location = new System.Drawing.Point(355, 39);
            this.LabelTableNo.Name = "LabelTableNo";
            this.LabelTableNo.Size = new System.Drawing.Size(159, 25);
            this.LabelTableNo.TabIndex = 7;
            this.LabelTableNo.Text = "Table Number";
            // 
            // S_Name
            // 
            this.S_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.S_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_Name.Location = new System.Drawing.Point(151, 42);
            this.S_Name.Name = "S_Name";
            this.S_Name.Size = new System.Drawing.Size(154, 21);
            this.S_Name.TabIndex = 6;
            this.S_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelServerName
            // 
            this.LabelServerName.AutoSize = true;
            this.LabelServerName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelServerName.Location = new System.Drawing.Point(13, 40);
            this.LabelServerName.Name = "LabelServerName";
            this.LabelServerName.Size = new System.Drawing.Size(132, 24);
            this.LabelServerName.TabIndex = 4;
            this.LabelServerName.Text = "Server Name";
            this.LabelServerName.Click += new System.EventHandler(this.label1_Click);
            // 
            // PanelTwo
            // 
            this.PanelTwo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PanelTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelTwo.Controls.Add(this.BtnOrder);
            this.PanelTwo.Controls.Add(this.ExitButton);
            this.PanelTwo.Controls.Add(this.button4);
            this.PanelTwo.Controls.Add(this.ButtonClear);
            this.PanelTwo.Location = new System.Drawing.Point(30, 298);
            this.PanelTwo.Name = "PanelTwo";
            this.PanelTwo.Size = new System.Drawing.Size(805, 70);
            this.PanelTwo.TabIndex = 15;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // labelTotalCompany_Transactions
            // 
            this.labelTotalCompany_Transactions.BackColor = System.Drawing.SystemColors.HighlightText;
            this.labelTotalCompany_Transactions.Location = new System.Drawing.Point(397, 41);
            this.labelTotalCompany_Transactions.Name = "labelTotalCompany_Transactions";
            this.labelTotalCompany_Transactions.Size = new System.Drawing.Size(129, 32);
            this.labelTotalCompany_Transactions.TabIndex = 13;
            // 
            // labelTotalNumber_Pizzas
            // 
            this.labelTotalNumber_Pizzas.BackColor = System.Drawing.SystemColors.HighlightText;
            this.labelTotalNumber_Pizzas.Location = new System.Drawing.Point(397, 84);
            this.labelTotalNumber_Pizzas.Name = "labelTotalNumber_Pizzas";
            this.labelTotalNumber_Pizzas.Size = new System.Drawing.Size(129, 32);
            this.labelTotalNumber_Pizzas.TabIndex = 14;
            // 
            // labelTotalCompany_Receipts
            // 
            this.labelTotalCompany_Receipts.BackColor = System.Drawing.SystemColors.HighlightText;
            this.labelTotalCompany_Receipts.Location = new System.Drawing.Point(397, 127);
            this.labelTotalCompany_Receipts.Name = "labelTotalCompany_Receipts";
            this.labelTotalCompany_Receipts.Size = new System.Drawing.Size(129, 32);
            this.labelTotalCompany_Receipts.TabIndex = 15;
            // 
            // labelAverageCompany_Transaction
            // 
            this.labelAverageCompany_Transaction.BackColor = System.Drawing.SystemColors.HighlightText;
            this.labelAverageCompany_Transaction.Location = new System.Drawing.Point(398, 168);
            this.labelAverageCompany_Transaction.Name = "labelAverageCompany_Transaction";
            this.labelAverageCompany_Transaction.Size = new System.Drawing.Size(129, 32);
            this.labelAverageCompany_Transaction.TabIndex = 16;
            // 
            // labelServer_Name
            // 
            this.labelServer_Name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelServer_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServer_Name.Location = new System.Drawing.Point(350, 54);
            this.labelServer_Name.Name = "labelServer_Name";
            this.labelServer_Name.Size = new System.Drawing.Size(172, 29);
            this.labelServer_Name.TabIndex = 11;
            this.labelServer_Name.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelTotal_Pizzas
            // 
            this.labelTotal_Pizzas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTotal_Pizzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal_Pizzas.Location = new System.Drawing.Point(350, 95);
            this.labelTotal_Pizzas.Name = "labelTotal_Pizzas";
            this.labelTotal_Pizzas.Size = new System.Drawing.Size(172, 29);
            this.labelTotal_Pizzas.TabIndex = 12;
            // 
            // labelTotalOrder_Receipts
            // 
            this.labelTotalOrder_Receipts.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTotalOrder_Receipts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalOrder_Receipts.Location = new System.Drawing.Point(350, 135);
            this.labelTotalOrder_Receipts.Name = "labelTotalOrder_Receipts";
            this.labelTotalOrder_Receipts.Size = new System.Drawing.Size(172, 29);
            this.labelTotalOrder_Receipts.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.PanelTwo);
            this.Controls.Add(this.PanelOne);
            this.Controls.Add(this.GroupBox_CompanyDetails);
            this.Controls.Add(this.GroupBox_OrderDetails);
            this.Controls.Add(this.GroupBoxPizzaMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Welcome to Sult Bar and Resturant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBoxPizzaMenu.ResumeLayout(false);
            this.GroupBoxPizzaMenu.PerformLayout();
            this.GroupBox_OrderDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GroupBox_CompanyDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PanelOne.ResumeLayout(false);
            this.PanelOne.PerformLayout();
            this.PanelTwo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GroupBoxPizzaMenu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox H_Pizza;
        private System.Windows.Forms.TextBox P_Pizza;
        private System.Windows.Forms.TextBox M_pizza;
        private System.Windows.Forms.Label LabelHamPineapple_Pizza;
        private System.Windows.Forms.Label LabelMargherita_Pizza;
        private System.Windows.Forms.Label LabelPepperoni_Pizza;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button BtnOrder;
        private System.Windows.Forms.GroupBox GroupBox_OrderDetails;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GroupBox_CompanyDetails;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel PanelOne;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox T_No;
        private System.Windows.Forms.Label LabelTableNo;
        private System.Windows.Forms.TextBox S_Name;
        private System.Windows.Forms.Label LabelServerName;
        private System.Windows.Forms.Panel PanelTwo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelAverageCompany_Transaction;
        private System.Windows.Forms.Label labelTotalCompany_Receipts;
        private System.Windows.Forms.Label labelTotalNumber_Pizzas;
        private System.Windows.Forms.Label labelTotalCompany_Transactions;
        private System.Windows.Forms.Label labelServer_Name;
        private System.Windows.Forms.Label labelTotalOrder_Receipts;
        private System.Windows.Forms.Label labelTotal_Pizzas;
    }
}

