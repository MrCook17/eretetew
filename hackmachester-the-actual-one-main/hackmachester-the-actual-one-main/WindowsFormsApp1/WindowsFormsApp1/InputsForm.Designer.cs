namespace WindowsFormsApp1
{
    partial class InputsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Confirm_Button = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.TextBox();
            this.CreateNewGoal = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.userAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.monthPay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.payDropDown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(418, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Inputs";

            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(219, 456);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(155, 47);
            this.Cancel_Button.TabIndex = 15;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Confirm_Button
            // 
            this.Confirm_Button.Location = new System.Drawing.Point(569, 456);
            this.Confirm_Button.Name = "Confirm_Button";
            this.Confirm_Button.Size = new System.Drawing.Size(155, 47);
            this.Confirm_Button.TabIndex = 14;
            this.Confirm_Button.Text = "Confirm";
            this.Confirm_Button.UseVisualStyleBackColor = true;
            this.Confirm_Button.Click += new System.EventHandler(this.Confirm_Button_Click);
            // 
            // userName
            // 
            this.userName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userName.Location = new System.Drawing.Point(219, 181);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(536, 22);
            this.userName.TabIndex = 11;
            // 
            // CreateNewGoal
            // 
            this.CreateNewGoal.AutoSize = true;
            this.CreateNewGoal.BackColor = System.Drawing.SystemColors.Control;
            this.CreateNewGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateNewGoal.Location = new System.Drawing.Point(216, 161);
            this.CreateNewGoal.Name = "CreateNewGoal";
            this.CreateNewGoal.Size = new System.Drawing.Size(44, 16);
            this.CreateNewGoal.TabIndex = 10;
            this.CreateNewGoal.Text = "Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Location = new System.Drawing.Point(162, -10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(644, 540);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // userAge
            // 
            this.userAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userAge.Location = new System.Drawing.Point(219, 243);
            this.userAge.Name = "userAge";
            this.userAge.Size = new System.Drawing.Size(536, 22);
            this.userAge.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(216, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(216, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(429, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Please enter the amount you earn or receive on a monthly/weekly basis";
            // 
            // monthPay
            // 
            this.monthPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthPay.Location = new System.Drawing.Point(219, 374);
            this.monthPay.Name = "monthPay";
            this.monthPay.Size = new System.Drawing.Size(536, 22);
            this.monthPay.TabIndex = 19;
            this.monthPay.Text = "£";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(216, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Please choose which one applies to you";
            // 
            // payDropDown
            // 
            this.payDropDown.FormattingEnabled = true;
            this.payDropDown.Items.AddRange(new object[] {
            "Weekly",
            "Monthly"});
            this.payDropDown.Location = new System.Drawing.Point(219, 306);
            this.payDropDown.Name = "payDropDown";
            this.payDropDown.Size = new System.Drawing.Size(535, 24);
            this.payDropDown.TabIndex = 2;
            this.payDropDown.Text = "Select one";
            // 
            // InputsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(964, 528);
            this.Controls.Add(this.payDropDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.monthPay);
            this.Controls.Add(this.userAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Confirm_Button);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.CreateNewGoal);
            this.Controls.Add(this.pictureBox2);
            this.Name = "InputsForm";
            this.Text = "InputsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Confirm_Button;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label CreateNewGoal;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox userAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox monthPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox payDropDown;
    }
}