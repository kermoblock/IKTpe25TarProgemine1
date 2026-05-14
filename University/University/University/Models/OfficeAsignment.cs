using System.ComponentModel.DataAnnotations;

namespace University.Models
{
    public class OfficeAsignment
    {
        //kui soovite kasknreetselt välja tuua, et InstructorId on nii OfficeAssignmenti
        // peamine võti kui ka võõrõvti, siis saate kasutada [Key] ja [ForeignKey] atribuute:
        [Key]
        public int InstructorId { get; set; }

        public string Location { get; set; } = string.Empty;

        public Instructor Instructor { get; set; }
    }
}
