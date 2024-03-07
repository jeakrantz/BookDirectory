namespace BookDirectory.Models {
    public class Book {
        //Properties
        public int Id { get; set; }
        public string? Title { get; set; }
        public int? Year { get; set;}
        public int? Score { get; set;}

        public int? AuthorId { get; set; }
        public Author? Author { get; set; }
    }
}