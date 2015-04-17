using System;
using PersonalDomain.Application.Blogging.Models;

namespace PersonalDomain.Application.WebApi.Models
{
    public class PostSummaryDTO : IPostSummaryDTO
    {
        public Int32 Id { get; set; }
        public String Title { get; set; }
        public String Subtitle { get; set; }
        public String Author { get; set; }
        public String PostedDate { get; set; }
    }
}
