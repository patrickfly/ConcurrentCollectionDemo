﻿//using System;
//using System.Collections.Concurrent;
//using System.Threading;

//namespace ConcurrentDemo
//{
//    public class StaffLogsForBonuses
//    {
//        private ConcurrentDictionary<SalesPerson, int> _salesByPerson = new ConcurrentDictionary<SalesPerson, int>();
//        private ConcurrentDictionary<SalesPerson, int> _purchaseByPerson = 
//            new ConcurrentDictionary<SalesPerson, int>();

//        public void ProcessTrade(Trade sale)
//        {
//            Thread.Sleep(300);

//            if (sale.QuantitySold > 0)
//                _salesByPerson.AddOrUpdate(sale.Person,
//                    sale.QuantitySold,
//                    (key, oldValue) => oldValue + sale.QuantitySold);
//            else
//            {
//                _purchaseByPerson.AddOrUpdate(
//                    sale.Person,
//                    -sale.QuantitySold,
//                    (key, oldValue) => oldValue - sale.QuantitySold);
//            }
//        }

//        public void DisplayReport(SalesPerson[] people)
//        {
//            Console.WriteLine();
//            Console.WriteLine("Transactions by salesperson");

//            foreach (var person in people)
//            {
//                int sales = _salesByPerson.GetOrAdd(person, 0);
//                int purchases = _purchaseByPerson.GetOrAdd(person, 0);

//                Console.WriteLine("{0, 15} sold {1,3}, bought {2,3} items, total {3}",
//                    person.Name, sales, purchases, sales + purchases);


//            }
//        }
//    }
//}