using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Довідник_нумізмата.Classes
{
    public class Data
    {
        public static void LoadCoinsFromFile(string filePath)
        {
            try
            {
                List<Coin> coins = new List<Coin>();
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 5 && parts[0] == "Coin")
                        {
                            string name = parts[1];
                            string country = parts[2];
                            int issueOfTheCoin = int.Parse(parts[3]);
                            int amount = int.Parse(parts[4]);
                            string denomination = parts[5];
                            string metal = parts[6];
                            string feature = parts[7];

                            Coin coin = new Coin(name, country, issueOfTheCoin, amount, denomination, metal, feature);
                            coins.Add(coin);
                        }
                    }
                }
                CoinList.coinlist = coins;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні монет: " + ex.Message);
            }
        }
        public static void LoadCollectorFromFile(string filePath)
        {
            try
            {
                List<Collector> collectors = new List<Collector>();
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 5 && parts[0] == "Collector")
                        {
                            string name = parts[1];
                            string country = parts[2];
                            int phone = int.Parse(parts[3]);
                            string rarecoins = parts[4];

                            Collector collector = new Collector(name, country, phone, rarecoins);
                            collectors.Add(collector);
                        }
                    }
                }
                Collector.CollectorList.collectorlist = collectors;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні колекціонерів: " + ex.Message);
            }
        }

        public static void LoadOwnCollectionFromFile(string filePath)
        {
            try
            {
                List<OwnCollection> ownCollections = new List<OwnCollection>();
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 8 && parts[0] == "OwnCollection")
                        {
                            string name1 = parts[1];
                            string country1 = parts[2];
                            int issueOfTheCoin1 = int.Parse(parts[3]);
                            int amount1 = int.Parse(parts[4]);
                            string denomination1 = parts[5];
                            string metal1 = parts[6];
                            string feature1 = parts[7];
                            OwnCollection ownCollection = new OwnCollection(name1, country1, issueOfTheCoin1, amount1, denomination1, metal1, feature1);
                            ownCollections.Add(ownCollection);
                        }
                    }
                }
                OwnCollectionList.owncollectionlist = ownCollections;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні монет: " + ex.Message);
            }
        }


    }


}
