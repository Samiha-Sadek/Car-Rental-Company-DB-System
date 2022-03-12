
namespace DBapplication
{
    partial class BookAVehicle
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
            this.SearchVehicle = new System.Windows.Forms.Button();
            this.OffersList = new System.Windows.Forms.Button();
            this.Location_ComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.book_Button = new System.Windows.Forms.Button();
            this.OfferList_GridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.OfferID_ComboBox = new System.Windows.Forms.ComboBox();
            this.RentDate = new System.Windows.Forms.DateTimePicker();
            this.ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SelectCar_Button = new System.Windows.Forms.Button();
            this.Available_Cars_DataGrid = new System.Windows.Forms.DataGridView();
            this.ShowAvailableCars_Button = new System.Windows.Forms.Button();
            this.PlateNumber_ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Check_Avail_Cars_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OfferList_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Available_Cars_DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchVehicle
            // 
            this.SearchVehicle.Location = new System.Drawing.Point(312, 91);
            this.SearchVehicle.Name = "SearchVehicle";
            this.SearchVehicle.Size = new System.Drawing.Size(180, 36);
            this.SearchVehicle.TabIndex = 20;
            this.SearchVehicle.Text = "Search for a car";
            this.SearchVehicle.UseVisualStyleBackColor = true;
            this.SearchVehicle.Click += new System.EventHandler(this.SearchVehicle_Click);
            // 
            // OffersList
            // 
            this.OffersList.Location = new System.Drawing.Point(312, 27);
            this.OffersList.Name = "OffersList";
            this.OffersList.Size = new System.Drawing.Size(180, 37);
            this.OffersList.TabIndex = 19;
            this.OffersList.Text = "View offers List";
            this.OffersList.UseVisualStyleBackColor = true;
            this.OffersList.Click += new System.EventHandler(this.OffersList_Click);
            // 
            // Location_ComboBox
            // 
            this.Location_ComboBox.FormattingEnabled = true;
            this.Location_ComboBox.Location = new System.Drawing.Point(468, 168);
            this.Location_ComboBox.Name = "Location_ComboBox";
            this.Location_ComboBox.Size = new System.Drawing.Size(153, 24);
            this.Location_ComboBox.TabIndex = 23;
            this.Location_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Location_ComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Location";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // book_Button
            // 
            this.book_Button.Location = new System.Drawing.Point(841, 545);
            this.book_Button.Name = "book_Button";
            this.book_Button.Size = new System.Drawing.Size(175, 35);
            this.book_Button.TabIndex = 27;
            this.book_Button.Text = "Select the car";
            this.book_Button.UseVisualStyleBackColor = true;
            this.book_Button.Click += new System.EventHandler(this.book_Button_Click);
            // 
            // OfferList_GridView
            // 
            this.OfferList_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OfferList_GridView.Location = new System.Drawing.Point(285, 168);
            this.OfferList_GridView.Name = "OfferList_GridView";
            this.OfferList_GridView.RowHeadersWidth = 51;
            this.OfferList_GridView.RowTemplate.Height = 24;
            this.OfferList_GridView.Size = new System.Drawing.Size(510, 309);
            this.OfferList_GridView.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Choose Offer\'s ID";
            // 
            // OfferID_ComboBox
            // 
            this.OfferID_ComboBox.FormattingEnabled = true;
            this.OfferID_ComboBox.Location = new System.Drawing.Point(425, 499);
            this.OfferID_ComboBox.Name = "OfferID_ComboBox";
            this.OfferID_ComboBox.Size = new System.Drawing.Size(91, 24);
            this.OfferID_ComboBox.TabIndex = 30;
            // 
            // RentDate
            // 
            this.RentDate.Location = new System.Drawing.Point(31, 99);
            this.RentDate.MinDate = new System.DateTime(2021, 12, 25, 0, 0, 0, 0);
            this.RentDate.Name = "RentDate";
            this.RentDate.Size = new System.Drawing.Size(231, 22);
            this.RentDate.TabIndex = 31;
            this.RentDate.ValueChanged += new System.EventHandler(this.RentDate_ValueChanged);
            // 
            // ReturnDate
            // 
            this.ReturnDate.Location = new System.Drawing.Point(31, 208);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(231, 22);
            this.ReturnDate.TabIndex = 32;
            this.ReturnDate.ValueChanged += new System.EventHandler(this.ReturnDate_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Rent Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Return Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "Boking Date Info";
            // 
            // SelectCar_Button
            // 
            this.SelectCar_Button.Location = new System.Drawing.Point(312, 27);
            this.SelectCar_Button.Name = "SelectCar_Button";
            this.SelectCar_Button.Size = new System.Drawing.Size(180, 37);
            this.SelectCar_Button.TabIndex = 36;
            this.SelectCar_Button.Text = "Select a car";
            this.SelectCar_Button.UseVisualStyleBackColor = true;
            this.SelectCar_Button.Click += new System.EventHandler(this.SelectCar_Button_Click);
            // 
            // Available_Cars_DataGrid
            // 
            this.Available_Cars_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Available_Cars_DataGrid.Location = new System.Drawing.Point(312, 265);
            this.Available_Cars_DataGrid.Name = "Available_Cars_DataGrid";
            this.Available_Cars_DataGrid.RowHeadersWidth = 51;
            this.Available_Cars_DataGrid.RowTemplate.Height = 24;
            this.Available_Cars_DataGrid.Size = new System.Drawing.Size(459, 199);
            this.Available_Cars_DataGrid.TabIndex = 37;
            // 
            // ShowAvailableCars_Button
            // 
            this.ShowAvailableCars_Button.Location = new System.Drawing.Point(312, 208);
            this.ShowAvailableCars_Button.Name = "ShowAvailableCars_Button";
            this.ShowAvailableCars_Button.Size = new System.Drawing.Size(190, 37);
            this.ShowAvailableCars_Button.TabIndex = 38;
            this.ShowAvailableCars_Button.Text = "Show Available Cars";
            this.ShowAvailableCars_Button.UseVisualStyleBackColor = true;
            this.ShowAvailableCars_Button.Click += new System.EventHandler(this.ShowAvailableCars_Button_Click);
            // 
            // PlateNumber_ComboBox
            // 
            this.PlateNumber_ComboBox.FormattingEnabled = true;
            this.PlateNumber_ComboBox.Location = new System.Drawing.Point(488, 545);
            this.PlateNumber_ComboBox.Name = "PlateNumber_ComboBox";
            this.PlateNumber_ComboBox.Size = new System.Drawing.Size(91, 24);
            this.PlateNumber_ComboBox.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Choose Car\'s Plate Number";
            // 
            // Check_Avail_Cars_Button
            // 
            this.Check_Avail_Cars_Button.Location = new System.Drawing.Point(597, 499);
            this.Check_Avail_Cars_Button.Name = "Check_Avail_Cars_Button";
            this.Check_Avail_Cars_Button.Size = new System.Drawing.Size(174, 35);
            this.Check_Avail_Cars_Button.TabIndex = 41;
            this.Check_Avail_Cars_Button.Text = "Check availale cars";
            this.Check_Avail_Cars_Button.UseVisualStyleBackColor = true;
            this.Check_Avail_Cars_Button.Click += new System.EventHandler(this.Check_Avail_Cars_Button_Click);
            // 
            // BookAVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 608);
            this.Controls.Add(this.Check_Avail_Cars_Button);
            this.Controls.Add(this.PlateNumber_ComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowAvailableCars_Button);
            this.Controls.Add(this.Available_Cars_DataGrid);
            this.Controls.Add(this.SelectCar_Button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.RentDate);
            this.Controls.Add(this.OfferID_ComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OfferList_GridView);
            this.Controls.Add(this.book_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Location_ComboBox);
            this.Controls.Add(this.SearchVehicle);
            this.Controls.Add(this.OffersList);
            this.Name = "BookAVehicle";
            this.Text = "BookVehicle";
            this.Load += new System.EventHandler(this.BookAVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OfferList_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Available_Cars_DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchVehicle;
        private System.Windows.Forms.Button OffersList;
        private System.Windows.Forms.ComboBox Location_ComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button book_Button;
        private System.Windows.Forms.DataGridView OfferList_GridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox OfferID_ComboBox;
        private System.Windows.Forms.DateTimePicker RentDate;
        private System.Windows.Forms.DateTimePicker ReturnDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SelectCar_Button;
        private System.Windows.Forms.DataGridView Available_Cars_DataGrid;
        private System.Windows.Forms.Button ShowAvailableCars_Button;
        private System.Windows.Forms.ComboBox PlateNumber_ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Check_Avail_Cars_Button;
    }
}