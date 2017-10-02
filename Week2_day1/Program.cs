using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_day1
{
    class Program
    {
        static void Main(string[] args)
        {


            //int[] favoriteNumbers = { 1, 2, 3, 4, 5, 6 };

            //String[] studentNames = { "Raz", "Monica", "David", "Brian", "Ali" };

            //Console.WriteLine (favoriteNumbers[3]);
            //Console.WriteLine(studentNames[1]);


            //String[] vacationSpots = { "home", "home", "home", "home", "home" };
            //Console.WriteLine(vacationSpots[0] + " " + vacationSpots[4]);

            //int[] childAges = { 1, 3, 5 };
            //Console.WriteLine(childAges[0] + " " + childAges[1] + " " + childAges[2]);

            //double[] gpas = { 2.2, 3.1, 3.9, 4.0, 1.9, 3.3, 2.7, 4.2 };

            //String[] firstInitials = { "D", "L", "B", "R" };

            int[] numbers = new int[4];
            numbers[0] = 43;
            numbers[1] = 12;
            Console.WriteLine("Please enter a number.");
            numbers[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number.");
            numbers[3] = int.Parse(Console.ReadLine());

            Console.WriteLine(numbers[3]);

        }
    }
}
