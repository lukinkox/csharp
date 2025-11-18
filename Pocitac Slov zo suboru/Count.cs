using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocitac_Slov_zo_suboru
{
    public class Count
    {
        public int PocitacSlov(string text)
        {
            if (text == null)
                return 0;

            string[] words = text.Split(' ');
            return words.Length;

        }
    }
}