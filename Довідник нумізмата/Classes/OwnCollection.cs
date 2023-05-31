using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Довідник_нумізмата.Classes
{
    public class OwnCollection
    {
        public string name1;
        public string country1;
        public int issueOfTheCoin1;
        public int amount1;
        public string denomination1;
        public string metal1;
        public string feature1;

        public OwnCollection(string _name, string _country, int _issueOfTheCoin, int _amount, string _denomination, string _metal, string _feature)
        {
            name1 = _name;
            issueOfTheCoin1 = _issueOfTheCoin;
            amount1 = _amount;
            denomination1 = _denomination;
            metal1 = _metal;
            feature1 = _feature;
            country1 = _country;



        }
    }
    public static class OwnCollectionList
    {
        public static List<OwnCollection> owncollectionlist = new List<OwnCollection>();

        public static void Add(OwnCollection owncollection)
        {
            owncollectionlist.Add(owncollection);
        }
    }
}
