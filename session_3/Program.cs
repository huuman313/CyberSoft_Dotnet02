// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");

#region làm lại bài tập số 2 buổi 2

//
// Console.WriteLine("Nhập giá tiền trà sữa");
// string giatien = Console.ReadLine();
// Console.WriteLine("nhập voucher giảm giá");
// string giagiam = Console.ReadLine();

// int tiengiam = 0;
// int tienphaitra = 0;

// int fgiatien = Convert.ToInt32(giatien);
// int ftiengiamgia = Convert.ToInt32(giagiam);

// tiengiam = fgiatien * ftiengiamgia / 100;
// tienphaitra = fgiatien - tiengiam;

// Console.WriteLine($"số tiền còn lại: {tienphaitra}");
//


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

#region if-else statement
// // Nhập số nguyên từ bàn phím và in ra số đó là số lẻ hay số chẵn
// // Input
// Console.WriteLine("Nhập 1 số nguyên từ bàn phím:");
// string? number = Console.ReadLine();
// int formatnumber = Convert.ToInt32(number);
// if(formatnumber % 2 == 0)
// {
//     Console.WriteLine($"Số {number} là số chẵn");
// }
// else
// {
//     Console.WriteLine($"Số {number} là số lẻ");
// }

#endregion

// // truthy
// int day = 5;
// if (day != 0)
// {
//     // >, <, >=, <=, !=, ==
//     Console.WriteLine("Truthy");
// }

#region 
// // Nhập điểm trung bình của học sinh. Xuất ra học lực của học sinh đó
// // >= 9: Xuất sắc
// // 8 <= điểm < 9: giỏi
// // 6.5 <= điểm < 8: khá
// // 5 <= điểm < 6.5: trung bình
// // 3.5 <= điểm < 5: yếu
// // < 3.5: quá kém
// Console.WriteLine("Nhập điểm trung bình của học sinh:");
// string diemtb = Console.ReadLine();
// double fdiemtb = Convert.ToDouble(diemtb);
// if(fdiemtb >= 9) {
//     Console.WriteLine("Xuất sắc");
// } else if (fdiemtb < 9 && fdiemtb >= 8)
// // kết hợp 2 hoặc nhiều điều kiện
// // && => và
// // || => hoặc 
// // 8 <= diem < 9 (trong ngôn ngữ thực tế)
// // 8 <= diem && diem < 9 (trong lập trình)
// {
//     Console.WriteLine("Giỏi");
// } else if (fdiemtb >= 6.5 && fdiemtb < 8) {
//     Console.WriteLine("Khá");
// } else if (5 <= fdiemtb && fdiemtb < 6.5) {
//     Console.WriteLine("Trung bình");
// } else if (3.5 <= fdiemtb && fdiemtb < 5) {
//     Console.WriteLine("Yếu");
// } else {
//     Console.WriteLine("Quá kém"); 
// }

#endregion

// Nhập 1 số có 3 chữ số và tính tổng 3 số đó
// Nhập số có 2 chữ số hoặc 1 chữ số thì báo không hợp lệ

#region cách 1
// Console.WriteLine("nhập 1 số nguyên có 3 chữ số");
// string songuyen = Console.ReadLine();
// int fsonguyen = Convert.ToInt32(songuyen);
// int phantram = 0;
// int phanchuc = 0;
// int haichuso = 0;
// int phandonvi = 0;
// int tong3so = 0;
// if (fsonguyen < 100 || fsonguyen >=1000) {
//     Console.WriteLine("Số bạn nhập bị lỗi");
// } else {
//     phantram = fsonguyen / 100;
//     haichuso = fsonguyen - (phantram * 100);
//     phanchuc = haichuso / 10;
//     phandonvi = haichuso % 10;
//     tong3so = phantram + phanchuc + phandonvi;
//     Console.WriteLine($"Tổng 3 số là {tong3so}");
// }
#endregion

#region cách 2
// Console.WriteLine("Mời bạn nhập số có 3 chữ số");
// string? number = Console.ReadLine();
// int formatnumber = Convert.ToInt32(number);
// if (formatnumber >= 100 && formatnumber <1000) {
//     // 987
//     // 9: hungdred, 8: tens, 7: units
//     int units = formatnumber % 10; // => 7
//     int tens = (formatnumber % 100) / 10; // => 8
//     int hungdred = formatnumber / 100;

//     int sum = units + tens + hungdred;
//     Console.WriteLine($"Tổng các chữ số là {sum}");
// } else {
//     Console.WriteLine("đây không phải số có 3 chữ số");
// }


#endregion

// Bài về nhà
// Nhập ngày (dd/mm/yyyy). In ra thứ mấy trong tuần
// Lưu ý không dùng thư viện

// 2 -> thứ hai
// 3 -> thứ ba
// 4 -> thứ tư
// khi các điều kiện nó độc lập với nhau, không có liên quan với nhau
// if {} {}
// if {} {}
// if {}

// Khi mà các điều kiện có liên quan tới nhau
// if {} {}
// else if {}
// else {}

#region ví dụ về hàm switch...case
// C1: dùng switch...case
// Nhập số có trong khoảng từ 1 đến 10. Đọc số đó ra
Console.WriteLine("Nhập số từ 1 đến 10");
string number2 = Console.ReadLine();
int fnumber2 = Convert.ToInt32(number2);
switch (fnumber2)
{
    case 1:
        Console.WriteLine("Số 1");
        break;
    case 2:
        Console.WriteLine("Số 2");
        break;
    case 3:
        Console.WriteLine("Số 3");
        break;
    case 4:
        Console.WriteLine("Số 4");
        break;
    case 5:
        Console.WriteLine("Số 5");
        break;
    case 6:
        Console.WriteLine("Số 6");
        break;
    case 7:
        Console.WriteLine("Số 7");
        break;
    case 8:
        Console.WriteLine("Số 8");
        break;
    case 9:
        Console.WriteLine("Số 9");
        break;
    default:
        Console.WriteLine("Số 10");
        break;
}


// C2: switch expression

#endregion



