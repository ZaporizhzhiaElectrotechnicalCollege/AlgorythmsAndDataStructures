using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ListItemsMultiplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            List<int> listOfNumbers = new List<int>(8);

            // Значения исходные
            string source = textBoxNumbers.Text;

            for (int index = 0; index < source.Length; index++)
            {
                // Текущий символ
                char currentSymbol = source[index];

                // Проверка на число
                if (Char.IsDigit(currentSymbol))
                {
                    int number;

                    if (int.TryParse(currentSymbol.ToString(), out number))
                    {
                        listOfNumbers.Add(number);
                    }
                }
            }
        }
    }
}
