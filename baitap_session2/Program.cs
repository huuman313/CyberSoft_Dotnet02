// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region Bài tập 1 - Buổi 2 - Tính số ngày trong tuần và số ngày lẻ
// // Input
// // Nhập số ngày cần tính từ bàn phím
// Console.WriteLine("Bài tập 1 - Tính số ngày trong tuần và số ngày lẻ");
// Console.WriteLine($"Nhập số ngày cần tính: ");
// string songay = Console.ReadLine();
// int formatsongay = Convert.ToInt32(songay);

// // Output
// int sotuan = 0;
// int songayle = 0;

// // Process
// // Tính ra bao nhiêu tuần và bao nhiêu ngày lẻ
// // Tính số tuần
// sotuan = formatsongay / 7;
// Console.WriteLine($"Số tuần tính toán là: {sotuan} tuần");
// // Tính số ngày lẻ
// songayle = formatsongay % 7;
// Console.WriteLine($"Số ngày lẻ tính toán là: {songayle} ngày");
#endregion 

#region Bài tập 2 - Buổi 2 - Tính tổng giá trị đơn hàng sau khi áp dụng giảm giá
// // Input
// // Nhập giá trị đơn hàng và % giảm giá
// Console.WriteLine("Bài tập 2 - Tính tổng giá trị đơn hàng sau khi áp dụng giảm giá");
// Console.WriteLine("Nhập giá trị đơn hàng:");
// string donhang = Console.ReadLine();
// double fdonhang = Convert.ToDouble(donhang);
// Console.WriteLine("Nhập % giảm giá:");
// string giamgia = Console.ReadLine();
// double fgiamgia = Convert.ToDouble(giamgia);

// // Output
// double tonggiamgia = 0.0;
// double tongtien = 0.0;

// // Process
// // Tính số tiền giảm giá
// tonggiamgia = fdonhang * fgiamgia / 100;
// Console.WriteLine($"Số tiền giảm giá là: {tonggiamgia}");
// // Tính tổng số tiền sau khi giảm giá
// tongtien = fdonhang - tonggiamgia;
// Console.WriteLine($"Tổng số tiền sau khi giảm giá là: {tongtien}");

#endregion

#region Bài tập 3 - Buổi 2 - Chuyển đổi thời gian từ phút sang giờ và phút
// // Input
// // Nhập giá trị thời gian theo phút
// Console.WriteLine("Bài tập 3 - Chuyển đổi thời gian từ phút sang giờ và phút");
// Console.WriteLine("Nhập giá trị thời gian theo phút:");
// string phut = Console.ReadLine();
// int fphut = Convert.ToInt32(phut);

// // Output
// int sogio = 0;
// int sophut = 0;

// // Process
// // Tính số giờ
// sogio = fphut / 60;
// // Tính số phút
// sophut = fphut % 60;
// Console.WriteLine($"Số giờ sau tính toán là: {sogio} giờ và {sophut} phút");

#endregion

#region Bài tập 4 - Buổi 2 - Tính tổng tiền sau khi cộng thêm thuế VAT
// // Input
// Console.WriteLine("Bài tập 4 - Tính tổng tiền sau khi cộng thêm thuế VAT");
// // Nhập số tiền gốc
// Console.WriteLine("Nhập số tiền gốc:");
// string tiengoc = Console.ReadLine();
// double ftiengoc = Convert.ToDouble(tiengoc);
// // Nhập tỉ lệ thuế VAT
// Console.WriteLine("Nhập % thuế VAT:");
// string vat = Console.ReadLine();
// double fvat = Convert.ToDouble(vat);

// // Output
// double tongVAT = 0.0;
// double tongtiensauVAT = 0.0;

// // Process
// // Tính số tiền chịu thuế VAT
// tongVAT = ftiengoc * fvat / 100;
// // Tính tổng số tiền sau khi cộng thêm VAT
// tongtiensauVAT = ftiengoc + tongVAT;
// Console.WriteLine($"Tổng số tiền sau khi cộng thêm thuế VAT là: {tongtiensauVAT}");

#endregion

#region Bài tập 5 - Buổi 2 - Chuyển đổi đơn vị tiền tệ từ USD sang VND
// // Input
// // Nhập số tiền USD
// Console.WriteLine("Bài tập 5 - Chuyển đổi đơn vị tiền tệ từ USD sang VND");
// Console.WriteLine("Nhập số tiền bằng USD:");
// string tienusd = Console.ReadLine();
// Int64 ftienusd = Convert.ToInt64(tienusd);
// // Nhập tỉ giá USD-VND
// Console.WriteLine("Nhập tỉ giá USD-VND:");
// string tigia = Console.ReadLine();
// Int64 ftigia = Convert.ToInt64(tigia);

// // Output
// Int64 tiensauchuyendoi = 0;

// // Process
// // Tính tổng số tiền sau khi nhân tỉ giá
// tiensauchuyendoi = ftienusd * ftigia;
// Console.WriteLine($"Tổng số tiền sau khi nhân tỉ giá là: {tiensauchuyendoi}");

#endregion
