using System;

namespace PersonalDomain.Application.Blogging.Models
{
    public class PostSummaryDTO
    {
        public String Title { get; set; }
        public String Subtitle { get; set; }
        public String Author { get; set; }
        public String PostedDate { get; set; }
    }
}
