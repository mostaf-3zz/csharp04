namespace ass04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q4
            int result = 1;
            Console.WriteLine("please enter the base ");
            int.TryParse(Console.ReadLine(), out int Base);
            Console.WriteLine("please enter the foundation");
            int.TryParse(Console.ReadLine(), out int Found);
            for (int i = 1; i <= Found; i++)
            {
                result *= Base;

            }
            Console.WriteLine(result);
            #endregion
        }
    }
}
