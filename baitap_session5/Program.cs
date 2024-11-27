// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region
// Console.WriteLine("Bài 1: nhập vào số n từ bàn phím. In ra các số nguyên tố từ 2 đến n");

// Console.WriteLine("Nhập số n từ bàn phím");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 2;
// Console.WriteLine("Các số nguyên tố từ 2 đến n là:");
// for(int i = 2; i < number; i++) {
//     while(count < number) {  // count < Math.Sqrt(number) (count < căn bậc 2 của n)
//         if (number % count == 0) {
//             Console.WriteLine($"Số {number} không phải là số nguyên tố");
//         break;
//         }
//         count++;
//     }
//     if (count == number) {
//     Console.WriteLine($"Số {number} là số nguyên tố");
// }
// }


#endregion


#region 
// // Console.WriteLine("Bài 2: Nhập chiều cao tam giác. In ra tam giác cân rỗng");
// // // __*
// // // _* *
// // // __*   *
// // // _*     *
// // // *******

// #endregion

// #region 
// Console.WriteLine("Bài 3: Nhập vào số n từ bàn phím. Kiểm tra số đó có phải là số đôi xứng không");
// // Console.WriteLine("VD: Số 121, 1221, 12321,... là những số đối xứng");
// int number = Convert.ToInt32(Console.ReadLine());



#endregion


#region bài 1
// Console.WriteLine("Bài 1: nhập vào số n từ bàn phím. In ra các số nguyên tố từ 2 đến n");

// Console.WriteLine("Nhập số n từ bàn phím");
// int number = Convert.ToInt32(Console.ReadLine());
// for(int count = 2; count <= number; count++) {
//     bool isPrime = true;
//     for(int j = 2; j <= Math.Sqrt(count); j++) {
//         if(count % j == 0) {
//             isPrime = false;
//             break;
//         }
//     }
//     if(isPrime == true) {
//         Console.Write($"{count} ");
//     }
// }
// Console.WriteLine();
#endregion


// int count = 2;
// Console.WriteLine("Các số nguyên tố từ 2 đến n là:");
// for(int i = 2; i < number; i++) {
//     while(count < number) {  // count < Math.Sqrt(number) (count < căn bậc 2 của n)
//         if (number % count == 0) {
//             Console.WriteLine($"Số {number} không phải là số nguyên tố");
//         break;
//         }
//         count++;
//     }
//     if (count == number) {
//     Console.WriteLine($"Số {number} là số nguyên tố");
// }
// }



// // Console.WriteLine("Bài 2: Nhập chiều cao tam giác. In ra tam giác cân rỗng");
// // // __*
// // // _* *
// // // __*   *
// // // _*     *
// // // *******

// #endregion

#region bài 3
// Console.WriteLine("Bài 3: Nhập vào số n từ bàn phím. Kiểm tra số đó có phải là số đôi xứng không");
// Console.WriteLine("VD: Số 121, 1221, 12321,... là những số đối xứng");
// Console.WriteLine("Mời bạn nhập một số:");
// int number3 = Convert.ToInt32(Console.ReadLine());
// int reverseNumber = 0;
// int originalNumber = number3;
// while(number3 > 0) {
//     int lastdigit = number3 % 10;
//     reverseNumber = reverseNumber * 10 + lastdigit;
//     number3 = number3 / 10;
// }
// if(reverseNumber == originalNumber) {
//     Console.WriteLine($"Số {originalNumber} là số đối xứng");
// } else {
//     Console.WriteLine($"Số {originalNumber} không phải là số đối xứng");
// }

// B1: lấy số 1: => dư = number % 10
// reverseNumber = reverseNumber * 10 + dư
// number = number / 10; => 12
// B2: lấy 2: => dư = number % 10 => 2
// reverseNumber = reverseNumber * 10 + dư => 12
// number = number / 10; => 1
// B3: lấy 1: => dư = number % 10 => 1
// reverseNumber = reverseNumber * 10 + dư => 121
// number = number / 10; => 0

#endregion






