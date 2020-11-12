using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;

namespace Work_SightOfOneCity
{
    public partial class Table : Form
    {
        private byte choose;
        private Author auth;
        private StatusSight stsi;
        private TransportStop trst;
        private Category cat;
        private KindOfTransport kintr;
        private string connectionString;
        public Table()
        {
            try
            {
                InitializeComponent();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        public Table(Author a, string con, bool view = false)
        {
            try
            {
                if (!view)
                {
                    if (a == null)
                    {
                        auth = new Author();
                        choose = 1;
                        connectionString = con;
                        InitializeComponent();
                        this.Text = "Создание";
                        HeaderLabel.Text = "Автор";
                        DeleteButton.Visible = false;
                    }
                    else
                    {
                        auth = a;
                        choose = 1;
                        connectionString = con;
                        InitializeComponent();
                        this.Text = "Изменение";
                        HeaderLabel.Text = "Автор";
                        NameTextBox.Text = a.NameAuthor;
                        PatronymicTextBox.Text = a.PatronymicAuthor;
                        FamilyTextBox.Text = a.FamilyAuthor;
                        YearNumericUpDown.Value = a.DateBirthday;
                        if (a.Gender)
                        {
                            ManCheckBox.Checked = true;
                        }
                    }
                }
                else
                {
                    auth = a;
                    choose = 1;
                    connectionString = con;
                    InitializeComponent();
                    this.Text = "Просмотр";
                    HeaderLabel.Text = "Автор";
                    NameTextBox.Text = a.NameAuthor;
                    NameTextBox.Enabled = false;
                    PatronymicTextBox.Text = a.PatronymicAuthor;
                    PatronymicTextBox.Enabled = false;
                    FamilyTextBox.Text = a.FamilyAuthor;
                    FamilyTextBox.Enabled = false;
                    YearNumericUpDown.Value = a.DateBirthday;
                    YearNumericUpDown.Enabled = false;
                    if (a.Gender)
                    {
                        ManCheckBox.Checked = true;
                    }
                    ManCheckBox.Enabled = false;
                    DeleteButton.Visible = false;
                    CreateEditButton.Visible = false;
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        public Table(StatusSight ss, string con, bool view = false)
        {
            try
            {
                if (!view)
                {
                    if (ss == null)
                    {
                        stsi = new StatusSight();
                        choose = 2;
                        connectionString = con;
                        InitializeComponent();
                        this.Text = "Создание";
                        HeaderLabel.Text = "Статус";
                        DeleteButton.Visible = false;
                        NoVisible();
                    }
                    else
                    {
                        stsi = ss;
                        choose = 2;
                        connectionString = con;
                        InitializeComponent();
                        this.Text = "Изменение";
                        HeaderLabel.Text = "Статус";
                        NameTextBox.Text = ss.NameStatus;
                        NoVisible();
                    }
                }
                else
                {
                    stsi = ss;
                    choose = 2;
                    connectionString = con;
                    InitializeComponent();
                    this.Text = "Просмотр";
                    HeaderLabel.Text = "Статус";
                    NameTextBox.Text = ss.NameStatus;
                    NameTextBox.Enabled = false;
                    DeleteButton.Visible = false;
                    CreateEditButton.Visible = false;
                    NoVisible();
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        public Table(TransportStop ts, string con, bool view = false)
        {
            try
            {
                if (!view)
                {
                    if (ts == null)
                    {
                        trst = new TransportStop();
                        choose = 3;
                        connectionString = con;
                        InitializeComponent();
                        this.Text = "Создание";
                        HeaderLabel.Text = "Остановка";
                        DeleteButton.Visible = false;
                        NoVisible();
                    }
                    else
                    {
                        trst = ts;
                        choose = 3;
                        connectionString = con;
                        InitializeComponent();
                        this.Text = "Изменение";
                        HeaderLabel.Text = "Остановка";
                        NameTextBox.Text = ts.NameStop;
                        NoVisible();
                    }
                }
                else
                {
                    trst = ts;
                    choose = 3;
                    connectionString = con;
                    InitializeComponent();
                    this.Text = "Просмотр";
                    HeaderLabel.Text = "Остановка";
                    NameTextBox.Text = ts.NameStop;
                    NameTextBox.Enabled = false;
                    DeleteButton.Visible = false;
                    CreateEditButton.Visible = false;
                    NoVisible();
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        public Table(Category c, string con, bool view = false)
        {
            try
            {
                if (!view)
                {
                    if (c == null)
                    {
                        cat = new Category();
                        choose = 4;
                        connectionString = con;
                        InitializeComponent();
                        this.Text = "Создание";
                        HeaderLabel.Text = "Категория";
                        DeleteButton.Visible = false;
                        NoVisible();
                    }
                    else
                    {
                        cat = c;
                        choose = 4;
                        connectionString = con;
                        InitializeComponent();
                        this.Text = "Изменение";
                        HeaderLabel.Text = "Категория";
                        NameTextBox.Text = c.NameCategory;
                        NoVisible();
                    }
                }
                else
                {
                    cat = c;
                    choose = 4;
                    connectionString = con;
                    InitializeComponent();
                    this.Text = "Просмотр";
                    HeaderLabel.Text = "Категория";
                    NameTextBox.Text = c.NameCategory;
                    NameTextBox.Enabled = false;
                    DeleteButton.Visible = false;
                    CreateEditButton.Visible = false;
                    NoVisible();
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        public Table(KindOfTransport kt, string con, bool view = false)
        {
            try
            {
                if (!view)
                {
                    if (kt == null)
                    {
                        kintr = new KindOfTransport();
                        choose = 5;
                        connectionString = con;
                        InitializeComponent();
                        this.Text = "Создание";
                        HeaderLabel.Text = "Вид транспорта";
                        DeleteButton.Visible = false;
                        NoVisible();
                    }
                    else
                    {
                        kintr = kt;
                        choose = 5;
                        connectionString = con;
                        InitializeComponent();
                        this.Text = "Изменение";
                        HeaderLabel.Text = "Вид транспорта";
                        NameTextBox.Text = kt.NameKind;
                        NoVisible();
                    }
                }
                else
                {
                    kintr = kt;
                    choose = 5;
                    connectionString = con;
                    InitializeComponent();
                    this.Text = "Просмотр";
                    HeaderLabel.Text = "Вид транспорта";
                    NameTextBox.Text = kt.NameKind;
                    NameTextBox.Enabled = false;
                    DeleteButton.Visible = false;
                    CreateEditButton.Visible = false;
                    NoVisible();
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void NoVisible()
        {
            PatronymicLabel.Visible = false;
            PatronymicTextBox.Visible = false;
            FamilyLabel.Visible = false;
            FamilyTextBox.Visible = false;
            YearLabel.Visible = false;
            YearNumericUpDown.Visible = false;
            ManCheckBox.Visible = false;
        }

        private bool ChekField()
        {
            if (choose == 1)
            {
                if ((!string.IsNullOrEmpty(NameTextBox.Text)) && (!string.IsNullOrEmpty(FamilyTextBox.Text))
                    && (YearNumericUpDown.Value != 0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(NameTextBox.Text))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void CreateEditButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SightOfOneCityEntities context = new SightOfOneCityEntities(connectionString))
                {
                    if (ChekField())
                    {
                        if (this.Text == "Изменение")
                        {
                            if (choose == 1)
                            {
                                Author a = context.Author.Find(auth.ID);
                                a.FamilyAuthor = FamilyTextBox.Text;
                                a.NameAuthor = NameTextBox.Text;
                                a.PatronymicAuthor = PatronymicTextBox.Text;
                                if (ManCheckBox.Checked)
                                {
                                    a.Gender = true;
                                }
                                else
                                {
                                    a.Gender = false;
                                }
                                a.DateBirthday = (short)YearNumericUpDown.Value;
                                context.SaveChanges();
                                this.Close();
                            }
                            if (choose == 2)
                            {
                                StatusSight ss = context.StatusSight.Find(stsi.ID);
                                ss.NameStatus = NameTextBox.Text;
                                context.SaveChanges();
                                this.Close();
                            }
                            if (choose == 3)
                            {
                                TransportStop ts = context.TransportStop.Find(trst.ID);
                                ts.NameStop = NameTextBox.Text;
                                context.SaveChanges();
                                this.Close();
                            }
                            if (choose == 4)
                            {
                                Category c = context.Category.Find(cat.ID);
                                c.NameCategory = NameTextBox.Text;
                                context.SaveChanges();
                                this.Close();
                            }
                            if (choose == 5)
                            {
                                KindOfTransport kt = context.KindOfTransport.Find(kintr.ID);
                                kt.NameKind = NameTextBox.Text;
                                context.SaveChanges();
                                this.Close();
                            }
                        }
                        else
                        {
                            if (choose == 1)
                            {
                                context.Author.Add(new Author(auth.FamilyAuthor, auth.NameAuthor,
                                    auth.PatronymicAuthor, auth.Gender, auth.DateBirthday));
                                context.SaveChanges();
                                this.Close();
                            }
                            if (choose == 2)
                            {
                                context.StatusSight.Add(new StatusSight(stsi.NameStatus));
                                context.SaveChanges();
                                this.Close();
                            }
                            if (choose == 3)
                            {
                                context.TransportStop.Add(new TransportStop(trst.NameStop));
                                context.SaveChanges();
                                this.Close();
                            }
                            if (choose == 4)
                            {
                                context.Category.Add(new Category(cat.NameCategory));
                                context.SaveChanges();
                                this.Close();
                            }
                            if (choose == 5)
                            {
                                context.KindOfTransport.Add(new KindOfTransport(kintr.NameKind));
                                context.SaveChanges();
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Не все обязательные поля заполнены. Проверьте данные.", "Внимание");
                    }
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Text != "Просмотр")
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
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SightOfOneCityEntities context = new SightOfOneCityEntities(connectionString))
                {
                    if (choose == 1)
                    {
                        DialogResult result = MessageBox.Show("Вы действительно хотите удалить автора? Отменить действие будет невозможно.", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            context.Author.Remove((from author in context.Author
                                                   where author.ID == auth.ID
                                                   select author).FirstOrDefault());
                            context.SaveChanges();
                            this.Close();
                        }
                        else if (result == DialogResult.No)
                        {
                            return;
                        }
                    }
                    if (choose == 2)
                    {
                        DialogResult result = MessageBox.Show("Вы действительно хотите удалить статус? Отменить действие будет невозможно.", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            context.StatusSight.Remove((from status in context.StatusSight
                                                                                where status.ID == stsi.ID
                                                                                select status).FirstOrDefault());
                            context.SaveChanges();
                            this.Close();
                        }
                        else if (result == DialogResult.No)
                        {
                            return;
                        }
                    }
                    if (choose == 3)
                    {
                        DialogResult result = MessageBox.Show("Вы действительно хотите удалить остановку? Отменить действие будет невозможно.", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            context.TransportStop.Remove((from stop in context.TransportStop
                                                          where stop.ID == trst.ID
                                                          select stop).FirstOrDefault());
                            context.SaveChanges();
                            this.Close();
                        }
                        else if (result == DialogResult.No)
                        {
                            return;
                        }
                    }
                    if (choose == 4)
                    {
                        DialogResult result = MessageBox.Show("Вы действительно хотите удалить категорию? Отменить действие будет невозможно.", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            context.Category.Remove((from category in context.Category
                                                     where category.ID == cat.ID
                                                     select category).FirstOrDefault());
                            context.SaveChanges();
                            this.Close();
                        }
                        else if (result == DialogResult.No)
                        {
                            return;
                        }
                    }
                    if (choose == 5)
                    {
                        DialogResult result = MessageBox.Show("Вы действительно хотите удалить вид транспорта? Отменить действие будет невозможно.", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            context.KindOfTransport.Remove((from kindtransport in context.KindOfTransport
                                                            where kindtransport.ID == kintr.ID
                                                            select kindtransport).FirstOrDefault());
                            context.SaveChanges();
                            this.Close();
                        }
                        else if (result == DialogResult.No)
                        {
                            return;
                        }
                    }
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        

        private void PatronymicTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                auth.PatronymicAuthor = PatronymicTextBox.Text;
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void FamilyTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                auth.FamilyAuthor = FamilyTextBox.Text;
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
                auth.DateBirthday = (short)YearNumericUpDown.Value;
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void ManCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                auth.Gender = ManCheckBox.Checked;
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
                if (choose == 1)
                {
                    auth.NameAuthor = NameTextBox.Text;
                }
                if (choose == 2)
                {
                    stsi.NameStatus = NameTextBox.Text;
                }
                if (choose == 3)
                {
                    trst.NameStop = NameTextBox.Text;
                }
                if (choose == 4)
                {
                    cat.NameCategory = NameTextBox.Text;
                }
                if (choose == 5)
                {
                    kintr.NameKind = NameTextBox.Text;
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(text: "У вас нет прав на это действие.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }
    }
}
