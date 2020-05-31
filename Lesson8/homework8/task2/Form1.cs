using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Студент: Дмитрий Фатеев

/* Задание №2
 * Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown
 */

namespace task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = numericUpDown1.Value.ToString();
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = numericUpDown1.Value.ToString();
        }
    }
}
