using System;
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
    public partial class MainForm : Form
    {
        public string op_name;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Добро пожаловать, " + op_name + "!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrihodForm prih = new PrihodForm(op_name);
            prih.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Spisanie spis = new Spisanie();
            spis.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SpisokForm form = new SpisokForm();
            form.Show();
        }
    }
}
