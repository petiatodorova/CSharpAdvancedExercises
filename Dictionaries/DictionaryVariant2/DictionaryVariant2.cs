using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryVariant2
{
    class DictionaryVariant2
    {
        static void Main(string[] args)
        {
            /*
             * On the console print for every person (ordered alphabetically) by name,
             * the fruits(ordered by names in descending order alphabetically) and how much money did he spend.
             * If there is one and the same name in the input rows, the fruits must be printed in increasing 
             * order by the money they have spent.
             * The Output must be as in the #### Output:
             */

            //SortedDictionary<string the name, List ot persons>
            SortedDictionary<string, List<Customer>> customers = new SortedDictionary<string, List<Customer>>();
            string newInput = Console.ReadLine();

            while (true)
            {
                if (newInput == "End")
                {
                    break;
                }
                Customer currCustomer = ReadCustomr(newInput);
                string color = currCustomer.Name;

                if (!customers.ContainsKey(color))
                {
                    customers[color] = new List<Customer>();
                }
                customers[color].Add(currCustomer);

                newInput = Console.ReadLine();
            }

            foreach (var cust in customers)
            {
                string theName = cust.Key;
                Console.WriteLine($"The Name: --> {theName}");
                List<Customer> theValues = cust.Value;
                foreach (var fruits in theValues.OrderByDescending(x => x.Fruit).ThenBy(y => y.TotalMoney))
                {
                    Console.WriteLine($"Fruit: {fruits.Fruit} --> Total Money: {fruits.TotalMoney}");
                }
            }
        }

        static Customer ReadCustomr(string input)
        {
            string[] inputArr = input
                .Split(new char[] { ' ', '/', '\\', ';', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            return new Customer
            {
                Name = inputArr[0],
                Fruit = inputArr[1],
                Color = inputArr[2],
                Quantity = double.Parse(inputArr[3]),
                Price = decimal.Parse(inputArr[4])
            };
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public string Fruit { get; set; }
        public string Color { get; set; }
        public double Quantity { get; set; }
        public decimal Price { get; set; }

        public decimal TotalMoney
        {
            get
            {
                return (decimal)Quantity * Price;
            }
        }
    }
}
