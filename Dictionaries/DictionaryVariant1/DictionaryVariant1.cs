using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryVariant1
{
    class DictionaryVariant1
    {
        static void Main(string[] args)
        {
            /*
             * On the console print for every color (ordered alphabetically) 
             * the persons (ordered by names in descending order alphabetically) how much money did they spend.
             * If there are persons with one and the same name in the input rows, 
             * the persons must be printed in increasing order by the money they have spent.

             * Dictionary which holds the color as a Key Value and a List of Customr objects as Value
             */

            SortedDictionary<string, List<Customer>> customers = new SortedDictionary<string, List<Customer>>();
            string newInput = Console.ReadLine();

            while (true)
            {
                if (newInput == "End")
                {
                    break;
                }
                Customer currCustomer = ReadCustomr(newInput);
                string color = currCustomer.Color;

                if (!customers.ContainsKey(color))
                {
                    customers[color] = new List<Customer>();
                }
                customers[color].Add(currCustomer);

                newInput = Console.ReadLine();
            }

            foreach (var cust in customers)
            {
                string theColor = cust.Key;
                Console.WriteLine($"The Color: --> {theColor}");
                List<Customer> theValues = cust.Value;
                foreach (var person in theValues.OrderByDescending(x => x.Name).ThenBy(y => y.TotalMoney))
                {
                    Console.WriteLine($"Name: {person.Name} --> Total Money: {person.TotalMoney}");
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
