class TinhToan {
    public int length;
    public int width;
    public void nhapthongtin() {
        Console.WriteLine("Mời bạn nhập thông tin các cạnh hình chữ nhật:");
        Console.WriteLine("Chiều dài: ");
        length = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Chiều rộng: ");
        width = Convert.ToInt32(Console.ReadLine());
    }

    public void xuatThongTin() {
        Console.WriteLine($"Diện tích hình chữ nhật là: {length * width}");
        Console.WriteLine($"Chu vi hình chữ nhật là: {(length + width) * 2}");
    }
}