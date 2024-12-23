using System.Threading.Channels;

namespace C43_G01_OOP01_assignment
{
    #region  Q1
    /*enum WeekDays
    {
        Monday, Tuesday, Wendesday, Thursday, Friday, Saturday, Sunday
    } */
    #endregion

    #region Q2

    /*struct Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

    }*/
    #endregion

    #region Q3

    /*enum Seasons
    {
        Spring,Summer,Autumn,Winter
    }*/

    #endregion

    #region Q4

    enum Seasons
    {
        Spring, Summer, Autumn, Winter
    }

    #endregion

    #region Q5

    /*enum Colors
    {
        Red,Blue, Green
    }*/

    #endregion

    #region Q6

    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            /*foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine($"today is : {day}");
            }*/


            #endregion

            #region q2

            /* Person[] Persons = new Person[3];

             Persons[0] = new Person { Name= "omar", Age = 44 };
             Persons[1] = new Person { Name = "kareeem", Age = 33 };
             Persons[2] = new Person { Name = "Samy", Age = 34 };

             foreach (Person person in Persons)
             {
                 Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
             }*/


            #endregion

            #region q3

            /*Enum.TryParse(Console.ReadLine(), out Seasons season);

            switch (season)
            {
                case Seasons.Spring:
                    Console.WriteLine("Spring: March to May");
                    break;
                case Seasons.Summer:
                    Console.WriteLine("Summer: June to August");
                    break;
                case Seasons.Autumn:
                    Console.WriteLine("Autumn: September to November");
                    break;
                case Seasons.Winter:
                    Console.WriteLine("Winter: December to February");
                    break;
                default:
                    Console.WriteLine("Invalid season.");
                    break;*/

            #endregion

            #region q4

            #endregion

            #region q5
            /*string input = Console.ReadLine();   
            if (Enum.TryParse(input, true, out Colors color))
            {
                switch (color) 
                { 
                    case Colors.Red:
                    case Colors.Green:
                    case Colors.Blue:
                        Console.WriteLine($"{input} is a primary color.");
                        break; 
                    default: Console.WriteLine($"{input} is not a primary color.");
                        break;
                } 
            } else 
            { 
                Console.WriteLine("Invalid color. Please enter Red, Green, or Blue.");
            }*/

            #endregion

            #region q6



            #endregion


        }


        

    }
}
