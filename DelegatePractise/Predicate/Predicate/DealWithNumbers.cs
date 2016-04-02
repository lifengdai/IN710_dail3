using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Predicate
{
    class DealWithNumbers
    {
        private Random radnom;
        private List<int> numbers;

        public DealWithNumbers()
        {
            radnom = new Random();
            numbers = new List<int>();
        }

        public void generateNumbers(ListBox listbox)
        {
            listbox.Items.Clear();
            numbers.Clear();
            for (int i = 0; i < 100; i++)
            {
                int num = radnom.Next(100);
                numbers.Add(num);
                listbox.Items.Add(num);
            }
        }

        public List<int> Numbers
        {
            get
            {
                return numbers;
            }
        }
    }
}
