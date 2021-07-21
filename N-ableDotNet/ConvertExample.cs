using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_ableDotNet
{
    public static class ConvertExample
    {
        public static void ConvertExampleDoubleToInt()
        {
            double temp = 12.3654895239;
            Console.WriteLine($"Double: {temp} \nConvert to int: {Convert.ToInt32(temp)}");
        }

        public static void ConvertExampleStringToInt()
        {
            var temp = "123";
            Console.WriteLine($"String: {temp} \nConvert to int: {Convert.ToInt32(temp)}");

            try
            {
                temp = "qwe";
                Console.WriteLine($"String: {temp}");
                Console.WriteLine($"Convert to int: {Convert.ToInt32(temp)}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void ConvertExampleFloatToInt()
        {
            float temp = 12.365483749f;
            Console.WriteLine($"Float: {temp} \nConvert to int: {Convert.ToInt32(temp)}");
        }

        public static void ConvertExampleDataTimeToString()
        {
            DateTime data = new DateTime();
            Console.WriteLine($"DataTime convert to string: {data.ToString()}");

            data = DateTime.UtcNow;
            Console.WriteLine($"DataTime convert to string: {data.ToString("d")}");
            Console.WriteLine($"DataTime convert to string: {data.ToString("D")}");
            Console.WriteLine($"DataTime convert to string: {data.ToString("hh:mm:ss")}");
            Console.WriteLine($"DataTime convert to string: {data.ToString("dd.MM.yyyy hh:mm:ss")}");
            Console.WriteLine($"DataTime convert to string: {data.ToString("dddd MMMM yyyy")}");
        }

        public static void ConvertExampleDecimal()
        {
            decimal temp = 1.25M;
            //Decimal.
        }
    }
}
