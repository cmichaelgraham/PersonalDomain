using System;
using PersonalDomain.Application.Blogging.Models;

namespace PersonalDomain.Application.WebApi.Models
{
    public class PostSummaryCountDTO : IPostSummaryCountDTO
    {
        public Int32 Count { get; set; }
    }
}
