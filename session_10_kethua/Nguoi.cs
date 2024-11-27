class Nguoi {
    public string ID;
    public string Ten;
    public string ngaySinh;
    public string gioiTinh;
    public string email;
    
    public Nguoi(string ID, string Ten, string ngaySinh, string gioiTinh, string email) {
        this.ID = ID;
        this.Ten = Ten;
        this.ngaySinh = ngaySinh;
        this.gioiTinh = gioiTinh;
        this.email = email;
    }

    public virtual void inthongtin() {
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Tên: {Ten}");
        Console.WriteLine($"Ngày sinh: {ngaySinh}");
        Console.WriteLine($"Giới tính: {gioiTinh}");
        Console.WriteLine($"email: {email}");
    }



}