namespace DemoHairSite.Models
    {
    public class ContactModel
        {
        public int Id
            {
            get; set;
            } = default!;
        public string? Name
            {
            get; set;
            } = default!;
        public string Email
            {
            get; set;
            } = default!;
        public string Message
            {
            get; set;
            } = default!;
        }
    }
