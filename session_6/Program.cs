internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    #region kiểm tra số nguyên tố
        // Console.WriteLine("Mời bạn nhập số: ");
        // string? number = Console.ReadLine();
        // int formatnumber = Convert.ToInt32(number);
        // bool isPrime = Method.checkPrime(formatnumber);
        // // if(Method.checkPrime(formatnumber))
        // if (isPrime == true) {
        //     Console.WriteLine($"Số {number} là số nguyên tố");
        // } else {
        //     Console.WriteLine($"Số {number} không là số nguyên tố");
        // }

    #endregion

    #region in ra tam giác vuông cân có chiều cao n nhập từ bàn phím
    // Console.Write("Mời bạn nhập chiều cao tam giác vuông cân: ");
    // string? height = Console.ReadLine();
    // int formatheight = Convert.ToInt32(height);
    // Method.printSquareTriangle(formatheight);
    #endregion

    #region Collection trong C#
    // // data structure
    // // List
    // List<int> numbers = new List<int>();    

    // // define giá trị ban đầu
    // List<string> names = new List<string> {"Phương", "Đức", "Linh", "Hưng", "Trí"};
    // //                              index     0        1       2       3      4
    // //                       reverseIndex    ^5       ^4      ^3      ^2     ^1
    // Console.WriteLine($"Phần tử thứ 2 là: {names[2]}");
    // Console.WriteLine($"Phần tử nghịch đảo là: {names[^3]}");
    // // Console.WriteLine(names);
    // // Lưu ý: WriteLine chỉ in được giá trị cho những kiểu dữ liệu nguyên thủy như: int, float, double, string...
    // // Còn kiểu dữ liệu Collection thì chỉ in ra địa chỉ vùng nhớ của biến đó
    // Console.Write(string.Join(", ",names));
    #endregion

    #region nhập n từ bàn phím, sau đó nhập n phần tử và xuất ra n phần tử
    Console.WriteLine("Mời bạn nhập số lượng phần tử:");
    string number = Console.ReadLine();
    int formatnumber = Convert.ToInt32(number);
    // Tạo biến chứa danh sách phần tử
    List<int> listnumbers = new List<int>();
    for(int i = 0; i < formatnumber; i++) {
        // C1: dùng insert
        Console.WriteLine($"Nhập phần tử thứ {i+1}");
        string? item = Console.ReadLine();
        int formatItem = Convert.ToInt32(item);
        listnumbers.Insert(i, formatItem);
    }
    // In list phần tử ra ngoài màn hình
    // có 2 cách duyệt phần tử: for hoặc foreach
    // C1: for
    Console.WriteLine("Danh sách phần tử sau khi nhập là: ");
    for(int i = 0; i < listnumbers.Count; i++) {
        Console.WriteLine(listnumbers[i]);
    }

    // C2: dùng foreach
    Console.WriteLine("Danh sách phần tử dùng foreach: ");
    foreach(int item in listnumbers) {
        Console.WriteLine(item);
    }


    #endregion

    }
}