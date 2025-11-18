using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6
{
    public class Otazka
    {
        public string Text { get; set; }
        public string[] Moznosti { get; set; }
        public string SpravnaOdpoved {  get; set; }

        public Otazka(string text, string[] moznosti, string spravnaOdpoved)
        {
            Text = text;
            Moznosti = moznosti;
            SpravnaOdpoved = spravnaOdpoved;
        }
    }
}
