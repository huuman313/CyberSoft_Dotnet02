// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// string calculate(int toan, int ly, int hoa){
    int toan = 10;
    int ly = 9;
    int hoa = 8;
    double DTB = 0.0;
    DTB = (toan + ly + hoa) / 3;
    if(DTB < 5) {
        return "Poor";
    } else if(DTB >= 5 && DTB < 6.5) {
        return "Average";
    } else if(DTB >= 6.5 && DTB < 8) {
        return "Good";
    } else if(DTB >= 8 && DTB <= 10) {
        return "Excellent";
    } else
        return "Not Grade";
// }