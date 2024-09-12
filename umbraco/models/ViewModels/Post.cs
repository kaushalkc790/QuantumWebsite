using System.ComponentModel.DataAnnotations;

namespace QuantumWebsite.Models.ViewModels
{
    public class Post
    {

        public int noticeId { get; set; }
        public DateTime saveDate { get; set; }
        public string title { get; set; }
        public string notice { get; set; }
        public bool isClosed { get; set; }
        public int cUserID { get; set; }
        public bool isUp { get; set; }
        public string docPath { get; set; }
        public string videoUrl { get; set; }
        public string mediaCaption { get; set; }
        public bool isVideo { get; set; }
        public IFormFile file { get; set; }
        public List<string> imageUrls { get; set; }
        public string userId { get; set; }
        public DateTime createdDateTime { get; set; }
        public string mUserId { get; set; }
        public DateTime mDate { get; set; }
        public bool isPublished { get; set; }
        public int audience { get; set; }
        public int? tenantId { get; set; }
        //yearId may be deleted or changed
        public int? officeId { get; set; }
        public int? countryId { get; set; }


    }
}
