namespace _2D_arrays_10B1_26_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[4];
            int[,] numbers = new int[3,4];

            double[,] price = {{53.123, 123.64},{625.32, 635.453},{12312.53, 5243762.4}};
            Console.WriteLine(price.GetLength(0));
            Console.WriteLine(price.GetLength(1));
            Console.WriteLine(price.Length);
            for (int i = 0; i < price.GetLength(0); i++)
            {
                for (int j = 0; j < price.GetLength(1); j++) 
                {
                    Console.WriteLine(price[i,j]);
                }
            }
        }
    }
}
