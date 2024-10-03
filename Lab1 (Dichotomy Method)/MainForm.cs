using System;
using System.Windows.Forms;

namespace Lab1__Dichotomy_Method_
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Настройка интрефейса
        private void buttonsPanel_Resize(object sender, EventArgs e)
        {
            //Высота кнопок
            dichotomyMethodButoon.Height = buttonsPanel.Height / 4;
            goldenRatioMethodbutton.Height = buttonsPanel.Height / 4;
            button3.Height = buttonsPanel.Height / 4;
            button4.Height = buttonsPanel.Height / 4;
            button5.Height = buttonsPanel.Height / 4;
            button6.Height = buttonsPanel.Height / 4;
            button7.Height = buttonsPanel.Height / 4;
            button8.Height = buttonsPanel.Height / 4;

            //Ширина кнопок
            dichotomyMethodButoon.Width = buttonsPanel.Width / 2;
            goldenRatioMethodbutton.Width = buttonsPanel.Width / 2;
            button3.Width = buttonsPanel.Width / 2;
            button4.Width = buttonsPanel.Width / 2;
            button5.Width = buttonsPanel.Width / 2;
            button6.Width = buttonsPanel.Width / 2;
            button7.Width = buttonsPanel.Width / 2;
            button8.Width = buttonsPanel.Width / 2;

            //Верхняя граница
            dichotomyMethodButoon.Top = 0;
            goldenRatioMethodbutton.Top = 0;
            button3.Top = buttonsPanel.Height / 4;
            button4.Top = buttonsPanel.Height / 4;
            button5.Top = buttonsPanel.Height * 2 / 4;
            button6.Top = buttonsPanel.Height * 2 / 4;
            button7.Top = buttonsPanel.Height * 3 / 4;
            button8.Top = buttonsPanel.Height * 3 / 4;

            //Левая граница
            dichotomyMethodButoon.Left = 0;
            button3.Left = 0;
            button5.Left = 0;
            button7.Left = 0;
            goldenRatioMethodbutton.Left = buttonsPanel.Width / 2;
            button4.Left = buttonsPanel.Width / 2;
            button6.Left = buttonsPanel.Width / 2;
            button8.Left = buttonsPanel.Width / 2;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            buttonsPanel_Resize(sender, e);
        }

        private void dichotomyMethodButoon_Click(object sender, EventArgs e)
        {
            DichotomyForm dichotomyForm = new DichotomyForm();
            dichotomyForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GoldenRatioForm goldenRatioForm = new GoldenRatioForm();
            goldenRatioForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }
    }
}
