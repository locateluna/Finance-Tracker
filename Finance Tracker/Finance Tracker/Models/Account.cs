namespace Finance_Tracker.Models
{
    public class Account
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public float Value { get; set; }
    }
}
