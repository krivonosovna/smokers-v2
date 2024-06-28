using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp4
{
    public class smoker
    {
        public smoker(string ResourceName)
        {
            tabakList = new List<tabak>();
            bumagaList = new List<bumaga>();
            spichkiList = new List<spichki>();
            if (ResourceName != "tabak" & ResourceName != "bumaga" & ResourceName != "spichki")
            {
                Console.WriteLine("Передан неизвестный ресурс");
                return;
            }
            if (ResourceName == "tabak")
            {
                for (int i = 0; i < 10; i++)
                {
                    tabak tabak1 = new tabak();
                    tabakList.Add(tabak1);
                }
            }
            if (ResourceName == "bumaga")
            {
                for (int i = 0; i < 10; i++)
                {
                    bumaga bumaga1 = new bumaga();
                    bumagaList.Add(bumaga1);
                }
            }
            if (ResourceName == "spichki")
            {
                for (int i = 0; i < 10; i++)
                {
                    spichki spichki1 = new spichki();
                    spichkiList.Add(spichki1);
                }
            }
        }
        public List<tabak> tabakList;
        public List<bumaga> bumagaList;
        public List<spichki> spichkiList;
        public Cigarette makecigarete(bumaga bumaga, spichki spichki)
        {
            if (tabakList.Count == 0)
            {
                Console.WriteLine("У меня закончился табак");
                Thread.Sleep(3000);
                return null;
            }
            tabak tabak1 = tabakList.FirstOrDefault();
            Cigarette abc = new Cigarette(tabak1, bumaga, spichki);
            tabakList.Remove(tabak1);
            Console.WriteLine("Я создал сигарету и потратил табак");
            return abc;
        }
        public Cigarette makecigarete(bumaga bumaga, tabak tabak)
        {
            if (spichkiList.Count == 0)
            {
                Console.WriteLine("У меня закончились спички");
                Thread.Sleep(3000);
                return null;
            }
            spichki spichki1 = spichkiList.FirstOrDefault();
            Cigarette abc = new Cigarette(tabak, bumaga, spichki1);
            spichkiList.Remove(spichki1);
            Console.WriteLine("Я создал сигарету и потратил спичку");
            return abc;
        }
        public Cigarette makecigarete(tabak tabak, spichki spichki)
        {
            if (bumagaList.Count == 0)
            {
                Console.WriteLine("У меня закончилась бумага");
                Thread.Sleep(3000);
                return null;
            }
            bumaga bumaga1 = bumagaList.FirstOrDefault();
            Cigarette abc = new Cigarette(tabak, bumaga1, spichki);
            bumagaList.Remove(bumaga1);
            Console.WriteLine("Я создал сигарету и потратил бумагу");
            return abc;
        }
    }
}