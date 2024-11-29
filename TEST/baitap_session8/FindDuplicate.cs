class FindDuplicate {
    public static List<int> findDuplicate (List<int> nums, int k)
    {
        // Tạo từ điển để đếm số lần xuất hiện của từng phần tử
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (frequency.ContainsKey(num))
            {
                frequency[num]++;
            }
            else
            {
                frequency[num] = 1;
            }
        }

        // Tạo danh sách chứa các phần tử thỏa mãn điều kiện
        List<int> result = new List<int>();
        foreach (KeyValuePair<int, int> item in frequency)
        {
            if (item.Value >= k)
            {
                result.Add(item.Key);
            }
        }
        return result;
    }
}