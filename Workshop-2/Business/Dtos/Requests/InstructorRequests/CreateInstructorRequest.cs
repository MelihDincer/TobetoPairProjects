namespace Workshop_2.Business.Dtos.Requests.InstructorRequests
{
    public class CreateInstructorRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}