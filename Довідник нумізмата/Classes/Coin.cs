using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Довідник_нумізмата.Classes
{
    public class Coin
    {


        public string name;
        public string country;
        public int issueOfTheCoin;
        public int amount;
        public string denomination;
        public string metal;
        public string feature;




        public Coin(string _name, string _country, int _issueOfTheCoin, int _amount, string _denomination, string _metal, string _feature)
        {
            name = _name;
            issueOfTheCoin = _issueOfTheCoin;
            amount = _amount;
            denomination = _denomination;
            metal = _metal;
            feature = _feature;
            country = _country;
        }
       


    }
    public static class CoinList
    {
        public static List<Coin> coinlist = new List<Coin>();
        public static void Add(Coin coin)
        {
            coinlist.Add(coin);
        }
    }

}
