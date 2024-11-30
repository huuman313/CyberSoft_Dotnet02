class FictionBook: Book {
    public string genre;
    public int year;
    public FictionBook(
        string bookId,
        string bookName,
        string author,
        double price,
        string genre,
        int year
        ) : base(bookId, bookName, author, price) {
            this.genre = genre;
            this.year = year;
        }

    public override void displayInfo()
    {
        base.displayInfo(); // gọi lại phương thức displayInfo của class cha
        Console.WriteLine($"Genre (thể loại): {genre}, Year: {year}");
    }
}