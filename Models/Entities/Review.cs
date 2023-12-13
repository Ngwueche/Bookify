namespace Bookify.Models.Entities
{
    public class Review : BaseEntity
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public string ReviewerId { get; set; }
        public string BookId { get; set; }


        //navigational properties
        public AppUser Reviewer { get; set; }
        public Book Book { get; set; }

    }
}
