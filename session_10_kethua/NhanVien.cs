class NhanVien {
    protected string MaNV;
    private string HoTen {get; set;}
    // mục đích dùng getter và setter để truy cập vào các thuộc tính private
    public string NgaySinh;
    public int Tuoi;
    public string GioiTinh;
    public double Luong;
    
    // overload: nạp chồng phương thức
    // override: ghi đè phương thức
    public virtual double tinhLuong() {
        return 1000;
    }

}