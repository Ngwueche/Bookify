namespace Bookify.Models.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; set; } = "";
        public string Author { get; set; } = "";
        public string Description { get; set; } = "";
        public int NumberofPages { get; set; }
        public string Language { get; set; } = "";
        public string ISBN { get; set; } = "";
        public string Publisher { get; set; } = "";
        public string PhotoUrl { get; set; } = "";
        public string PublicId { get; set; } = "";
        public string AddedBy { get; set; } = "";
        public int CopiesInLibrary { get; set; }
        public DateTime PublishedDate { get; set; }

        //Navigation Properties
        public IList<Review> Reviews { get; set; } = new List<Review>();
        public IList<Rating> Ratings { get; set; } = new List<Rating>();

    }
}
