namespace kursachForAxl
{
    partial class Authentication
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
            this.label1 = new System.Windows.Forms.Label();
            this.adminButton = new System.Windows.Forms.Button();
            this.guestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // adminButton
            // 
            this.adminButton.Location = new System.Drawing.Point(79, 122);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(280, 133);
            this.adminButton.TabIndex = 2;
            this.adminButton.Text = "Administrator";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // guestButton
            // 
            this.guestButton.Location = new System.Drawing.Point(459, 122);
            this.guestButton.Name = "guestButton";
            this.guestButton.Size = new System.Drawing.Size(280, 133);
            this.guestButton.TabIndex = 1;
            this.guestButton.Text = "Guest";
            this.guestButton.UseVisualStyleBackColor = true;
            this.guestButton.Click += new System.EventHandler(this.guestButton_Click);
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 340);
            this.Controls.Add(this.guestButton);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.label1);
            this.Name = "Authentication";
            this.Text = "Authentication";
            this.Load += new System.EventHandler(this.Authentication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button guestButton;
    }
}