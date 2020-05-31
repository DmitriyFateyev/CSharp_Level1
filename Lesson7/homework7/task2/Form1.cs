using System;
using System.Collections.Generic;
using System.Windows.Forms;

// Студент: Дмитрий Фатеев

/* Задание №2
 * Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, 
 * а человек пытается его угадать за минимальное число попыток. Компьютер говорит, больше или меньше загаданное число введенного.  
 * a) Для ввода данных от человека используется элемент TextBox;
 * б) **Реализовать отдельную форму c TextBox для ввода числа.
 */

namespace task2
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int userRetry = 5;
        int secretNumber;

        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = $"Осталось попыток: {userRetry}";
            secretNumber = rnd.Next(0, 100);
        }

        private void BtnUserInput_Click(object sender, EventArgs e)
        {
            if(int.Parse(tbAnswer.Text) == secretNumber && userRetry > 0)
            {
                MessageBox.Show("Поздравляем, Вы угадали число!", "Верный ответ!");
                userRetry = 5;
                toolStripStatusLabel1.Text = $"Осталось попыток: {userRetry}";
                secretNumber = rnd.Next(0, 100);
                tbTooltip.Text = "Загадано новое число! Попробуйте отгадать.";
            } else if (int.Parse(tbAnswer.Text) < secretNumber && userRetry > 0)
            {
                userRetry--;
                tbTooltip.Text = "Введенное число меньше загаданного";
                toolStripStatusLabel1.Text = $"Осталось попыток: {userRetry}";
            } else if (int.Parse(tbAnswer.Text) > secretNumber && userRetry > 0)
            {
                userRetry--;
                tbTooltip.Text = "Введенное число больше загаданного";
                toolStripStatusLabel1.Text = $"Осталось попыток: {userRetry}";
            } else
            {
                MessageBox.Show("Вы исчерпали все попытки! Попробуйте еще раз.", "Загаданное число: " + secretNumber.ToString());
                userRetry = 5;
                toolStripStatusLabel1.Text = $"Осталось попыток: {userRetry}";
                secretNumber = rnd.Next(0, 100);
                tbTooltip.Text = "Загадано новое число! Попробуйте отгадать.";
            }
        }

        private void TbAnswer_TextChanged(object sender, EventArgs e)
        {
            tbTooltip.Text = "";
        }
    }
}
