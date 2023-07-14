using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Collection!!!");
            //objectname objectname=new classname();
            //objcetname.membername
            //objectname.propertyname
            //objectname.methodname
            ArrayList arrayList = new ArrayList
            {
                "sam",
                "Ravi",
                "Amit"

            };
            Console.WriteLine("Number of elements in Array List are:\t "+arrayList.Count);
            Console.WriteLine("Capacity of Array list is:\t" + arrayList.Capacity);
            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Add("Amit");
            arrayList.Add("Sunita");
            Console.WriteLine("Array adding two more elements in array List");
            Console.WriteLine("Number of element in Array List are:\t" + arrayList.Count);
            Console.WriteLine("Capacity of Array list is: \t " + arrayList.Capacity);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Add("A");
            arrayList.Add("zoya");
            arrayList.Add("Kunal");
            Console.WriteLine("Array adding 8 elements in array List");
            Console.WriteLine("Number of element in Array List are:\t" + arrayList.Count);
            Console.WriteLine("Capacity of Array list is: \t " + arrayList.Capacity);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Add("Manu");
            
            Console.WriteLine("Array adding one more  in array List");
            Console.WriteLine("Number of element in Array List are:\t" + arrayList.Count);
            Console.WriteLine("Capacity of Array list is: \t " + arrayList.Capacity);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
