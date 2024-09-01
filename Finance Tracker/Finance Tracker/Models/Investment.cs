using System.ComponentModel.DataAnnotations.Schema;

namespace Finance_Tracker.Models
{
    [NotMapped]
    public class Investment : Saving
    {
        public required string AccountType { get; set; }
        public bool IsRetirement { get; set; }

    }
}
