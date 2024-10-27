// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");

// Quan trọng nhất là xác định điều kiện dừng
// Bấm ctrl+Z hoặc ctrl+C để dừng
// while - khi không biết rõ số lần lặp
// for - biết rõ số lần lặp
// do ... while

#region while statement
// // In ra các số từ 1 đến n với n là số được nhập từ bàn phím
// // B1: khởi tạo giá trị lặp
// // B2: xác định điều kiện lặp (tính tới trường hợp dừng)
// // B3: thay đổi điều kiện lặp

// Console.WriteLine("Mời bạn nhập số:");
// string? number = Console.ReadLine();
// int fnumber = Convert.ToInt32(number);
// int count = 1;
// while(count <= fnumber) {
//     Console.WriteLine(count);
//     count++; // count = count + 1;
// }

#endregion


#region while - nhập số n từ bàn phím, in ra tổng các số từ 1 đến n
// // nhập số n từ bàn phím, in ra tổng các số từ 1 đến n
// // S = 1 + 2 + 3 + ... + n;
// Console.WriteLine("Mời bạn nhập số:");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// int sum = 0;
// while(count <= number) {
//     sum += count; // sum = sum + count;
//     count++; // count = count + 1 hoặc count += 1;
// }
// Console.WriteLine($"Tổng các số từ 1 đến n là: {sum}");

#endregion


#region tính giai thừa của 1 số n nhập từ bàn phím
// // tính giai thừa của 1 số n nhập từ bàn phím
// Console.WriteLine("Nhập số n từ bàn phím:");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// int result = 1;
// while (count <= number) {
//     result *= count;
//     count ++;
// }
// Console.WriteLine($"giai thừa của số {number} là: {result}");

#endregion

#region in bảng cửu chương của n với n nhập từ bàn phím
// // in bảng cửu chương của n với n nhập từ bàn phím
// Console.WriteLine("Nhập số n từ bàn phím");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// // int result = 1;
// while(count <= 10) {
//     // result = number * count;
//     Console.WriteLine($"{number} * {count} = {number * count}");
//     count ++;
// }
#endregion

#region while - Nhập số n từ bàn phím, kiểm tra xem có phải số nguyên số không?
// Console.WriteLine("Nhập số n từ bàn phím");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 2;
// // giả sử a và b là ước của n
// // ít nhất 1 trong 2 số a và b phải nhỏ hơn văn bậc 2 của n
// // vì nếu a và b lớn hơn căn bậc 2 của n thì khi a*b sẽ lớn hơn n
// // vd: n=9 => căn bậc 2 của 9 = 3
// while(count < number) {  // count < Math.Sqrt(number) (count < căn bậc 2 của n)
//     if (number % count == 0) {
//         Console.WriteLine($"Số {number} không phải là số nguyên tố");
//         break;
//     }
//     count++;
// }
// if (count == number) {
//     Console.WriteLine($"Số {number} là số nguyên tố");
// }
#endregion

#region for - in bảng cửu chương
// Console.WriteLine("Nhập số n từ bàn phím:");
// int number = Convert.ToInt32(Console.ReadLine());
// for(int count = 1; count <= 10; count++) {
//     Console.WriteLine($"{count} x {number} = {count*number}");
// }

#endregion

#region for - kiểm tra số nguyên tố 
// Console.WriteLine("nhập số n:");
// int number = Convert.ToInt32(Console.ReadLine());
// int count;
// for(count = 2; count < number; count++) {
//     if(number % count == 0) {
//         Console.WriteLine($"Số {number} không phải là số nguyên tố");
//         break;
//     }
// }
// if (count == number) {
//     Console.WriteLine($"Số {number} là số nguyên tố");
// }
#endregion

#region for statement
// // for lồng nhau => ma trận (nhiều mảng kết hợp với nhau)
// Console.WriteLine("Nhập vào chiều dài:");
// int chieudai = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Nhập vào chiều rộng:");
// int chieurong = Convert.ToInt32(Console.ReadLine());
// for(int i = 0; i < chieurong; i++) {
//     for(int j = 0; j < chieudai; j++) {
//         Console.Write("*");
//     }
//     Console.WriteLine(); // Console.Write("\n");
// }
#endregion

#region in ra tam giác cân
// //              j => 2*i+1
// // i=0; ___*    => height - i - 1
// // i=1; __***   => height = 2, in ra 2 space và 3 *
// // i=2; _*****  => height = 3, in ra 1 space và 5 *
// // i=3; ******* =>

// Console.WriteLine("Nhập số chiều cao tam giác cân:");
// int height = Convert.ToInt32(Console.ReadLine());
// for(int i = 0; i < height; i++) {
//     // in khoảng trắng (space) trước dấu *
//     for(int j = 0; j < height - i - 1; j++) {
//         Console.Write(" ");
//     }
//     // in dấu *
//     for(int k = 0; k < (2*i+1); k++) {
//         Console.Write("*");
//     }
//     Console.WriteLine();
// }

#endregion

#region nhập chiều dài và rộng, in ra hình chữ nhật dấu * rỗng ở giữa

// ***********************
// *                     *
// *                     *
// ***********************

#endregion

