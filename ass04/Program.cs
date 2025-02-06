namespace ass04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q5

            Console.WriteLine("please enter string");
            string tex = Console.ReadLine();
            for (int i = 0; i < tex.Length; i++)
            {
                Console.Write(tex[tex.Length - 1 - i]);
            }

            #endregion
        }
    }
}
