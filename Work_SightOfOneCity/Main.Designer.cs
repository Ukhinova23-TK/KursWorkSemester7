namespace Work_SightOfOneCity
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ViewButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.addRecordButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.StatusFilterTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.CategoryFilterTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.CategoryFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.authorFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.FamilyoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FamilyToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.NameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.PatronymicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PatronymicToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.nameFilterTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.nameFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.DGVDropDownMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.StatusFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.UserButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.ChangeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TablesToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.AuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KindTrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.MainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(5, 34);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(809, 427);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDoubleClick);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.EditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(65, 22);
            this.EditButton.Text = "Изменить";
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // ViewButton
            // 
            this.ViewButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ViewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ViewButton.Image = ((System.Drawing.Image)(resources.GetObject("ViewButton.Image")));
            this.ViewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(78, 22);
            this.ViewButton.Text = "Посмотреть";
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // addRecordButton
            // 
            this.addRecordButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.addRecordButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addRecordButton.Image = ((System.Drawing.Image)(resources.GetObject("addRecordButton.Image")));
            this.addRecordButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addRecordButton.Name = "addRecordButton";
            this.addRecordButton.Size = new System.Drawing.Size(106, 22);
            this.addRecordButton.Text = "Создать элемент ";
            this.addRecordButton.Click += new System.EventHandler(this.addRecordButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // StatusFilterTextBox
            // 
            this.StatusFilterTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StatusFilterTextBox.Name = "StatusFilterTextBox";
            this.StatusFilterTextBox.Size = new System.Drawing.Size(100, 23);
            this.StatusFilterTextBox.TextChanged += new System.EventHandler(this.StatusFilterTextBox_TextChanged);
            // 
            // CategoryFilterTextBox
            // 
            this.CategoryFilterTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CategoryFilterTextBox.Name = "CategoryFilterTextBox";
            this.CategoryFilterTextBox.Size = new System.Drawing.Size(100, 23);
            this.CategoryFilterTextBox.TextChanged += new System.EventHandler(this.CategoryFilterTextBox_TextChanged);
            // 
            // CategoryFilter
            // 
            this.CategoryFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CategoryFilterTextBox});
            this.CategoryFilter.Name = "CategoryFilter";
            this.CategoryFilter.Size = new System.Drawing.Size(180, 22);
            this.CategoryFilter.Text = "Категория";
            // 
            // authorFilter
            // 
            this.authorFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FamilyoolStripMenuItem,
            this.NameToolStripMenuItem,
            this.PatronymicToolStripMenuItem});
            this.authorFilter.Name = "authorFilter";
            this.authorFilter.Size = new System.Drawing.Size(180, 22);
            this.authorFilter.Text = "Автор";
            // 
            // FamilyoolStripMenuItem
            // 
            this.FamilyoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FamilyToolStripTextBox});
            this.FamilyoolStripMenuItem.Name = "FamilyoolStripMenuItem";
            this.FamilyoolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.FamilyoolStripMenuItem.Text = "Фамилия";
            // 
            // FamilyToolStripTextBox
            // 
            this.FamilyToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FamilyToolStripTextBox.Name = "FamilyToolStripTextBox";
            this.FamilyToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            this.FamilyToolStripTextBox.TextChanged += new System.EventHandler(this.FamilyToolStripTextBox_TextChanged);
            // 
            // NameToolStripMenuItem
            // 
            this.NameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NameToolStripTextBox});
            this.NameToolStripMenuItem.Name = "NameToolStripMenuItem";
            this.NameToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.NameToolStripMenuItem.Text = "Имя";
            // 
            // NameToolStripTextBox
            // 
            this.NameToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NameToolStripTextBox.Name = "NameToolStripTextBox";
            this.NameToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            this.NameToolStripTextBox.TextChanged += new System.EventHandler(this.NameToolStripTextBox_TextChanged);
            // 
            // PatronymicToolStripMenuItem
            // 
            this.PatronymicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PatronymicToolStripTextBox});
            this.PatronymicToolStripMenuItem.Name = "PatronymicToolStripMenuItem";
            this.PatronymicToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.PatronymicToolStripMenuItem.Text = "Отчество";
            // 
            // PatronymicToolStripTextBox
            // 
            this.PatronymicToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PatronymicToolStripTextBox.Name = "PatronymicToolStripTextBox";
            this.PatronymicToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            this.PatronymicToolStripTextBox.TextChanged += new System.EventHandler(this.PatronymicToolStripTextBox_TextChanged);
            // 
            // nameFilterTextBox
            // 
            this.nameFilterTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameFilterTextBox.Name = "nameFilterTextBox";
            this.nameFilterTextBox.Size = new System.Drawing.Size(100, 23);
            this.nameFilterTextBox.TextChanged += new System.EventHandler(this.nameFilterTextBox_TextChanged);
            // 
            // nameFilter
            // 
            this.nameFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameFilterTextBox});
            this.nameFilter.Name = "nameFilter";
            this.nameFilter.Size = new System.Drawing.Size(180, 22);
            this.nameFilter.Text = "Название";
            // 
            // DGVDropDownMenu
            // 
            this.DGVDropDownMenu.BackColor = System.Drawing.Color.AntiqueWhite;
            this.DGVDropDownMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DGVDropDownMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameFilter,
            this.authorFilter,
            this.CategoryFilter,
            this.StatusFilter});
            this.DGVDropDownMenu.Image = ((System.Drawing.Image)(resources.GetObject("DGVDropDownMenu.Image")));
            this.DGVDropDownMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DGVDropDownMenu.Name = "DGVDropDownMenu";
            this.DGVDropDownMenu.Size = new System.Drawing.Size(61, 22);
            this.DGVDropDownMenu.Text = "Фильтр";
            // 
            // StatusFilter
            // 
            this.StatusFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusFilterTextBox});
            this.StatusFilter.Name = "StatusFilter";
            this.StatusFilter.Size = new System.Drawing.Size(180, 22);
            this.StatusFilter.Text = "Статус";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.DGVDropDownMenu,
            this.toolStripSeparator2,
            this.addRecordButton,
            this.toolStripSeparator4,
            this.ViewButton,
            this.toolStripSeparator6,
            this.EditButton,
            this.toolStripSeparator7,
            this.UserButton,
            this.TablesToolStripDropDownButton});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 5);
            this.MainToolStrip.MinimumSize = new System.Drawing.Size(809, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainToolStrip.Size = new System.Drawing.Size(809, 25);
            this.MainToolStrip.TabIndex = 2;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // UserButton
            // 
            this.UserButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.UserButton.AutoSize = false;
            this.UserButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.UserButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UserButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeUserToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.UserButton.Image = ((System.Drawing.Image)(resources.GetObject("UserButton.Image")));
            this.UserButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(200, 22);
            this.UserButton.Text = "Профиль";
            // 
            // ChangeUserToolStripMenuItem
            // 
            this.ChangeUserToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.ChangeUserToolStripMenuItem.Name = "ChangeUserToolStripMenuItem";
            this.ChangeUserToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.ChangeUserToolStripMenuItem.Text = "Сменить пользователя";
            this.ChangeUserToolStripMenuItem.Click += new System.EventHandler(this.ChangeUserToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // TablesToolStripDropDownButton
            // 
            this.TablesToolStripDropDownButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.TablesToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TablesToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AuthorToolStripMenuItem,
            this.StatusToolStripMenuItem,
            this.StopToolStripMenuItem,
            this.CategoryToolStripMenuItem,
            this.SightToolStripMenuItem,
            this.KindTrToolStripMenuItem});
            this.TablesToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("TablesToolStripDropDownButton.Image")));
            this.TablesToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TablesToolStripDropDownButton.Name = "TablesToolStripDropDownButton";
            this.TablesToolStripDropDownButton.Size = new System.Drawing.Size(70, 22);
            this.TablesToolStripDropDownButton.Text = "Таблицы";
            // 
            // AuthorToolStripMenuItem
            // 
            this.AuthorToolStripMenuItem.Name = "AuthorToolStripMenuItem";
            this.AuthorToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.AuthorToolStripMenuItem.Text = "Авторы";
            this.AuthorToolStripMenuItem.Click += new System.EventHandler(this.AuthorToolStripMenuItem_Click);
            // 
            // StatusToolStripMenuItem
            // 
            this.StatusToolStripMenuItem.Name = "StatusToolStripMenuItem";
            this.StatusToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.StatusToolStripMenuItem.Text = "Статусы";
            this.StatusToolStripMenuItem.Click += new System.EventHandler(this.StatusToolStripMenuItem_Click);
            // 
            // StopToolStripMenuItem
            // 
            this.StopToolStripMenuItem.Name = "StopToolStripMenuItem";
            this.StopToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.StopToolStripMenuItem.Text = "Остановки";
            this.StopToolStripMenuItem.Click += new System.EventHandler(this.StopToolStripMenuItem_Click);
            // 
            // CategoryToolStripMenuItem
            // 
            this.CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem";
            this.CategoryToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.CategoryToolStripMenuItem.Text = "Категории";
            this.CategoryToolStripMenuItem.Click += new System.EventHandler(this.CategoryToolStripMenuItem_Click);
            // 
            // SightToolStripMenuItem
            // 
            this.SightToolStripMenuItem.Name = "SightToolStripMenuItem";
            this.SightToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.SightToolStripMenuItem.Text = "Достопримечательности";
            this.SightToolStripMenuItem.Click += new System.EventHandler(this.SightToolStripMenuItem_Click);
            // 
            // KindTrToolStripMenuItem
            // 
            this.KindTrToolStripMenuItem.Name = "KindTrToolStripMenuItem";
            this.KindTrToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.KindTrToolStripMenuItem.Text = "Вид транспорта";
            this.KindTrToolStripMenuItem.Click += new System.EventHandler(this.KindTrToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 467);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.MainToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(830, 506);
            this.MinimumSize = new System.Drawing.Size(830, 506);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton ViewButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton addRecordButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox StatusFilterTextBox;
        private System.Windows.Forms.ToolStripTextBox CategoryFilterTextBox;
        private System.Windows.Forms.ToolStripMenuItem CategoryFilter;
        private System.Windows.Forms.ToolStripMenuItem authorFilter;
        private System.Windows.Forms.ToolStripTextBox nameFilterTextBox;
        private System.Windows.Forms.ToolStripMenuItem nameFilter;
        private System.Windows.Forms.ToolStripDropDownButton DGVDropDownMenu;
        private System.Windows.Forms.ToolStripMenuItem StatusFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripMenuItem FamilyoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PatronymicToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox FamilyToolStripTextBox;
        private System.Windows.Forms.ToolStripTextBox NameToolStripTextBox;
        private System.Windows.Forms.ToolStripTextBox PatronymicToolStripTextBox;
        private System.Windows.Forms.ToolStripDropDownButton UserButton;
        private System.Windows.Forms.ToolStripMenuItem ChangeUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton TablesToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem AuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KindTrToolStripMenuItem;
    }
}

