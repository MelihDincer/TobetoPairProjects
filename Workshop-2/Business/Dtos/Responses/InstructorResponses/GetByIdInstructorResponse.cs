namespace Workshop_2.Business.Dtos.Responses.InstructorResponses
{
    public class GetByIdInstructorResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}