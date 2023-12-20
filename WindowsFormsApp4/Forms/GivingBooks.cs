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
    public partial class GivingBooks : Form
    {
        public GivingBooks()
        {
            InitializeComponent();
            GetIds();
        }
        private void GetIds()
        {
            DBConnection.msCommand.CommandText = @"SELECT id_reader FROM readers";
            using (MySqlDataReader reader = DBConnection.msCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDReadersCombo.Items.Add(reader.GetInt32(0));
                }
            }
        }

        private void IDReaderCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBConnection.msCommand.CommandText = @"SELECT edition FROM library_collection";
            using (MySqlDataReader reader = DBConnection.msCommand.ExecuteReader())
            {
                reader.Read();
                EditionCombo.Items.Add(reader.GetInt32(0));
            }
        }

        private void GiveButt_Click(object sender, EventArgs e)
        {
            DBConnection.msCommand.CommandText = @"SELECT copy_count FROM library_collection WHERE id_library_collection = " + Convert.ToInt32(EditionCombo.SelectedItem.ToString()) + " AND edition = " + Convert.ToInt32(EditionCombo.SelectedItem.ToString());
            int count;
            int copy = Convert.ToInt32(CountText.Text.ToString());
            using (MySqlDataReader reader = DBConnection.msCommand.ExecuteReader())
            {
                reader.Read();
                count = Convert.ToInt32(reader.GetInt32(0));
            }
            if (CountText.Text.ToString() != "" && copy <= count && copy > 0)
            {
                DBConnection.msCommand.CommandText = @"UPDATE library_collection SET copy_count = copy_count - " + copy + " WHERE id_library_collection = " + Convert.ToInt32(EditionCombo.SelectedItem.ToString()) + " AND edition = " + Convert.ToInt32(EditionCombo.SelectedItem.ToString());
                DBConnection.msCommand.ExecuteScalar();
                DBConnection.msCommand.CommandText = @"INSERT INTO journal (library_collection, reader) VALUES (" + Convert.ToInt32(EditionCombo.SelectedItem.ToString()) +  ", " + Convert.ToInt32(IDReadersCombo.SelectedItem.ToString()) + ")";
                DBConnection.msCommand.ExecuteScalar();
            }
        }
    }
}
