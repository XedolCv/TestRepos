﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneForms.Forms
{
    public partial class SpisokForm : Form
    {
        public SpisokForm()
        {
            InitializeComponent();
        }

        private void SpisokForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "phonesDataSet.Spisanie". При необходимости она может быть перемещена или удалена.
            this.spisanieTableAdapter.Fill(this.phonesDataSet.Spisanie);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
