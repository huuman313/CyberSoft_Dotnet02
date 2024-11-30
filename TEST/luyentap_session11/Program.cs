internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("-------------------------");
        #region làm lại bài tập 2 tại session 11
        // 1. Tạo class book để quản lý sách (class cha)
        // - bookId: mã sách
        // - bookName: tên sách
        // - author: tác giả
        // - price: giá sách
        // 1.1 tạo class Textbook kế thừa từ Book
        // - subjtect: môn học
        // - grade: lớp
        // 1.2 Tạo class ReferenceBook kế thừa từ book
        // - topic: chủ đề
        // - publisher: nhà xuất bản
        // 1.3 Tạo class FictionBook kế thừa từ Book
        // - genre: thể loại
        // - year: năm xuất bản
        // ----------------------
        // 2. Tạo class library để quản lý thư viện
        // - libraryId: mã thư viện
        // - libraryName: tên thư viện
        // - danh sách sách trong thư viện
        // - file json lưu thông tin sách (nâng cao)
        // ----------------------
        // 3. Yêu cầu chức năng
        // - thêm sách vào thư viện (lưu sách mới vào file json - sử dụng thư viện Newtonsoft.Json)
        // - check xem mã sách đã tồn tại chưa. Nếu có rồi thì báo lỗi
        // - hiển thị danh sách sách trong thư viện (đọc file json)
        // - tìm sách theo mã sách
        // 4. Thoát

        Console.WriteLine("Nhập mã thư viện:");
        string libraryId = Console.ReadLine();

        Console.WriteLine("Nhập tên thư viện");
        string libraryName = Console.ReadLine();

        LibraryManager libraryManager = new LibraryManager(libraryId, libraryName);

        // Tạo menu
        bool isRunning = true;
        while (isRunning) {
            Console.WriteLine("\n === Library Management Menu ===");
            Console.WriteLine("1. Thêm sách giáo khoa vào thư viện");
            Console.WriteLine("2. Thêm sách tham khảo vào thư viện");
            Console.WriteLine("3. Thêm sách tiểu thuyết vào thư viện");
            Console.WriteLine("4. Hiển thị danh sách các sách trong thư viện");
            Console.WriteLine("5. Tìm sách theo mã sách");
            Console.WriteLine("6. Thoát");
            Console.WriteLine("Vui lòng chọn chức năng (1-6)");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice) {
                case 1:
                    libraryManager.addTextBook();
                    break;
                case 2:
                    libraryManager.addReferenceBook();
                    break;
                case 3:
                    libraryManager.addFictionBook();
                    break;
                case 4:
                    libraryManager.displayAllBook();
                    break;
                case 5:
                    // thêm code sau
                    break;
                case 6:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Vui lòng chọn chức năng (1-6)");
                    break;
            }
        }

        Console.WriteLine("-------------------------");
        #endregion

        #region Bài 2: quản lý phương tiện giao thông (xe hơi, xe máy)
            // 1. Tạo class cha Vehicle
            // - vehicleId: mã phương tiện
            // - brand: hãng xe
            // - year: năm sản xuất
            // - price: giá xe
            // 1.1 Tạo class Car kế thừa từ Vehicle
            // - model: dòng xe
            // - color: màu xe
            // - engine: dung tích động cơ
            // 1.2 Tạo class Motor kế thừa từ Vehicle
            // - type: loại xe (số tay, số tự động)
            // - power: công suất
            // Tạo class VehicleManager để quản lý phương tiện giao thông
            // - danh sách phương tiện
            // - file json lưu thông tin phương tiện (nâng cao)
            // 3. Yêu cầu chức năng
            // - Thêm phương tiện vào danh sách
            // * check xem mã phương tiện đã tồn tại chưa. Nếu có rồi thì báo lỗi.
            // lưu phương tiện mới vào file json (sử dụng thư viện Newtonsoft.Json)
            // - Hiển thị danh sách phương tiện
            // - Tìm phương tiện theo mã phương tiện
            // - Thoát


        #endregion

    }
}