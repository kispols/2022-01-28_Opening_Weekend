using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2022_01_28_Opening_Weekend
{
    class OpeningWeekend
    {
        static void Main(string[] args)
        {
            List<Film> filmek = new List<Film>();
            foreach (var sor in File.ReadAllLines("nyitohetvege.txt").Skip(1))
            {
                filmek.Add(new Film(sor));
            }
            Console.WriteLine($"3. feladat: Filmek száma az állományban: {filmek.Count} db");
            Console.ReadKey();
        }
    }
}
