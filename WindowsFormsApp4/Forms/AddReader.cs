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
    public partial class AddReader : Form
    {
        public AddReader()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            int Course = Convert.ToInt32(CourseCombo.SelectedItem.ToString());
            int ProfessorRole = Convert.ToInt32(ProfessorRoleCombo.SelectedItem.ToString());
            int PersonId;
            string Surname = SurnameText.Text;
            string Name = NameText.Text;
            string Patronymic = PatronymicText.Text;

            DBConnection.msCommand.CommandText = @"INSERT INTO person (surname, name, patronymic) VALUES ('" + Surname + "', '" + Name + "', '" + Patronymic + "')";
            DBConnection.msCommand.ExecuteScalar();
            DBConnection.msCommand.CommandText = @"SELECT COUNT(id_person) FROM person";
            using (MySqlDataReader reader = DBConnection.msCommand.ExecuteReader())
            {
                reader.Read();
                PersonId = reader.GetInt32(0);
            }
            DBConnection.msCommand.CommandText = @"INSERT INTO student (id_person) VALUES (" + PersonId + ")";
            DBConnection.msCommand.ExecuteScalar();
            
            DBConnection.msCommand.CommandText = @"INSERT INTO professor (department, post, id_person) VALUES (1, 1, " + PersonId + ")";
            DBConnection.msCommand.ExecuteScalar();

            DBConnection.msCommand.CommandText = @"INSERT INTO readers (id_person, Student_role, Professor_role) VALUES (" + PersonId + ", 1, 1)";
            DBConnection.msCommand.ExecuteScalar();
        }
    }
}
