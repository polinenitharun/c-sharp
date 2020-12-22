using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Linqimplementation
{
    public class linqExamples
    {
        public IEnumerable<int> disp()
        {
            var numbers = Enumerable.Range(0, 10).
            Aggregate((a, b) => a = a + b);
            yield return numbers;   
        }
        public IEnumerable<int> disp1()
        {
            var numbers = Enumerable.Range(0, 10).
                Where(i => i > 5);
            var numbers1 = Enumerable.Range(0, 10).
               Where(i => i < 5);
            return numbers.Except(numbers1);
        }

    }
}
