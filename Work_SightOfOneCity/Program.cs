using System;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;

namespace Work_SightOfOneCity
{
    static class Program
    {
        private const string Caption = "ERROR";

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MyApplicationContext(() => new Authorization()));
            }
            catch(Exception)
            {
                MessageBox.Show(text: "Произошла ошибка.", caption: Caption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }
        public class MyApplicationContext : ApplicationContext
        {
            public MyApplicationContext(Func<Form> formFactory)
            {
                Form startupForm = formFactory();
                startupForm.FormClosed += OnFormClosed;
                startupForm.Show();
            }

            private void OnFormClosed(object sender, FormClosedEventArgs e)
            {
                if (Application.OpenForms.Count > 0)
                {
                    foreach (Form form in Application.OpenForms)
                    {
                        form.FormClosed -= OnFormClosed;
                        form.FormClosed += OnFormClosed;
                    }
                }
                else ExitThread();
            }
        }
    }
}
