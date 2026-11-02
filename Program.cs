namespace _2D_arrays_10B1_26_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[4];
            int[,] numbers = new int[3, 4];

            double[,] price = { { 53.123, 123.64 }, { 625.32, 635.453 }, { 12312.53, 5243762.4 } };
            Console.WriteLine(price.GetLength(0));
            Console.WriteLine(price.GetLength(1));
            Console.WriteLine(price.Length);
            for (int i = 0; i < price.GetLength(0); i++)
            {
                for (int j = 0; j < price.GetLength(1); j++)
                {
                    Console.WriteLine(price[i, j]);
                }
            }

            //Task 1
            double[] WeekTemp = new double[7];
            double weekAvg = 0;
            for (int i = 0; i < WeekTemp.Length; i++) {
                Console.WriteLine("What was the temp on day " + i);
                WeekTemp[i] = Convert.ToDouble(Console.ReadLine());
                weekAvg += WeekTemp[i];
            }
            weekAvg = weekAvg / WeekTemp.Length;
            Console.WriteLine($"the weekly average was {weekAvg}");

            //Task 2
            double[,] monthlyTemp = new double[4, 7];
            double monthlyAvg = 0;
            for (int i = 0; i < monthlyTemp.GetLength(0); i++)
            {
                for (int j = 0; j < monthlyTemp.GetLength(1); j++)
                {
                    Console.WriteLine("What was the temp on week " + i+1 +" day " + j+1);
                    monthlyTemp[i, j] = Convert.ToDouble(Console.ReadLine());
                    monthlyAvg += monthlyTemp[i, j];
                }
            }
            monthlyAvg = monthlyAvg / monthlyTemp.Length;


        }
    }
}
