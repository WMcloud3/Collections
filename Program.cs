using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring an array of length 5, initialized by default to all zeroes
            int[] numArray = new int[10];
            for(int i =0; i<numArray.Length; ++i){
                Console.WriteLine(numArray[i]);
            }
            // Declaring an array with pre-populated values
            // For Arrays initialized this way, the length is determined by the size of the given data
            string[] numArray2 = {"Tim", "Martin", "Nikki", "Sara"};
            for(int i =0; i<numArray2.Length; ++i){
                Console.WriteLine(numArray2[i]);
            }

            bool[] boolArray = {true, false, true, false, true, false, true, false, true, false};
            for(int i =0; i<boolArray.Length; ++i){
                Console.WriteLine(boolArray[i]);
            }


            //Initializing an empty list of Motorcycle Manufacturers
            List<string> iceCreamFlavor = new List<string>();
            //Use the Add function in a similar fashion to push
            iceCreamFlavor.Add("Vanilla");
            iceCreamFlavor.Add("Chocolate");
            iceCreamFlavor.Add("Buttered Pecan");
            iceCreamFlavor.Add("Strawberry");
            iceCreamFlavor.Add("Cookie Dough");
            //Accessing a generic list value is the same as you would an array
            for (var idx = 0; idx < iceCreamFlavor.Count; idx++)
            {
                Console.WriteLine("-" + iceCreamFlavor[idx]);
            }

            Console.WriteLine(iceCreamFlavor[2]); //Prints "BMW"
            iceCreamFlavor.RemoveAt(2);

            foreach (string i in iceCreamFlavor)
            {
                Console.WriteLine("-" + i);
            }


            Dictionary<string,string> profile = new Dictionary<string,string>();
            //Almost all the methods that exists with Lists are the same with Dictionaries
            profile.Add("Tim", "Vanilla");
            profile.Add("Martin", "Chocolate");
            profile.Add("Nikki", "Strawberry");
            profile.Add("Sara", "Buttered Pecan");



            foreach (KeyValuePair<string,string> entry in profile)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }



        }
    }
}
