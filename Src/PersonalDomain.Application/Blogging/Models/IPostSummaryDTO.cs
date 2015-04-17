using System;

namespace PersonalDomain.Application.Blogging.Models
{
    public interface IPostSummaryDTO
    {
        Int32 Id { get; }
        String Title { get; }
        String Subtitle { get; }
        String Author { get; }
        String PostedDate { get; }
    }
}
