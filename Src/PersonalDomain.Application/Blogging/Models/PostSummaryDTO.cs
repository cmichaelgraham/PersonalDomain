using System;

namespace PersonalDomain.Application.Blogging.Models
{
    public class PostSummaryDTO
    {
        public Int32 Id { get; set; }
        public String Title { get; set; }
        public String Subtitle { get; set; }
        public String Slug { get; set; }
        public String PostedDate { get; set; }        
        
        public String Author { get; set; }
    }
}
