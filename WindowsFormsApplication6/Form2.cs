﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.ActiveForm.Hide();
            e.Cancel = true;
        }
    }
}
