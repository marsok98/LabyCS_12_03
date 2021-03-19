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
            if (weight != 0) this.ratio = (float)value / (float)weight;
            else ratio = 0;
        }
        public Item()
        {
            this.weight = 0;
            this.value = 0;
            this.ratio = 0;
        }
        public string GetStringFromItem()
        {
            return ("Waga: " + weight + " Wartosc: " + value+"||");
        }
        public static bool operator ==(Item compare, Item toCompare)
        {
            if (compare.Value == toCompare.Value && compare.Weight == compare.Weight) return true;
            else return false;     
        }

        public static bool operator !=(Item compare, Item toCompare)
        {
            if (compare.Value == toCompare.Value && compare.Weight == compare.Weight) return false;
            else return true;
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
            SortListByRatio();
                    
        }
        public string getStringFromList()
        {
            string returnValue = "";
            foreach (Item x in list)
            {
                returnValue += "\n" + x.GetStringFromItem() + " ";
            }
            return returnValue;
        }
        public void AddItemToListManual(Item item)
        {
            list.Add(item);
            SortListByRatio();
        }

        public void  SortListByRatio()
        {
            list.Sort((x, y) => x.Ratio.CompareTo(y.Ratio));
            list.Reverse();
        }

        public ListOfItem()
        {

        }

        public void DisplayList()
        {
            foreach (Item x in list)
            {
                System.Console.WriteLine(x.GetStringFromItem());
            }
        }

        public static bool operator ==(ListOfItem compare, ListOfItem toCompare)
        {
            for(int i = 0;i<compare.List.Count();i++)
            {
                if (compare.List[i] != toCompare.List[i]) return false;  
            }
            return true;
        }
        public static bool operator != (ListOfItem compare, ListOfItem toCompare)
        {
            for (int i = 0; i < compare.List.Count(); i++)
            {
                if (compare.List[i] != toCompare.List[i]) return true;
            }
            return false;
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

        public bool robTheHouse(ListOfItem availableItems)
        {
            int amountBeforeRob = itemsOnBackPack.Count();
            foreach(Item item in availableItems.List)
            {
                Add(item);
            }
            int amountAfterRob = itemsOnBackPack.Count();
            if (amountAfterRob == amountBeforeRob) return false;
            else return true;

        }

        public void showWhatYouVeStolen()
        {
            foreach(Item item in ItemsOnBackPack)
            {
                Console.WriteLine(item.GetStringFromItem());
            }
        }
        public string getStringFromBackPack()
        {
            string returnValue = "";
            foreach (Item x in itemsOnBackPack)
            {
                returnValue += "\n" + x.GetStringFromItem() + " ";
            }
            return returnValue;
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
