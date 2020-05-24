using System;
using System.Collections.Generic;
using System.Windows.Forms;

// Студент: Дмитрий Фатеев

/* Задание №1
 * а) а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
 * б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. 
 * Игрок должен получить это число за минимальное количество ходов.
 * в) *Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте обобщенный класс Stack.
 * Вся логика игры должна быть реализована в классе с удвоителем.
 */

namespace homework7
{
    public partial class Form1 : Form
    {
        public int playerSteps = 0;
        public Stack<string> operationStack = new Stack<string>();

        public Form1()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            btnUndo.Text = "Отменить";
            lblNumber.Text = "0";
            this.Text = "Удвоитель";
            toolStripStatusLabel1.Text = "Счетчик ходов: 0";

            
        }

        private void BtnCommand1_Click(object sender, EventArgs e)
        {
            operationStack.Push(lblNumber.Text);
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();            
            toolStripStatusLabel1.Text = $"Счетчик ходов: {(++playerSteps).ToString()}";
        }

        private void BtnCommand2_Click(object sender, EventArgs e)
        {
            operationStack.Push(lblNumber.Text);
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();            
            toolStripStatusLabel1.Text = $"Счетчик ходов: {(++playerSteps).ToString()}";
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            operationStack.Push(lblNumber.Text);
            lblNumber.Text = "1";
            toolStripStatusLabel1.Text = $"Счетчик ходов: {(++playerSteps).ToString()}";
        }

        private void ИгратьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int number = random.Next(50, 100);
            MessageBox.Show($"Игрок должен получить число {number} за минимальное количество ходов.", "Игрок1");
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            if(operationStack.Count > 0)
            {
                lblNumber.Text = operationStack.Pop();
            }
        }
    }
}
