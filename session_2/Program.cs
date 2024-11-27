// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// phím tắt tạo command (ghi chú) nhiều dòng: ctrl + ?. Bấm lại là bỏ cmd

#region Học phép toán cơ bản
// // học +, -, *, / (chia lấy phần nguyên), % (chia lấy phần dư)
// // khai báo biến
// int add = 5 + 10;
// Console.WriteLine($"Kết quả cộng hai số 5 và 10 là: {add}");

// int minus = 92421 - 8327;
// Console.WriteLine($"Kết quả trừ 2 số là: {minus}");

// double devide = 5/2;
// Console.WriteLine($"Kết quả chia 2 số là: {devide}");

#endregion

#region numberic toán tử
// int cong = 0; // định nghĩa biến cong có giá trị mặt định = 0
// cong += 10;
// Console.WriteLine($"kết quả numberic toán tử cộng là: {cong}");

// int tru = 100;
// tru -= 49;
// Console.WriteLine($"Kết quả numberic toán tử cộng là: {tru}");

// int nhan = 2;
// nhan *= 11;
// Console.WriteLine($"Kết quả numberic toán tử cộng là: {nhan}");

#endregion

#region ép kiểu dữ liệu C1: dùng convert
// Convert
// // nhập dữ liệu từ bàn phím => Readline (string)
// Console.WriteLine("Mời bạn nhập số: ");
// string number = Console.ReadLine();
// int convertNumber = Convert.ToInt32 (number);
// // int sum = convertNumber + 1;
// // Console.WriteLine($"gia tri: {sum}");
// Console.WriteLine($"value number: {convertNumber}");

#endregion

#region tính chỉ số BMI
// // Input
// // Chiều cao và cân nặng nhập từ bàn phím
// Console.WriteLine("Mời bạn nhập chiều cao (m):");
// string chieucao = Console.ReadLine();
// // convert string sang double
// double formatchieucao = Convert.ToDouble(chieucao);

// Console.WriteLine("Mời bạn nhập cân nặng (kg): ");
// string cannang = Console.ReadLine();
// double formatcannang = Convert.ToDouble(cannang);

// // Output
// // In ra chỉ số BMI
// // Khởi tạo biến bmi để lưu giá trị BMI
// double bmi = 0.0;

// // Process
// // BMI = Cân nặng / chiều cao * chiều cao
// bmi = formatcannang / (formatchieucao*formatchieucao);
// Console.WriteLine($"Chỉ số BMI của bạn là: {bmi}");


#endregion

#region tính chu vi và diện tích hình tròn
// // Input
// // B1: nhập bán kính từ bàn phím
// Console.WriteLine($"Mời bạn nhập bán kính hình tròn: ");
// string bankinh = Console.ReadLine();
// // B2: convert kiểu dữ liệu string -> double cho bán kính
// double formatbankinh = Convert.ToDouble(bankinh);

// // Output
// double chuvi = 0.0;
// double dientich = 0.0;

// // Process
// double PI = Math.PI; // dùng hằng số PI có sẵn của thư viện Math trong C#
// // Chu vi = 2 * pi * bankinh
// chuvi = 2 * PI * formatbankinh;
// // Diện tích = pi * bankinh * bankinh
// dientich = PI * formatbankinh * formatbankinh;

// Console.WriteLine($"Chu vi hình tròn là: {chuvi}");
// Console.WriteLine($"Diện tích hình tròn là: {dientich}");

#endregion