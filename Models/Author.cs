using System.ComponentModel.DataAnnotations;

namespace BookDirectory.Models {
    public class Author {
        //Properties
        public int Id { get; set; }
        [Display(Name = "Namn")]
        public string? Name { get; set; }
        [Display(Name = "Land")]

        public string? Country { get; set; }
        [Display(Name = "Böcker")]


        public List<Book>? Books { get; set; }

    }
}