class tudienAnhViet {
    public static void process () {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        // 1. Thêm từ
        // 2. Tra từ
        // 3. Xóa từ
        // 4. Thoát
        while(true) { // dừng đến khi user nhập vào option 4: thoát và dừng chương trình
            Console.WriteLine("1. Thêm từ");
            Console.WriteLine("2. Tra từ");
            Console.WriteLine("3. Xóa từ");
            Console.WriteLine("4. Tìm từ tiếng Anh dựa vào tiếng Việt");
            Console.WriteLine("5. Thoát");
            Console.WriteLine("Mời bạn chọn 1 chức năng: ");
            int choice = Convert.ToInt32(Console.ReadLine()); // in choice = in.Parse(Console.Readline())

            if(choice == 1) {
                Console.WriteLine("Mời bạn nhập từ tiếng Anh: ");
                string english = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập tiếng Việt tương ứng: ");
                string vietnamese = Console.ReadLine();
                // Thêm english-vietnamese vào dictionary
                // C1:
                dictionary[english] = vietnamese;
                // // C2:
                // dictionary.Add(english, vietnamese);
                Console.WriteLine("Đã thêm thành công");

            } else if (choice == 2) {
                Console.WriteLine("Mời bạn nhập từ cần tra: ");
                string english = Console.ReadLine();
                // ContainKeys để tìm cặp Key-Value
                if(dictionary.ContainsKey(english)) {
                Console.WriteLine($"Nghĩa của từ {english} là: {dictionary[english]}");
                } else {
                    Console.WriteLine("Từ này chưa có trong từ điển");
                }
                Console.WriteLine("-----------------------------------");

            } else if (choice == 3) {
                // remove để xóa từ trong từ điển
                Console.WriteLine("Mời bạn nhập từ cần xóa: ");
                string english = Console.ReadLine();
                if(dictionary.Remove(english) == true) {
                    Console.WriteLine("Xóa từ thành công");
                } else {
                    Console.WriteLine("Từ này không tồn tại trong từ điển");
                }
                Console.WriteLine("-----------------------------------");

            } else if (choice == 4) {
                Console.WriteLine("Mời bạn nhập từ tiếng Việt cần tra: ");
                string vietnamese = Console.ReadLine();
                // duyệt từng key-value trong dictionary và so sánh với value nhập từ bàn phím
                string englishOutput = null; // biến flag để đánh dấu. Nếu không tìm thấy từ tiếng Anh tương ứng => không tìm thấy
                foreach(KeyValuePair<string, string> pointer in dictionary) {
                    //C1:
                    if(pointer.Value == vietnamese) {
                        englishOutput = pointer.Key;
                        break; // nếu tìm thấy rồi thì không duyệt dic nữa
                    }
                    // Console.WriteLine($"Nghĩa của từ {vietnamese} là: {dictionary.Keys}")
                }
                if(englishOutput != null) {
                    Console.WriteLine($"Từ tiếng Anh tương ứng là: {englishOutput}");
                } else {
                    Console.WriteLine("Không tìm thấy từ tương ứng");
                }
                Console.WriteLine("-----------------------------------");
            } else {
                break;
            }
        }


    }
}