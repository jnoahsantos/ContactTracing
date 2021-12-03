﻿
namespace ContactTracingApp
{
    partial class ContactTracer
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
            this.txtBxFN = new System.Windows.Forms.TextBox();
            this.txtBxMN = new System.Windows.Forms.TextBox();
            this.txtBxLN = new System.Windows.Forms.TextBox();
            this.txtBxAge = new System.Windows.Forms.TextBox();
            this.labelFN = new System.Windows.Forms.Label();
            this.labelMN = new System.Windows.Forms.Label();
            this.labelLN = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.rdoBtnMale = new System.Windows.Forms.RadioButton();
            this.rdoBtnFemale = new System.Windows.Forms.RadioButton();
            this.txtBxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.rdoBtnIPNTS = new System.Windows.Forms.RadioButton();
            this.labelQuesOne = new System.Windows.Forms.Label();
            this.labelQuesTwoPt1 = new System.Windows.Forms.Label();
            this.labelQuesTwoPt2 = new System.Windows.Forms.Label();
            this.labelQuesThreePt1 = new System.Windows.Forms.Label();
            this.labelQuesThreePt2 = new System.Windows.Forms.Label();
            this.chkBxQuesOneFever = new System.Windows.Forms.CheckBox();
            this.chkBxQuesOneCough = new System.Windows.Forms.CheckBox();
            this.chkBxQuesOneBD = new System.Windows.Forms.CheckBox();
            this.labelPN = new System.Windows.Forms.Label();
            this.txtBxPN = new System.Windows.Forms.TextBox();
            this.groupBoxQuesTwo = new System.Windows.Forms.GroupBox();
            this.rdoBtnQuesTwoNS = new System.Windows.Forms.RadioButton();
            this.rdoBtnQuesTwoNo = new System.Windows.Forms.RadioButton();
            this.rdoBtnQuesTwoYes = new System.Windows.Forms.RadioButton();
            this.groupBoxQuesOne = new System.Windows.Forms.GroupBox();
            this.rdoBtnQuesOneNS = new System.Windows.Forms.RadioButton();
            this.rdoBtnQuesOneNo = new System.Windows.Forms.RadioButton();
            this.rdoBtnQuesOneYes = new System.Windows.Forms.RadioButton();
            this.labelFocusGetter = new System.Windows.Forms.Label();
            this.labelMainTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.groupBoxQuesTwo.SuspendLayout();
            this.groupBoxQuesOne.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBxFN
            // 
            this.txtBxFN.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtBxFN.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBxFN.Location = new System.Drawing.Point(16, 118);
            this.txtBxFN.Name = "txtBxFN";
            this.txtBxFN.Size = new System.Drawing.Size(218, 25);
            this.txtBxFN.TabIndex = 1;
            this.txtBxFN.Text = "(Required field)";
            this.txtBxFN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBxFN.Enter += new System.EventHandler(this.ReqField_Enter);
            this.txtBxFN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxChar_KeyPress);
            this.txtBxFN.Leave += new System.EventHandler(this.ReqField_Leave);
            // 
            // txtBxMN
            // 
            this.txtBxMN.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtBxMN.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBxMN.Location = new System.Drawing.Point(240, 118);
            this.txtBxMN.Name = "txtBxMN";
            this.txtBxMN.Size = new System.Drawing.Size(218, 25);
            this.txtBxMN.TabIndex = 1;
            this.txtBxMN.Text = "(Required field)";
            this.txtBxMN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBxMN.Enter += new System.EventHandler(this.ReqField_Enter);
            this.txtBxMN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxChar_KeyPress);
            this.txtBxMN.Leave += new System.EventHandler(this.ReqField_Leave);
            // 
            // txtBxLN
            // 
            this.txtBxLN.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtBxLN.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBxLN.Location = new System.Drawing.Point(464, 118);
            this.txtBxLN.Name = "txtBxLN";
            this.txtBxLN.Size = new System.Drawing.Size(218, 25);
            this.txtBxLN.TabIndex = 1;
            this.txtBxLN.Text = "(Required field)";
            this.txtBxLN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBxLN.Enter += new System.EventHandler(this.ReqField_Enter);
            this.txtBxLN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxChar_KeyPress);
            this.txtBxLN.Leave += new System.EventHandler(this.ReqField_Leave);
            // 
            // txtBxAge
            // 
            this.txtBxAge.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtBxAge.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBxAge.Location = new System.Drawing.Point(17, 228);
            this.txtBxAge.Name = "txtBxAge";
            this.txtBxAge.Size = new System.Drawing.Size(109, 25);
            this.txtBxAge.TabIndex = 1;
            this.txtBxAge.Text = "(Required field)";
            this.txtBxAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBxAge.Enter += new System.EventHandler(this.ReqField_Enter);
            this.txtBxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNum_KeyPress);
            this.txtBxAge.Leave += new System.EventHandler(this.ReqField_Leave);
            // 
            // labelFN
            // 
            this.labelFN.AutoSize = true;
            this.labelFN.BackColor = System.Drawing.Color.Transparent;
            this.labelFN.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFN.Location = new System.Drawing.Point(13, 93);
            this.labelFN.Name = "labelFN";
            this.labelFN.Size = new System.Drawing.Size(100, 22);
            this.labelFN.TabIndex = 0;
            this.labelFN.Text = "First Name:";
            this.labelFN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMN
            // 
            this.labelMN.AutoSize = true;
            this.labelMN.BackColor = System.Drawing.Color.Transparent;
            this.labelMN.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMN.Location = new System.Drawing.Point(236, 95);
            this.labelMN.Name = "labelMN";
            this.labelMN.Size = new System.Drawing.Size(118, 22);
            this.labelMN.TabIndex = 0;
            this.labelMN.Text = "Middle Name:";
            this.labelMN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelLN
            // 
            this.labelLN.AutoSize = true;
            this.labelLN.BackColor = System.Drawing.Color.Transparent;
            this.labelLN.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLN.Location = new System.Drawing.Point(460, 95);
            this.labelLN.Name = "labelLN";
            this.labelLN.Size = new System.Drawing.Size(99, 22);
            this.labelLN.TabIndex = 0;
            this.labelLN.Text = "Last Name:";
            this.labelLN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.BackColor = System.Drawing.Color.Transparent;
            this.labelAge.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(13, 201);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(46, 22);
            this.labelAge.TabIndex = 0;
            this.labelAge.Text = "Age:";
            this.labelAge.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.BackColor = System.Drawing.Color.Transparent;
            this.labelGender.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(302, 201);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(72, 22);
            this.labelGender.TabIndex = 0;
            this.labelGender.Text = "Gender:";
            this.labelGender.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelGender.Click += new System.EventHandler(this.labelGender_Click);
            // 
            // rdoBtnMale
            // 
            this.rdoBtnMale.AutoSize = true;
            this.rdoBtnMale.Font = new System.Drawing.Font("Tahoma", 11F);
            this.rdoBtnMale.Location = new System.Drawing.Point(336, 229);
            this.rdoBtnMale.Name = "rdoBtnMale";
            this.rdoBtnMale.Size = new System.Drawing.Size(56, 22);
            this.rdoBtnMale.TabIndex = 2;
            this.rdoBtnMale.TabStop = true;
            this.rdoBtnMale.Text = "Male";
            this.rdoBtnMale.UseVisualStyleBackColor = true;
            // 
            // rdoBtnFemale
            // 
            this.rdoBtnFemale.AutoSize = true;
            this.rdoBtnFemale.Font = new System.Drawing.Font("Tahoma", 11F);
            this.rdoBtnFemale.Location = new System.Drawing.Point(408, 229);
            this.rdoBtnFemale.Name = "rdoBtnFemale";
            this.rdoBtnFemale.Size = new System.Drawing.Size(73, 22);
            this.rdoBtnFemale.TabIndex = 3;
            this.rdoBtnFemale.TabStop = true;
            this.rdoBtnFemale.Text = "Female";
            this.rdoBtnFemale.UseVisualStyleBackColor = true;
            // 
            // txtBxAddress
            // 
            this.txtBxAddress.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtBxAddress.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBxAddress.Location = new System.Drawing.Point(16, 173);
            this.txtBxAddress.Name = "txtBxAddress";
            this.txtBxAddress.Size = new System.Drawing.Size(666, 25);
            this.txtBxAddress.TabIndex = 1;
            this.txtBxAddress.Text = "(Required field)";
            this.txtBxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBxAddress.TextChanged += new System.EventHandler(this.txtBxAddress_TextChanged);
            this.txtBxAddress.Enter += new System.EventHandler(this.ReqField_Enter);
            this.txtBxAddress.Leave += new System.EventHandler(this.ReqField_Leave);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(13, 146);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(78, 22);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Address:";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rdoBtnIPNTS
            // 
            this.rdoBtnIPNTS.AutoSize = true;
            this.rdoBtnIPNTS.Font = new System.Drawing.Font("Tahoma", 11F);
            this.rdoBtnIPNTS.Location = new System.Drawing.Point(496, 229);
            this.rdoBtnIPNTS.Name = "rdoBtnIPNTS";
            this.rdoBtnIPNTS.Size = new System.Drawing.Size(148, 22);
            this.rdoBtnIPNTS.TabIndex = 3;
            this.rdoBtnIPNTS.TabStop = true;
            this.rdoBtnIPNTS.Text = "I prefer not to say";
            this.rdoBtnIPNTS.UseVisualStyleBackColor = true;
            // 
            // labelQuesOne
            // 
            this.labelQuesOne.AutoSize = true;
            this.labelQuesOne.BackColor = System.Drawing.Color.Transparent;
            this.labelQuesOne.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuesOne.Location = new System.Drawing.Point(13, 265);
            this.labelQuesOne.Name = "labelQuesOne";
            this.labelQuesOne.Size = new System.Drawing.Size(600, 22);
            this.labelQuesOne.TabIndex = 0;
            this.labelQuesOne.Text = "Have you traveled outside the country anytime from last month until now?";
            this.labelQuesOne.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelQuesTwoPt1
            // 
            this.labelQuesTwoPt1.AutoSize = true;
            this.labelQuesTwoPt1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuesTwoPt1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuesTwoPt1.Location = new System.Drawing.Point(13, 359);
            this.labelQuesTwoPt1.Name = "labelQuesTwoPt1";
            this.labelQuesTwoPt1.Size = new System.Drawing.Size(642, 22);
            this.labelQuesTwoPt1.TabIndex = 0;
            this.labelQuesTwoPt1.Text = "Have you come into contact with anyone who has traveled outside your country";
            this.labelQuesTwoPt1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelQuesTwoPt2
            // 
            this.labelQuesTwoPt2.AutoSize = true;
            this.labelQuesTwoPt2.BackColor = System.Drawing.Color.Transparent;
            this.labelQuesTwoPt2.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuesTwoPt2.Location = new System.Drawing.Point(13, 379);
            this.labelQuesTwoPt2.Name = "labelQuesTwoPt2";
            this.labelQuesTwoPt2.Size = new System.Drawing.Size(362, 22);
            this.labelQuesTwoPt2.TabIndex = 0;
            this.labelQuesTwoPt2.Text = "between the period of last month until now?";
            this.labelQuesTwoPt2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelQuesThreePt1
            // 
            this.labelQuesThreePt1.AutoSize = true;
            this.labelQuesThreePt1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuesThreePt1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuesThreePt1.Location = new System.Drawing.Point(13, 472);
            this.labelQuesThreePt1.Name = "labelQuesThreePt1";
            this.labelQuesThreePt1.Size = new System.Drawing.Size(573, 22);
            this.labelQuesThreePt1.TabIndex = 0;
            this.labelQuesThreePt1.Text = "Do you currently have any of the following conditions during this time?";
            this.labelQuesThreePt1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelQuesThreePt2
            // 
            this.labelQuesThreePt2.AutoSize = true;
            this.labelQuesThreePt2.BackColor = System.Drawing.Color.Transparent;
            this.labelQuesThreePt2.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuesThreePt2.Location = new System.Drawing.Point(13, 492);
            this.labelQuesThreePt2.Name = "labelQuesThreePt2";
            this.labelQuesThreePt2.Size = new System.Drawing.Size(185, 22);
            this.labelQuesThreePt2.TabIndex = 0;
            this.labelQuesThreePt2.Text = "(Check all that apply):";
            this.labelQuesThreePt2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chkBxQuesOneFever
            // 
            this.chkBxQuesOneFever.AutoSize = true;
            this.chkBxQuesOneFever.Font = new System.Drawing.Font("Tahoma", 11F);
            this.chkBxQuesOneFever.Location = new System.Drawing.Point(39, 545);
            this.chkBxQuesOneFever.Name = "chkBxQuesOneFever";
            this.chkBxQuesOneFever.Size = new System.Drawing.Size(64, 22);
            this.chkBxQuesOneFever.TabIndex = 4;
            this.chkBxQuesOneFever.Text = "Fever";
            this.chkBxQuesOneFever.UseVisualStyleBackColor = true;
            this.chkBxQuesOneFever.CheckedChanged += new System.EventHandler(this.chkBxQuesOneFever_CheckedChanged);
            // 
            // chkBxQuesOneCough
            // 
            this.chkBxQuesOneCough.AutoSize = true;
            this.chkBxQuesOneCough.Font = new System.Drawing.Font("Tahoma", 11F);
            this.chkBxQuesOneCough.Location = new System.Drawing.Point(39, 525);
            this.chkBxQuesOneCough.Name = "chkBxQuesOneCough";
            this.chkBxQuesOneCough.Size = new System.Drawing.Size(68, 22);
            this.chkBxQuesOneCough.TabIndex = 4;
            this.chkBxQuesOneCough.Text = "Cough";
            this.chkBxQuesOneCough.UseVisualStyleBackColor = true;
            // 
            // chkBxQuesOneBD
            // 
            this.chkBxQuesOneBD.AutoSize = true;
            this.chkBxQuesOneBD.Font = new System.Drawing.Font("Tahoma", 11F);
            this.chkBxQuesOneBD.Location = new System.Drawing.Point(39, 564);
            this.chkBxQuesOneBD.Name = "chkBxQuesOneBD";
            this.chkBxQuesOneBD.Size = new System.Drawing.Size(147, 22);
            this.chkBxQuesOneBD.TabIndex = 4;
            this.chkBxQuesOneBD.Text = "Breathing Difficulty";
            this.chkBxQuesOneBD.UseVisualStyleBackColor = true;
            // 
            // labelPN
            // 
            this.labelPN.AutoSize = true;
            this.labelPN.BackColor = System.Drawing.Color.Transparent;
            this.labelPN.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPN.Location = new System.Drawing.Point(148, 201);
            this.labelPN.Name = "labelPN";
            this.labelPN.Size = new System.Drawing.Size(131, 22);
            this.labelPN.TabIndex = 0;
            this.labelPN.Text = "Phone number:";
            this.labelPN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBxPN
            // 
            this.txtBxPN.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtBxPN.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBxPN.Location = new System.Drawing.Point(152, 228);
            this.txtBxPN.Name = "txtBxPN";
            this.txtBxPN.Size = new System.Drawing.Size(129, 25);
            this.txtBxPN.TabIndex = 1;
            this.txtBxPN.Text = "(Required field)";
            this.txtBxPN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBxPN.Enter += new System.EventHandler(this.ReqField_Enter);
            this.txtBxPN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNum_KeyPress);
            this.txtBxPN.Leave += new System.EventHandler(this.ReqField_Leave);
            // 
            // groupBoxQuesTwo
            // 
            this.groupBoxQuesTwo.Controls.Add(this.rdoBtnQuesTwoNS);
            this.groupBoxQuesTwo.Controls.Add(this.rdoBtnQuesTwoNo);
            this.groupBoxQuesTwo.Controls.Add(this.rdoBtnQuesTwoYes);
            this.groupBoxQuesTwo.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.groupBoxQuesTwo.Location = new System.Drawing.Point(39, 406);
            this.groupBoxQuesTwo.Margin = new System.Windows.Forms.Padding(1);
            this.groupBoxQuesTwo.Name = "groupBoxQuesTwo";
            this.groupBoxQuesTwo.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxQuesTwo.Size = new System.Drawing.Size(370, 60);
            this.groupBoxQuesTwo.TabIndex = 6;
            this.groupBoxQuesTwo.TabStop = false;
            // 
            // rdoBtnQuesTwoNS
            // 
            this.rdoBtnQuesTwoNS.AutoSize = true;
            this.rdoBtnQuesTwoNS.Font = new System.Drawing.Font("Tahoma", 11F);
            this.rdoBtnQuesTwoNS.Location = new System.Drawing.Point(267, 22);
            this.rdoBtnQuesTwoNS.Name = "rdoBtnQuesTwoNS";
            this.rdoBtnQuesTwoNS.Size = new System.Drawing.Size(82, 22);
            this.rdoBtnQuesTwoNS.TabIndex = 3;
            this.rdoBtnQuesTwoNS.TabStop = true;
            this.rdoBtnQuesTwoNS.Text = "Not sure";
            this.rdoBtnQuesTwoNS.UseVisualStyleBackColor = true;
            // 
            // rdoBtnQuesTwoNo
            // 
            this.rdoBtnQuesTwoNo.AutoSize = true;
            this.rdoBtnQuesTwoNo.Font = new System.Drawing.Font("Tahoma", 11F);
            this.rdoBtnQuesTwoNo.Location = new System.Drawing.Point(151, 22);
            this.rdoBtnQuesTwoNo.Name = "rdoBtnQuesTwoNo";
            this.rdoBtnQuesTwoNo.Size = new System.Drawing.Size(44, 22);
            this.rdoBtnQuesTwoNo.TabIndex = 4;
            this.rdoBtnQuesTwoNo.TabStop = true;
            this.rdoBtnQuesTwoNo.Text = "No";
            this.rdoBtnQuesTwoNo.UseVisualStyleBackColor = true;
            // 
            // rdoBtnQuesTwoYes
            // 
            this.rdoBtnQuesTwoYes.AutoSize = true;
            this.rdoBtnQuesTwoYes.Font = new System.Drawing.Font("Tahoma", 11F);
            this.rdoBtnQuesTwoYes.Location = new System.Drawing.Point(29, 22);
            this.rdoBtnQuesTwoYes.Name = "rdoBtnQuesTwoYes";
            this.rdoBtnQuesTwoYes.Size = new System.Drawing.Size(51, 22);
            this.rdoBtnQuesTwoYes.TabIndex = 5;
            this.rdoBtnQuesTwoYes.TabStop = true;
            this.rdoBtnQuesTwoYes.Text = "Yes";
            this.rdoBtnQuesTwoYes.UseVisualStyleBackColor = true;
            // 
            // groupBoxQuesOne
            // 
            this.groupBoxQuesOne.Controls.Add(this.rdoBtnQuesOneNS);
            this.groupBoxQuesOne.Controls.Add(this.rdoBtnQuesOneNo);
            this.groupBoxQuesOne.Controls.Add(this.rdoBtnQuesOneYes);
            this.groupBoxQuesOne.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.groupBoxQuesOne.Location = new System.Drawing.Point(39, 288);
            this.groupBoxQuesOne.Margin = new System.Windows.Forms.Padding(1);
            this.groupBoxQuesOne.Name = "groupBoxQuesOne";
            this.groupBoxQuesOne.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxQuesOne.Size = new System.Drawing.Size(370, 60);
            this.groupBoxQuesOne.TabIndex = 7;
            this.groupBoxQuesOne.TabStop = false;
            // 
            // rdoBtnQuesOneNS
            // 
            this.rdoBtnQuesOneNS.AutoSize = true;
            this.rdoBtnQuesOneNS.Font = new System.Drawing.Font("Tahoma", 11F);
            this.rdoBtnQuesOneNS.Location = new System.Drawing.Point(267, 22);
            this.rdoBtnQuesOneNS.Name = "rdoBtnQuesOneNS";
            this.rdoBtnQuesOneNS.Size = new System.Drawing.Size(82, 22);
            this.rdoBtnQuesOneNS.TabIndex = 3;
            this.rdoBtnQuesOneNS.TabStop = true;
            this.rdoBtnQuesOneNS.Text = "Not sure";
            this.rdoBtnQuesOneNS.UseVisualStyleBackColor = true;
            this.rdoBtnQuesOneNS.CheckedChanged += new System.EventHandler(this.rdoBtnQuesOneNS_CheckedChanged);
            // 
            // rdoBtnQuesOneNo
            // 
            this.rdoBtnQuesOneNo.AutoSize = true;
            this.rdoBtnQuesOneNo.Font = new System.Drawing.Font("Tahoma", 11F);
            this.rdoBtnQuesOneNo.Location = new System.Drawing.Point(151, 22);
            this.rdoBtnQuesOneNo.Name = "rdoBtnQuesOneNo";
            this.rdoBtnQuesOneNo.Size = new System.Drawing.Size(44, 22);
            this.rdoBtnQuesOneNo.TabIndex = 4;
            this.rdoBtnQuesOneNo.TabStop = true;
            this.rdoBtnQuesOneNo.Text = "No";
            this.rdoBtnQuesOneNo.UseVisualStyleBackColor = true;
            // 
            // rdoBtnQuesOneYes
            // 
            this.rdoBtnQuesOneYes.AutoSize = true;
            this.rdoBtnQuesOneYes.Font = new System.Drawing.Font("Tahoma", 11F);
            this.rdoBtnQuesOneYes.Location = new System.Drawing.Point(29, 22);
            this.rdoBtnQuesOneYes.Name = "rdoBtnQuesOneYes";
            this.rdoBtnQuesOneYes.Size = new System.Drawing.Size(51, 22);
            this.rdoBtnQuesOneYes.TabIndex = 5;
            this.rdoBtnQuesOneYes.TabStop = true;
            this.rdoBtnQuesOneYes.Text = "Yes";
            this.rdoBtnQuesOneYes.UseVisualStyleBackColor = true;
            // 
            // labelFocusGetter
            // 
            this.labelFocusGetter.AutoSize = true;
            this.labelFocusGetter.Location = new System.Drawing.Point(20, 13);
            this.labelFocusGetter.Name = "labelFocusGetter";
            this.labelFocusGetter.Size = new System.Drawing.Size(0, 13);
            this.labelFocusGetter.TabIndex = 8;
            // 
            // labelMainTitle
            // 
            this.labelMainTitle.AutoSize = true;
            this.labelMainTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelMainTitle.Font = new System.Drawing.Font("Cooper Black", 35F);
            this.labelMainTitle.ForeColor = System.Drawing.Color.Black;
            this.labelMainTitle.Location = new System.Drawing.Point(159, 13);
            this.labelMainTitle.Name = "labelMainTitle";
            this.labelMainTitle.Size = new System.Drawing.Size(411, 54);
            this.labelMainTitle.TabIndex = 0;
            this.labelMainTitle.Text = "Contact Tracing";
            this.labelMainTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.Controls.Add(this.labelMainTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 82);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel2.Controls.Add(this.SubmitButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 592);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 60);
            this.panel2.TabIndex = 10;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.DeepPink;
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.SubmitButton.Location = new System.Drawing.Point(258, 7);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(169, 47);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "SUBMIT";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ContactTracer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(704, 652);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelFocusGetter);
            this.Controls.Add(this.groupBoxQuesOne);
            this.Controls.Add(this.groupBoxQuesTwo);
            this.Controls.Add(this.chkBxQuesOneBD);
            this.Controls.Add(this.chkBxQuesOneCough);
            this.Controls.Add(this.chkBxQuesOneFever);
            this.Controls.Add(this.rdoBtnIPNTS);
            this.Controls.Add(this.rdoBtnFemale);
            this.Controls.Add(this.rdoBtnMale);
            this.Controls.Add(this.txtBxLN);
            this.Controls.Add(this.txtBxMN);
            this.Controls.Add(this.txtBxAge);
            this.Controls.Add(this.txtBxPN);
            this.Controls.Add(this.txtBxAddress);
            this.Controls.Add(this.txtBxFN);
            this.Controls.Add(this.labelLN);
            this.Controls.Add(this.labelMN);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelQuesTwoPt2);
            this.Controls.Add(this.labelQuesThreePt2);
            this.Controls.Add(this.labelQuesThreePt1);
            this.Controls.Add(this.labelQuesTwoPt1);
            this.Controls.Add(this.labelQuesOne);
            this.Controls.Add(this.labelPN);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelFN);
            this.MaximizeBox = false;
            this.Name = "ContactTracer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracing";
            this.Load += new System.EventHandler(this.ContactTracer_Load);
            this.Click += new System.EventHandler(this.ContactTracer_Click);
            this.groupBoxQuesTwo.ResumeLayout(false);
            this.groupBoxQuesTwo.PerformLayout();
            this.groupBoxQuesOne.ResumeLayout(false);
            this.groupBoxQuesOne.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBxFN;
        private System.Windows.Forms.TextBox txtBxMN;
        private System.Windows.Forms.TextBox txtBxLN;
        private System.Windows.Forms.TextBox txtBxAge;
        private System.Windows.Forms.Label labelFN;
        private System.Windows.Forms.Label labelMN;
        private System.Windows.Forms.Label labelLN;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.RadioButton rdoBtnMale;
        private System.Windows.Forms.RadioButton rdoBtnFemale;
        private System.Windows.Forms.TextBox txtBxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.RadioButton rdoBtnIPNTS;
        private System.Windows.Forms.Label labelQuesOne;
        private System.Windows.Forms.Label labelQuesTwoPt1;
        private System.Windows.Forms.Label labelQuesTwoPt2;
        private System.Windows.Forms.Label labelQuesThreePt1;
        private System.Windows.Forms.Label labelQuesThreePt2;
        private System.Windows.Forms.CheckBox chkBxQuesOneFever;
        private System.Windows.Forms.CheckBox chkBxQuesOneCough;
        private System.Windows.Forms.CheckBox chkBxQuesOneBD;
        private System.Windows.Forms.Label labelPN;
        private System.Windows.Forms.TextBox txtBxPN;
        private System.Windows.Forms.GroupBox groupBoxQuesTwo;
        private System.Windows.Forms.RadioButton rdoBtnQuesTwoNS;
        private System.Windows.Forms.RadioButton rdoBtnQuesTwoNo;
        private System.Windows.Forms.RadioButton rdoBtnQuesTwoYes;
        private System.Windows.Forms.GroupBox groupBoxQuesOne;
        private System.Windows.Forms.RadioButton rdoBtnQuesOneNS;
        private System.Windows.Forms.RadioButton rdoBtnQuesOneNo;
        private System.Windows.Forms.RadioButton rdoBtnQuesOneYes;
        private System.Windows.Forms.Label labelFocusGetter;
        private System.Windows.Forms.Label labelMainTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SubmitButton;
    }
}

