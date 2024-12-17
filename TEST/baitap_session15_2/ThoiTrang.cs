public class ThoiTrang : SanPham
{
    private double giamGia;
    public double GiamGia
    {
        get { return giamGia; }
        set { giamGia = value; }
    }
    public ThoiTrang(
        string maSanPham,
        string tenSanPham,
        double giaGoc,
        double giamGia
    ) : base(maSanPham, tenSanPham, giaGoc)
    {
        this.giamGia = giamGia;
    }
    public override double TinhGiaBan()
    {
        return GiaGoc - (GiaGoc * GiamGia / 100);
    }

    public override void displayInfo()
    {
        base.displayInfo();
        Console.WriteLine($"Giảm giá theo mùa: {GiamGia}%");
    }
}
