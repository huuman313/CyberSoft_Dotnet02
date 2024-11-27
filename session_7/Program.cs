internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

    #region từ session 6 - nhập n từ bàn phím, sau đó nhập n phần tử và xuất ra n phần tử
    // Console.WriteLine("Mời bạn nhập số lượng phần tử:");
    // string? number = Console.ReadLine();
    // int formatnumber = Convert.ToInt32(number);
    // // Tạo biến chứa danh sách phần tử
    // List<int> listnumbers = new List<int>();
    // for(int i = 0; i < formatnumber; i++) {
    //     Console.WriteLine($"Nhập phần tử thứ {i+1}");
    //     string? item = Console.ReadLine();
    //     int formatItem = Convert.ToInt32(item);
    //     // C1: dùng insert: thêm phần tử vào index thứ i
    //     // listnumbers.Insert(i, formatItem);
        
    //     // C2: dùng add
    //     // Add: thêm phần tử vào cuối danh sách
    //     listnumbers.Add(formatItem); 

    // }
    // // In list phần tử ra ngoài màn hình
    // // có 2 cách duyệt phần tử: for hoặc foreach
    // // C1: for
    // Console.WriteLine("Danh sách phần tử sau khi nhập là: ");
    // for(int i = 0; i < listnumbers.Count; i++) {
    //     Console.WriteLine(listnumbers[i]);
    // }

    // // C2: dùng foreach
    // Console.WriteLine("Danh sách phần tử dùng foreach: ");
    // foreach(int item in listnumbers) {
    //     Console.WriteLine(item);
    // }
    #endregion

    #region function trong list của Collection
    // // khởi tạo danh sách
    // List<int> numbers = new List<int>();
    // // Nhập n từ bàn phím với n là số lượng phần tử của mảng
    // Console.Write("Mời bạn nhập n là số phần tử của mảng: ");
    // string? n = Console.ReadLine();
    // int formatn = Convert.ToInt32(n);
    // for(int i = 0; i < formatn; i++) {
    //     Console.WriteLine($"Mời bạn nhập vào số thứ {i+1}");
    //     int number = Convert.ToInt32(Console.ReadLine());
    //     numbers.Add(number);
    // }
    // Console.WriteLine("Danh sách phần tử đã nhập là: ");
    // foreach(int number in numbers){
    //     Console.Write(number);
    //     Console.Write(", ");
    // }
    // //C1: dùng Join
    // Console.WriteLine();
    // Console.Write(string.Join(", ",numbers));
    // Console.WriteLine();

    // // dùng function Sort để sắp xếp phần tử của mảng
    // numbers.Sort();
    // Console.WriteLine("Danh sách phần tử đã sắp xếp: ");
    // Console.Write(string.Join(", ", numbers));

    // // dùng function Reverse
    // numbers.Reverse();
    // Console.WriteLine();
    // Console.WriteLine("Danh sách phần tử sau khi dùng hàm Reverse: ");
    // Console.Write(string.Join(", ", numbers));

    #endregion

    #region Bài 1: tính tổng các số lớn hơn 50
    // // Khai báo list phần tử
    // List<int> Numbers = new List<int> {20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20, 100};
    // // kết quả của hàm TinhTongSoLon50 sẽ gán cho biến sum
    // int sum = Bai1.TinhTongSoLon50(Numbers);
    // Console.WriteLine($"Tổng các số lớn hơn 50 là: {sum}");
    #endregion

    #region Bài 2: tìm số lớn nhất của mảng
    // // B1: tìm 1 số bất kỳ trong mảng làm số lớn (số đầu tiên của mảng)
    // // B2: duyệt mảng từ phần tử thứ 2 và so sánh với số đại diện
    // // B3: nếu số đại diện nhỏ hơn phần tử đang xét thì gán lại
    // // B4: ngược kại => duyệt tiếp
    // List<int> Numbers = new List<int> {20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20, 100};
    // int max = Bai2.findMaxNumber(Numbers);
    // Console.WriteLine($"Số lớn nhất là: {max}");
    #endregion

    #region Bài 3: tìm tất cả các chuỗi bắt đầu bằng chữ m
    // List<string> lstString = new List<string> {"applem", "banana", "orange", "kiwi", "mango", "pineapple", "grape", "melon"};
    // Console.Write(string.Join(", ", lstString));
    // Console.WriteLine();
    // Console.WriteLine("Chữ bắt đầu bằng m là: ");
    // List<string> results = Bai3.findAllStartM (lstString);
    // foreach(string result in results) {
    //     Console.WriteLine(result);
    // }
    #endregion

    #region Bài 4: remove duplicates
    // // B1: thêm phần tử đầu tiên vào result
    // // B2: duyệt từ phần tử thứ 2 đến hết mảng
    // // Nếu phần tử thứ i có trong result => duyệt tiếp
    // // Ngược lại => add vào result
    // List<int> lstNumbers = new List<int> {1,1,5,2,2,2,3,4,4,5,8,8,11,11};
    // Console.Write(string.Join(", ", lstNumbers));
    // Console.WriteLine();
    // List<int> lstResult = Bai4.uniqueNumber(lstNumbers);
    // Console.WriteLine("Liệt kê các phần tử không trùng nhau:");
    // foreach(int result in lstResult) {
    //     Console.WriteLine(result);
    // }
    #endregion

    #region tìm hiểu về Dictionary trong Collection
    Console.WriteLine("tìm hiểu về Dictionary trong Collection");
    Dictionary<string, string> dic = new Dictionary<string, string>();
    // Thêm key-value vào dic
    dic.Add("Alice", "test");
    dic["Do"] = "Nam Trung";

    // Duyệt dic
    foreach(KeyValuePair<string, string> pointer in dic) {
        // pointer: key-value
        Console.WriteLine($"Họ: {pointer.Key}, Tên: {pointer.Value}");
    }

    // Chỉ duyệt mỗi key hoặc value => y như bên list
    // chỉ duyệt key
    Console.WriteLine("Danh sách các key là:");
    foreach(string str in dic.Keys) {
        Console.WriteLine(str);
    }

    for(int i = 0; i < dic.Keys.Count; i++) {
        Console.WriteLine(dic.Keys.ElementAt(i));
    }

    // update value cho dic
    dic["Alice"] = "Johnon";
    Console.WriteLine("Dic sau khi update: ");
    foreach(KeyValuePair<string, string> pointer in dic) {
        Console.WriteLine($"Họ: {pointer.Key}, Tên: {pointer.Value}");
    }

    // xóa key-value trong dic
    dic.Remove("Alice");
    Console.WriteLine("Dic sau khi remove: ");
    foreach(KeyValuePair<string, string> pointer in dic) {
        Console.WriteLine($"Họ: {pointer.Key}, Tên: {pointer.Value}");
    }
    
    Console.WriteLine($"Giá trị {dic["Do"]}");

    #endregion
       
    
    
    }
}