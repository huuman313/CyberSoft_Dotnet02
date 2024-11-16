internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

    #region 
    // Tìm 2 số trong 1 danh sách số nguyên sao cho tổng của chúng bằng 1 giá trị target cho trước
    // vd: lst_number = [2,7,11,15], target = 9;
    // Output: [0,1] vì nums[0] = nums[1] = 2 + 7 = 9
    
    // Kiểm tra lại đang lỗi
    // List<int> lst_number = new List<int> {2, 7, 11, 15};
    // int target = 9;
    // for(int i = 0; i < lst_number.Count - 1; i++) {
    //     for(int j = i + 1; j < lst_number.Count; j++) {
    //         if(lst_number[i] + lst_number[j] != target){
    //             Console.WriteLine("Không có cặp số nào");
    //         } else {
    //             Console.WriteLine($"{i} và {j}");
                
    //         } 
    //     }           
    // }
        
    

    // List<int> lst = new List<int>{2, 7, 9, 11, 15};
    // int target = 26;
    // Console.WriteLine("Bài 1: Tìm 2 số trong 1 danh sách");
    // if(TwoSum.twosum(lst, target) == null) {
    //     Console.WriteLine("Không có");
    // } else {
    //     List<int> indexes = TwoSum.twosum(lst, target);
    //     Console.WriteLine($"Chỉ số 2 số là: {string.Join(", ", indexes)}");
    // }
    
    //  Console.WriteLine("Cách 2: dùng dictionary");
    // if(TwoSum.twoSumDictionary(lst, target) == null) {
    //     Console.WriteLine("Không có");
    // } else {
    //     List<int> indexes = TwoSum.twoSumDictionary(lst, target);
    //     Console.WriteLine($"Chỉ số 2 số là: {string.Join(", ", indexes)}");
    // }
    
    #endregion

    #region 
    // "apple", "mango", "melon", "apple", "pineapple", "mango"
    // in ra số lần xuất hiện từng từ trong list trên


    #endregion

    #region khái niệm về cách lưu trữ biến trong máy tính
        int number1 = 10;
        int number2 = number1;
        number1 = 30;
        Console.WriteLine($"number 1 = {number1}, number 2 = {number2}");


    #endregion

    }
}