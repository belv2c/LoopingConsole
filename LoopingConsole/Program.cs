using System;
using System.Collections.Generic;

namespace LoopingConsole
{
    class Program 
    {
        static void Main(string[] args)
        {

            // lists live in the collections.generic using statement (generic type)
            // list of instances of the child class
            // lists are classes and you can use object initializers with them
            // object init inside of an object init 
            var children = new List<Child>
            { 
                new Child {Name = "Suzie", Sick = false}, // only lets you name new properties (Name is property)
                new Child {Name = "Ralph", Sick = true}
            };

            // for each instance of the child class inside of the list children - do this code
            foreach (var child in children)
            {
                // if you hit a child whos name is Suzie, stop this iteration of the loop and move on to the next child
                // aka skip and move onto next
                if (child.Name == "Suzie")
                {
                    continue;
                    // break; if i hit a kid named Suzie quit the loop and move on 
                }
                Console.WriteLine($"{child.Name} is {(child.Sick ? "sick" : "healthy")}");
                Console.WriteLine(child.ForgeASickNote());
            }


            var lineIRead = Console.ReadLine();
        }
    }
}
