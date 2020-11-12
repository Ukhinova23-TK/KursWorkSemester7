namespace Work_SightOfOneCity
{
    partial class Edit
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
            this.YearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.AddPictureButton = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.Statuslabel = new System.Windows.Forms.Label();
            this.BusStopLable = new System.Windows.Forms.Label();
            this.DelButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CreationDateLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.DiscriptionLabel = new System.Windows.Forms.Label();
            this.DiscriptionTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.StopComboBox = new System.Windows.Forms.ComboBox();
            this.AuthorDataGridView = new System.Windows.Forms.DataGridView();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.Categorylabel = new System.Windows.Forms.Label();
            this.AuthorComboBox = new System.Windows.Forms.ComboBox();
            this.AuthorDGV = new System.Windows.Forms.DataGridView();
            this.FamilyAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatronymicAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorLabel1 = new System.Windows.Forms.Label();
            this.DelAuthButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.YearNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // YearNumericUpDown
            // 
            this.YearNumericUpDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YearNumericUpDown.Location = new System.Drawing.Point(413, 191);
            this.YearNumericUpDown.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.YearNumericUpDown.Name = "YearNumericUpDown";
            this.YearNumericUpDown.Size = new System.Drawing.Size(69, 20);
            this.YearNumericUpDown.TabIndex = 53;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // AddPictureButton
            // 
            this.AddPictureButton.BackColor = System.Drawing.Color.Khaki;
            this.AddPictureButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddPictureButton.Location = new System.Drawing.Point(9, 235);
            this.AddPictureButton.Name = "AddPictureButton";
            this.AddPictureButton.Size = new System.Drawing.Size(232, 21);
            this.AddPictureButton.TabIndex = 52;
            this.AddPictureButton.Text = "Добавить изображение";
            this.AddPictureButton.UseVisualStyleBackColor = false;
            this.AddPictureButton.Click += new System.EventHandler(this.AddPictureButton_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.DarkKhaki;
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox.Location = new System.Drawing.Point(9, 15);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(232, 209);
            this.PictureBox.TabIndex = 51;
            this.PictureBox.TabStop = false;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.BackColor = System.Drawing.Color.DarkKhaki;
            this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(646, 226);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(249, 21);
            this.StatusComboBox.TabIndex = 50;
            // 
            // Statuslabel
            // 
            this.Statuslabel.AutoSize = true;
            this.Statuslabel.Location = new System.Drawing.Point(517, 229);
            this.Statuslabel.Name = "Statuslabel";
            this.Statuslabel.Size = new System.Drawing.Size(45, 13);
            this.Statuslabel.TabIndex = 48;
            this.Statuslabel.Text = "Статус*";
            // 
            // BusStopLable
            // 
            this.BusStopLable.AutoSize = true;
            this.BusStopLable.Location = new System.Drawing.Point(517, 193);
            this.BusStopLable.Name = "BusStopLable";
            this.BusStopLable.Size = new System.Drawing.Size(66, 13);
            this.BusStopLable.TabIndex = 47;
            this.BusStopLable.Text = "Остановка*";
            // 
            // DelButton
            // 
            this.DelButton.BackColor = System.Drawing.Color.Salmon;
            this.DelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelButton.Location = new System.Drawing.Point(9, 477);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(886, 23);
            this.DelButton.TabIndex = 40;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseVisualStyleBackColor = false;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(9, 569);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(886, 23);
            this.CloseButton.TabIndex = 39;
            this.CloseButton.Text = "Отменить";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.PaleGreen;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Location = new System.Drawing.Point(9, 523);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(886, 23);
            this.SaveButton.TabIndex = 38;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CreationDateLabel
            // 
            this.CreationDateLabel.AutoSize = true;
            this.CreationDateLabel.Location = new System.Drawing.Point(284, 195);
            this.CreationDateLabel.Name = "CreationDateLabel";
            this.CreationDateLabel.Size = new System.Drawing.Size(80, 13);
            this.CreationDateLabel.TabIndex = 37;
            this.CreationDateLabel.Text = "Год создания*";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(284, 158);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(107, 13);
            this.AddressLabel.TabIndex = 36;
            this.AddressLabel.Text = "Место нахождения*";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(234)))), ((int)(((byte)(172)))));
            this.AddressTextBox.Location = new System.Drawing.Point(413, 155);
            this.AddressTextBox.MaxLength = 250;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(482, 20);
            this.AddressTextBox.TabIndex = 35;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(6, 292);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(92, 13);
            this.AuthorLabel.TabIndex = 34;
            this.AuthorLabel.Text = "Текущие авторы";
            // 
            // DiscriptionLabel
            // 
            this.DiscriptionLabel.AutoSize = true;
            this.DiscriptionLabel.Location = new System.Drawing.Point(284, 55);
            this.DiscriptionLabel.Name = "DiscriptionLabel";
            this.DiscriptionLabel.Size = new System.Drawing.Size(61, 13);
            this.DiscriptionLabel.TabIndex = 32;
            this.DiscriptionLabel.Text = "Описание*";
            // 
            // DiscriptionTextBox
            // 
            this.DiscriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(234)))), ((int)(((byte)(172)))));
            this.DiscriptionTextBox.Location = new System.Drawing.Point(413, 53);
            this.DiscriptionTextBox.MaxLength = 4000;
            this.DiscriptionTextBox.Multiline = true;
            this.DiscriptionTextBox.Name = "DiscriptionTextBox";
            this.DiscriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DiscriptionTextBox.Size = new System.Drawing.Size(482, 87);
            this.DiscriptionTextBox.TabIndex = 31;
            this.DiscriptionTextBox.TextChanged += new System.EventHandler(this.DiscriptionTextBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(284, 21);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(61, 13);
            this.NameLabel.TabIndex = 30;
            this.NameLabel.Text = "Название*";
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(234)))), ((int)(((byte)(172)))));
            this.NameTextBox.Location = new System.Drawing.Point(413, 18);
            this.NameTextBox.MaxLength = 250;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(482, 20);
            this.NameTextBox.TabIndex = 29;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // StopComboBox
            // 
            this.StopComboBox.BackColor = System.Drawing.Color.DarkKhaki;
            this.StopComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StopComboBox.FormattingEnabled = true;
            this.StopComboBox.Location = new System.Drawing.Point(646, 190);
            this.StopComboBox.Name = "StopComboBox";
            this.StopComboBox.Size = new System.Drawing.Size(249, 21);
            this.StopComboBox.TabIndex = 54;
            // 
            // AuthorDataGridView
            // 
            this.AuthorDataGridView.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.AuthorDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AuthorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuthorDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(179)))));
            this.AuthorDataGridView.Location = new System.Drawing.Point(9, 355);
            this.AuthorDataGridView.MaximumSize = new System.Drawing.Size(340, 87);
            this.AuthorDataGridView.MinimumSize = new System.Drawing.Size(340, 87);
            this.AuthorDataGridView.Name = "AuthorDataGridView";
            this.AuthorDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AuthorDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AuthorDataGridView.Size = new System.Drawing.Size(340, 87);
            this.AuthorDataGridView.TabIndex = 55;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.BackColor = System.Drawing.Color.DarkKhaki;
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(646, 262);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(249, 21);
            this.CategoryComboBox.TabIndex = 57;
            // 
            // Categorylabel
            // 
            this.Categorylabel.AutoSize = true;
            this.Categorylabel.Location = new System.Drawing.Point(517, 265);
            this.Categorylabel.Name = "Categorylabel";
            this.Categorylabel.Size = new System.Drawing.Size(64, 13);
            this.Categorylabel.TabIndex = 56;
            this.Categorylabel.Text = "Категория*";
            // 
            // AuthorComboBox
            // 
            this.AuthorComboBox.BackColor = System.Drawing.Color.DarkKhaki;
            this.AuthorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuthorComboBox.FormattingEnabled = true;
            this.AuthorComboBox.Location = new System.Drawing.Point(413, 319);
            this.AuthorComboBox.Name = "AuthorComboBox";
            this.AuthorComboBox.Size = new System.Drawing.Size(340, 21);
            this.AuthorComboBox.TabIndex = 58;
            this.AuthorComboBox.Visible = false;
            // 
            // AuthorDGV
            // 
            this.AuthorDGV.AllowUserToAddRows = false;
            this.AuthorDGV.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.AuthorDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AuthorDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuthorDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FamilyAuthor,
            this.NameAuthor,
            this.PatronymicAuthor});
            this.AuthorDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(179)))));
            this.AuthorDGV.Location = new System.Drawing.Point(413, 355);
            this.AuthorDGV.MaximumSize = new System.Drawing.Size(340, 87);
            this.AuthorDGV.MinimumSize = new System.Drawing.Size(340, 87);
            this.AuthorDGV.Name = "AuthorDGV";
            this.AuthorDGV.ReadOnly = true;
            this.AuthorDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AuthorDGV.Size = new System.Drawing.Size(340, 87);
            this.AuthorDGV.TabIndex = 59;
            // 
            // FamilyAuthor
            // 
            this.FamilyAuthor.HeaderText = "Фамилия";
            this.FamilyAuthor.MaxInputLength = 150;
            this.FamilyAuthor.Name = "FamilyAuthor";
            this.FamilyAuthor.ReadOnly = true;
            // 
            // NameAuthor
            // 
            this.NameAuthor.HeaderText = "Имя";
            this.NameAuthor.MaxInputLength = 150;
            this.NameAuthor.Name = "NameAuthor";
            this.NameAuthor.ReadOnly = true;
            // 
            // PatronymicAuthor
            // 
            this.PatronymicAuthor.HeaderText = "Отчество";
            this.PatronymicAuthor.MaxInputLength = 150;
            this.PatronymicAuthor.Name = "PatronymicAuthor";
            this.PatronymicAuthor.ReadOnly = true;
            // 
            // AuthorLabel1
            // 
            this.AuthorLabel1.AutoSize = true;
            this.AuthorLabel1.Location = new System.Drawing.Point(410, 292);
            this.AuthorLabel1.Name = "AuthorLabel1";
            this.AuthorLabel1.Size = new System.Drawing.Size(120, 13);
            this.AuthorLabel1.TabIndex = 60;
            this.AuthorLabel1.Text = "Добавляемые авторы";
            // 
            // DelAuthButton
            // 
            this.DelAuthButton.BackColor = System.Drawing.Color.Salmon;
            this.DelAuthButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelAuthButton.Location = new System.Drawing.Point(9, 317);
            this.DelAuthButton.Name = "DelAuthButton";
            this.DelAuthButton.Size = new System.Drawing.Size(340, 23);
            this.DelAuthButton.TabIndex = 61;
            this.DelAuthButton.Text = "Удалить автора";
            this.DelAuthButton.UseVisualStyleBackColor = false;
            this.DelAuthButton.Click += new System.EventHandler(this.DelAuthButton_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(907, 607);
            this.Controls.Add(this.DelAuthButton);
            this.Controls.Add(this.AuthorLabel1);
            this.Controls.Add(this.AuthorDGV);
            this.Controls.Add(this.AuthorComboBox);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.Categorylabel);
            this.Controls.Add(this.AuthorDataGridView);
            this.Controls.Add(this.StopComboBox);
            this.Controls.Add(this.YearNumericUpDown);
            this.Controls.Add(this.AddPictureButton);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.Statuslabel);
            this.Controls.Add(this.BusStopLable);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CreationDateLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.DiscriptionLabel);
            this.Controls.Add(this.DiscriptionTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            ((System.ComponentModel.ISupportInitialize)(this.YearNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown YearNumericUpDown;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button AddPictureButton;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Label Statuslabel;
        private System.Windows.Forms.Label BusStopLable;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label CreationDateLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label DiscriptionLabel;
        private System.Windows.Forms.TextBox DiscriptionTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ComboBox StopComboBox;
        private System.Windows.Forms.DataGridView AuthorDataGridView;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label Categorylabel;
        private System.Windows.Forms.ComboBox AuthorComboBox;
        private System.Windows.Forms.DataGridView AuthorDGV;
        private System.Windows.Forms.Label AuthorLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamilyAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatronymicAuthor;
        private System.Windows.Forms.Button DelAuthButton;
    }
}