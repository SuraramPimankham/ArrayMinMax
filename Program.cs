namespace ArrayMinMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("-------data-------");

            foreach (int data in num)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("-------Max-------");
            Console.WriteLine(num.Max());
            Console.WriteLine("-------Min-------");
            Console.WriteLine(num.Min());
        }
    }
}