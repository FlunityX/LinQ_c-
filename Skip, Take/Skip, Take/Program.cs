namespace Skip__Take
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 2, 6, 4, 8, 3, 7, 9, 1, 10 };
            var a = list.Take(2);
            var b= list.Skip(3);
            foreach(var x in a)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine();
            foreach (var x1 in b)
            {
                Console.Write(x1+" ");
            }
           
            Console.ReadLine();
        }
    }
}
