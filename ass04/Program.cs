namespace ass04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q8
            Console.WriteLine("plese enter degree of marks");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }

                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
