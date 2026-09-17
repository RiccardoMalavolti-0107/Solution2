using System;
using System.Collections.Generic;
using System.Text;

namespace Kavezogep
{
    public class Kavezogepek
    {
        private int VizKeszletMl { get; set; }
        public void VizTolt(int ml)
        {
            VizKeszletMl += ml;
            Console.WriteLine("{0} viz betoltve",ml);

        }
        public void KaveFozes()
        {
            if (VizKeszletMl >= 150)
            {
                VizKeszletMl -= 150;
                Console.WriteLine("1 db kave lefozve");
                Console.WriteLine("{0} vizkeszlet maradt", VizKeszletMl);
            }
            else
            {
                Console.WriteLine("nincs eleg viz");
            }
        }
        public void KaveFozes(int db)
        {
            if (VizKeszletMl >= 150*db)
            {
                VizKeszletMl -= 150*db;
                Console.WriteLine("{0}db kave lefozve", db);
                Console.WriteLine("{0} vizkeszlet maradt", VizKeszletMl);
            }
            else
            {
                Console.WriteLine("nincs eleg viz");
            }
        }
    }
}
