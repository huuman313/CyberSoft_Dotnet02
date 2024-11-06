class Bai2 {
    public static int findMaxNumber (List<int> numbers) {
        int Max = numbers.ElementAt(0);  // int Max = numbers[0]
        foreach(int number in numbers) {
            if(number > Max) {
                Max = number;
            }
        }
        return Max;
    }
}
