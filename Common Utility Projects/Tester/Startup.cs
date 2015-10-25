namespace Tester
{
    using System;
    using RandomGenerator;

    public class Startup
    {
        public static void Main()
        {
            TestRandomClass();            
        }

        private static void TestRandomClass()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            var random = RandomGenerator.Instance;

            // PrintRandomNumbers(random);
            // PrintRandomNames(random);
            // PrintRandomCities(random);
            // PrintRandomDates(random);   
            // PrintRandomString(random);
        }

        private static void PrintRandomString(RandomGenerator random)
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(random.GetRandomString(i + 1));
            }
        }

        private static void PrintRandomDates(RandomGenerator random)
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(random.GetRandomDate());
            }
        }

        private static void PrintRandomCities(RandomGenerator random)
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(random.GetRandomCityName());
            }
        }

        private static void PrintRandomNames(RandomGenerator random)
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(random.GetRandomFirstName() + " " + random.GetRandomLastName());
            }
        }

        private static void PrintRandomNumbers(RandomGenerator random)
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(random.GetRandomNumber(1, 5));
            }
        }
    }
}
