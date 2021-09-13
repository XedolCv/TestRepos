using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneForms.Forms
{
    public partial class PrihodForm : Form
    {
        public string operator_name;
        public PrihodForm()
        {
            InitializeComponent();
        }
        public PrihodForm(string a)
        {
            operator_name = a;
            InitializeComponent();
            comingTableAdapter1.Fill(this.phonesDataSet1.Coming);
            textBox2.Text = operator_name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && comboBox1.Text != "")
                {
                    comingTableAdapter1.Insert(DateTime.Parse(dateTimePicker1.Text), textBox1.Text, textBox2.Text, comboBox1.Text, Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text));

                }
                else
                {
                    MessageBox.Show("Одно из полей не заполнено");
                }
            comingTableAdapter1.Fill(this.phonesDataSet1.Coming);
        }
        private void PrihodForm_Load(object sender, EventArgs e)
        {

        }
    }
 }
