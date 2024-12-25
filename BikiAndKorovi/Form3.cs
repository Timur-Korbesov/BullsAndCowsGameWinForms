using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace BikiAndKorovi
{
    public partial class Form3 : Form
    {

        public static string currWord;
        public static int attempts = 0;

        public Form3(string curword)
        {
            currWord = curword;

            InitializeComponent();


        }

        private void Form3_Load(object sender, EventArgs e)
        {
            wordDesc.Text += " из " + currWord.Length.ToString() + " букв";
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            if (charInputBox.Text.Length == 0)
            {
                resultAnswerLabel.Text = "Введите букву!";
            }
            else if (charInputBox.Text.Length > 1)
            {
                resultAnswerLabel.Text = "Введите ОДНУ букву!";
            }
            else
            {
                if (userWord.Text.Length < currWord.Length)
                {
                    char userChar = charInputBox.Text.ToLower()[0];

                    if ((int)(userChar) >= (int)('а') && (int)(userChar) <= (int)('я'))
                    {
                        userWord.Text += userChar;
                        resultAnswerLabel.Text = "";
                    }
                    else
                    {
                        resultAnswerLabel.Text = "Введите корректный символ (букву)";
                    }
                }
                else
                {
                    resultAnswerLabel.Text = "Вы УЖЕ ввели нужное количество букв";
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            userWord.Text = "";
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (userWord.Text.Length == currWord.Length)
            {

                int bullsCount = 0;
                int cowsCount = 0;

                attempts++;

                for (int i = 0; i < userWord.Text.Length; i++)
                {
                    if (userWord.Text.ToString()[i] == currWord[i])
                    {
                        bullsCount++;
                    }
                    else if (currWord.Contains(userWord.Text.ToString()[i]))
                    {
                        cowsCount++;
                    }
                }

                if (bullsCount < currWord.Length)
                {

                    countOfAttempts.Text = "Количество попыток: " + attempts;
                    resultAnswerLabel.Text = "Быков - " + bullsCount + ", коров - " + cowsCount;
                }
                else {

                    if (MessageBox.Show("Вы отгадали слово! Начать игру заново?", "Выиграли за " + attempts + " шагов") == DialogResult.OK)
                    {
                        Form2 form2 = new Form2();
                        this.Hide();
                        form2.ShowDialog();
                        this.Show();
                    }
                
                }
            }
            else {
                resultAnswerLabel.Text = "Вы ввели недостаточно букв";
            }
            
        }
    }
}
