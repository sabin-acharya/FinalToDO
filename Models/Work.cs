using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace FinalToDO.Models
{
    public class Work
    {
        public int Id { get; set; }

        public string TaskName { get; set; }

        public DateOnly Date { get; set; }

        public string statusId { get; set; }
    }
}
