namespace Finance_Tracker.Models
{
    public class Account
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required float Value { get; set; }
    }
}
