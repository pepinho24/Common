namespace RandomGenerator
{
    using System;

    public class RandomGenerator
    {
        private static RandomGenerator instance;

        private readonly Random random;

        private RandomGenerator()
        {
            this.random = new Random();
        }

        /// <summary>
        /// Gets an instance of the random generator.
        /// </summary>
        public static RandomGenerator Instance
        {
            get
            {
                return instance ?? (instance = new RandomGenerator());
            }
        }

        /// <summary>
        /// Gets a random number from min to max, inclusive.
        /// </summary>
        /// <param name="min">Lower limit.</param>
        /// <param name="max">Upper limit.</param>
        /// <returns>Random number as integer.</returns>
        public int GetRandomNumber(int min, int max)
        {
            return this.random.Next(min, max + 1);
        }

        /// <summary>
        /// Gets a random string with given length.
        /// </summary>
        /// <param name="length">Number of characters of the string.</param>
        /// <returns>The random string.</returns>
        public string GetRandomString(int length)
        {
            var chars = new char[length];

            for (int i = 0; i < length; i++)
            {
                chars[i] = Constants.Letters[this.GetRandomNumber(0, Constants.Letters.Length - 1)];
            }

            return new string(chars);
        }

        /// <summary>
        /// Gets a random first name.
        /// </summary>
        /// <returns>First name as string.</returns>
        public string GetRandomFirstName()
        {
            var randomNumber = this.GetRandomNumber(0, Constants.FirstNames.Length - 1);
            return Constants.FirstNames[randomNumber];
        }

        /// <summary>
        /// Gets a random last name.
        /// </summary>
        /// <returns>Last name as string.</returns>
        public string GetRandomLastName()
        {
            var randomNumber = this.GetRandomNumber(0, Constants.LastNames.Length - 1);
            return Constants.LastNames[randomNumber];
        }

        /// <summary>
        /// Gets a random bulgarian city name.
        /// </summary>
        /// <returns>City name as string.</returns>
        public string GetRandomCityName()
        {
            return Constants.Cities[this.GetRandomNumber(0, Constants.Cities.Length - 1)];
        }

        /// <summary>
        /// Gets a random date in given period. Default dates are 01.01.1995 and 31.12.2050.
        /// </summary>
        /// <param name="startDate">Earliest date. Default is 01.01.1995.</param>
        /// <param name="endDate">Latest date. Default is 31.12.2050.</param>
        /// <returns>Date in the given period as DateTime.</returns>
        public DateTime GetRandomDate(DateTime? startDate = null, DateTime? endDate = null)
        {
            DateTime start = startDate ?? new DateTime(1995, 1, 1);
            DateTime end = endDate ?? new DateTime(2050, 12, 31);
            Random gen = new Random();

            int range = (end - start).Days;
            return start.AddDays(this.GetRandomNumber(0, range - 1));
        }
    }
}
