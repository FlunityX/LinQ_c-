namespace all_any
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 2, 6, 4, 8, 3, 7, 9, 1, 10 };
            // tất cả các phần tử có %2 ko 
            bool a = list.All(x => x % 2 ==0);
            Console.WriteLine(a? "tất cả đều chia hết cho 2 ":"trong danh sách có phần tử ko chia hết cho 2");
            // tất cả phần tử nhỏ hơn 20 ko 
            bool b = list.All(x => x < 20);
            Console.WriteLine(b ? "tất cả đều nhỏ hơn 20" : "trong danh sách có phần tử lớn hơn 20");
            // tìm phần tử lớn hơn 5 lớn nhất
            bool c = list.Any(x=> x >5);
            var max = list.Select(x=>x>5).Max();
            Console.WriteLine(c ? "tất cả đều nhỏ hơn 5" : "trong danh sách có phần tử nhỏ hơn 5");
            Console.WriteLine("phần từ lớn nhất lớn hơn 5 là " + max);
            Console.ReadLine();

        }
    }
}
