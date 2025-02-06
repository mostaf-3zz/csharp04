namespace ass04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q6
            Console.WriteLine("please enter a start");
            int Start = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter a end ");
            int End = int.Parse(Console.ReadLine());
            for (int i = Start; i <= End; ++i)
            {

                Console.WriteLine($"{i}");
            }
            #endregion
        }
    }
}
