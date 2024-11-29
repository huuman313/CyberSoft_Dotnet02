using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("--------------------------");

    #region Bài 1: tính tổng các số trong mảng
        // Console.WriteLine("Bài 1: tính tổng các số trong mảng: 20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20");       
        // List <int> lstNumber = new List<int> {20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20};
        // int sum = 0;
        // foreach (int number in lstNumber)
        // {
        //     sum += number;
        // }
        // Console.WriteLine($"Tổng của tất cả các số trong mảng là: {sum}");
        // Console.WriteLine("--------------------------");
    #endregion

    #region Bài 2: Tìm hai số trong danh sách sao cho tổng của chúng bằng giá trị target
        // List<int> lst = new List<int>{2, 7, 9, 11, 15};
        // int target = 18;
        // Console.WriteLine("Bài 2: Tìm 2 số trong 1 danh sách");
        // if(TwoSum.twosum(lst, target) == null) {
        //     Console.WriteLine("Không có");
        // } else {
        //     List<int> indexes = TwoSum.twosum(lst, target);
        //     Console.WriteLine($"Chỉ số 2 số là: {string.Join(", ", indexes)}");
        // }
        // Console.WriteLine("--------------------------");
    #endregion


    #region Bài 3: Remove duplicates from sorted Array(Easy)
        // Console.WriteLine("Bài 3: Remove duplicates from sorted Array(Easy)");
        // List<int> lstNumber = new List<int> {1, 1, 2, 2, 2, 3, 4, 4, 5};
        // lstNumber.Sort();
        // List<int> uniqueList = UniqueList.RemoveDuplicates(lstNumber);
        // Console.WriteLine($"Chiều dài của mảng mới là: {uniqueList.Count}");
        // Console.WriteLine($"Mảng mới là: {string.Join(", ", uniqueList)}");
        // Console.WriteLine("--------------------------");
    #endregion

    
    #region Bài 4: Remove duplicates from sorted Array(Easy)
        // Console.WriteLine("Bài 4: Remove duplicates from sorted Array(Easy)");
        // List<int> lstNumber = new List<int> {1, 1, 1, 2, 2, 3};
        // int k = 2;
        // lstNumber.Sort();
        // Console.WriteLine($"Danh sách list là: {string.Join(", ", lstNumber)}");
        // List<int> result = FindDuplicate.findDuplicate(lstNumber, k);
        // Console.WriteLine($"Các phần tử xuất hiện ít nhất {k} lần là: {string.Join(", ", result)}");
        // Console.WriteLine("--------------------------");
    #endregion

    
    #region Bài 5: Best time to Buy and Sell Stock
        // Console.WriteLine("Bài 5: Best time to Buy and Sell Stock: (7, 1, 5, 3, 6, 4)");
        // List<int> prices = new List<int> { 7, 1, 5, 3, 6, 4 };
        // int maxProfit = MaxProfit.maxProfit(prices);
        // Console.WriteLine($"Lợi nhuận lớn nhất là: {maxProfit}");
    #endregion
    }
}