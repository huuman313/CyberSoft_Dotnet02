class Bai4 {
    public static List<int> uniqueNumber (List<int> numbers) {
        List<int> results = new List<int>();
        results.Add(numbers.ElementAt(0));
        for(int i = 1; i < numbers.Count; i++) {
            // C1:
            if(results.Contains(numbers[i]) == false) {
                results.Add(numbers[i]);
            // // C2: so sánh phần tử đằng trước
            // if(numbers[i] != numbers[i-1]) {
            //     results.Add(numbers[i]);
                }
            }
            return results;
        }
        
    }