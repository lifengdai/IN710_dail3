using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate
{
    class CheckConditionNumber
    {
        public CheckConditionNumber() { }

        public static bool isEvenNumber(int number)
        {
            return number % 2 == 0;
        }

        public static bool isLessThenTen(int number)
        {
            return number < 10;
        }
    }
}
