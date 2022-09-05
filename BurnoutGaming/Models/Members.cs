namespace BurnoutGaming.Models
{
    public class Members
    {
        public int Id { get; set; }
        public string Password { get; set; }


        //[DataType(DataType.Date)]
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
