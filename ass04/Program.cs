namespace ass04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q9

            Console.WriteLine("please enter a string ");
            string str = Console.ReadLine();
            int start, end;
            Console.WriteLine("please enter start");
            start = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter end");
            end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                Console.Write(str[i]);
            }
            #endregion
        }
    }
}
