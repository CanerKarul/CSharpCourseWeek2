using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string student1 = "Caner";
            //string student2 = "Hekim";
            //string student3 = "Omar";

            string[] students = new string[3];
            students[0] = "Caner";
            students[1] = "Hekim";
            students[2] = "Omar";

            string[] students2 = new[] { "Caner", "Hekim", "Omarr" };

            string[] students3 = { "Caner", "Hekim", "Omarrr" };
            
            foreach (string student in students3)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("*****");
            string[,] regions = new string[7,3]
            {
                {"İstanbul","İzmit","Balıkesir" },
                {"Ankara","Konya","Kırıkkale" },
                {"Antala","Adana","Mersin" },
                {"Rize","Trabzon","Samsun" },
                {"İzmir","Muğla","Manisa" },
                {"Malatya","Elazığ","Adıyaman" },
                {"Diyarbakır","Hakkari","Mardin" }
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("**********");
            }

            Console.ReadLine();
            
        }
    }
}
