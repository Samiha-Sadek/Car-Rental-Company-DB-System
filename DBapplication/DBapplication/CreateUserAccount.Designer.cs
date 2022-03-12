
namespace DBapplication
{
    partial class CreateUserAccount
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
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LastName_TextBox = new System.Windows.Forms.TextBox();
            this.Address_TextBox = new System.Windows.Forms.TextBox();
            this.MNumber_TextBox = new System.Windows.Forms.TextBox();
            this.Email_TextBox = new System.Windows.Forms.TextBox();
            this.FirstName_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(82, 310);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 40);
            this.button5.TabIndex = 26;
            this.button5.Text = "Create";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Contact Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Email";
            // 
            // LastName_TextBox
            // 
            this.LastName_TextBox.Location = new System.Drawing.Point(160, 76);
            this.LastName_TextBox.Name = "LastName_TextBox";
            this.LastName_TextBox.Size = new System.Drawing.Size(155, 22);
            this.LastName_TextBox.TabIndex = 21;
            // 
            // Address_TextBox
            // 
            this.Address_TextBox.Location = new System.Drawing.Point(160, 128);
            this.Address_TextBox.Name = "Address_TextBox";
            this.Address_TextBox.Size = new System.Drawing.Size(205, 22);
            this.Address_TextBox.TabIndex = 20;
            // 
            // MNumber_TextBox
            // 
            this.MNumber_TextBox.Location = new System.Drawing.Point(160, 186);
            this.MNumber_TextBox.MaxLength = 11;
            this.MNumber_TextBox.Name = "MNumber_TextBox";
            this.MNumber_TextBox.Size = new System.Drawing.Size(155, 22);
            this.MNumber_TextBox.TabIndex = 19;
            // 
            // Email_TextBox
            // 
            this.Email_TextBox.Location = new System.Drawing.Point(160, 243);
            this.Email_TextBox.Name = "Email_TextBox";
            this.Email_TextBox.Size = new System.Drawing.Size(205, 22);
            this.Email_TextBox.TabIndex = 18;
            // 
            // FirstName_TextBox
            // 
            this.FirstName_TextBox.Location = new System.Drawing.Point(160, 23);
            this.FirstName_TextBox.Name = "FirstName_TextBox";
            this.FirstName_TextBox.Size = new System.Drawing.Size(155, 22);
            this.FirstName_TextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "First Name";
            // 
            // CreateUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastName_TextBox);
            this.Controls.Add(this.Address_TextBox);
            this.Controls.Add(this.MNumber_TextBox);
            this.Controls.Add(this.Email_TextBox);
            this.Controls.Add(this.FirstName_TextBox);
            this.Controls.Add(this.label1);
            this.Name = "CreateUserAccount";
            this.Text = "CreateUserAccount";
            this.Load += new System.EventHandler(this.CreateUserAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastName_TextBox;
        private System.Windows.Forms.TextBox Address_TextBox;
        private System.Windows.Forms.TextBox MNumber_TextBox;
        private System.Windows.Forms.TextBox Email_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstName_TextBox;
    }
}