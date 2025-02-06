namespace ass04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q12
            Console.WriteLine("Please enter the size of array");
            int size = int.Parse(Console.ReadLine()), sum = 0;
            int[] Numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"please ener array element no {i}");
                Numbers[i] = int.Parse(Console.ReadLine());
                sum += Numbers[i];

            }
            Console.WriteLine($"Sum of elements of array is {sum}");
            #endregion
        }
    }
}
