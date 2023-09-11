using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicijalni4_4D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Napišite program koji će provjeriti jesu li 
             * vrijednosti sadržane u int varijablama x, y i z
            stranice pravokutnog trokuta. U program uključite i 
            provjeru da vrijednosti varijabli za ovakav primjer imaju 
            smislene vrijednosti (iznosi moraju biti veći od 0).*/

            int x, y, z;
            Console.WriteLine("Unesi stranicu x: ");
            string a = Console.ReadLine();
            x = Convert.ToInt32(a);
            Console.WriteLine("Unesi stranicu y: ");
            string b = Console.ReadLine();
            y = Convert.ToInt32(b);
            Console.WriteLine("Unesi stranicu z: ");
            string c = Console.ReadLine();
            z = Convert.ToInt32(c);
            int d = (z * z);
            int e = (x * x) + (y * y);

            if (e==d && e>0 && d>0){
                Console.WriteLine("Trokut je pravokutan.");
            }
            else
            {
                Console.WriteLine("Trokut nije pravokutan.");
            }
            Console.ReadKey();
        }
    }
}
