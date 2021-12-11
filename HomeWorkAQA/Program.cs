using Newtonsoft.Json;
using NLog;
using NLog.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HomeWork5
{
    class Program
    {   
        public static void CountingPhones(Shop[] shop)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            for (int i = 0; i < shop.Length; i++)
            {
                Phone[] phoneArray = shop[i].Phones.Where(i => i.IsAvailable == true).ToArray();
                int countIOS = phoneArray.Where(i => i.OperationSystemType == "IOS").Count();
                int countAndroid = phoneArray.Where(i => i.OperationSystemType == "Android").Count();

                Console.WriteLine($"{shop[i].Id} {shop[i].Name}");
                Console.WriteLine(shop[i].Description);
                Console.WriteLine($"IOS Is Available: {countIOS}");
                Console.WriteLine($"Android Is Available: {countAndroid}");
                Console.WriteLine("-----------");

                logger.Info($"{shop[i].Id} {shop[i].Name}");
                logger.Info(shop[i].Description);
                logger.Info($"IOS Is Available: {countIOS}");
                logger.Info($"Android Is Available: {countAndroid}");
                logger.Info("-----------");



            }
        }

        static void Main(string[] args)
        {
            Logger logger = LogManager.GetCurrentClassLogger();

            
            #region Creation objects

            string path = "info.json";
            Rootobject rootobject = JsonConvert.DeserializeObject<Rootobject>(File.ReadAllText(path));

            Shop[] shop = rootobject.Shops;
            Phone[] phoneOnliner = shop[0].Phones;
            Phone[] phoneYandex = shop[1].Phones;

            List<Phone> onlinerIsAvailable = shop[0].Phones.Where(i => i.IsAvailable == true).ToList();
            List<Phone> yandexIsAvailable = shop[1].Phones.Where(i => i.IsAvailable == true).ToList();
            List<Phone> allPhone = phoneOnliner.Concat(phoneYandex).ToList();

            #endregion

            CountingPhones(shop);
            List<int> foo = new List<int>();
            List<Phone> desiredPhones = new List<Phone>();
            bool exitToCycle = true;
            while (exitToCycle)
            {
                Console.WriteLine("Which mobile phone do you want to buy ?");
                logger.Info("Which mobile phone do you want to buy ?");
                var usersModel = Console.ReadLine();

                desiredPhones = allPhone.FindAll(i => i.Model == usersModel);
                Console.WriteLine("-------");
                logger.Info("-------");

                for (int i = 0; i < desiredPhones.Count; i++)
                {
                    if (desiredPhones[i].IsAvailable == true)
                    {
                        var marketId = desiredPhones[i].ShopId == 1 ? 0 : 1;
                        Console.WriteLine($"{desiredPhones[i].Model} \n" +
                                $"{desiredPhones[i].OperationSystemType} \n" +
                                $"{desiredPhones[i].MarketLaunchDate} \n" +
                                $"{desiredPhones[i].Price} \n" +
                                $"{shop[marketId].Name}");
                        Console.WriteLine("-----------");

                        logger.Info($"{desiredPhones[i].Model} \n" +
                                $"{desiredPhones[i].OperationSystemType} \n" +
                                $"{desiredPhones[i].MarketLaunchDate} \n" +
                                $"{desiredPhones[i].Price} \n" +
                                $"{shop[marketId].Name}" +
                                "-----------------");
                    }
                    else if (desiredPhones[i].IsAvailable == false)
                    {
                        Console.WriteLine("This mobile phone is out of stock");
                        logger.Info("This mobile phone is out of stock");
                        continue;
                    }
                }
                if (desiredPhones.Count == 0)
                {
                    Console.WriteLine("This mobile phone is not found");
                    logger.Info("This mobile phone is not found");
                    continue;
                }
                exitToCycle = false;
            }

            exitToCycle = true;
            int idShop = 0;
            int choseShop = 0;

            while (exitToCycle)
            {
                Console.WriteLine("In which store do you want to buy the mobile phone ? Enter the number.");
                Console.WriteLine(" 1.Onliner \n 2.Yandex Market");
                logger.Info("In which store do you want to buy the mobile phone ? Enter the number.");
                logger.Info(" 1.Onliner \n 2.Yandex Market");
                try
                {
                    idShop = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                if (idShop > 2 | idShop < 1)
                {
                    Console.WriteLine("You entered incorrect data. Try again.");
                    logger.Info("You entered incorrect data. Try again.");
                    continue;
                }

                List<Phone> selectedPhone = desiredPhones.Where(i => i.ShopId == idShop & i.IsAvailable == true).ToList();
                try
                {
                    choseShop = selectedPhone[0].ShopId == 1 ? 0 : 1;
                }
                catch (Exception)
                {
                    Console.WriteLine("This model is not available in the store. Please choose another store.");
                    logger.Error("This model is not available in the store. Please choose another store.");
                    continue;
                }

                if (selectedPhone.Count == 1)
                {
                    Console.WriteLine($"Order for { selectedPhone[0].Model} ({ selectedPhone[0].OperationSystemType}), price ${ selectedPhone[0].Price}, market launch date " +
                        $"{ selectedPhone[0].MarketLaunchDate}, in shop {shop[choseShop].Name} has been successfully placed");
                    logger.Info($"Order for { selectedPhone[0].Model} ({ selectedPhone[0].OperationSystemType}), price ${ selectedPhone[0].Price}, market launch date " +
                        $"{ selectedPhone[0].MarketLaunchDate}, in shop {shop[choseShop].Name} has been successfully placed");

                    exitToCycle = false;
                }
                else if (selectedPhone.Count == 0)
                {
                    Console.WriteLine("This shop is not found");
                    logger.Info("This shop is not found");
                    break;
                }

                Console.WriteLine();

            }
        }
    }
}
