namespace CityInformationApp
{
    partial class CityInformation
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
            this.cityInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.aboutTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.cityListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.countrySearchRadioButton = new System.Windows.Forms.RadioButton();
            this.citySearchRadioButton = new System.Windows.Forms.RadioButton();
            this.cityInfoGroupBox.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cityInfoGroupBox
            // 
            this.cityInfoGroupBox.Controls.Add(this.saveButton);
            this.cityInfoGroupBox.Controls.Add(this.aboutTextBox);
            this.cityInfoGroupBox.Controls.Add(this.countryTextBox);
            this.cityInfoGroupBox.Controls.Add(this.cityTextBox);
            this.cityInfoGroupBox.Controls.Add(this.label3);
            this.cityInfoGroupBox.Controls.Add(this.label2);
            this.cityInfoGroupBox.Controls.Add(this.label1);
            this.cityInfoGroupBox.Location = new System.Drawing.Point(77, 12);
            this.cityInfoGroupBox.Name = "cityInfoGroupBox";
            this.cityInfoGroupBox.Size = new System.Drawing.Size(409, 174);
            this.cityInfoGroupBox.TabIndex = 0;
            this.cityInfoGroupBox.TabStop = false;
            this.cityInfoGroupBox.Text = "City Information";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(193, 145);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // aboutTextBox
            // 
            this.aboutTextBox.Location = new System.Drawing.Point(93, 68);
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.Size = new System.Drawing.Size(175, 20);
            this.aboutTextBox.TabIndex = 5;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(93, 108);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(175, 20);
            this.countryTextBox.TabIndex = 4;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(93, 34);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(175, 20);
            this.cityTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "About";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "City Name";
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.cityListView);
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.searchTextBox);
            this.searchGroupBox.Controls.Add(this.countrySearchRadioButton);
            this.searchGroupBox.Controls.Add(this.citySearchRadioButton);
            this.searchGroupBox.Location = new System.Drawing.Point(77, 204);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(409, 329);
            this.searchGroupBox.TabIndex = 1;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search";
            // 
            // cityListView
            // 
            this.cityListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.cityListView.FullRowSelect = true;
            this.cityListView.GridLines = true;
            this.cityListView.Location = new System.Drawing.Point(25, 86);
            this.cityListView.Name = "cityListView";
            this.cityListView.Size = new System.Drawing.Size(351, 227);
            this.cityListView.TabIndex = 4;
            this.cityListView.UseCompatibleStateImageBehavior = false;
            this.cityListView.View = System.Windows.Forms.View.Details;
            this.cityListView.DoubleClick += new System.EventHandler(this.cityListView_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SerialNo.";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CityName";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "About";
            this.columnHeader3.Width = 133;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Country";
            this.columnHeader4.Width = 94;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(328, 26);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(153, 29);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(144, 20);
            this.searchTextBox.TabIndex = 2;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // countrySearchRadioButton
            // 
            this.countrySearchRadioButton.AutoSize = true;
            this.countrySearchRadioButton.Location = new System.Drawing.Point(25, 42);
            this.countrySearchRadioButton.Name = "countrySearchRadioButton";
            this.countrySearchRadioButton.Size = new System.Drawing.Size(112, 17);
            this.countrySearchRadioButton.TabIndex = 1;
            this.countrySearchRadioButton.TabStop = true;
            this.countrySearchRadioButton.Text = "Search by Country";
            this.countrySearchRadioButton.UseVisualStyleBackColor = true;
            // 
            // citySearchRadioButton
            // 
            this.citySearchRadioButton.AutoSize = true;
            this.citySearchRadioButton.Location = new System.Drawing.Point(25, 19);
            this.citySearchRadioButton.Name = "citySearchRadioButton";
            this.citySearchRadioButton.Size = new System.Drawing.Size(93, 17);
            this.citySearchRadioButton.TabIndex = 0;
            this.citySearchRadioButton.TabStop = true;
            this.citySearchRadioButton.Text = "Search by City";
            this.citySearchRadioButton.UseVisualStyleBackColor = true;
            // 
            // CityInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 545);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.cityInfoGroupBox);
            this.Name = "CityInformation";
            this.Text = "City Information";
            this.Load += new System.EventHandler(this.CityInformation_Load);
            this.cityInfoGroupBox.ResumeLayout(false);
            this.cityInfoGroupBox.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cityInfoGroupBox;
        private System.Windows.Forms.TextBox aboutTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.ListView cityListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.RadioButton countrySearchRadioButton;
        private System.Windows.Forms.RadioButton citySearchRadioButton;
    }
}

