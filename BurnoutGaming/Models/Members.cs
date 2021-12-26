namespace BurnoutGaming.Models
{
    public class Members
    {
        public int Id { get; set; }
        public string? MemberInfo { get; set; }

        //[DataType(DataType.Date)]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
