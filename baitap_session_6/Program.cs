// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// câu 1
// int n = 20;
// int count = 0;

// for (int i = 2; i <= n; i++)
// {
//     bool isPrime = true;
//     for (int j = 2; j <= i / 2; j++)
//     {
//         if (i % j == 0)
//         {
//             isPrime = false;
//             break;
//         }
//     }
//     if (isPrime)
//     {
//         count += 1;
//     }
// }

// Console.WriteLine("Số lượng các số nguyên tố từ 1 đến " + n + " là: " + count);

// // Kết quả mong muốn: "Số lượng các số nguyên tố từ 1 đến 20 là: 8"


// câu 2
// int[] arr = { 5, 3, 9, 1, 7 };
// int max = arr[0];
// int i = 1;
// while (i < arr.Length)
// {
//     if (arr[i] > max)
//     {
//         max = arr[i];
//     }
//     i++;
// }
// Console.WriteLine("Số lớn nhất trong mảng là: " + max);

// // Giá trị mong muốn: Số lớn nhất trong mảng là 9.

// câu 3
int n = 5;
int result = 1;
int i = 1;
while (i <= n)
{
    result *= i;
    i++;
}
Console.WriteLine("Giai thừa của " + n + " là: " + result);

// Kết quả mong muốn: Giai thừa của 5 là 120.


// câu 4
// int n = 20;
// int sum = 0;

// for (int i = 1; i <= n; i++)
// {
//     if (i % 3 == 0)
//     {
//         sum += i;
//     }
// }

// Console.WriteLine("Tổng các số chia hết cho 3 từ 1 đến " + n + " là: " + sum);

// // Kết quả mong muốn: "Tổng các số chia hết cho 3 từ 1 đến 20 là: 63"

// câu 5
// int number = 12321;
// int reverse = 0, temp = number;

// while (temp > 0)
// {
//     reverse = reverse * 10 + temp % 10;
//     temp /= 10;
// }

// if (number == reverse)
// {
//     Console.WriteLine(number + " là số đối xứng");
// }
// else
// {
//     Console.WriteLine(number + " không phải là số đối xứng");
// }

// // Kết quả mong muốn: "12321 là số đối xứng"

// câu 6
// int num = 6;
// double inverse = 0;
// if (num != 0)
// {
//     inverse = 1 / num;
// }
// Console.WriteLine("Số nghịch đảo của "+ num +" là:" +inverse);

// // Kết quả mong muốn: Số nghịch đảo của 6 là 0.1667.

// câu 7
// int number = 12;
// int result;

// // Điều kiện kiểm tra và tính toán
// if (number > 10)
// {
//     result = number + 3;
// }
// else
// {
//     result = number - 5;  // Giả định này không áp dụng với giá trị hiện tại của number
// }
// Console.WriteLine($" kết quả là {result}");
// // Kết quả mong muốn là 15

// câu 8
// int[] arr = { 50, 20, 40, 30, 10 };
// int n = arr.Length;
// bool swapped;
// do
// {
//     swapped = false;
//     for (int i = 0; i < n - 1; i++)
//     {
//         if (arr[i] < arr[i + 1])
//         {
//             int temp = arr[i];
//             arr[i] = arr[i + 1];
//             arr[i + 1] = temp;
//             swapped = true;
//         }
//     }
//     n--;
// } while (swapped);

// // Mục tiêu: Mảng sau sắp xếp là 10, 20, 30, 40, 50.

// // câu 9
// int[] arr = { 9, 4, 7, 12, 2 };
// int min = arr[0];

// for (int i = 1; i < arr.Length; i++) 
// {
//     if (arr[i] < min)
//     {
//         min = arr[i];
//     }
// }

// Console.WriteLine("Số nhỏ nhất trong mảng là: " + min);

// // Kết quả mong muốn: "Số nhỏ nhất trong mảng là: 2"

// câu 10
// int num = 1234;
// int reversedNum = 0;
// while (num != 0)
// {
//     int digit = num % 10;
//     reversedNum = reversedNum * 10 + digit;
//     num /= 10;
// }
// Console.WriteLine($"Số đảo ngược của 1234 là {reversedNum}");
// // Mục tiêu: Số đảo ngược của 1234 là 4321.


