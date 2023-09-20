namespace CleanMovie.Domain
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; } = string.Empty;
        public decimal RentalCost { get; set; }
        public int RentalDurantion { get; set; }

        // Many to Many Relationship
        public ICollection<MovieRental> MovieRentals { get; set; }
    }
}
