namespace ass04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q14
            int[] Numbers = new int[7] { 1, 2, 3, 2, 5, 4, 5 };
            int counter = 0;
            for (int i = 0; i < Numbers.Length; i++)
            {
                for (int j = 0; j < Numbers.Length; j++)
                {
                    if (Numbers[i] == Numbers[j])
                    {
                        counter++;
                    }
                }
                Console.WriteLine($"{Numbers[i]} is repated {counter} times");
                counter = 0;
            }
            #endregion
        }
    }
}
