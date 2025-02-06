namespace ass04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q2


            Console.WriteLine("please enter an intger number");
            int.TryParse(Console.ReadLine(), out int Number);
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} * {Number} = {i * Number}");
            }
            #endregion
        }
    }
}
