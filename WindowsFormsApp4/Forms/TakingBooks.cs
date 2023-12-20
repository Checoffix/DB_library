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
    public partial class TakingBooks : Form
    {
        private static List<int> libraryCollection = new List<int>();
        public TakingBooks()
        {
            InitializeComponent();
            GetIds();
        }

        private void GetIds()
        {
            DBConnection.msCommand.CommandText = @"SELECT reader FROM journal";
            using (MySqlDataReader reader = DBConnection.msCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDReadersCombo.Items.Add(reader.GetInt32(0));
                }
            }
        }

        private void IDReadersCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBConnection.msCommand.CommandText = @"SELECT library_collection FROM journal WHERE reader = " + Convert.ToInt32(IDReadersCombo.SelectedItem.ToString());
            using (MySqlDataReader reader = DBConnection.msCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    libraryCollection.Add(reader.GetInt32(0));
                }
            }
            for(int i = 0; i < libraryCollection.Count; i++)
            {
                DBConnection.msCommand.CommandText = @"SELECT edition FROM library_collection";
                using (MySqlDataReader reader = DBConnection.msCommand.ExecuteReader())
                {
                    reader.Read();
                    EditionCombo.Items.Add(reader.GetInt32(0));
                }
            }
        }

        private void TakeButt_Click(object sender, EventArgs e)
        {
            int copy = Convert.ToInt32(CountText.Text.ToString());
            if (CountText.Text.ToString() != "" && copy > 0)
            {
                DBConnection.msCommand.CommandText = @"DELETE FROM journal WHERE library_collection = " + libraryCollection[EditionCombo.SelectedIndex];
                DBConnection.msCommand.ExecuteScalar();
                DBConnection.msCommand.CommandText = @"UPDATE library_collection SET copy_count = copy_count + " + copy + " WHERE id_library_collection = " + libraryCollection[EditionCombo.SelectedIndex] + " AND edition = " + Convert.ToInt32(EditionCombo.SelectedItem.ToString());
                DBConnection.msCommand.ExecuteScalar();
            }
        }
    }
}
