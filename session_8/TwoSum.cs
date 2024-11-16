using System.ComponentModel.DataAnnotations;

class TwoSum {
    public static List<int> twosum (List<int> lst, int target) {
        for(int i = 0; i < lst.Count - 1; i++) {
            for(int j = i + 1; j < lst.Count; j++) {
                if(lst[i] + lst[j] == target) {
                    return new List<int>{i, j};
                }
            }
        }
        return null;
    }

    public static List<int> twoSumDictionary (List<int> lst, int target) {
        // khai báo Dictionary để đánh dấu từng số trong danh sách
        Dictionary<int, int> seenNumbers = new Dictionary<int, int>();
        for(int i = 0; i < lst.Count; i++) {
            int completion = target - lst[i];
            if(seenNumbers.ContainsKey(completion)) {
                return new List<int> {seenNumbers[completion], i};
            } else {
                // nếu completion không nằm trong dic thì add vào dic để đánh dấu
                seenNumbers.Add(lst[i], i);
            }
        }
        return null;
    }
}