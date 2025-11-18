using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6
{
    public class Kviz
    {
        private List<Otazka> otazky = new List<Otazka>();
        public void NacitajOtazky(string cestaPriecinka)
        {
            if (!Directory.Exists(cestaPriecinka))
            {
                Console.WriteLine("Priecinok sa nenasiel");
                return;
            }
            string[] subory = Directory.GetFiles(cestaPriecinka, "*.txt");
            foreach (string subor in subory)
            {
                var riadky = File.ReadAllLines(subor);
                if (riadky.Length < 3) continue;
                string text = riadky[0];
                string[] moznosti = riadky[1].Split(';');
                string odpoved = riadky[2];
                otazky.Add(new Otazka(text, moznosti, odpoved));

            }
        }

        public void SpustiKviz()
        {
            Console.WriteLine("\n--- Kviz ---\n");
            foreach (var o in otazky)
            {
                Console.WriteLine(o.Text);
                foreach (var m in o.Moznosti) Console.WriteLine(m);
                Console.Write("Odpoved: ");
                string odp = Console.ReadLine();

                if (odp.Trim().ToUpper() == o.SpravnaOdpoved.ToUpper())
                {
                    Console.WriteLine("Spravne");
                }
                else
                {
                    Console.WriteLine($"Zle Spravna odpoved: {o.SpravnaOdpoved}\n");
                }

            }
        }
    }
}