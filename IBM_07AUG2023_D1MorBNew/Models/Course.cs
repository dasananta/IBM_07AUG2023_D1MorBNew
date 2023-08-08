using System;
using System.Collections.Generic;

namespace IBM_07AUG2023_D1MorBNew.Models
{
    public partial class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; } = null!;
        public int DurationInHrs { get; set; }
        public string CourseDesc { get; set; } = null!;
    }
}
