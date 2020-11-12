using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;

namespace Work_SightOfOneCity
{
    public partial class Edit : Form
    {
        private string connectionString;
        private Sight sight;
        public Edit(Sight sight, string con, bool view = false)
        {
            try
            {
                connectionString = con;
                if (sight != null)
                {
                    if (!view)
                    {
                        this.sight = sight;
                        InitializeComponent();
                        InitForm(sight);
                        AuthorComboBox.Visible = true;
                    }
                    else
                    {
                        this.sight = sight;
                        InitializeComponent();
                        InitForm(sight);
                        NoVisible();
                        SaveButton.Visible = false;
                        DelAuthButton.Enabled = false;
                        AuthorComboBox.Enabled = false;
                        DelButton.Visible = false;
                        AuthorDGV.Visible = false;
                        AuthorLabel1.Visible = false;
                        this.Text = "Просмотр";
                    }
                }
                else
                {
                    this.sight = new Sight();
                    InitializeComponent();
                    InitForm();
                    SaveButton.Text = "Создать";
                    this.Text = "Создание";
                    DelButton.Visible = false;
                    AuthorComboBox.Visible = true;
                    DelAuthButton.Visible = false;
                    AuthorDataGridView.Visible = false;
                    AuthorLabel.Visible = false;
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void NoVisible()
        {
            AddPictureButton.Visible = false;
            NameTextBox.Enabled = false;
            DiscriptionTextBox.Enabled = false;
            AuthorDataGridView.Enabled = false;
            AddressTextBox.Enabled = false;
            YearNumericUpDown.Enabled = false;
            StopComboBox.Enabled = false;
            StatusComboBox.Enabled = false;
            CategoryComboBox.Enabled = false;
        }

        private  void InitForm(Sight sight)
        {
            try
            {
                using (SightOfOneCityEntities context = new SightOfOneCityEntities(connectionString))
                {
                    NameTextBox.Text = sight.NameSight;
                    DiscriptionTextBox.Text = sight.DescriptionSight;
                    AddressTextBox.Text = sight.AddresSights;
                    YearNumericUpDown.Value = (from sig in context.Sight
                                               join aos in context.AuthorOfSight on sig.ID equals aos.SightID
                                               where sig.ID == sight.ID
                                               select aos.DateCreate).FirstOrDefault();
                    YearNumericUpDown.ValueChanged += YearNumericUpDown_ValueChanged;
                    if (File.Exists(sight.Photo.Trim()))
                    {
                        Image imgsight = Image.FromFile(sight.Photo.Trim());
                        PictureBox.Image = imgsight;
                        PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        Image imgsight = Image.FromFile("unnamed.png");
                        PictureBox.Image = imgsight;
                        PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    AddPictureButton.Text = "Изменить изображение";
                    this.Text = "Изменение";
                    StatusComboBox.DataSource = (from status in context.StatusSight
                                                 select status.NameStatus).ToList();
                    StatusComboBox.TextChanged += StatusComboBox_TextChanged;
                    StatusComboBox.Text = (from status in context.StatusSight
                                           where status.ID == sight.StatusID
                                           select status.NameStatus).FirstOrDefault().ToString();
                    StopComboBox.DataSource = (from stop in context.TransportStop
                                               select stop.NameStop).ToList();
                    StopComboBox.TextChanged += StopComboBox_TextChanged;
                    StopComboBox.Text = (from sig in context.Sight
                                         join stop in context.TransportStop on sig.StopID equals stop.ID
                                         where sig.ID == sight.ID
                                         select stop.NameStop).Single();
                    CategoryComboBox.DataSource = (from category in context.Category
                                                   select category.NameCategory).ToList();
                    CategoryComboBox.TextChanged += CategoryComboBox_TextChanged;
                    CategoryComboBox.Text = (from sig in context.Sight
                                             join category in context.Category on sig.CategoryID equals category.ID
                                             where sig.ID == sight.ID
                                             select category.NameCategory).Single();
                    if (this.Text == "Изменение")
                    {
                        AuthorComboBox.DataSource = (from author in context.Author
                                                     select author.FamilyAuthor + " " + author.NameAuthor + " " + author.PatronymicAuthor).ToList();
                        AuthorComboBox.SelectedItem = null;
                        AuthorComboBox.TextChanged += AuthorComboBox_TextChanged;
                    }
                    InitDGV();
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void InitForm()
        {
            try
            {
                using (SightOfOneCityEntities context = new SightOfOneCityEntities(connectionString))
                {
                    YearNumericUpDown.ValueChanged += YearNumericUpDown_ValueChanged;
                    Image imgsight = Image.FromFile("unnamed.png");
                    PictureBox.Image = imgsight;
                    PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    StatusComboBox.DataSource = (from status in context.StatusSight
                                                 select status.NameStatus).ToList();
                    StatusComboBox.SelectedItem = null;
                    StatusComboBox.TextChanged += StatusComboBox_TextChanged;
                    StopComboBox.DataSource = (from stop in context.TransportStop
                                               select stop.NameStop).ToList();
                    StopComboBox.SelectedItem = null;
                    StopComboBox.TextChanged += StopComboBox_TextChanged;
                    CategoryComboBox.DataSource = (from category in context.Category
                                                   select category.NameCategory).ToList();
                    CategoryComboBox.SelectedItem = null;
                    CategoryComboBox.TextChanged += CategoryComboBox_TextChanged;
                    AuthorComboBox.DataSource = (from author in context.Author
                                                 select author.FamilyAuthor + " " + author.NameAuthor + " " + author.PatronymicAuthor).ToList();
                    AuthorComboBox.SelectedItem = null;
                    AuthorComboBox.TextChanged += AuthorComboBox_TextChanged;
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void InitDGV()
        {
            try
            {
                using (SightOfOneCityEntities context = new SightOfOneCityEntities(connectionString))
                {
                    AuthorDataGridView.DataSource = (from sig in context.Sight
                                                     join aos in context.AuthorOfSight on sig.ID equals aos.SightID
                                                     join author in context.Author on aos.AuthorID equals author.ID
                                                     where sig.ID == sight.ID
                                                     select new
                                                     {
                                                         Family = author.FamilyAuthor,
                                                         Name = author.NameAuthor,
                                                         Patronymic = author.PatronymicAuthor
                                                     }).ToList();
                    AuthorDataGridView.Columns[0].Width = 100;
                    AuthorDataGridView.Columns[0].HeaderText = "Фамилия";
                    AuthorDataGridView.Columns[1].Width = 100;
                    AuthorDataGridView.Columns[1].HeaderText = "Имя";
                    AuthorDataGridView.Columns[2].Width = 100;
                    AuthorDataGridView.Columns[2].HeaderText = "Отчество";
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private bool CheckFied()
        {
            if (this.Text == "Изменение")
            {
                if ((!string.IsNullOrEmpty(sight.NameSight))&& (!string.IsNullOrEmpty(sight.DescriptionSight))
                    && (!string.IsNullOrEmpty(sight.AddresSights)) && ((AuthorDataGridView.RowCount + AuthorDGV.RowCount) > 0) 
                    && (YearNumericUpDown.Value != 0) && (!string.IsNullOrEmpty(sight.Photo)))
                {
                    SaveButton.Visible = true;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if ((!string.IsNullOrEmpty(NameTextBox.Text))
                && (AuthorDGV.RowCount > 0) && (!string.IsNullOrEmpty(AddressTextBox.Text))
                && (!string.IsNullOrEmpty(DiscriptionTextBox.Text)) && (!string.IsNullOrEmpty(StatusComboBox.Text))
                && (!string.IsNullOrEmpty(StopComboBox.Text)) && (YearNumericUpDown.Value != 0))
                {
                    SaveButton.Visible = true;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить достопримечательность? Отменить это дейсвие будет невозможно.", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (result == DialogResult.Yes)
                {
                    using (SightOfOneCityEntities context = new SightOfOneCityEntities(connectionString))
                    {
                        context.Sight.Remove((from sig in context.Sight
                                              where sig.ID == sight.ID
                                              select sig).FirstOrDefault());
                            context.SaveChanges();
                    }
                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckFied())
                {
                    using (SightOfOneCityEntities context = new SightOfOneCityEntities(connectionString))
                    {
                        if (this.Text == "Изменение")
                        {
                            Sight s = context.Sight.Find((from sig in context.Sight
                                                          where sig.ID == sight.ID
                                                          select sig.ID).Single());
                            s.NameSight = sight.NameSight;
                            s.DescriptionSight = sight.DescriptionSight;
                            s.AddresSights = sight.AddresSights;
                            s.Photo = sight.Photo;
                            s.StopID = sight.StopID;
                            s.StatusID = sight.StatusID;
                            s.CategoryID = sight.CategoryID;
                            for (int i = 0; i < AuthorDGV.Rows.Count; i++)
                            {
                                string namea = AuthorDGV.Rows[i].Cells[1].Value.ToString();
                                string familya = AuthorDGV.Rows[i].Cells[0].Value.ToString();
                                string patrona = AuthorDGV.Rows[i].Cells[2].Value.ToString();
                                context.AuthorOfSight.Add(new AuthorOfSight(sight.ID, (from author in context.Author
                                                                                       where author.NameAuthor == namea
                                                                                       && author.FamilyAuthor == familya
                                                                                       && author.PatronymicAuthor == patrona
                                                                                       select author.ID).FirstOrDefault(),
                                                                            (short)YearNumericUpDown.Value));
                            }
                                context.SaveChanges();
                        }
                        else
                        {
                            context.Sight.Add(new Sight(sight.NameSight, sight.DescriptionSight,
                            sight.Photo, sight.AddresSights, sight.StopID, sight.StatusID,
                            sight.CategoryID));
                            for (int i = 0; i < AuthorDGV.Rows.Count; i++)
                            {
                                string namea = AuthorDGV.Rows[i].Cells[1].Value.ToString();
                                string familya = AuthorDGV.Rows[i].Cells[0].Value.ToString();
                                string patrona = AuthorDGV.Rows[i].Cells[2].Value.ToString();
                                context.AuthorOfSight.Add(new AuthorOfSight((from sig in context.Sight
                                                                             where sig.NameSight == NameTextBox.Text
                                                                             select sig.ID).FirstOrDefault(),
                                                                            (from author in context.Author
                                                                             where author.NameAuthor == namea
                                                                             && author.FamilyAuthor == familya
                                                                             && author.PatronymicAuthor == patrona
                                                                             select author.ID).FirstOrDefault(),
                                                                            (short)YearNumericUpDown.Value));
                            }
                            context.SaveChanges();
                        }
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Не все обязательные поля заполнены. Проверьте данные.", "Внимание");
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if(this.Text != "Просмотр" )
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите покинуть страницу? Внесенные изменения не будут сохранены.", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                this.Close();
            }
        }

        private void AddPictureButton_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.Filter = "Файлы изображений|*.png;*.jpg;*jpeg";
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                if (File.Exists(openFileDialog.FileName))
                {
                    Image imgsight = Image.FromFile(openFileDialog.FileName);
                    PictureBox.Image = imgsight;
                    PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    Image imgsight = Image.FromFile("unnamed.png");
                    PictureBox.Image = imgsight;
                    PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                sight.Photo = openFileDialog.FileName;
                AddPictureButton.Text = "Изменить изображение";
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sight.NameSight = NameTextBox.Text;
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void DiscriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sight.DescriptionSight = DiscriptionTextBox.Text;
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sight.AddresSights = AddressTextBox.Text;
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void StopComboBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SightOfOneCityEntities context = new SightOfOneCityEntities(connectionString))
                {
                    sight.StopID = (from stop in context.TransportStop
                                    where stop.NameStop == StopComboBox.Text
                                    select stop.ID).FirstOrDefault();
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void StatusComboBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SightOfOneCityEntities context = new SightOfOneCityEntities(connectionString))
                {
                    sight.StatusID = (from status in context.StatusSight
                                      where status.NameStatus == StatusComboBox.Text
                                      select status.ID).FirstOrDefault();
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void CategoryComboBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SightOfOneCityEntities context = new SightOfOneCityEntities(connectionString))
                {
                    sight.CategoryID = (from category in context.Category
                                        where category.NameCategory == CategoryComboBox.Text
                                        select category.ID).FirstOrDefault();
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void AuthorComboBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SightOfOneCityEntities context = new SightOfOneCityEntities(connectionString))
                {
                    if (AuthorComboBox.SelectedItem != null)
                    {
                        string[] parse = AuthorComboBox.Text.Split(' ');
                        AuthorDGV.Rows.Add();
                        for (int i = 0; i < AuthorDGV.Columns.Count; i++)
                        {
                            AuthorDGV.Rows[AuthorDGV.Rows.Count - 1].Cells[i].Value = parse[i];
                        }
                    }
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void YearNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                using (SightOfOneCityEntities context = new SightOfOneCityEntities(connectionString))
                {
                    List<AuthorOfSight> authorOfSights = (from aos in context.AuthorOfSight
                                                          where sight.ID == aos.SightID
                                                          select aos).ToList<AuthorOfSight>();
                    foreach (AuthorOfSight item in authorOfSights)
                    {
                        item.DateCreate = (short)YearNumericUpDown.Value;
                    }
                        context.SaveChanges();
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "ERror", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void DelAuthButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить автора? Отменить действие будет невозможно.", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (result == DialogResult.Yes)
                {
                    if (AuthorDataGridView.SelectedRows.Count != 0)
                    {
                        using (SightOfOneCityEntities context = new SightOfOneCityEntities(connectionString))
                        {
                            string s = AuthorDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                            string s1 = AuthorDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                            string s2 = AuthorDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                            context.AuthorOfSight.Remove((from aos in context.AuthorOfSight
                                                          join author in context.Author on aos.AuthorID equals author.ID
                                                          where aos.SightID == sight.ID && author.FamilyAuthor == s
                                                          && author.NameAuthor == s1 && author.PatronymicAuthor == s2
                                                          select aos).FirstOrDefault());

                                context.SaveChanges();
                        }
                        InitDGV();
                    }
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }
    }
}
