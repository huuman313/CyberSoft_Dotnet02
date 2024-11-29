class UniqueList {
public static List<int> RemoveDuplicates(List <int> nums)
    {
        List<int> uniqueList = new List<int>();
        foreach (int num in nums)
        {
            // Chỉ thêm vào danh sách nếu chưa tồn tại
            if (uniqueList.Contains(num) == false)
            {
                uniqueList.Add(num);
            }
        }
        return uniqueList;
    }
}