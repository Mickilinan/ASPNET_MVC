using ASPNETAssignment.Models;
using static ASPNETAssignment.Models.CoursesModel;
using static ASPNETAssignment.Models.SavedCoursesModel;

namespace ASPNETAssignment.ViewModels
{
    public class SavedCoursesViewModel
    {
        public string Title { get; set; } = "Saved Items";

        public SavedCoursesModel AccountInfo { get; set; } = new SavedCoursesModel()
        {
            ProfileImage = "images/contactDetailsImages/profile_image.svg",
            FirstName = "Hanna",
            LastName = "Grehn",
            Email = "Hanna.Grehn@domain.com"
        };
        public List<MyCourse> MyCourses { get; set; } = new List<MyCourse>
        {
            new() {
                Title = "Blender Character Creator v2.0 for Video Games Design",
                Author = "By Ralph Edwards",
                ImageUrl = "images/coursesImages/womandesk.svg",
                BookmarkUrl = "images/coursesImages/bookmark.svg",
                Price = 18.99m,
                Hours = 160,
                RatingPercentage = 92,
                RatingCount = "3.1K"
            },

            new() {
                Title = "Fullstack Web Developer Course from Scratch",
                Author = "By Robert Fox",
                ImageUrl =  "images/coursesImages/laptop.svg",
                BestBadgeUrl = "images/coursesImages/bestsellerbadge.svg",
                BookmarkUrl = "images/coursesImages/bookmark.svg",
                Price = 12.50m,
                Hours = 220,
                RatingPercentage = 94,
                RatingCount = "4.2K"
            },

            new() {
                Title = "Learn JMETER from Scratch on Live Apps-Performance Testing",
                Author = "By Jenny Wilson",
                ImageUrl = "images/coursesImages/manlaptop.svg",
                BookmarkUrl = "images/coursesImages/bookmark.svg",
                Price = 14.50m,
                Hours = 160,
                RatingPercentage = 92,
                RatingCount = "3.1K"
            }
        };
    }
}
