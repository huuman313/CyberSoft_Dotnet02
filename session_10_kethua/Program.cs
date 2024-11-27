internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // 4 tính chất trong OOP
        // - Tính kế thừa: class con kế thừa (sở hữu) các thuộc tính (biến) và phương thức của class cha
        // - Tính đóng gói
        // - Tính trừu tượng
        // - Tính đa hình

        // Bài tập mẫu: Trong công ty có 3 đối tượng: nhân viên, trưởng nhóm, quản lý
        // Lập trình quản lý nhân sự trong công ty
        // Nhân viên: mã nhân viên, tên, ngày sinh, giới tính, tuổi, lương
        // tính lương: nhân viên = 1000

        // Trưởng nhóm: mã nhân viên, tên, ngày sinh, giới tính, tuổi, lương, mã quản lý nhóm
        // tính lương: trưởng nhóm = 1000 + hệ số * 1000

        // Quản lý: mã nhân viên, tên, ngày sinh, giới tính, tuổi, lương, mã quản lý nhóm, thư ký
        // tính lương: quản lý = 1000 + hệ số * 1000 + 500

        TruongNhom truongNhom = new TruongNhom();
        Console.WriteLine($"Tính lương trưởng nhóm: {truongNhom.tinhLuong()}");


        // truongNhom.HoTen = "Nguyễn Văn A";
        // truongNhom.MaNV = "NV123";
        // Console.WriteLine($"Tên trưởng nhóm: {truongNhom.HoTen}");
        // Console.WriteLine($"Mã nhân viên: {truongNhom.MaNV}");

        // Phạm vi truy cập của thuộc tính và phương thức
        // Public: có thể truy cập từ bất kỳ đâu: class con, bên ngoài class

        // Private: class con và bên ngoài class không thể truy cập. Chỉ có thể truy cập từ chính class đó
       
        // Protected: class con có thể truy cập các thuộc tính của class cha
        // nhưng bên ngoài class thì không thể truy cập.

        QuanLy quanLy = new QuanLy();
        // quanLy.Luong = 10000;
        Console.WriteLine($"Lương Quản lý: {quanLy.tinhLuong()}");

        // C# check class QuanLy để tìm thuộc tính Luong.
        // Nếu không có thì check class cha (TruongNhom)
        // Nếu vẫn không có thì check class cha của class cha (NhanVien)

        // lưu ý: override
        // nếu class con không muốn các logic phương thức class cha
        // => có thể viết lại phương thức đó trong class cha
        // nếu class con muốn dùng lại logic phương thức class cha
        // => có thể dùng từ khóa base.tenphuongthuc() để gọi phương thức của class cha

        // BT ôn lại
        // Sinh viên, giảng viên, cán bộ trong trường học
        // Viết chương trình quản lý những đối tượng trên
        // Class: Nguoi: ID, tên, ngày sinh, giới tính, email
        // Sinh viên: ID, tên, ngày sinh, giới tính, email, lớp, điểm trung bình
        // Giảng viên: ID, tên, ngày sinh, giới tính, email, chuyên ngành, học vị
        // Cán bộ: ID, tên, ngày sinh, giới tính, email, chức vụ, phòng ban 

        SinhVien sinhVien = new SinhVien("SV001", "Nguyễn Văn A", "01/01/2000", "Nam", "vana@gmail.com", "Lớp IT01", 8.5);
        sinhVien.inthongtin();

    }
}