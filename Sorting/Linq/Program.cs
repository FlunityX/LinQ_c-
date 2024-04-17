namespace sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // orderby cho phép mảng đc sắp xếp theo tròng tự tăng dần và orderbyDescending thì ngược lại 
           List<int> list = new List<int>() { 2,6,4,8,3,7,9,1,10};
           var sorting = list.OrderBy(x => x).ToList();
           var sortingDescending = list.OrderByDescending(x => x).ToList();
           Console.WriteLine("Ascending order:");
           foreach (var item in sorting)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Descending order:");
            foreach (var itemdesc in sortingDescending)
            {
                Console.Write(itemdesc + " ");
            }

            Console.ReadLine();
        }
    }
}
