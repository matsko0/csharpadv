namespace Class06Homework
{
    public static class ListHelper
    {
        public static void PrintSimple<T>(this List<T> list)
        {
            Console.WriteLine($"Printing {list.Count} items:");
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public static void PrintEntities<T>(this List<T> list)
        {
            Console.WriteLine($"Printing {list.Count} items:");
            foreach (T item in list)
            {
                Console.WriteLine(item.ToString());   
            }
        }

    }
}
