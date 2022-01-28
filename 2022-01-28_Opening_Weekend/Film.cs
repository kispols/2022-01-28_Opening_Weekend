using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_01_28_Opening_Weekend
{
    class Film
    {
        public string eredetiCím { get; set; }
        public string magyarCím { get; set; }
        public string Bemutató { get; set; }
        public string Forgalmazó { get; set; }
        public int Bevétel { get; set; }
        public int Látogatók { get; set; }

        public Film(string sor)
        {
            string[] t = sor.Split(';');
            eredetiCím = t[0];
            magyarCím = t[1];
            Bemutató = t[2];
            Forgalmazó = t[3];
            Bevétel = int.Parse(t[4]);
            Látogatók = int.Parse(t[5]);
        }
    }
}
