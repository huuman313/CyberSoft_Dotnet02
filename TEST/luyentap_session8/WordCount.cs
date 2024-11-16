class WordCount {
    public static void process() {
        Console.WriteLine("Mời bạn nhập vào đoạn văn: ");
        string text = Console.ReadLine();
        // B1: tách từ
        // B2: làm tương tự như session 8
        string[] words = text.Split(new[] {' ', ',', '.', '!', '?', ':', '-'});
        Dictionary<string, int> wordCounts = new Dictionary<string, int>();
        foreach (string word in words) {
            // chuyển các từ về viết thường. vd: Many, many
            string lowerWord = word.ToLower();
            if(wordCounts.ContainsKey(lowerWord)) {
                wordCounts[lowerWord]++;
            } else {
                wordCounts[lowerWord] = 1;
            }
        }
        Console.WriteLine("Số lần xuất hiện từng từ là: ");
        foreach(KeyValuePair<string, int> pointer in wordCounts) {
            Console.WriteLine($"{pointer.Key}: {pointer.Value}");
        }
    }
}