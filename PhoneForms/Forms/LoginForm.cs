using PhoneForms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LogText.Text != "" && PassText.Text != "")
            {
                string log = LogText.Text.Trim();
                string pass = PassText.Text.Trim();
                DataTable db = new DataTable();
                DataRow[] dr = new DataRow[10];
                dr = usersTableAdapter.GetData().Select("Login = '" + log + "' And Password ='" + pass + "'");
                if (dr.Count() != 0)
                {
                    MainForm f2 = new MainForm();
                    f2.op_name = dr[0].Field<String>("FIO");
                    f2.Show();
                    f2.FormClosed += (object s, FormClosedEventArgs ev) => { this.Close(); };
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль");
                }
            }
            else if (LogText.Text != "")
            {
                MessageBox.Show("Не указан логин");
            }
            else
            {
                MessageBox.Show("Не указан пароль");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            LogText.Text = "operator1";
            PassText.Text = "pass123";
        }
    }

}
