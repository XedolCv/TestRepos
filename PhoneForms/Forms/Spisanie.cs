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
    public partial class Spisanie : Form
    {
        public Spisanie()
        {
            InitializeComponent();
            spisanieTableAdapter.Fill(this.phonesDataSet.Spisanie);
        }

        private void Spisanie_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "phonesDataSet.Spisanie". При необходимости она может быть перемещена или удалена.
            this.spisanieTableAdapter.Fill(this.phonesDataSet.Spisanie);
            int count = comingTableAdapter1.GetData().Select().Count();
            DataRow[] dr = new DataRow[count];
            dr = comingTableAdapter1.GetData().Select();
            List<String> phones = new List<string>();
            for (int i = 0; i < count; i++)
            {
                phones.Add(dr[i].Field<string>("Phone_Model"));
                comboBox1.Items.Add(phones[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && comboBox1.Text != "")
            {
                spisanieTableAdapter.Insert(comboBox1.Text,textBox4.Text,textBox1.Text,textBox2.Text,textBox3.Text, DateTime.Parse(dateTimePicker1.Text));
                spisanieTableAdapter.Fill(this.phonesDataSet.Spisanie);
            }
            else
            {
                MessageBox.Show("Одно из полей не заполнено");
            }

        }
    }
}
