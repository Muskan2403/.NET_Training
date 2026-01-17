using System;
using System.Collections.Generic;
using System.Linq;

namespace FindItem{
	class Program{
		public static SortedDictionary<string,long> itemDetails = new SortedDictionary<string, long>();

		
        public static void Main(string[] args){
			Program program = new Program();

            Console.Write("Enter number of items: ");
            int numOfItem = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<numOfItem; i++){

                Console.Write("Enter item Name: ");
                string itemName = Console.ReadLine();

                Console.Write("Enter sold Count: ");
                long sold = Convert.ToInt64(Console.ReadLine());

                if(!itemDetails.ContainsKey(itemName)){
                    itemDetails.Add(itemName, sold);
                }
                else{
                    Console.WriteLine("Item already exists. Skipping...");
                }
            }
			
			Console.Write("\nEnter sold Count for Search: ");
            long soldCount = Convert.ToInt64(Console.ReadLine());

            SortedDictionary<string, long> foundItem = program.FindItemDetails(soldCount);
            
            if (foundItem.Count == 0)
            {
                Console.WriteLine("Invalid sold count");
            }
            else
            {
                Console.WriteLine("\nItem Details:");
                foreach (var item in foundItem)
                {
                    Console.WriteLine($"{item.Key} : {item.Value}");
                }
            

                List<string> minMaxItems = program.FindMinandMaxSolditems();

                Console.WriteLine($"\nMinimum sold count: {minMaxItems[0]} \nMaximum sold count: {minMaxItems[1]}");
                
                Console.WriteLine("\nSorted Items:");
                Dictionary<string, long> sortedItem =program.SortByCount();
                foreach (var item in sortedItem)
                {
                    Console.WriteLine($"{item.Key} : {item.Value}");
                }
            }
			
		}
		public SortedDictionary<string, long> FindItemDetails(long soldCount){

            SortedDictionary<string, long> result = new SortedDictionary<string, long>();

            foreach(var item in itemDetails){
                if(item.Value == soldCount){
                    result.Add(item.Key, item.Value);
                }
            }
            return result;
		}
		
		public List<string> FindMinandMaxSolditems(){

            List<string> result = new List<string>();

            long minSold = long.MaxValue;
            long maxSold = long.MinValue;

            foreach(var item in itemDetails){
                if(item.Value < minSold){
                    minSold = item.Value;
                }
                if(item.Value > maxSold){
                    maxSold = item.Value;
                }
            }

            result.Add(minSold.ToString());
            result.Add(maxSold.ToString());

            return result;
			
		}
		public Dictionary<string, long> SortByCount()
        {
            return itemDetails
                .OrderBy(item => item.Value)
                .ToDictionary(item => item.Key, item => item.Value);
        }
		
	}
}
