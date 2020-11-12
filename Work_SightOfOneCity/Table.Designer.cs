namespace Work_SightOfOneCity
{
    partial class Table
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.FamilyLabel = new System.Windows.Forms.Label();
            this.PatronymicLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.FamilyTextBox = new System.Windows.Forms.TextBox();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.YearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.CreateEditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ManCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.YearNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(18, 77);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Имя";
            // 
            // FamilyLabel
            // 
            this.FamilyLabel.AutoSize = true;
            this.FamilyLabel.Location = new System.Drawing.Point(18, 147);
            this.FamilyLabel.Name = "FamilyLabel";
            this.FamilyLabel.Size = new System.Drawing.Size(56, 13);
            this.FamilyLabel.TabIndex = 1;
            this.FamilyLabel.Text = "Фамилия";
            // 
            // PatronymicLabel
            // 
            this.PatronymicLabel.AutoSize = true;
            this.PatronymicLabel.Location = new System.Drawing.Point(18, 112);
            this.PatronymicLabel.Name = "PatronymicLabel";
            this.PatronymicLabel.Size = new System.Drawing.Size(54, 13);
            this.PatronymicLabel.TabIndex = 2;
            this.PatronymicLabel.Text = "Отчество";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(18, 179);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(78, 13);
            this.YearLabel.TabIndex = 3;
            this.YearLabel.Text = "Год рождения";
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.PowderBlue;
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.Location = new System.Drawing.Point(112, 74);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(287, 20);
            this.NameTextBox.TabIndex = 4;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // FamilyTextBox
            // 
            this.FamilyTextBox.BackColor = System.Drawing.Color.PowderBlue;
            this.FamilyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FamilyTextBox.Location = new System.Drawing.Point(112, 144);
            this.FamilyTextBox.Name = "FamilyTextBox";
            this.FamilyTextBox.Size = new System.Drawing.Size(287, 20);
            this.FamilyTextBox.TabIndex = 5;
            this.FamilyTextBox.TextChanged += new System.EventHandler(this.FamilyTextBox_TextChanged);
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.BackColor = System.Drawing.Color.PowderBlue;
            this.PatronymicTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PatronymicTextBox.Location = new System.Drawing.Point(112, 110);
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(287, 20);
            this.PatronymicTextBox.TabIndex = 6;
            this.PatronymicTextBox.TextChanged += new System.EventHandler(this.PatronymicTextBox_TextChanged);
            // 
            // YearNumericUpDown
            // 
            this.YearNumericUpDown.Location = new System.Drawing.Point(112, 177);
            this.YearNumericUpDown.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.YearNumericUpDown.Name = "YearNumericUpDown";
            this.YearNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.YearNumericUpDown.TabIndex = 7;
            this.YearNumericUpDown.ValueChanged += new System.EventHandler(this.YearNumericUpDown_ValueChanged);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.HeaderLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderLabel.Location = new System.Drawing.Point(176, 28);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(67, 27);
            this.HeaderLabel.TabIndex = 8;
            this.HeaderLabel.Text = "label1";
            // 
            // CreateEditButton
            // 
            this.CreateEditButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CreateEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateEditButton.Location = new System.Drawing.Point(21, 250);
            this.CreateEditButton.Name = "CreateEditButton";
            this.CreateEditButton.Size = new System.Drawing.Size(378, 23);
            this.CreateEditButton.TabIndex = 9;
            this.CreateEditButton.Text = "Сохранить";
            this.CreateEditButton.UseVisualStyleBackColor = false;
            this.CreateEditButton.Click += new System.EventHandler(this.CreateEditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Orchid;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteButton.Location = new System.Drawing.Point(21, 221);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(378, 23);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.Location = new System.Drawing.Point(21, 279);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(378, 23);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.Text = "Омена";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ManCheckBox
            // 
            this.ManCheckBox.AutoSize = true;
            this.ManCheckBox.Location = new System.Drawing.Point(288, 179);
            this.ManCheckBox.Name = "ManCheckBox";
            this.ManCheckBox.Size = new System.Drawing.Size(93, 17);
            this.ManCheckBox.TabIndex = 13;
            this.ManCheckBox.Text = "Мужской пол";
            this.ManCheckBox.UseVisualStyleBackColor = true;
            this.ManCheckBox.CheckedChanged += new System.EventHandler(this.ManCheckBox_CheckedChanged);
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 316);
            this.Controls.Add(this.ManCheckBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CreateEditButton);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.YearNumericUpDown);
            this.Controls.Add(this.PatronymicTextBox);
            this.Controls.Add(this.FamilyTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.PatronymicLabel);
            this.Controls.Add(this.FamilyLabel);
            this.Controls.Add(this.NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Изменение информационных сведений";
            ((System.ComponentModel.ISupportInitialize)(this.YearNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label FamilyLabel;
        private System.Windows.Forms.Label PatronymicLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox FamilyTextBox;
        private System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.NumericUpDown YearNumericUpDown;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Button CreateEditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.CheckBox ManCheckBox;
    }
}