using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp4
{
    public class Cigarette
    {
        private tabak tabak1;
        private bumaga bumaga1;
        private spichki spichki1;
        public Cigarette(tabak tabak, bumaga bumaga, spichki spichki)
        {
            tabak1 = tabak;
            bumaga1 = bumaga;
            spichki1 = spichki;
            Console.WriteLine("Создалась сигарета");
        }
    }
}