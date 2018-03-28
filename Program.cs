using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksQueues
{
    class Program
    {
        static void Main(string[] args) {
 
            Stack<string> backpack = new Stack<string>();
            
            backpack.Push("Longsword.");
            backpack.Push("Wooden Shield.");
            backpack.Push("Cricket.");
            backpack.Push("Fire staff.");
            backpack.Push("Food(4).");
            backpack.Push("Potions(2).");
           
            Console.WriteLine("There are {0} items in your backpack.", backpack.Count);

            Console.WriteLine("Your are currently holding {0}", backpack.Peek());

            Console.WriteLine("You just sold two items.");
            backpack.Pop();
            backpack.Pop();

            Console.WriteLine("Does your backpack still contains Potions?: {0}", backpack.Contains("Potions(2)."));


            Queue<string> backpackQueue = new Queue<string>();
            backpackQueue.Enqueue("Potions(2)");
            backpackQueue.Enqueue("Food(4)");
            backpackQueue.Enqueue("Fire staff");
            backpackQueue.Enqueue("Cricket");
            backpackQueue.Enqueue("Wooden Shield");
            backpackQueue.Enqueue("Longsword");

            Console.WriteLine("\nThere are {0} items in your backpack.", backpackQueue.Count);

            Console.WriteLine("Your are currently holding {0}", backpackQueue.Peek());

            Console.WriteLine("You just sold two items.");
            backpackQueue.Dequeue();
            backpackQueue.Dequeue();
            Console.WriteLine("Does your backpack still contains Potions?: {0}", backpackQueue.Contains("Fire staff"));

            Console.WriteLine("\nPress Enter key to continue...");
            Console.ReadLine();
        }
    }
}
