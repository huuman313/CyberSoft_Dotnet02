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

}