namespace Task_1_23._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sorted = new SortedList<int, string>();

            sorted.Add(2000, "C#");

            sorted.Add(1995, "Java");

            sorted.Add(1979, "C++");

            sorted.Add(1994, "Python");

            sorted.Add(1996, "JavaScript");

            sorted.Add(1972, "C");

            foreach(var item in sorted)
            {
                Console.WriteLine(item.Key +" "+item.Value);
            }
        }
    }
}