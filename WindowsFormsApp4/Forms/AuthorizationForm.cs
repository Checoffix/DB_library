using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class AuthorizationForm : Form
    {
        public static string loginActive;
        public static string status;

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DBConnection.ConnectionDB();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(loginBox.Text!= "" && passwordBox.Text!= "")
            {
                Authorization.AccountAuthorization(loginBox.Text, passwordBox.Text);
                switch (Authorization.role)
                {
                    case null:
                        {
                            MessageBox.Show("Такого аккаунта не существует!", "Проверьте данные и попрообуйте снова", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                    case "Администратор":
                        {
                            loginActive = loginBox.Text;
                            status = "Администратор";
                            Authorization.user = loginBox.Text;

                            string surname = Authorization.AuthorizationName(loginBox.Text);
                            Authorization.surname = surname;
                            MessageBox.Show(surname + ", добро пожаловать в меню администратора!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            AdminForm admin = new AdminForm();
                            admin.Show();
                            break;
                        }
                    case "Пользователь":
                        {
                            loginActive = loginBox.Text;
                            status = "Пользователь";
                            Authorization.user = loginBox.Text;

                            string surname = Authorization.AuthorizationName(loginBox.Text);
                            Authorization.surname = surname;
                            MessageBox.Show(surname + ", добро пожаловать в меню пользователя!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            UserForm user = new UserForm();
                            user.Show();
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Заполните поля!", "Пустые поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
