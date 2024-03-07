using System.ComponentModel.DataAnnotations;


namespace BookDirectory.Models {
    public class Book {
        //Properties
        public int Id { get; set; }
        [Display(Name = "Titel")]

        public string? Title { get; set; }
        [Display(Name = "Publiceringsår")]

        public int? Year { get; set;}
        [Display(Name = "Betyg")]

        public int? Score { get; set;}
        [Display(Name = "Författare")]


        public int? AuthorId { get; set; }
        [Display(Name = "Författare")]
        public Author? Author { get; set; }
    }
}