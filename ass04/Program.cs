namespace ass04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q18
            Console.WriteLine("please enter number of rows");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter a number of coulmns");
            int columns = int.Parse(Console.ReadLine());
            int[,] Numbers1 = new int[rows, columns];
            int[,] Numbers2 = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"enter value of row{i + 1}");

                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine("please enter value of coulmns ");
                    Numbers1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Array.Copy(Numbers1, Numbers2, Numbers2.Length);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine(Numbers2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
