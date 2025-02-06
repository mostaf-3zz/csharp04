namespace ass04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q3
            Console.WriteLine("please enter a number");
            int.TryParse(Console.ReadLine(), out int Number);
            for (int i = 1; i < Number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            #endregion
        }
    }
}
