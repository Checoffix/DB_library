using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public class Authorization
    {
        static public string role, surname, user;

        static public void AccountAuthorization(string login, string password)
        {
            try
            {
                DBConnection.msCommand.CommandText = @"SELECT Name_role FROM sp_role, account WHERE Login = '" + login + "'and Password = '" + password + "' and account.id_role=sp_role.id_role ";
                Object result = DBConnection.msCommand.ExecuteScalar();
                if (result != null)
                {
                    role = result.ToString();
                    user = login;
                }
                else
                {
                    role = null;
                    surname = null;
                }
            }
            catch
            {
                role = user = null;
                MessageBox.Show("Ошибка при авторизации!", "Ошибка!");
            }
        }

        static public string AuthorizationName(string login)
        {
            try
            {
                DBConnection.msCommand.CommandText = @"SELECT Name FROM account WHERE Login = '" + login + "' ";
                Object result = DBConnection.msCommand.ExecuteScalar();
                surname =result.ToString();
                return surname;
            }
            catch
            {
                return null;
            }
        }    
    }
}
