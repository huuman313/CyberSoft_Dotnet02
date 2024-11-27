class SinhVien: Nguoi {
    public string lop;
    public double diemTB;
    
    public SinhVien(
        string ID,
        string Ten,
        string ngaySinh,
        string gioiTinh,
        string email,
        string lop,
        double diemTB
        ) : base(ID, Ten, ngaySinh, gioiTinh, email) {
            this.lop = lop;
            this.diemTB = diemTB;
        }

    public override void inthongtin()
    {
        base.inthongtin(); // dùng lại phương thức in thông tin của class cha
        Console.WriteLine($"Lớp: {lop}");
        Console.WriteLine($"Điểm trung bình: {diemTB}");
    }


}