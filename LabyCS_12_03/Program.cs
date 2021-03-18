using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyCS_12_03
{

    public class Item
    {
        int weight;
        int value;
        float ratio;

        public int Weight
        {
            get => weight;
            set => weight = value;
        }

        public int Value
        {
            get => this.value;
            set => this.value = value;
        }

        public float Ratio
        {
            get => ratio;
            set => ratio = value;
        }

        public Item(int weight, int value)
        {
            this.weight = weight;
            this.value = value;
            this.ratio = (float)value / (float)weight;
        }
        public Item()
        {
            this.weight = 0;
            this.value = 0;
            this.ratio = 0;
        }
        public string GetStringFromItem()
        {
            return ("Waga: " + weight + " Wartosc: " + value + " Stosunek: " + ratio);
        }
    }

    public class ListOfItem
    {
        List<Item> list = new List<Item>();
        public List<Item> List
        {
            get => this.list;
            set => this.list = value;
        }


        public ListOfItem(int seedToWeight, int seedToValue, int amountOfItems)
        {
            RandomNumberGenerator rngToWeights = new RandomNumberGenerator(seedToWeight);
            RandomNumberGenerator rngToValues = new RandomNumberGenerator(seedToValue);


            for (int x = 0; x < amountOfItems; x++)
            {
                list.Add(new Item(rngToWeights.nextInt(1, 29), rngToValues.nextInt(1, 29)));
            }
            list.Sort((x, y) => x.Ratio.CompareTo(y.Ratio));
            list.Reverse();        
        }

        public void DisplayList()
        {
            foreach (Item x in list)
            {
                System.Console.WriteLine(x.GetStringFromItem());
            }
        }
    }

    public class BackPack
    {
        int maxCapacity;
        int currentCapacity;
        List<Item> itemsOnBackPack =new List<Item>();

        public int MaxCapacity
        {
            get => maxCapacity;
            set => maxCapacity = value;
        }
        public int CurrentCapacity
        {
            get => currentCapacity;
            set => currentCapacity = value;
        }

        public List<Item> ItemsOnBackPack
        {
            get => itemsOnBackPack;
            set => itemsOnBackPack = value;
        }




        public BackPack(int capacity)
        {
            this.maxCapacity = capacity;
        }
        public bool Add(Item newItem)
        {
            if(this.currentCapacity + newItem.Weight <= maxCapacity)
            {
                this.ItemsOnBackPack.Add(newItem);
                this.currentCapacity += newItem.Weight;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void robTheHouse(ListOfItem availableItems)
        {
            foreach(Item item in availableItems.List)
            {
                Add(item);
            }
        }

        public void showWhatYouVeStolen()
        {
            foreach(Item item in ItemsOnBackPack)
            {
                Console.WriteLine(item.GetStringFromItem());
            }
        }

    }

    class Program
    {

        static void Main(string[] args)
        {

            ListOfItem list = new ListOfItem(4, 2, 10);
            list.DisplayList();
            BackPack backPack = new BackPack(40);
            Console.WriteLine("przerwa");
            backPack.robTheHouse(list);
            backPack.showWhatYouVeStolen();

            Console.Read();

        }
    }
}
