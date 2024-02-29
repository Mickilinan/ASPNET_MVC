namespace ASPNETAssignment.Models;

public class CoursesModel
{
    public class Course
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ImageUrl { get; set; }
        public string? BestBadgeUrl { get; set; }
        public string BookmarkUrl { get; set; }
        public decimal? Price { get; set; }
        public decimal? RedPrice { get; set; }
        public decimal? OldPrice { get; set; }
        public int Hours { get; set; }
        public int RatingPercentage { get; set; }
        public string RatingCount { get; set; }

    }
         

    public List<Course> Courses { get; set; } = [];
   
}
