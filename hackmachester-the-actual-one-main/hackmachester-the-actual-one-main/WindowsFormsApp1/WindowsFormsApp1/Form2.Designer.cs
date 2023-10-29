
namespace WindowsFormsApp1
{
    partial class InputGoalScreen
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CreateNewGoal = new System.Windows.Forms.Label();
            this.Goal_Name = new System.Windows.Forms.TextBox();
            this.Goal_Amount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Confirm_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Location = new System.Drawing.Point(127, -7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(644, 540);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // CreateNewGoal
            // 
            this.CreateNewGoal.AutoSize = true;
            this.CreateNewGoal.BackColor = System.Drawing.SystemColors.Control;
            this.CreateNewGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateNewGoal.Location = new System.Drawing.Point(181, 164);
            this.CreateNewGoal.Name = "CreateNewGoal";
            this.CreateNewGoal.Size = new System.Drawing.Size(79, 17);
            this.CreateNewGoal.TabIndex = 2;
            this.CreateNewGoal.Text = "Goal Name";
            // 
            // Goal_Name
            // 
            this.Goal_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Goal_Name.Location = new System.Drawing.Point(184, 184);
            this.Goal_Name.Name = "Goal_Name";
            this.Goal_Name.Size = new System.Drawing.Size(536, 22);
            this.Goal_Name.TabIndex = 3;
            this.Goal_Name.TextChanged += new System.EventHandler(this.Goal_Name_TextChanged);
            // 
            // Goal_Amount
            // 
            this.Goal_Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Goal_Amount.Location = new System.Drawing.Point(184, 321);
            this.Goal_Amount.Name = "Goal_Amount";
            this.Goal_Amount.Size = new System.Drawing.Size(536, 22);
            this.Goal_Amount.TabIndex = 4;
            this.Goal_Amount.Text = "£";
            this.Goal_Amount.TextChanged += new System.EventHandler(this.Goal_Amount_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(181, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please Enter The Cost Of Your Item";
            // 
            // Confirm_Button
            // 
            this.Confirm_Button.Location = new System.Drawing.Point(534, 459);
            this.Confirm_Button.Name = "Confirm_Button";
            this.Confirm_Button.Size = new System.Drawing.Size(155, 47);
            this.Confirm_Button.TabIndex = 6;
            this.Confirm_Button.Text = "Confirm";
            this.Confirm_Button.UseVisualStyleBackColor = true;
            this.Confirm_Button.Click += new System.EventHandler(this.Confirm_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(184, 459);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(155, 47);
            this.Cancel_Button.TabIndex = 7;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Create A Goal";
            // 
            // InputGoalScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(964, 528);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Confirm_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Goal_Amount);
            this.Controls.Add(this.Goal_Name);
            this.Controls.Add(this.CreateNewGoal);
            this.Controls.Add(this.pictureBox2);
            this.Name = "InputGoalScreen";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label CreateNewGoal;
        private System.Windows.Forms.TextBox Goal_Name;
        private System.Windows.Forms.TextBox Goal_Amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Confirm_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Label label2;
    }
}