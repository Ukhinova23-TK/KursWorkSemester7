using System;
using System.Windows.Forms;

namespace Work_SightOfOneCity
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            try
            {
                string conn = $"metadata=res://*/Model.csdl|res://*/Model.ssdl|res://*/Model.msl;provider=System.Data.SqlClient;provider connection string=\"data source={ServerTextBox.Text};initial catalog={DBTextBox.Text};integrated security=False;user ID={LoginTextBox.Text};password={PasswordTextBox.Text};MultipleActiveResultSets=False;App=EntityFramework\"";
                Main mainform = new Main(conn);
                mainform.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка соединения");
            }
        }
    }
}
