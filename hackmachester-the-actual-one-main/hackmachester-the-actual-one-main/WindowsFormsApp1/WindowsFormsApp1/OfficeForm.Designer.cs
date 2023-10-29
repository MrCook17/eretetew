namespace WindowsFormsApp1
{
    partial class OfficeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfficeForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.speak_girl = new System.Windows.Forms.Button();
            this.speak_boy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(629, 312);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // speak_girl
            // 
            this.speak_girl.Location = new System.Drawing.Point(144, 239);
            this.speak_girl.Name = "speak_girl";
            this.speak_girl.Size = new System.Drawing.Size(155, 47);
            this.speak_girl.TabIndex = 17;
            this.speak_girl.Text = "Click here to speak";
            this.speak_girl.UseVisualStyleBackColor = true;
            this.speak_girl.Click += new System.EventHandler(this.Boy_Speak);
            // 
            // speak_boy
            // 
            this.speak_boy.Location = new System.Drawing.Point(398, 239);
            this.speak_boy.Name = "speak_boy";
            this.speak_boy.Size = new System.Drawing.Size(155, 47);
            this.speak_boy.TabIndex = 16;
            this.speak_boy.Text = "Click here to speak";
            this.speak_boy.UseVisualStyleBackColor = true;
            // 
            // OfficeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 478);
            this.Controls.Add(this.speak_girl);
            this.Controls.Add(this.speak_boy);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OfficeForm";
            this.Text = "OfficeForm";
            this.Load += new System.EventHandler(this.Girl_Speak);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button speak_girl;
        private System.Windows.Forms.Button speak_boy;
    }
}