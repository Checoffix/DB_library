using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4.Forms
{
    public partial class DeleteReader : Form
    {
        public DeleteReader()
        {
            InitializeComponent();
            GetAllIds();
        }
        private void GetAllIds()
        {
            DBConnection.msCommand.CommandText = @"SELECT id_person FROM readers";
            using (MySqlDataReader reader = DBConnection.msCommand.ExecuteReader())
            {
                List<int> idList = new List<int>();

                while (reader.Read())
                {
                    IdBox.Items.Add(reader.GetInt32(0));
                }
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DBConnection.msCommand.CommandText = @"DELETE FROM student WHERE id_person = " + IdBox.SelectedItem.ToString();
            DBConnection.msCommand.ExecuteScalar();
            DBConnection.msCommand.CommandText = @"DELETE FROM professor WHERE id_person = " + IdBox.SelectedItem.ToString();
            DBConnection.msCommand.ExecuteScalar();
            DBConnection.msCommand.CommandText = @"DELETE FROM readers WHERE id_person = " + IdBox.SelectedItem.ToString();
            DBConnection.msCommand.ExecuteScalar();
            DBConnection.msCommand.CommandText = @"DELETE FROM person WHERE id_person = " + IdBox.SelectedItem.ToString();
            DBConnection.msCommand.ExecuteScalar();
            IdBox.Items.RemoveAt(IdBox.SelectedIndex);
            SurnameText.Text = "";
            NameText.Text = "";
            PatronymicText.Text = "";
        }

        private void IdBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBConnection.msCommand.CommandText = @"SELECT surname, name, patronymic FROM person WHERE person.id_person = " + IdBox.SelectedItem.ToString();
            using (MySqlDataReader result = DBConnection.msCommand.ExecuteReader())
            {

                result.Read();
                string Surname, Name, Patronymic;
                if (result != null)
                {
                    Surname = result.GetString(0);
                    Name = result.GetString(1);
                    Patronymic = result.GetString(2);
                }
                else
                {
                    Surname = "";
                    Name = "";
                    Patronymic = "";
                }
                SurnameText.Text = Surname;
                NameText.Text = Name;
                PatronymicText.Text = Patronymic;
            }
        }
    }
}
