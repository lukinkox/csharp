using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocitac_Slov_zo_suboru
{
    public class Read
    {
        private string filePath = @"C:\\Users\\Lukas\\Desktop\\Textovy dokumnet\\text.txt";
        public string ReadFile()

        {
            if (File.Exists(filePath))
                return File.ReadAllText(filePath);
            else
                return "";
        }
        
    }
}
