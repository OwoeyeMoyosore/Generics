using System;

namespace Shopping
{
    public class Program
    {
        static void Main()
        {

            ShoppingBag<Bag> shoppingBag = new ShoppingBag<Bag>();
            shoppingBag.AddItem(new Bag() { ProductName = "Noodles ", ProductCount = 80 });
            shoppingBag.AddItem(new Bag() { ProductName = "Clothes", ProductCount = 56 });
            shoppingBag.AddItem(new Bag() { ProductName = "Rice", ProductCount = 10 });
            shoppingBag.AddItem(new Bag() { ProductName = "Hypo", ProductCount = 35 });

            var counter = 0;
            while (counter <10)
            {
                Console.WriteLine(shoppingBag.GetItem(counter));
                counter++;
            }
        }
    }
    public class ShoppingBag<T> where T : Bag
    {
        private T[] _items = new T[10];
        private int _index = 0;

        public void AddItem(T item)
        {
            _items[_index++] = item;
        }


        public T GetItem(int index)
        {
            return _items[index];
        }
       
    }
    public class Bag
    {
        public string ProductName { get; set; }
        public int ProductCount { get; set; }

        public override string ToString()
        {
            return $"{ProductName} - {ProductCount}";
        }


    }


    
}
