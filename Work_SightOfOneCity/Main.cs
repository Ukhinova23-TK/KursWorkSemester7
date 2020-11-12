using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;

namespace Work_SightOfOneCity
{
    public partial class Main : Form
    {
        private byte choose; 
        private string connectionString;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="con">Строка соединения с бд</param>
        public Main(string con)
        {
            try
            {
                connectionString = con;
                InitializeComponent();
                InitDVG();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public Main()
        {
            InitializeComponent();
            InitDVG();
        }

        private void InitDVG()
        {
            try
            {
                using (SightOfOneCityEntities context = new SightOfOneCityEntities(connectionString))
                {
                    var result = (from sight in context.Sight
                                  join category in context.Category on sight.CategoryID equals category.ID
                                  join status in context.StatusSight on sight.StatusID equals status.ID
                                  join authorofsight in context.AuthorOfSight on sight.ID equals authorofsight.SightID
                                  join author in context.Author on authorofsight.AuthorID equals author.ID
                                  select new
                                  {
                                      NameSight = sight.NameSight,
                                      Category = category.NameCategory,
                                      Status = status.NameStatus,
                                      Family = author.FamilyAuthor,
                                      Name = author.NameAuthor,
                                      Patronymic = author.PatronymicAuthor
                                  });
                    dataGridView.DataSource = null;
                    dataGridView.DataSource = result.ToList();
                    dataGridView.Columns[0].Width = 170;
                }
                dataGridView.Columns[0].HeaderText = "Название";
                dataGridView.Columns[1].Width = 80;
                dataGridView.Columns[1].HeaderText = "Категория";
                dataGridView.Columns[2].Width = 220;
                dataGridView.Columns[2].HeaderText = "Статус";
                dataGridView.Columns[3].Width = 100;
                dataGridView.Columns[3].HeaderText = "Фамилия";
                dataGridView.Columns[4].Width = 100;
                dataGridView.Columns[4].HeaderText = "Имя";
                dataGridView.Columns[5].Width = 100;
                dataGridView.Columns[5].HeaderText = "Отчество";
                nameFilter.Visible = true;
                authorFilter.Visible = true;
                CategoryFilter.Visible = true;
                StatusFilter.Visible = true;
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            InitDVG();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SightOfOneCityEntities context = new SightOfOneCityEntities(connectionString))
                {
                    if (choose == 0)
                    {
                        if (dataGridView.SelectedRows.Count != 0)
                        {
                            string s = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                            Edit edit = new Edit((from sight in context.Sight
                                                  where s == sight.NameSight
                                                  select sight).FirstOrDefault(), connectionString, true);
                            edit.FormClosed += Edit_FormClosed;
                            edit.ShowDialog();
                        }
                    }
                    else if (choose == 1)
                    {
                        if (dataGridView.SelectedRows.Count != 0)
                        {
                            string a = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                            string a1 = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                            string a2 = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                            string a3 = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                            string a4 = dataGridView.SelectedRows[0].Cells[4].Value.ToString();
                            Table table = new Table((from author in context.Author
                                                     where a == author.FamilyAuthor
                                                     && a1 == author.NameAuthor
                                                     && a2 == author.PatronymicAuthor
                                                     && a3 == author.Gender.ToString()
                                                     && a4 == author.DateBirthday.ToString()
                                                     select author).FirstOrDefault(), connectionString, true);
                            table.FormClosed += Edit_FormClosed;
                            table.ShowDialog();
                            choose = 0;
                        }
                    }
                    else if (choose == 2)
                    {
                        if (dataGridView.SelectedRows.Count != 0)
                        {
                            string ss = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                            Table table = new Table((from status in context.StatusSight
                                                     where ss == status.NameStatus
                                                     select status).FirstOrDefault(), connectionString, true);
                            table.FormClosed += Edit_FormClosed;
                            table.ShowDialog();
                            choose = 0;
                        }
                    }
                    else if (choose == 3)
                    {
                        if (dataGridView.SelectedRows.Count != 0)
                        {
                            string ts = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                            Table table = new Table((from stop in context.TransportStop
                                                     where ts == stop.NameStop
                                                     select stop).FirstOrDefault(), connectionString, true);
                            table.FormClosed += Edit_FormClosed;
                            table.ShowDialog();
                            choose = 0;
                        }
                    }
                    else if (choose == 4)
                    {
                        if (dataGridView.SelectedRows.Count != 0)
                        {
                            string c = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                            Table table = new Table((from category in context.Category
                                                     where c == category.NameCategory
                                                     select category).FirstOrDefault(), connectionString, true);
                            table.FormClosed += Edit_FormClosed;
                            table.ShowDialog();
                            choose = 0;
                        }
                    }
                    else if (choose == 5)
                    {
                        if (dataGridView.SelectedRows.Count != 0)
                        {
                            string kt = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                            Table table = new Table((from kind in context.KindOfTransport
                                                     where kt == kind.NameKind
                                                     select kind).FirstOrDefault(), connectionString, true);
                            table.FormClosed += Edit_FormClosed;
                            table.ShowDialog();
                            choose = 0;
                        }
                    }
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void addRecordButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (choose == 0)
                {
                    var editform = new Edit(null, connectionString);
                    editform.FormClosed += Edit_FormClosed;
                    editform.ShowDialog(this);
                }
                if (choose == 1)
                {
                    Author a = null;
                    var form = new Table(a, connectionString);
                    form.FormClosed += Edit_FormClosed;
                    form.ShowDialog(this);
                    choose = 0;
                }
                if (choose == 2)
                {
                    StatusSight a = null;
                    var form = new Table(a, connectionString);
                    form.FormClosed += Edit_FormClosed;
                    form.ShowDialog(this);
                    choose = 0;
                }
                if (choose == 3)
                {
                    TransportStop a = null;
                    var form = new Table(a, connectionString);
                    form.FormClosed += Edit_FormClosed;
                    form.ShowDialog(this);
                    choose = 0;
                }
                if (choose == 4)
                {
                    Category a = null;
                    var form = new Table(a, connectionString);
                    form.FormClosed += Edit_FormClosed;
                    form.ShowDialog(this);
                    choose = 0;
                }
                if (choose == 5)
                {
                    KindOfTransport a = null;
                    var form = new Table(a, connectionString);
                    form.FormClosed += Edit_FormClosed;
                    form.ShowDialog(this);
                    choose = 0;
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void nameFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SightOfOneCityEntities context = new SightOfOneCityEntities(connectionString))
                {
                    if (choose == 0)
                    {
                        var r = (from sight in context.Sight
                                 join category in context.Category on sight.CategoryID equals category.ID
                                 join status in context.StatusSight on sight.StatusID equals status.ID
                                 join authorofsight in context.AuthorOfSight on sight.ID equals authorofsight.SightID
                                 join author in context.Author on authorofsight.AuthorID equals author.ID
                                 select new
                                 {
                                     NameSight = sight.NameSight,
                                     Category = category.NameCategory,
                                     Status = status.NameStatus,
                                     Family = author.FamilyAuthor,
                                     Name = author.NameAuthor,
                                     Patronymic = author.PatronymicAuthor
                                 });
                        if (dataGridView.DataSource != null)
                        {
                            if (!string.IsNullOrWhiteSpace(nameFilterTextBox.Text))
                            {
                                dataGridView.DataSource = r.Where(c => c.NameSight.Contains(nameFilterTextBox.Text)).ToList();
                            }
                            else
                            {
                                dataGridView.DataSource = r.ToList();
                            }
                        }
                    }
                    else if (choose == 2)
                    {
                        var r = (from status in context.StatusSight
                                 select new { Name = status.NameStatus });
                        if (dataGridView.DataSource != null)
                        {
                            if (!string.IsNullOrWhiteSpace(nameFilterTextBox.Text))
                            {
                                dataGridView.DataSource = r.Where(c => c.Name.Contains(nameFilterTextBox.Text)).ToList();
                            }
                            else
                            {
                                dataGridView.DataSource = r.ToList();
                            }
                        }
                    }
                    else if (choose == 3)
                    {
                        var r = (from stop in context.TransportStop
                                 select new { Name = stop.NameStop });
                        if (dataGridView.DataSource != null)
                        {
                            if (!string.IsNullOrWhiteSpace(nameFilterTextBox.Text))
                            {
                                dataGridView.DataSource = r.Where(c => c.Name.Contains(nameFilterTextBox.Text)).ToList();
                            }
                            else
                            {
                                dataGridView.DataSource = r.ToList();
                            }
                        }
                    }
                    else if (choose == 4)
                    {
                        var r = (from category in context.Category
                                 select new { Name = category.NameCategory });
                        if (dataGridView.DataSource != null)
                        {
                            if (!string.IsNullOrWhiteSpace(nameFilterTextBox.Text))
                            {
                                dataGridView.DataSource = r.Where(c => c.Name.Contains(nameFilterTextBox.Text)).ToList();
                            }
                            else
                            {
                                dataGridView.DataSource = r.ToList();
                            }
                        }
                    }
                    else if (choose == 5)
                    {
                        var r = (from kind in context.KindOfTransport
                                 select new { Name = kind.NameKind });
                        if (dataGridView.DataSource != null)
                        {
                            if (!string.IsNullOrWhiteSpace(nameFilterTextBox.Text))
                            {
                                dataGridView.DataSource = r.Where(c => c.Name.Contains(nameFilterTextBox.Text)).ToList();
                            }
                            else
                            {
                                dataGridView.DataSource = r.ToList();
                            }
                        }
                    }
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void StatusFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SightOfOneCityEntities context = new SightOfOneCityEntities(connectionString))
                {
                    var r = (from sight in context.Sight
                             join category in context.Category on sight.CategoryID equals category.ID
                             join status in context.StatusSight on sight.StatusID equals status.ID
                             join authorofsight in context.AuthorOfSight on sight.ID equals authorofsight.SightID
                             join author in context.Author on authorofsight.AuthorID equals author.ID
                             select new
                             {
                                 NameSight = sight.NameSight,
                                 Category = category.NameCategory,
                                 Status = status.NameStatus,
                                 Family = author.FamilyAuthor,
                                 Name = author.NameAuthor,
                                 Patronymic = author.PatronymicAuthor
                             });
                    if (dataGridView.DataSource != null)
                    {
                        if (!string.IsNullOrWhiteSpace(StatusFilterTextBox.Text))
                        {
                            dataGridView.DataSource = r.Where(c => c.Status.Contains(StatusFilterTextBox.Text)).ToList();
                        }
                        else
                        {
                            dataGridView.DataSource = r.ToList();
                        }
                    }
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void CategoryFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SightOfOneCityEntities context = new SightOfOneCityEntities(connectionString))
                {
                    var r = (from sight in context.Sight
                             join category in context.Category on sight.CategoryID equals category.ID
                             join status in context.StatusSight on sight.StatusID equals status.ID
                             join authorofsight in context.AuthorOfSight on sight.ID equals authorofsight.SightID
                             join author in context.Author on authorofsight.AuthorID equals author.ID
                             select new
                             {
                                 NameSight = sight.NameSight,
                                 Category = category.NameCategory,
                                 Status = status.NameStatus,
                                 Family = author.FamilyAuthor,
                                 Name = author.NameAuthor,
                                 Patronymic = author.PatronymicAuthor
                             });
                    if (dataGridView.DataSource != null)
                    {
                        if (!string.IsNullOrWhiteSpace(CategoryFilterTextBox.Text))
                        {
                            dataGridView.DataSource = r.Where(c => c.Category.Contains(CategoryFilterTextBox.Text)).ToList();
                        }
                        else
                        {
                            dataGridView.DataSource = r.ToList();
                        }
                    }
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void FamilyToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SightOfOneCityEntities context = new SightOfOneCityEntities(connectionString))
                {
                    if (choose == 0)
                    {
                        var r = (from sight in context.Sight
                                 join category in context.Category on sight.CategoryID equals category.ID
                                 join status in context.StatusSight on sight.StatusID equals status.ID
                                 join authorofsight in context.AuthorOfSight on sight.ID equals authorofsight.SightID
                                 join author in context.Author on authorofsight.AuthorID equals author.ID
                                 select new
                                 {
                                     NameSight = sight.NameSight,
                                     Category = category.NameCategory,
                                     Status = status.NameStatus,
                                     Family = author.FamilyAuthor,
                                     Name = author.NameAuthor,
                                     Patronymic = author.PatronymicAuthor
                                 });
                        if (dataGridView.DataSource != null)
                        {
                            if (!string.IsNullOrWhiteSpace(FamilyToolStripTextBox.Text))
                            {
                                dataGridView.DataSource = r.Where(c => c.Family.Contains(FamilyToolStripTextBox.Text)).ToList();
                            }
                            else
                            {
                                dataGridView.DataSource = r.ToList();
                            }
                        }
                    }
                    else if (choose == 1)
                    {
                        var r = (from author in context.Author
                                 select new
                                 {
                                     Family = author.FamilyAuthor,
                                     Name = author.NameAuthor,
                                     Patronymic = author.PatronymicAuthor,
                                     Gender = author.Gender,
                                     YearBirthday = author.DateBirthday
                                 });
                        if (dataGridView.DataSource != null)
                        {
                            if (!string.IsNullOrWhiteSpace(FamilyToolStripTextBox.Text))
                            {
                                dataGridView.DataSource = r.Where(c => c.Family.Contains(FamilyToolStripTextBox.Text)).ToList();
                            }
                            else
                            {
                                dataGridView.DataSource = r.ToList();
                            }
                        }
                    }
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void NameToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SightOfOneCityEntities context = new SightOfOneCityEntities(connectionString))
                {
                    if (choose == 0)
                    {
                        var r = (from sight in context.Sight
                                 join category in context.Category on sight.CategoryID equals category.ID
                                 join status in context.StatusSight on sight.StatusID equals status.ID
                                 join authorofsight in context.AuthorOfSight on sight.ID equals authorofsight.SightID
                                 join author in context.Author on authorofsight.AuthorID equals author.ID
                                 select new
                                 {
                                     NameSight = sight.NameSight,
                                     Category = category.NameCategory,
                                     Status = status.NameStatus,
                                     Family = author.FamilyAuthor,
                                     Name = author.NameAuthor,
                                     Patronymic = author.PatronymicAuthor
                                 });
                        if (dataGridView.DataSource != null)
                        {
                            if (!string.IsNullOrWhiteSpace(NameToolStripTextBox.Text))
                            {
                                dataGridView.DataSource = r.Where(c => c.Name.Contains(NameToolStripTextBox.Text)).ToList();
                            }
                            else
                            {
                                dataGridView.DataSource = r.ToList();
                            }
                        }
                    }
                    else if (choose == 1)
                    {
                        var r = (from author in context.Author
                                 select new
                                 {
                                     Family = author.FamilyAuthor,
                                     Name = author.NameAuthor,
                                     Patronymic = author.PatronymicAuthor,
                                     Gender = author.Gender,
                                     YearBirthday = author.DateBirthday
                                 });
                        if (dataGridView.DataSource != null)
                        {
                            if (!string.IsNullOrWhiteSpace(NameToolStripTextBox.Text))
                            {
                                dataGridView.DataSource = r.Where(c => c.Name.Contains(NameToolStripTextBox.Text)).ToList();
                            }
                            else
                            {
                                dataGridView.DataSource = r.ToList();
                            }
                        }
                    }
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void PatronymicToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SightOfOneCityEntities context = new SightOfOneCityEntities(connectionString))
                {
                    if (choose == 0)
                    {
                        var r = (from sight in context.Sight
                                 join category in context.Category on sight.CategoryID equals category.ID
                                 join status in context.StatusSight on sight.StatusID equals status.ID
                                 join authorofsight in context.AuthorOfSight on sight.ID equals authorofsight.SightID
                                 join author in context.Author on authorofsight.AuthorID equals author.ID
                                 select new
                                 {
                                     NameSight = sight.NameSight,
                                     Category = category.NameCategory,
                                     Status = status.NameStatus,
                                     Family = author.FamilyAuthor,
                                     Name = author.NameAuthor,
                                     Patronymic = author.PatronymicAuthor
                                 });
                        if (dataGridView.DataSource != null)
                        {
                            if (!string.IsNullOrWhiteSpace(PatronymicToolStripTextBox.Text))
                            {
                                dataGridView.DataSource = r.Where(c => c.Patronymic.Contains(PatronymicToolStripTextBox.Text)).ToList();
                            }
                            else
                            {
                                dataGridView.DataSource = r.ToList();
                            }
                        }
                    }
                    else if (choose == 1)
                    {
                        var r = (from author in context.Author
                                 select new
                                 {
                                     Family = author.FamilyAuthor,
                                     Name = author.NameAuthor,
                                     Patronymic = author.PatronymicAuthor,
                                     Gender = author.Gender,
                                     YearBirthday = author.DateBirthday
                                 });
                        if (dataGridView.DataSource != null)
                        {
                            if (!string.IsNullOrWhiteSpace(PatronymicToolStripTextBox.Text))
                            {
                                dataGridView.DataSource = r.Where(c => c.Patronymic.Contains(PatronymicToolStripTextBox.Text)).ToList();
                            }
                            else
                            {
                                dataGridView.DataSource = r.ToList();
                            }
                        }
                    }
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SightOfOneCityEntities context = new SightOfOneCityEntities(connectionString))
                {
                    if (choose == 0)
                    {
                        if (dataGridView.SelectedRows.Count != 0)
                        {
                            string s = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                            Edit edit = new Edit((from sight in context.Sight
                                                  where s == sight.NameSight
                                                  select sight).FirstOrDefault(), connectionString);
                            edit.FormClosed += Edit_FormClosed;
                            edit.ShowDialog();
                        }
                    }
                    else if (choose == 1)
                    {
                        if (dataGridView.SelectedRows.Count != 0)
                        {
                            string a = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                            string a1 = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                            string a2 = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                            string a3 = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                            string a4 = dataGridView.SelectedRows[0].Cells[4].Value.ToString();
                            Table table = new Table((from author in context.Author
                                                     where a == author.FamilyAuthor
                                                     && a1 == author.NameAuthor
                                                     && a2 == author.PatronymicAuthor
                                                     && a3 == author.Gender.ToString()
                                                     && a4 == author.DateBirthday.ToString()
                                                     select author).FirstOrDefault(), connectionString);
                            table.FormClosed += Edit_FormClosed;
                            table.ShowDialog();
                            choose = 0;
                        }
                    }
                    else if (choose == 2)
                    {
                        if (dataGridView.SelectedRows.Count != 0)
                        {
                            string ss = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                            Table table = new Table((from status in context.StatusSight
                                                     where ss == status.NameStatus
                                                     select status).FirstOrDefault(), connectionString);
                            table.FormClosed += Edit_FormClosed;
                            table.ShowDialog();
                            choose = 0;
                        }
                    }
                    else if (choose == 3)
                    {
                        if (dataGridView.SelectedRows.Count != 0)
                        {
                            string ts = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                            Table table = new Table((from stop in context.TransportStop
                                                     where ts == stop.NameStop
                                                     select stop).FirstOrDefault(), connectionString);
                            table.FormClosed += Edit_FormClosed;
                            table.ShowDialog();
                            choose = 0;
                        }
                    }
                    else if (choose == 4)
                    {
                        if (dataGridView.SelectedRows.Count != 0)
                        {
                            string c = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                            Table table = new Table((from category in context.Category
                                                     where c == category.NameCategory
                                                     select category).FirstOrDefault(), connectionString);
                            table.FormClosed += Edit_FormClosed;
                            table.ShowDialog();
                            choose = 0;
                        }
                    }
                    else if (choose == 5)
                    {
                        if (dataGridView.SelectedRows.Count != 0)
                        {
                            string kt = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                            Table table = new Table((from kind in context.KindOfTransport
                                                     where kt == kind.NameKind
                                                     select kind).FirstOrDefault(), connectionString);
                            table.FormClosed += Edit_FormClosed;
                            table.ShowDialog();
                            choose = 0;
                        }
                    }
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }



        private void ChangeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authorization form = new Authorization();
            form.Show();
            this.Close();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choose = 0;
            InitDVG();
        }

        private void AuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SightOfOneCityEntities context = new SightOfOneCityEntities(connectionString))
                {
                    choose = 1;
                    dataGridView.DataSource = (from author in context.Author
                                               select new
                                               {
                                                   Family = author.FamilyAuthor,
                                                   Name = author.NameAuthor,
                                                   Patronymic = author.PatronymicAuthor,
                                                   Gender = author.Gender,
                                                   YearBirthday = author.DateBirthday
                                               }).ToList();
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    nameFilter.Visible = false;
                    authorFilter.Visible = true;
                    CategoryFilter.Visible = false;
                    StatusFilter.Visible = false;
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void StatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SightOfOneCityEntities context = new SightOfOneCityEntities(connectionString))
                {
                    choose = 2;
                    dataGridView.DataSource = (from status in context.StatusSight
                                               select new { Name = status.NameStatus }).ToList();
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    nameFilter.Visible = true;
                    authorFilter.Visible = false;
                    CategoryFilter.Visible = false;
                    StatusFilter.Visible = false;
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void StopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SightOfOneCityEntities context = new SightOfOneCityEntities(connectionString))
                {
                    choose = 3;
                    dataGridView.DataSource = (from stop in context.TransportStop
                                               select new { Name = stop.NameStop }).ToList();
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    nameFilter.Visible = true;
                    authorFilter.Visible = false;
                    CategoryFilter.Visible = false;
                    StatusFilter.Visible = false;
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void CategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SightOfOneCityEntities context = new SightOfOneCityEntities(connectionString))
                {
                    choose = 4;
                    dataGridView.DataSource = (from category in context.Category
                                               select new { Name = category.NameCategory }).ToList();
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    nameFilter.Visible = true;
                    authorFilter.Visible = false;
                    CategoryFilter.Visible = false;
                    StatusFilter.Visible = false;
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void KindTrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SightOfOneCityEntities context = new SightOfOneCityEntities(connectionString))
                {
                    choose = 5;
                    dataGridView.DataSource = (from kindtr in context.KindOfTransport
                                               select new { Name = kindtr.NameKind }).ToList();
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    nameFilter.Visible = true;
                    authorFilter.Visible = false;
                    CategoryFilter.Visible = false;
                    StatusFilter.Visible = false;
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                using (SightOfOneCityEntities context = new SightOfOneCityEntities(connectionString))
                {
                    if(choose == 0)
                    {
                        if (e.RowIndex >= 0)
                        {
                            string s = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                            Edit edit = new Edit((from sight in context.Sight
                                                  where s == sight.NameSight
                                                  select sight).FirstOrDefault(), connectionString);
                            edit.FormClosed += Edit_FormClosed;
                            edit.ShowDialog();
                        }
                    }
                    else if (choose == 1)
                    {
                        if (e.RowIndex >= 0)
                        {
                            string a = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                            string a1 = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                            string a2 = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                            string a3 = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                            string a4 = dataGridView.SelectedRows[0].Cells[4].Value.ToString();
                            Table table = new Table((from author in context.Author
                                                     where a == author.FamilyAuthor
                                                     && a1 == author.NameAuthor
                                                     && a2 == author.PatronymicAuthor
                                                     && a3 == author.Gender.ToString()
                                                     && a4 == author.DateBirthday.ToString()
                                                     select author).FirstOrDefault(), connectionString);
                            table.FormClosed += Edit_FormClosed;
                            table.ShowDialog();
                            choose = 0;
                        }
                    }
                    else if (choose == 2)
                    {
                        if (e.RowIndex >= 0)
                        {
                            string ss = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                            Table table = new Table((from status in context.StatusSight
                                                     where ss == status.NameStatus
                                                     select status).FirstOrDefault(), connectionString);
                            table.FormClosed += Edit_FormClosed;
                            table.ShowDialog();
                            choose = 0;
                        }
                    }
                    else if (choose == 3)
                    {
                        if (e.RowIndex >= 0)
                        {
                            string ts = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                            Table table = new Table((from stop in context.TransportStop
                                                     where ts == stop.NameStop
                                                     select stop).FirstOrDefault(), connectionString);
                            table.FormClosed += Edit_FormClosed;
                            table.ShowDialog();
                            choose = 0;
                        }
                    }
                    else if (choose == 4)
                    {
                        if (e.RowIndex >= 0)
                        {
                            string c = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                            Table table = new Table((from category in context.Category
                                                     where c == category.NameCategory
                                                     select category).FirstOrDefault(), connectionString);
                            table.FormClosed += Edit_FormClosed;
                            table.ShowDialog();
                            choose = 0;
                        }
                    }
                    else if (choose == 5)
                    {
                        if (e.RowIndex >= 0)
                        {
                            string kt = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                            Table table = new Table((from kind in context.KindOfTransport
                                                     where kt == kind.NameKind
                                                     select kind).FirstOrDefault(), connectionString);
                            table.FormClosed += Edit_FormClosed;
                            table.ShowDialog();
                            choose = 0;
                        }
                    }
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }
    }
}
