using System;

namespace PersonalDomain.Application.Blogging.Models
{
    public class PostIndexDTO
    {
        public PostSummaryDTO[] PostSummaries { get; set; }
        public Int32 PostSummaryCount { get; set; }
    }
}
