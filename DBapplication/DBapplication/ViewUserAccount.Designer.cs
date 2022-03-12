
namespace DBapplication
{
    partial class ViewUserAccount
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
            this.Return_Button = new System.Windows.Forms.Button();
            this.Upgrade_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ViewID_TextBox = new System.Windows.Forms.TextBox();
            this.ViewFName_TextBox = new System.Windows.Forms.TextBox();
            this.ViewLName_TextBox = new System.Windows.Forms.TextBox();
            this.ViewBalance_TextBox = new System.Windows.Forms.TextBox();
            this.ViewAddress_TextBox = new System.Windows.Forms.TextBox();
            this.ViewMNumber_TextBox = new System.Windows.Forms.TextBox();
            this.ViewEmail_TextBox = new System.Windows.Forms.TextBox();
            this.Premium_CheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Return_Button
            // 
            this.Return_Button.Location = new System.Drawing.Point(41, 462);
            this.Return_Button.Name = "Return_Button";
            this.Return_Button.Size = new System.Drawing.Size(185, 36);
            this.Return_Button.TabIndex = 0;
            this.Return_Button.Text = "Return to main screen";
            this.Return_Button.UseVisualStyleBackColor = true;
            this.Return_Button.Click += new System.EventHandler(this.Return_Button_Click);
            // 
            // Upgrade_Button
            // 
            this.Upgrade_Button.Location = new System.Drawing.Point(447, 459);
            this.Upgrade_Button.Name = "Upgrade_Button";
            this.Upgrade_Button.Size = new System.Drawing.Size(174, 39);
            this.Upgrade_Button.TabIndex = 2;
            this.Upgrade_Button.Text = "Upgrade Account";
            this.Upgrade_Button.UseVisualStyleBackColor = true;
            this.Upgrade_Button.Click += new System.EventHandler(this.Upgrade_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Account Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Balance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Mobile Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Email";
            // 
            // ViewID_TextBox
            // 
            this.ViewID_TextBox.Location = new System.Drawing.Point(221, 47);
            this.ViewID_TextBox.Name = "ViewID_TextBox";
            this.ViewID_TextBox.ReadOnly = true;
            this.ViewID_TextBox.Size = new System.Drawing.Size(154, 22);
            this.ViewID_TextBox.TabIndex = 11;
            // 
            // ViewFName_TextBox
            // 
            this.ViewFName_TextBox.Location = new System.Drawing.Point(221, 96);
            this.ViewFName_TextBox.Name = "ViewFName_TextBox";
            this.ViewFName_TextBox.ReadOnly = true;
            this.ViewFName_TextBox.Size = new System.Drawing.Size(154, 22);
            this.ViewFName_TextBox.TabIndex = 12;
            // 
            // ViewLName_TextBox
            // 
            this.ViewLName_TextBox.Location = new System.Drawing.Point(221, 141);
            this.ViewLName_TextBox.Name = "ViewLName_TextBox";
            this.ViewLName_TextBox.ReadOnly = true;
            this.ViewLName_TextBox.Size = new System.Drawing.Size(154, 22);
            this.ViewLName_TextBox.TabIndex = 13;
            // 
            // ViewBalance_TextBox
            // 
            this.ViewBalance_TextBox.Location = new System.Drawing.Point(221, 243);
            this.ViewBalance_TextBox.Name = "ViewBalance_TextBox";
            this.ViewBalance_TextBox.ReadOnly = true;
            this.ViewBalance_TextBox.Size = new System.Drawing.Size(154, 22);
            this.ViewBalance_TextBox.TabIndex = 15;
            // 
            // ViewAddress_TextBox
            // 
            this.ViewAddress_TextBox.Location = new System.Drawing.Point(221, 285);
            this.ViewAddress_TextBox.Name = "ViewAddress_TextBox";
            this.ViewAddress_TextBox.ReadOnly = true;
            this.ViewAddress_TextBox.Size = new System.Drawing.Size(260, 22);
            this.ViewAddress_TextBox.TabIndex = 16;
            // 
            // ViewMNumber_TextBox
            // 
            this.ViewMNumber_TextBox.Location = new System.Drawing.Point(221, 336);
            this.ViewMNumber_TextBox.Name = "ViewMNumber_TextBox";
            this.ViewMNumber_TextBox.ReadOnly = true;
            this.ViewMNumber_TextBox.Size = new System.Drawing.Size(154, 22);
            this.ViewMNumber_TextBox.TabIndex = 17;
            // 
            // ViewEmail_TextBox
            // 
            this.ViewEmail_TextBox.Location = new System.Drawing.Point(221, 386);
            this.ViewEmail_TextBox.Name = "ViewEmail_TextBox";
            this.ViewEmail_TextBox.ReadOnly = true;
            this.ViewEmail_TextBox.Size = new System.Drawing.Size(260, 22);
            this.ViewEmail_TextBox.TabIndex = 18;
            // 
            // Premium_CheckBox
            // 
            this.Premium_CheckBox.AutoSize = true;
            this.Premium_CheckBox.Enabled = false;
            this.Premium_CheckBox.Location = new System.Drawing.Point(221, 193);
            this.Premium_CheckBox.Name = "Premium_CheckBox";
            this.Premium_CheckBox.Size = new System.Drawing.Size(85, 21);
            this.Premium_CheckBox.TabIndex = 19;
            this.Premium_CheckBox.Text = "Premium";
            this.Premium_CheckBox.UseVisualStyleBackColor = true;
            // 
            // ViewUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 535);
            this.Controls.Add(this.Premium_CheckBox);
            this.Controls.Add(this.ViewEmail_TextBox);
            this.Controls.Add(this.ViewMNumber_TextBox);
            this.Controls.Add(this.ViewAddress_TextBox);
            this.Controls.Add(this.ViewBalance_TextBox);
            this.Controls.Add(this.ViewLName_TextBox);
            this.Controls.Add(this.ViewFName_TextBox);
            this.Controls.Add(this.ViewID_TextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Upgrade_Button);
            this.Controls.Add(this.Return_Button);
            this.Name = "ViewUserAccount";
            this.Text = "ViewUserAccount";
            this.Load += new System.EventHandler(this.ViewUserAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Return_Button;
        private System.Windows.Forms.Button Upgrade_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ViewID_TextBox;
        private System.Windows.Forms.TextBox ViewFName_TextBox;
        private System.Windows.Forms.TextBox ViewLName_TextBox;
        private System.Windows.Forms.TextBox ViewBalance_TextBox;
        private System.Windows.Forms.TextBox ViewAddress_TextBox;
        private System.Windows.Forms.TextBox ViewMNumber_TextBox;
        private System.Windows.Forms.TextBox ViewEmail_TextBox;
        private System.Windows.Forms.CheckBox Premium_CheckBox;
    }
}