class SanPham {
    public string maSP;
    public string tenSP;
    public int giaBan;
    public int soLuongTonKho;
    public void nhapthongtin() {
        Console.WriteLine("Mời bạn nhập thông tin SP:");
        Console.WriteLine("Mã SP: ");
        maSP = Console.ReadLine();
        Console.WriteLine("Tên SP:");
        tenSP = Console.ReadLine();
        Console.WriteLine("Giá bán:");
        giaBan = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Số lượng hàng tồn kho:");
        soLuongTonKho = Convert.ToInt32(Console.ReadLine());
    }

    public void xuatThongTin() {
        Console.WriteLine("Thông tin sản phẩm là:");
        Console.WriteLine($"Mã SP: {maSP}");
        Console.WriteLine($"Tên SP: {tenSP}");
        Console.WriteLine($"Giá bán: {giaBan}");
        Console.WriteLine($"Số lượng hàng tồn kho: {soLuongTonKho}");
    }


}