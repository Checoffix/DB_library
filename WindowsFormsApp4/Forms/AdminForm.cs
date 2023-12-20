using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Forms;

namespace WindowsFormsApp4
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            DBConnection.ConnectionDB();
        }

        private void WorkWithReaders_Click(object sender, EventArgs e)
        {
            ChangeReaders nextForm = new ChangeReaders();
            nextForm.Show();
        }

        private void GiveBook_Click(object sender, EventArgs e)
        {
            GivingBooks nextForm = new GivingBooks();
            nextForm.Show();
        }

        private void TakeBook_Click(object sender, EventArgs e)
        {
            TakingBooks nextForm = new TakingBooks();
            nextForm.Show();
        }
    }
}
