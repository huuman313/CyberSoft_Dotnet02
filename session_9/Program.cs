internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // bản chất của OOP chính là gom nhóm các biến
        // các biến được gọi là các thuộc tính
        // chữ cái đầu tiên của class phải là in hoa (khi tạo new file .cs)
        #region 
        // BaiViet baiviet1 = new BaiViet();
        // baiviet1.tieuDe = "111 sđa sad sads ad sad";
        // baiviet1.hinhAnh = "hinh1.png";
        // baiviet1.noiDung = "111 dsad sad sadsadsa";
        // // Console.WriteLine($"Bài viết 1: {baiviet1.hinhAnh}, {baiviet1.noiDung}, {baiviet1.tieuDe}");
        // baiviet1.xuatThongTin();
        // Console.WriteLine("=====================");
        //
        // BaiViet baiviet2 = new BaiViet();
        // baiviet2.tieuDe = "222 sđa sad ssad sad ádads ad sad";
        // baiviet2.hinhAnh = "hinh2.png";
        // baiviet2.noiDung = "222 dsad dsa đấ dá sad sadsadsa";
        // // Console.WriteLine($"Bài viết 2: {baiviet2.hinhAnh}, {baiviet2.noiDung}, {baiviet2.tieuDe}");
        // baiviet2.xuatThongTin();
        // Console.WriteLine("=====================");

        // BaiViet baiviet3;
        // baiviet3 = baiviet1;
        // Console.WriteLine($"kiểm tra: {baiviet3 == baiviet1}");
        // baiviet3.hinhAnh = "hinh3.png";
        // Console.WriteLine($"Bài viết 3: {baiviet1.hinhAnh}, {baiviet3.noiDung}, {baiviet3.tieuDe}");
        // Console.WriteLine("=====================");

        // BaiViet baiviet3 = new BaiViet(baiviet1);
        // Console.WriteLine($"kiểm tra: {baiviet3 == baiviet1}");
        // baiviet3.hinhAnh = "hinh3.png";
        // Console.WriteLine($"Bài viết 3: {baiviet1.hinhAnh}, {baiviet3.noiDung}, {baiviet3.tieuDe}");
        // Console.WriteLine("=====================");
        //
        // BaiViet baiviet4 = new BaiViet();
        // baiviet4.hinhAnh = baiviet1.hinhAnh;
        // baiviet4.noiDung = baiviet1.noiDung;
        // baiviet4.tieuDe = baiviet1.tieuDe;
        // Console.WriteLine($"kiểm tra: {baiviet4 == baiviet1}");
        // Console.WriteLine("=====================");
        //
        // BaiViet baiviet5 = new BaiViet();
        // Console.WriteLine($"Giá trị mặc định của thuộc tính noiDung là: {baiviet5.noiDung}");
        
        #endregion

        // default value của các biến có kiểu dữ liệu string là null
        // của integer là số 0
        // của boolean là số 0 (0 và 1)

        // bải tập nhập môn
        // tạo đối tượng học sinh (họ tên, tuổi, giới tính, email)
        // xuất thông tin học sinh
        #region 
        // HocSinh hs1 = new HocSinh();
        // hs1.hoTen = "Nguyễn Hữu Mẫn";
        // hs1.tuoi = 38;
        // hs1.gioiTinh = "Nam";
        // hs1.email = "huuman313@gmail.com";
        // hs1.xuatThongTin();
        // Console.WriteLine("=============");

        // HocSinh hs2 = new HocSinh();
        // hs2.hoTen = "Nguyễn Hữu Mẫn 2";
        // hs2.tuoi = 40;
        // hs2.gioiTinh = "Nam 2";
        // hs2.email = "huuman313@gmail.com 2";
        // hs2.xuatThongTin();
        // Console.WriteLine("=============");      

        // HocSinh hs3 = new HocSinh();
        // hs3.nhapthongtin();
        // hs3.xuatThongTin();
        // Console.WriteLine("=============");      

        #endregion

        // bài tập về nhà
        // Bài 1: tạo đối tượng sản phẩm (mã sp, tên sp, giá bán, số lượng tồn kho)
        // nhập và xuất thông tin sp
    #region        
        // Console.WriteLine("Bài 1: tạo đối tượng sp, nhập và xuất thông tin sp");
        // SanPham sp1 = new SanPham();
        // sp1.nhapthongtin();
        // sp1.xuatThongTin();
        // Console.WriteLine("================");
        // SanPham sp2 = new SanPham();
        // sp2.nhapthongtin();
        // sp2.xuatThongTin();
        // Console.WriteLine("================");
        
    #endregion
        
        
        // Bài 2: nhập thông tin chiều dài và rộng hình chữ nhật => tính chu vi và diện tích
        // length (chiều dài)
        // width (chiều rộng)
        // tính diện tích (area) và chu vi (perimeter)
    #region 
        Console.WriteLine("Bài 2: ");
        TinhToan test1 = new TinhToan();
        test1.nhapthongtin();
        test1.xuatThongTin();
        Console.WriteLine("================");
    #endregion
    }
}

// tổng kết:
// bản chất của class là gom nhóm các biến
// trong class sẽ có 2 thành phần chính
//      + thuộc tính (biến)
//      + phương thức (hàm)
// trong class sẽ có 1 hoặc nhiều hàm khởi tạo (constructor)
// câu hỏi interview:
// BaiViet baiviet1 = new BaiViet();
// BaiViet baiviet2 = new BaiViet();
// => mỗi lần khởi tạo đối tượng thì máy tính sẽ tạo vùng nhớ mới trong RAM
// BaiViet baiviet3;
// baiviet3 = baiviet1;
// => baiviet3 == baiviet1 do baiviet1 và baiviet3 cùng trỏ tới 1 vùng nhớ
// 