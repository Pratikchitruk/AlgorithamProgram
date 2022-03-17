using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithamProgram
{
    public class Binarysearch
    {
        public static void Binary()
        {

            List<string> Bin = new List<string>();


            Bin.Add("ABCD");
            Bin.Add("QRST");
            Bin.Add("XYZ");
            Bin.Add("IJKL");

            Console.WriteLine("The Original List is:");
            foreach (string g in Bin)
            {

               
                Console.WriteLine(g);



            }
            Console.WriteLine("\nThe List in Sorted form");

          
            Bin.Sort();


            Console.WriteLine();
            foreach (string g in Bin)
            {
             
                Console.WriteLine(g);

            }
            Console.WriteLine("\nInsert EFGH :");

          
            int index = Bin.BinarySearch("EFGH");


            if (index < 0)
            {

                Bin.Insert(~index, "EFGH");
            }
            Console.WriteLine();

            foreach (string g in Bin)
            {

           
                Console.WriteLine(g);
            }
        }
    }
}

