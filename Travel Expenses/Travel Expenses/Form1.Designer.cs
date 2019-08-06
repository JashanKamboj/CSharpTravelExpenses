namespace Travel_Expenses
{
    partial class travelExpenseForm
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
            this.label = new System.Windows.Forms.Label();
            this.lodgingGrpBox = new System.Windows.Forms.GroupBox();
            this.dayListBox = new System.Windows.Forms.ListBox();
            this.amountDayGrpBox = new System.Windows.Forms.GroupBox();
            this.amountDayTxtBox = new System.Windows.Forms.TextBox();
            this.airfareGrpBox = new System.Windows.Forms.GroupBox();
            this.airfareTxtBx = new System.Windows.Forms.TextBox();
            this.eventsGrpBx = new System.Windows.Forms.GroupBox();
            this.eventsListBx = new System.Windows.Forms.ListBox();
            this.carRentalDayGrpBx = new System.Windows.Forms.GroupBox();
            this.parkingGrpBx = new System.Windows.Forms.GroupBox();
            this.parkingTxtBx = new System.Windows.Forms.TextBox();
            this.carRentalListBx = new System.Windows.Forms.ListBox();
            this.carRentalDayTxtBox = new System.Windows.Forms.TextBox();
            this.privateMilesrpBx = new System.Windows.Forms.GroupBox();
            this.parking2GrpBx = new System.Windows.Forms.GroupBox();
            this.parking2TxtBx = new System.Windows.Forms.TextBox();
            this.privateMilesTxtBx = new System.Windows.Forms.TextBox();
            this.resetEventsBttn = new System.Windows.Forms.Button();
            this.ITSecurityGrpBx = new System.Windows.Forms.GroupBox();
            this.typesOfAttackCheckBx = new System.Windows.Forms.CheckBox();
            this.OSSecurityCheckBx = new System.Windows.Forms.CheckBox();
            this.encryptionCheckBx = new System.Windows.Forms.CheckBox();
            this.taxiFareGrpBx = new System.Windows.Forms.GroupBox();
            this.taxiFareTxtBx = new System.Windows.Forms.TextBox();
            this.expensesLabel = new System.Windows.Forms.Label();
            this.totalExpensesTxtBx = new System.Windows.Forms.TextBox();
            this.reimbursementLabel = new System.Windows.Forms.Label();
            this.reimbursementTxtBx = new System.Windows.Forms.TextBox();
            this.youPayLabl = new System.Windows.Forms.Label();
            this.youPayTxtBx = new System.Windows.Forms.TextBox();
            this.calculateBttn = new System.Windows.Forms.Button();
            this.clearBttn = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.lodgingGrpBox.SuspendLayout();
            this.amountDayGrpBox.SuspendLayout();
            this.airfareGrpBox.SuspendLayout();
            this.eventsGrpBx.SuspendLayout();
            this.carRentalDayGrpBx.SuspendLayout();
            this.parkingGrpBx.SuspendLayout();
            this.privateMilesrpBx.SuspendLayout();
            this.parking2GrpBx.SuspendLayout();
            this.ITSecurityGrpBx.SuspendLayout();
            this.taxiFareGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Yellow;
            this.label.Location = new System.Drawing.Point(147, 28);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(438, 37);
            this.label.TabIndex = 0;
            this.label.Text = "Jashandeep Kaur Travel Expenses";
            // 
            // lodgingGrpBox
            // 
            this.lodgingGrpBox.Controls.Add(this.dayListBox);
            this.lodgingGrpBox.Controls.Add(this.amountDayGrpBox);
            this.lodgingGrpBox.Location = new System.Drawing.Point(32, 91);
            this.lodgingGrpBox.Name = "lodgingGrpBox";
            this.lodgingGrpBox.Size = new System.Drawing.Size(292, 104);
            this.lodgingGrpBox.TabIndex = 1;
            this.lodgingGrpBox.TabStop = false;
            this.lodgingGrpBox.Text = "Lodging ";
            // 
            // dayListBox
            // 
            this.dayListBox.FormattingEnabled = true;
            this.dayListBox.HorizontalScrollbar = true;
            this.dayListBox.Items.AddRange(new object[] {
            "1 Day(s)",
            "2 Day(s)",
            "3 Day(s)",
            "4 Day(s)",
            "5 Day(s)",
            "6 Day(s)",
            "7 Day(s)",
            "8 Day(s)",
            "9 Day(s)",
            "10 Day(s)",
            "11 Day(s)",
            "12 Day(s)",
            "13 Day(s)",
            "14 Day(s)"});
            this.dayListBox.Location = new System.Drawing.Point(179, 30);
            this.dayListBox.Name = "dayListBox";
            this.dayListBox.Size = new System.Drawing.Size(77, 56);
            this.dayListBox.TabIndex = 3;
            this.dayListBox.SelectedIndexChanged += new System.EventHandler(this.dayListBox_SelectedIndexChanged);
            // 
            // amountDayGrpBox
            // 
            this.amountDayGrpBox.Controls.Add(this.amountDayTxtBox);
            this.amountDayGrpBox.Location = new System.Drawing.Point(19, 33);
            this.amountDayGrpBox.Name = "amountDayGrpBox";
            this.amountDayGrpBox.Size = new System.Drawing.Size(139, 53);
            this.amountDayGrpBox.TabIndex = 2;
            this.amountDayGrpBox.TabStop = false;
            this.amountDayGrpBox.Text = "Amount/Day ($)";
            // 
            // amountDayTxtBox
            // 
            this.amountDayTxtBox.BackColor = System.Drawing.Color.Yellow;
            this.amountDayTxtBox.Location = new System.Drawing.Point(16, 19);
            this.amountDayTxtBox.Name = "amountDayTxtBox";
            this.amountDayTxtBox.Size = new System.Drawing.Size(100, 20);
            this.amountDayTxtBox.TabIndex = 0;
            // 
            // airfareGrpBox
            // 
            this.airfareGrpBox.Controls.Add(this.airfareTxtBx);
            this.airfareGrpBox.Location = new System.Drawing.Point(402, 119);
            this.airfareGrpBox.Name = "airfareGrpBox";
            this.airfareGrpBox.Size = new System.Drawing.Size(140, 58);
            this.airfareGrpBox.TabIndex = 2;
            this.airfareGrpBox.TabStop = false;
            this.airfareGrpBox.Text = "Airfare ($)";
            // 
            // airfareTxtBx
            // 
            this.airfareTxtBx.BackColor = System.Drawing.Color.Yellow;
            this.airfareTxtBx.Location = new System.Drawing.Point(22, 24);
            this.airfareTxtBx.Name = "airfareTxtBx";
            this.airfareTxtBx.Size = new System.Drawing.Size(100, 20);
            this.airfareTxtBx.TabIndex = 0;
            // 
            // eventsGrpBx
            // 
            this.eventsGrpBx.Controls.Add(this.eventsListBx);
            this.eventsGrpBx.Location = new System.Drawing.Point(32, 228);
            this.eventsGrpBx.Name = "eventsGrpBx";
            this.eventsGrpBx.Size = new System.Drawing.Size(229, 100);
            this.eventsGrpBx.TabIndex = 3;
            this.eventsGrpBx.TabStop = false;
            this.eventsGrpBx.Text = "Events";
            // 
            // eventsListBx
            // 
            this.eventsListBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsListBx.FormattingEnabled = true;
            this.eventsListBx.ItemHeight = 16;
            this.eventsListBx.Items.AddRange(new object[] {
            "Advanced Programming - $472.93",
            "Cloud Computing - $789.34",
            "NetWork Security - $220.45",
            "IT Security Seminar"});
            this.eventsListBx.Location = new System.Drawing.Point(6, 19);
            this.eventsListBx.Name = "eventsListBx";
            this.eventsListBx.Size = new System.Drawing.Size(191, 68);
            this.eventsListBx.TabIndex = 0;
            this.eventsListBx.SelectedIndexChanged += new System.EventHandler(this.eventsListBx_SelectedIndexChanged);
            // 
            // carRentalDayGrpBx
            // 
            this.carRentalDayGrpBx.Controls.Add(this.parkingGrpBx);
            this.carRentalDayGrpBx.Controls.Add(this.carRentalListBx);
            this.carRentalDayGrpBx.Controls.Add(this.carRentalDayTxtBox);
            this.carRentalDayGrpBx.Location = new System.Drawing.Point(342, 228);
            this.carRentalDayGrpBx.Name = "carRentalDayGrpBx";
            this.carRentalDayGrpBx.Size = new System.Drawing.Size(387, 100);
            this.carRentalDayGrpBx.TabIndex = 4;
            this.carRentalDayGrpBx.TabStop = false;
            this.carRentalDayGrpBx.Text = "Car Rental/Day ($)";
            // 
            // parkingGrpBx
            // 
            this.parkingGrpBx.Controls.Add(this.parkingTxtBx);
            this.parkingGrpBx.Location = new System.Drawing.Point(237, 35);
            this.parkingGrpBx.Name = "parkingGrpBx";
            this.parkingGrpBx.Size = new System.Drawing.Size(131, 52);
            this.parkingGrpBx.TabIndex = 2;
            this.parkingGrpBx.TabStop = false;
            this.parkingGrpBx.Text = "Parking ($)";
            // 
            // parkingTxtBx
            // 
            this.parkingTxtBx.BackColor = System.Drawing.Color.Yellow;
            this.parkingTxtBx.Location = new System.Drawing.Point(15, 19);
            this.parkingTxtBx.Name = "parkingTxtBx";
            this.parkingTxtBx.Size = new System.Drawing.Size(100, 20);
            this.parkingTxtBx.TabIndex = 0;
            // 
            // carRentalListBx
            // 
            this.carRentalListBx.FormattingEnabled = true;
            this.carRentalListBx.Items.AddRange(new object[] {
            "1 Day(s)"});
            this.carRentalListBx.Location = new System.Drawing.Point(138, 19);
            this.carRentalListBx.Name = "carRentalListBx";
            this.carRentalListBx.Size = new System.Drawing.Size(75, 56);
            this.carRentalListBx.TabIndex = 1;
            // 
            // carRentalDayTxtBox
            // 
            this.carRentalDayTxtBox.BackColor = System.Drawing.Color.Yellow;
            this.carRentalDayTxtBox.Location = new System.Drawing.Point(23, 29);
            this.carRentalDayTxtBox.Name = "carRentalDayTxtBox";
            this.carRentalDayTxtBox.Size = new System.Drawing.Size(100, 20);
            this.carRentalDayTxtBox.TabIndex = 0;
            // 
            // privateMilesrpBx
            // 
            this.privateMilesrpBx.Controls.Add(this.parking2GrpBx);
            this.privateMilesrpBx.Controls.Add(this.privateMilesTxtBx);
            this.privateMilesrpBx.Location = new System.Drawing.Point(342, 360);
            this.privateMilesrpBx.Name = "privateMilesrpBx";
            this.privateMilesrpBx.Size = new System.Drawing.Size(387, 100);
            this.privateMilesrpBx.TabIndex = 5;
            this.privateMilesrpBx.TabStop = false;
            this.privateMilesrpBx.Text = "Private (miles - 0.32)";
            // 
            // parking2GrpBx
            // 
            this.parking2GrpBx.Controls.Add(this.parking2TxtBx);
            this.parking2GrpBx.Location = new System.Drawing.Point(205, 29);
            this.parking2GrpBx.Name = "parking2GrpBx";
            this.parking2GrpBx.Size = new System.Drawing.Size(147, 55);
            this.parking2GrpBx.TabIndex = 1;
            this.parking2GrpBx.TabStop = false;
            this.parking2GrpBx.Text = "Parking ($)";
            // 
            // parking2TxtBx
            // 
            this.parking2TxtBx.BackColor = System.Drawing.Color.Yellow;
            this.parking2TxtBx.Location = new System.Drawing.Point(22, 19);
            this.parking2TxtBx.Name = "parking2TxtBx";
            this.parking2TxtBx.Size = new System.Drawing.Size(100, 20);
            this.parking2TxtBx.TabIndex = 0;
            // 
            // privateMilesTxtBx
            // 
            this.privateMilesTxtBx.BackColor = System.Drawing.Color.Yellow;
            this.privateMilesTxtBx.Location = new System.Drawing.Point(23, 29);
            this.privateMilesTxtBx.Name = "privateMilesTxtBx";
            this.privateMilesTxtBx.Size = new System.Drawing.Size(100, 20);
            this.privateMilesTxtBx.TabIndex = 0;
            // 
            // resetEventsBttn
            // 
            this.resetEventsBttn.Location = new System.Drawing.Point(79, 334);
            this.resetEventsBttn.Name = "resetEventsBttn";
            this.resetEventsBttn.Size = new System.Drawing.Size(111, 39);
            this.resetEventsBttn.TabIndex = 6;
            this.resetEventsBttn.Text = "Reset Events";
            this.resetEventsBttn.UseVisualStyleBackColor = true;
            this.resetEventsBttn.Click += new System.EventHandler(this.resetEventsBttn_Click);
            // 
            // ITSecurityGrpBx
            // 
            this.ITSecurityGrpBx.Controls.Add(this.typesOfAttackCheckBx);
            this.ITSecurityGrpBx.Controls.Add(this.OSSecurityCheckBx);
            this.ITSecurityGrpBx.Controls.Add(this.encryptionCheckBx);
            this.ITSecurityGrpBx.Location = new System.Drawing.Point(38, 389);
            this.ITSecurityGrpBx.Name = "ITSecurityGrpBx";
            this.ITSecurityGrpBx.Size = new System.Drawing.Size(200, 100);
            this.ITSecurityGrpBx.TabIndex = 7;
            this.ITSecurityGrpBx.TabStop = false;
            this.ITSecurityGrpBx.Text = "IT Security Topics";
            // 
            // typesOfAttackCheckBx
            // 
            this.typesOfAttackCheckBx.AutoSize = true;
            this.typesOfAttackCheckBx.Location = new System.Drawing.Point(13, 70);
            this.typesOfAttackCheckBx.Name = "typesOfAttackCheckBx";
            this.typesOfAttackCheckBx.Size = new System.Drawing.Size(149, 17);
            this.typesOfAttackCheckBx.TabIndex = 2;
            this.typesOfAttackCheckBx.Text = "Types of Attack - $150.94";
            this.typesOfAttackCheckBx.UseVisualStyleBackColor = true;
            // 
            // OSSecurityCheckBx
            // 
            this.OSSecurityCheckBx.AutoSize = true;
            this.OSSecurityCheckBx.Location = new System.Drawing.Point(13, 46);
            this.OSSecurityCheckBx.Name = "OSSecurityCheckBx";
            this.OSSecurityCheckBx.Size = new System.Drawing.Size(130, 17);
            this.OSSecurityCheckBx.TabIndex = 1;
            this.OSSecurityCheckBx.Text = "OS Security - $347.51";
            this.OSSecurityCheckBx.UseVisualStyleBackColor = true;
            // 
            // encryptionCheckBx
            // 
            this.encryptionCheckBx.AutoSize = true;
            this.encryptionCheckBx.Location = new System.Drawing.Point(13, 22);
            this.encryptionCheckBx.Name = "encryptionCheckBx";
            this.encryptionCheckBx.Size = new System.Drawing.Size(124, 17);
            this.encryptionCheckBx.TabIndex = 0;
            this.encryptionCheckBx.Text = "Encryption - $250.63";
            this.encryptionCheckBx.UseVisualStyleBackColor = true;
            // 
            // taxiFareGrpBx
            // 
            this.taxiFareGrpBx.Controls.Add(this.taxiFareTxtBx);
            this.taxiFareGrpBx.Location = new System.Drawing.Point(342, 495);
            this.taxiFareGrpBx.Name = "taxiFareGrpBx";
            this.taxiFareGrpBx.Size = new System.Drawing.Size(151, 58);
            this.taxiFareGrpBx.TabIndex = 8;
            this.taxiFareGrpBx.TabStop = false;
            this.taxiFareGrpBx.Text = "Taxi Fare ($)";
            // 
            // taxiFareTxtBx
            // 
            this.taxiFareTxtBx.BackColor = System.Drawing.Color.Yellow;
            this.taxiFareTxtBx.Location = new System.Drawing.Point(23, 19);
            this.taxiFareTxtBx.Name = "taxiFareTxtBx";
            this.taxiFareTxtBx.Size = new System.Drawing.Size(100, 20);
            this.taxiFareTxtBx.TabIndex = 0;
            // 
            // expensesLabel
            // 
            this.expensesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expensesLabel.Location = new System.Drawing.Point(226, 581);
            this.expensesLabel.Name = "expensesLabel";
            this.expensesLabel.Size = new System.Drawing.Size(153, 23);
            this.expensesLabel.TabIndex = 9;
            this.expensesLabel.Text = "Total Expenses Incurred";
            // 
            // totalExpensesTxtBx
            // 
            this.totalExpensesTxtBx.Location = new System.Drawing.Point(402, 579);
            this.totalExpensesTxtBx.Name = "totalExpensesTxtBx";
            this.totalExpensesTxtBx.ReadOnly = true;
            this.totalExpensesTxtBx.Size = new System.Drawing.Size(140, 20);
            this.totalExpensesTxtBx.TabIndex = 10;
            // 
            // reimbursementLabel
            // 
            this.reimbursementLabel.AutoSize = true;
            this.reimbursementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reimbursementLabel.Location = new System.Drawing.Point(276, 616);
            this.reimbursementLabel.Name = "reimbursementLabel";
            this.reimbursementLabel.Size = new System.Drawing.Size(103, 16);
            this.reimbursementLabel.TabIndex = 11;
            this.reimbursementLabel.Text = "Reimbursement";
            // 
            // reimbursementTxtBx
            // 
            this.reimbursementTxtBx.BackColor = System.Drawing.Color.RoyalBlue;
            this.reimbursementTxtBx.Location = new System.Drawing.Point(402, 615);
            this.reimbursementTxtBx.Name = "reimbursementTxtBx";
            this.reimbursementTxtBx.ReadOnly = true;
            this.reimbursementTxtBx.Size = new System.Drawing.Size(140, 20);
            this.reimbursementTxtBx.TabIndex = 12;
            // 
            // youPayLabl
            // 
            this.youPayLabl.AutoSize = true;
            this.youPayLabl.Location = new System.Drawing.Point(332, 649);
            this.youPayLabl.Name = "youPayLabl";
            this.youPayLabl.Size = new System.Drawing.Size(47, 13);
            this.youPayLabl.TabIndex = 13;
            this.youPayLabl.Text = "You Pay";
            // 
            // youPayTxtBx
            // 
            this.youPayTxtBx.BackColor = System.Drawing.Color.Red;
            this.youPayTxtBx.Location = new System.Drawing.Point(402, 645);
            this.youPayTxtBx.Name = "youPayTxtBx";
            this.youPayTxtBx.ReadOnly = true;
            this.youPayTxtBx.Size = new System.Drawing.Size(140, 20);
            this.youPayTxtBx.TabIndex = 14;
            // 
            // calculateBttn
            // 
            this.calculateBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBttn.Location = new System.Drawing.Point(220, 679);
            this.calculateBttn.Name = "calculateBttn";
            this.calculateBttn.Size = new System.Drawing.Size(117, 33);
            this.calculateBttn.TabIndex = 15;
            this.calculateBttn.Text = "Calculate";
            this.calculateBttn.UseVisualStyleBackColor = true;
            this.calculateBttn.Click += new System.EventHandler(this.calculateBttn_Click);
            // 
            // clearBttn
            // 
            this.clearBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBttn.Location = new System.Drawing.Point(385, 681);
            this.clearBttn.Name = "clearBttn";
            this.clearBttn.Size = new System.Drawing.Size(91, 33);
            this.clearBttn.TabIndex = 16;
            this.clearBttn.Text = "Clear";
            this.clearBttn.UseVisualStyleBackColor = true;
            this.clearBttn.Click += new System.EventHandler(this.clearBttn_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(529, 684);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(93, 29);
            this.exit.TabIndex = 17;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // travelExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 721);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clearBttn);
            this.Controls.Add(this.calculateBttn);
            this.Controls.Add(this.youPayTxtBx);
            this.Controls.Add(this.youPayLabl);
            this.Controls.Add(this.reimbursementTxtBx);
            this.Controls.Add(this.reimbursementLabel);
            this.Controls.Add(this.totalExpensesTxtBx);
            this.Controls.Add(this.expensesLabel);
            this.Controls.Add(this.taxiFareGrpBx);
            this.Controls.Add(this.ITSecurityGrpBx);
            this.Controls.Add(this.resetEventsBttn);
            this.Controls.Add(this.privateMilesrpBx);
            this.Controls.Add(this.carRentalDayGrpBx);
            this.Controls.Add(this.eventsGrpBx);
            this.Controls.Add(this.airfareGrpBox);
            this.Controls.Add(this.lodgingGrpBox);
            this.Controls.Add(this.label);
            this.Name = "travelExpenseForm";
            this.Text = "Travel Expenses";
            this.Load += new System.EventHandler(this.travelExpenseForm_Load);
            this.lodgingGrpBox.ResumeLayout(false);
            this.amountDayGrpBox.ResumeLayout(false);
            this.amountDayGrpBox.PerformLayout();
            this.airfareGrpBox.ResumeLayout(false);
            this.airfareGrpBox.PerformLayout();
            this.eventsGrpBx.ResumeLayout(false);
            this.carRentalDayGrpBx.ResumeLayout(false);
            this.carRentalDayGrpBx.PerformLayout();
            this.parkingGrpBx.ResumeLayout(false);
            this.parkingGrpBx.PerformLayout();
            this.privateMilesrpBx.ResumeLayout(false);
            this.privateMilesrpBx.PerformLayout();
            this.parking2GrpBx.ResumeLayout(false);
            this.parking2GrpBx.PerformLayout();
            this.ITSecurityGrpBx.ResumeLayout(false);
            this.ITSecurityGrpBx.PerformLayout();
            this.taxiFareGrpBx.ResumeLayout(false);
            this.taxiFareGrpBx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox lodgingGrpBox;
        private System.Windows.Forms.ListBox dayListBox;
        private System.Windows.Forms.GroupBox amountDayGrpBox;
        private System.Windows.Forms.TextBox amountDayTxtBox;
        private System.Windows.Forms.GroupBox airfareGrpBox;
        private System.Windows.Forms.TextBox airfareTxtBx;
        private System.Windows.Forms.GroupBox eventsGrpBx;
        private System.Windows.Forms.ListBox eventsListBx;
        private System.Windows.Forms.GroupBox carRentalDayGrpBx;
        private System.Windows.Forms.GroupBox parkingGrpBx;
        private System.Windows.Forms.TextBox parkingTxtBx;
        private System.Windows.Forms.ListBox carRentalListBx;
        private System.Windows.Forms.TextBox carRentalDayTxtBox;
        private System.Windows.Forms.GroupBox privateMilesrpBx;
        private System.Windows.Forms.GroupBox parking2GrpBx;
        private System.Windows.Forms.TextBox parking2TxtBx;
        private System.Windows.Forms.TextBox privateMilesTxtBx;
        private System.Windows.Forms.Button resetEventsBttn;
        private System.Windows.Forms.GroupBox ITSecurityGrpBx;
        private System.Windows.Forms.CheckBox typesOfAttackCheckBx;
        private System.Windows.Forms.CheckBox OSSecurityCheckBx;
        private System.Windows.Forms.CheckBox encryptionCheckBx;
        private System.Windows.Forms.GroupBox taxiFareGrpBx;
        private System.Windows.Forms.TextBox taxiFareTxtBx;
        private System.Windows.Forms.Label expensesLabel;
        private System.Windows.Forms.TextBox totalExpensesTxtBx;
        private System.Windows.Forms.Label reimbursementLabel;
        private System.Windows.Forms.TextBox reimbursementTxtBx;
        private System.Windows.Forms.Label youPayLabl;
        private System.Windows.Forms.TextBox youPayTxtBx;
        private System.Windows.Forms.Button calculateBttn;
        private System.Windows.Forms.Button clearBttn;
        private System.Windows.Forms.Button exit;
    }
}

