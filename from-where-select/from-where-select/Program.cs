namespace from_where_select
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 2, 6, 4, 8, 3, 7, 9, 1, 10 };
            // truy vấn số chia hết cho 2 trong list 
            var a = from b in list where b%2==0 select b;
            var f = from c in list where c%3==0 select c;
            var j =from k in list where k%4==0 select k;
            foreach(var c in a)
            {
                Console.Write(c.ToString());
            }
            Console.WriteLine();
            // số đầu tiên lớn nhất chia hết cho 3
            var d = from g in list where g%3==0 select g;
            var e = d.OrderByDescending(x => x).First();
            Console.WriteLine("số lớn nhất chia hết cho 3 trong list là "+e);
            // tổng số phần tử có thể chia hết cho 2 ,3 ,4
            int s=a.Count()+ f.Count()+ j.Count();
            Console.WriteLine("tong so phan tu co the chia het cho 2 3 4 la :" + s);
        }
    }
}
