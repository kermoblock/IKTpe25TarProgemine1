namespace University.Models
{
    public class FileToApi
    {
        public Guid Id { get; set; }
        public string? ExistingFilePath { get; set; }
        public Guid? CourseId { get; set; }
    }
}
