using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikiAndKorovi
{
    public partial class Form2 : Form
    {
        public static List<string> wordsNature = ["дымгэ", "уарын", "мит", "хур", "кэрдаг"];
        public static List<string> wordsAnimals = ["арс", "бирэгъ", "рувас", "куыдз", "бах"];
        public static List<string> wordsFood = ["лывжэ", "фаткъуы", "кэрдо", "сэнэфсир", "дзул"];
        public static List<string> wordsCloth = ["свитер", "хэлаф", "хэдон", "галстук", "худ"];
        public static List<string> wordsHuman = ["сэр", "къах", "къух", "зэрдэ", "ахсэн"];

        public static List<List<string>> allThems = [wordsNature, wordsAnimals, wordsFood, wordsCloth, wordsHuman];
        public static List<string> allTitles = ["Природа", "Животные", "Еда", "Одежда", "Человек"];


        public Form2()
        {
            InitializeComponent();
        }

        private void choiceButton_Click(object sender, EventArgs e)
        {
            if (themeComboBox.Text.Length > 0)
            {
                errorLabel.Text = "";

                List <string> them = allThems[allTitles.IndexOf(themeComboBox.Text)];

                Random rnd = new Random();

                string newWord = them[rnd.Next(0, 5)];

                Form3 form3 = new Form3(newWord);
                this.Hide();
                form3.ShowDialog();
                this.Show();
            }
            else
            {
                errorLabel.Text = "Выберите тематику слова";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
