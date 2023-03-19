using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersClick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Name // фио
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Phone // телефон
        {
            get { return textBox2.Text; }
            set { textBox2.Text = ("+7" + value); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ("Поздравляем!\n Участник" + Name + " успешно зарегистрирован\n" + 
                "Проверяйте информацию в сообщениях по номеру\n" + Phone);
            button1.Enabled = false;
            button1.Text = ("Вы не можете больше участвовать.");

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле ФИО не может содержать цифры");
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле Номер не может содержать буквы");
            }

        }
    }
}
