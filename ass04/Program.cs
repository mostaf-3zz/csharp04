namespace ass04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            bool Flag;
            Console.WriteLine("please enter a integer number ");
            Flag = int.TryParse(Console.ReadLine(), out var Number);
            if (Flag && Number > 0)
            {
                for (int i = 1; i <= Number; i++)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion
        }
    }
}
