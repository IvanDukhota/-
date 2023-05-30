using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Довідник_нумізмата.Classes
{
    public class Collector
    {
        public string name;
        public string country;
        public int phone;
        public string rarecoins;




        public Collector(string _name, string _country, int _phone, string _rarecoins)
        {
            name = _name;
            country = _country;
            phone = _phone;
            rarecoins = _rarecoins;
        }

        public static class CollectorList
        {
            public static List<Collector> collectorlist = new List<Collector>();
            public static void Add(Collector collector)
            {
                collectorlist.Add(collector);
            }
        }
    }
}
