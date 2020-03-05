using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnet.Lab4
{
    class Store
    {
        

        private Product[] products;
        private int size;
        private int capacity;

        public Store() {
            capacity = 20;
            products = new Product[capacity];
            size = 0;
        }

        public void printArray()
        {
            Console.WriteLine("----------");
            for (int i = 0; i != size; i++)
            {
                Console.WriteLine("Product[{0}]:",(i+1));
                products[i].print();
                Console.WriteLine();
            }
            Console.WriteLine("----------");
        }

        public void add(Product time)
        {
            if (size < capacity)
                products[size++] = time;
            else
            {
                capacity *= 2;
                Product[] dop = new Product[ capacity];
                for (int i = 0; i != products.Length; i++)
                    dop[i] = products[i];
                products = dop;
                add(time);
            }
        }

        public Product findByData(string d)
        {
            for (int i = 0; i != size; i++)
                if (d == products[i].Data)
                    return products[i];
            return null;
        }

        public Product findByCost(double c)
        {
            for (int i = 0; i != size; i++)
                if (c == products[i].Cost)
                    return products[i];
            return null;
        }

        public Product findByWeight(double w)
        {
            for (int i = 0; i != size; i++)
                if (w == products[i].Weight)
                    return products[i];
            return null;
        }


        public void sortByName()
        {
            Array.Sort(products,0,size ,new CompareName());
        }
        /// <summary>
        public void SortByName()
        {
            string[] names = new string[size];
            for (int i = 0; i != size; i++)
                names[i] = products[i].ProductName;
            Array.Sort(names, products, 0, size);
        }
            
        /// </summary>

        public void sortByCost()
        {
            Array.Sort(products,0,size, new CompareCost());
        }
        public void sortByWeight()
        {
            Array.Sort(products,0,size, new ComapreWeight());
        }
        //sort and demonstrate
        public static void ZVMain()
        {
            Store store = new Store();

            store.add(new Product("Potato", "20/03/2019", 430, 200));
            store.add(new Product("Carrot", "09/12/2018", 622, 452));
            store.add(new Product("Phone", "10/05/2020", 5000, 60));
            store.add(new Product("TV", "31/09/2017", 7800, 70));

            store.printArray();

            Console.WriteLine("Sort by name:");
            store.sortByName();
            store.printArray();
            Console.WriteLine("Sort by cost:");
            store.sortByCost();
            store.printArray();
            Console.WriteLine("Sort by weight:");
            store.sortByWeight();
            store.printArray();

            string word;
            Product product;
            Console.WriteLine("Enter one of date(in format 27/05/1999): ");
            word = Console.ReadLine();
            product = store.findByData(word);
            if (product != null)
            {
                Console.WriteLine("Your product found:");
                product.print();
            }
            else
                Console.WriteLine("Your product did not found:");

            double cost;
            Console.WriteLine("Enter one of cost: ");
            cost = double.Parse(Console.ReadLine());
            product = store.findByCost(cost);
            if (product != null)
            {
                Console.WriteLine("Your product found:");
                product.print();
            }
            else
                Console.WriteLine("Your product did not found:");

            double weight;
            Console.WriteLine("Enter one of weight: ");
            weight = double.Parse(Console.ReadLine());
            product = store.findByWeight(weight);
            if (product != null)
            {
                Console.WriteLine("Your product found:");
                product.print();
            }
            else
                Console.WriteLine("Your product did not found:");
        }
    }
}
