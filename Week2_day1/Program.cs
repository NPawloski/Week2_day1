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

            //int[] numbers = new int[4];
            //numbers[0] = 43;
            //numbers[1] = 12;
            //Console.WriteLine("Please enter a number.");
            //numbers[2] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter a number.");
            //numbers[3] = int.Parse(Console.ReadLine());

            //numbers[3] = 30;

            //Console.WriteLine(numbers[3]);



            //String[] weekdays = new string[7];
            //weekdays[0] = "Mon";
            //weekdays[1] = "Tues";
            //weekdays[2] = "Wed";
            //weekdays[3] = "Thur";
            //weekdays[4] = "Fri";
            //weekdays[5] = "Sat";
            //weekdays[6] = "Sun";

            //int[] studentAges = new int[5];
            //studentAges[0] = 11;
            //studentAges[1] = 14;
            //studentAges[2] = 21;
            //studentAges[3] = 17;
            //studentAges[4] = 9;


            //Console.WriteLine(weekdays.Length);
            //Console.WriteLine(weekdays[1].Length);


            //Char[] lastname = { 'P', 'a', 'w', 'l', 'o', 's', 'k', 'i' };
            //Console.WriteLine(lastname.Length);

            //String[] moreWords = { "word", "stuff", "thing", "Memes", "word" };
            //int wordsLength = moreWords.Length;
            //Console.WriteLine(moreWords[wordsLength - 2]);

            //Console.WriteLine("Please enter an array size.");
            //int arraySize = int.Parse(Console.ReadLine());

            //int[] newArray = new int[arraySize];

            //Console.WriteLine("The length of the array is " + newArray.Length);

            //String[] birthMonths = { "October", "July", "October", "May" };
            //Console.WriteLine(Array.IndexOf(birthMonths, "October"));


            //int[] numbers = { 2, 3, 9, 4, 3, 4, 6, 5 };
            //Console.WriteLine(Array.LastIndexOf(numbers, 4));

            //Array.Reverse(numbers);
            //Console.WriteLine(numbers[0]);

            //Array.Sort(numbers);
            //Console.WriteLine(numbers[numbers.Length - 1]);

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}
            //Console.WriteLine();

            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}
            //Console.WriteLine();


            String[] names = { "Nate", "Dan", "Ali", "Brian", "Monica" };
            Console.WriteLine(Array.IndexOf(names, "Brian"));

            int[] luckyNumbers = { 7, 13, 21, 12, 12, 13, 7, 21 };
            Console.WriteLine(Array.LastIndexOf(luckyNumbers, 13));

            Char[] characters = { 'A', 'B', 'D', 'R', 'N', 'M' };
            Console.WriteLine(characters[0]);
            Array.Reverse(characters);
            Console.WriteLine(characters[0]);

            String[] studentNames = { "Dan", "Nathan", "Brian", "Ali" };
            Array.Sort(studentNames);
            Console.WriteLine(studentNames[0] + " " + studentNames[studentNames.Length - 1]);

            int[] favoriteNumbers = { 7, 2, 1, 21, 13, 92, 99, 79 };
            Array.Sort(favoriteNumbers);
            Console.WriteLine(favoriteNumbers[0] + " " + favoriteNumbers[favoriteNumbers.Length - 1]);





        }
    }
}
