// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//const int sort;
/*int[] array =  new int[] { 1, 3, 2, 41, 5 };
Array.Sort(array);
Console.WriteLine(array);*/


/*using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

extern alias DeveloperPublicNamespace
namespace myapplication
{
    public   class car
    {
        string color = "red";
    
    public void main(string[] args)
    {
        car myobj1 = new car();
        car myobj2 = new car();
        Console.WriteLine(myobj2.color);
    }
}
}*/


using  System;

namespace AccessArray
{
    class Program
    {
        static void Main(string[] args)
        {

            // create an array
            int[] numbers = { 1, 4,7,2, 3 };
            //sorting of an array using sort method 
            Array.Sort(numbers);
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("reversing an array");
            Array.Reverse(numbers);
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
                Console.WriteLine("incrementing the value by 1");
                Console.WriteLine(i + 1);
                Console.WriteLine("done");
            }
            

            /*access first element
            Console.WriteLine("Element in first index : " + numbers[0]);

            //access second element
            Console.WriteLine("Element in second index : " + numbers[1]);

            //access third element
            Console.WriteLine("Element in third index : " + numbers[2]);

            Console.ReadLine();
            */

        }
    }
}