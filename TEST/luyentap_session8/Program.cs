internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Bài 1: từ điển Anh - Việt");
        tudienAnhViet.process();
        Console.WriteLine("---------------------");
        Console.WriteLine("Bài 2: Tần suất xuất hiện các từ trong đoạn văn");
        WordCount.process();
        Console.WriteLine("Bài 3: Quản lý danh sách học sinh, tương tự bài từ điển Anh - Việt");
    }
}