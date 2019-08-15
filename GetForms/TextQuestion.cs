using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetForms
{
    public class TextQuestion : Question
    {
        public override string GetAnswer()
        {
            return Console.ReadLine();
        }
    }
}
