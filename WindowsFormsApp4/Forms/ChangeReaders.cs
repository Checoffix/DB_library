﻿using System;
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
    public partial class ChangeReaders : Form
    {
        public ChangeReaders()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddReader nextForm = new AddReader();
            nextForm.Show();
        }

        private void DeleteButt_Click(object sender, EventArgs e)
        {
            DeleteReader nextForm = new DeleteReader();
            nextForm.Show();
        }
    }
}
